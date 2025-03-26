using AdventureCore.Domain.Models;
using AdventureCore.Domain.Settings;
using MongoDB.Driver;

namespace AdventureCore.Infrastructure.Repository
{
    public class RepositoryBase
    {
        internal readonly IMongoCollection<Person> _users;
        private readonly string _collectionName = "Users";

        public RepositoryBase(EnvirolmentVariables envirolmentVariables)
        {
            string connectionString = string.Format(
                envirolmentVariables.MONGODBSETTINGS_CONNECTIONSTRING,
                envirolmentVariables.MONGODBDATA_USER,
                Uri.EscapeDataString(envirolmentVariables.MONGODBDATA_PASSWORD),
                envirolmentVariables.MONGODBDATA_CLUSTER);

            var client = new MongoClient(connectionString);

            var database = client.GetDatabase(envirolmentVariables.MONGODBSETTINGS_DATABASENAME);
            _users = database.GetCollection<Person>(_collectionName);
        }
    }
}
