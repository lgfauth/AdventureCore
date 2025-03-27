using AdventureCore.Application.Models.Response;

namespace AdventureCore.Application.Services.Interfaces
{
    public interface IInventoryService
    {
        Task<List<ItemResponse>> GetInventoryAsync(string playerId);
        Task<StatsResponse> UseItemAsync(string playerId, Guid itemId);
    }
}