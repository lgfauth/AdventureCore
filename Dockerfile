FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Esta fase é usada para compilar o projeto de serviço
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

COPY ["src/AdventureCore.Api/AdventureCore.Api.csproj", "src/AdventureCore.Api/"]

RUN dotnet restore "./src/AdventureCore.Api/AdventureCore.Api.csproj"

COPY . .

WORKDIR "/src/src/AdventureCore.Api"
RUN dotnet build "./AdventureCore.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Esta fase é usada para publicar o projeto de serviço a ser copiado para a fase final
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./AdventureCore.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Esta fase é usada na produção ou quando executada no VS no modo normal (padrão quando não está usando a configuração de Depuração)
FROM base AS final
WORKDIR /app

ENV ASPNETCORE_URLS="http://0.0.0.0:${PORT:-8080}"

COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "AdventureCore.Api.dll"]