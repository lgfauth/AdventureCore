using AdventureCore.Application.Models.Request;
using AdventureCore.Application.Models.Response;
using AdventureCore.Application.Services.Interfaces;

namespace AdventureCore.Application.Services.Implementarions
{
    public class CombatService : ICombatService
    {
        public async Task<CombatResultResponse> ResolveCombatAsync(string playerId, ResolveCombatRequest request)
        {
            // Simulação de resultado de combate genérico
            return await Task.FromResult(new CombatResultResponse
            {
                Result = "Victory",
                XpGained = 25,
                GoldGained = 15,
                Loot = new List<ItemResponse>
            {
                new ItemResponse
                {
                    Id = Guid.NewGuid(),
                    Name = "Poção de Vida",
                    Type = "Consumable",
                    Bonus = new Dictionary<string, int> { { "HP", 30 } }
                }
            },
                PlayerStatus = new StatsResponse
                {
                    HP = 80,
                    MP = 45,
                    Strength = 5,
                    Defense = 3,
                    Agility = 4,
                    Intelligence = 10
                }
            });
        }
    }
}