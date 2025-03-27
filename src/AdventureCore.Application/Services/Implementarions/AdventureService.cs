using AdventureCore.Application.Models.Response;
using AdventureCore.Application.Services.Interfaces;

namespace AdventureCore.Application.Services.Implementarions
{
    public class AdventureService : IAdventureService
    {
        public async Task<ExploreResponse> ExploreAsync(string playerId)
        {
            // Simulação de lógica de exploração com evento aleatório
            var random = new Random();
            var roll = random.Next(0, 3);

            return await Task.FromResult(roll switch
            {
                0 => new ExploreResponse
                {
                    Type = "combat",
                    Description = "Você foi emboscado por um goblin!",
                    Payload = new { EnemyId = Guid.NewGuid(), Name = "Goblin", Level = 2, HP = 60 }
                },
                1 => new ExploreResponse
                {
                    Type = "event",
                    Description = "Você encontra um viajante misterioso que lhe oferece um pergaminho antigo.",
                    Payload = null
                },
                _ => new ExploreResponse
                {
                    Type = "loot",
                    Description = "Você encontrou um baú com algumas moedas de ouro.",
                    Payload = new { Gold = 50 }
                }
            });
        }
    }
}