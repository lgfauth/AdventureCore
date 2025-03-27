using AdventureCore.Domain.Settings;
using MongoDB.Driver;

namespace AdventureCore.Infrastructure.Persistence.Base
{
    public class RepositoryBase<T> where T : class
    {
        protected readonly IMongoCollection<T> _collection;

        public RepositoryBase(EnvirolmentVariables envirolmentVariables, string collectionName)
        {
            var connectionString = string.Format(
                envirolmentVariables.MONGODBSETTINGS_CONNECTIONSTRING,
                envirolmentVariables.MONGODBDATA_USER,
                Uri.EscapeDataString(envirolmentVariables.MONGODBDATA_PASSWORD),
                envirolmentVariables.MONGODBDATA_CLUSTER);

            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(envirolmentVariables.MONGODBSETTINGS_DATABASENAME);

            _collection = database.GetCollection<T>(collectionName);
        }
    }
}