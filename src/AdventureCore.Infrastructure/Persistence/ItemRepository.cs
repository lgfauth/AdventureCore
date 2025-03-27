using AdventureCore.Domain.Entities;
using AdventureCore.Domain.Repositories;
using AdventureCore.Domain.Settings;
using AdventureCore.Infrastructure.Persistence.Base;
using MongoDB.Driver;

namespace AdventureCore.Infrastructure.Persistence
{
    public class ItemRepository : RepositoryBase<Item>, IItemRepository
    {
        public ItemRepository(EnvirolmentVariables env) : base(env, "Items") { }

        public async Task<Item?> GetByIdAsync(Guid id)
            => await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task<List<Item>> GetAllAsync()
            => await _collection.Find(_ => true).ToListAsync();
    }
}