using AdventureCore.Application.Models.Response;

namespace AdventureCore.Application.Services.Interfaces
{
    public interface IAdventureService
    {
        Task<ExploreResponse> ExploreAsync(string playerId);
    }
}
