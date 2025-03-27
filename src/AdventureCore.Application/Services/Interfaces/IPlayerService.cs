using AdventureCore.Application.Models.Response;
using AdventureCore.Application.Models.Request;

namespace AdventureCore.Application.Services.Interfaces
{
    public interface IPlayerService
    {
        Task<PlayerResponse> CreatePlayerAsync(PlayerRequest request);
        Task<PlayerResponse> GetPlayerByIdAsync(string playerId);
    }
}
