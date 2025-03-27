using AdventureCore.Domain.Entities;

namespace AdventureCore.Domain.Repositories
{
    public interface IPlayerRepository
    {
        Task<Player?> GetByIdAsync(Guid id);
        Task AddAsync(Player player);
        Task UpdateAsync(Player player);
    }
}