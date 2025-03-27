using AdventureCore.Domain.Entities;
using AdventureCore.Domain.Repositories;
using AdventureCore.Domain.Settings;
using AdventureCore.Infrastructure.Persistence.Base;
using MongoDB.Driver;

namespace AdventureCore.Infrastructure.Persistence
{
    public class EnemyRepository : RepositoryBase<Enemy>, IEnemyRepository
    {
        public EnemyRepository(EnvirolmentVariables env) : base(env, "Enemies") { }

        public async Task<Enemy?> GetByIdAsync(Guid id)
            => await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task<List<Enemy>> GetRandomEnemiesAsync(int level)
        {
            var enemies = await _collection.Find(e => e.Level == level).ToListAsync();
            return enemies.OrderBy(_ => Guid.NewGuid()).Take(3).ToList();
        }
    }
}