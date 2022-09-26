
using Microsoft.Extensions.Options;
using MongoDB.Driver;


namespace Materials.Core
{
    public class DbClient : IDbClient
    {
        private readonly IMongoCollection<Material> _materials;

        public DbClient(IOptions<MaterialDbConfig> materialDbConfig)
        {
            var client = new MongoClient(materialDbConfig.Value.Connection_String);
            var database = client.GetDatabase(materialDbConfig.Value.Database_Name);
            _materials = database.GetCollection<Material>(materialDbConfig.Value.Material_Collection_name);
        }
        public IMongoCollection<Material> GetBooksCollection() => _materials;
    }
}
