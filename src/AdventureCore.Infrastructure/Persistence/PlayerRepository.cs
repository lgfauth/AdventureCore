using AdventureCore.Domain.Entities;
using AdventureCore.Domain.Repositories;
using AdventureCore.Domain.Settings;
using AdventureCore.Infrastructure.Persistence.Base;
using MongoDB.Driver;

namespace AdventureCore.Infrastructure.Persistence
{
    public class PlayerRepository : RepositoryBase<Player>, IPlayerRepository
    {
        public PlayerRepository(EnvirolmentVariables env) : base(env, "Players") { }

        public async Task<Player?> GetByIdAsync(Guid id)
            => await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task AddAsync(Player player)
            => await _collection.InsertOneAsync(player);

        public async Task UpdateAsync(Player player)
            => await _collection.ReplaceOneAsync(x => x.Id == player.Id, player);
    }
}