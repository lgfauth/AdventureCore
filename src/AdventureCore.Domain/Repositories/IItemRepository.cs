using AdventureCore.Domain.Entities;

namespace AdventureCore.Domain.Repositories
{
    public interface IItemRepository
    {
        Task<Item?> GetByIdAsync(Guid id);
        Task<List<Item>> GetAllAsync();
    }
}