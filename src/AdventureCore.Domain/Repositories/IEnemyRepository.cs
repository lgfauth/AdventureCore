using AdventureCore.Domain.Entities;

namespace AdventureCore.Domain.Repositories
{
    public interface IEnemyRepository
    {
        Task<Enemy?> GetByIdAsync(Guid id);
        Task<List<Enemy>> GetRandomEnemiesAsync(int level);
    }
}