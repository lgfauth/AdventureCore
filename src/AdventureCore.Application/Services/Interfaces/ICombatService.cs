using AdventureCore.Application.Models.Request;
using AdventureCore.Application.Models.Response;

namespace AdventureCore.Application.Services.Interfaces
{
    public interface ICombatService
    {
        Task<CombatResultResponse> ResolveCombatAsync(string playerId, ResolveCombatRequest request);
    }
}
