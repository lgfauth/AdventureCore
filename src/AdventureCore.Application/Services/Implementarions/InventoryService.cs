using AdventureCore.Application.Models.Response;
using AdventureCore.Application.Services.Interfaces;

namespace AdventureCore.Application.Services.Implementarions
{
    public class InventoryService : IInventoryService
    {
        public async Task<List<ItemResponse>> GetInventoryAsync(string playerId)
        {
            return await Task.FromResult(new List<ItemResponse>
        {
            new ItemResponse
            {
                Id = Guid.NewGuid(),
                Name = "Espada de Ferro",
                Type = "Weapon",
                Bonus = new Dictionary<string, int> { { "Strength", 2 } }
            },
            new ItemResponse
            {
                Id = Guid.NewGuid(),
                Name = "Poção de Mana",
                Type = "Consumable",
                Bonus = new Dictionary<string, int> { { "MP", 25 } }
            }
        });
        }

        public async Task<StatsResponse> UseItemAsync(string playerId, Guid itemId)
        {
            // Simula efeito de uso de item (ex: poção de HP)
            return await Task.FromResult(new StatsResponse
            {
                HP = 100,
                MP = 60,
                Strength = 5,
                Defense = 3,
                Agility = 4,
                Intelligence = 10
            });
        }
    }
}