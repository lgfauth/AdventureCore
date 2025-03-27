using AdventureCore.Application.Models.Request;
using AdventureCore.Application.Models.Response;
using AdventureCore.Application.Services.Interfaces;
using System.Numerics;

namespace AdventureCore.Application.Services.Implementations
{
    public class PlayerService : IPlayerService
    {
        // No momento, simulação de armazenamento em memória
        private static readonly Dictionary<string, Player> _players = new();

        public async Task<PlayerResponse> CreatePlayerAsync(PlayerRequest request)
        {
            var player = new Player
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Class = request.Class,
                Level = 1,
                Experience = 0,
                Gold = 100,
                Stats = new Stats
                {
                    HP = 100,
                    MP = 50,
                    Strength = 5,
                    Defense = 3,
                    Agility = 4,
                    Intelligence = 10
                }
            };

            _players[player.Id.ToString()] = player;

            return await Task.FromResult(ToResponse(player));
        }

        public async Task<PlayerResponse> GetPlayerByIdAsync(string playerId)
        {
            _players.TryGetValue(playerId, out var player);

            return await Task.FromResult(player != null ? ToResponse(player) : null);
        }

        private PlayerResponse ToResponse(Player player)
        {
            return new PlayerResponse
            {
                Id = player.Id,
                Name = player.Name,
                Class = player.Class,
                Level = player.Level,
                Experience = player.Experience,
                Gold = player.Gold,
                Stats = new StatsResponse
                {
                    HP = player.Stats.HP,
                    MP = player.Stats.MP,
                    Strength = player.Stats.Strength,
                    Defense = player.Stats.Defense,
                    Agility = player.Stats.Agility,
                    Intelligence = player.Stats.Intelligence
                }
            };
        }
    }
}
