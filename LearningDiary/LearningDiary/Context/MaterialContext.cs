using LearningDiary.Config;
using Materials.Core;
using MongoDB.Driver;

namespace LearningDiary.Context
{
    public class MaterialContext : IMaterialContext
    {
        private readonly IMongoDatabase _db;
        public MaterialContext(MongoDBConfig config)
        {
            var client = new MongoClient(config.ConnectionString);
            _db = client.GetDatabase(config.Database);
        }

        public IMongoCollection<Material> Materials => _db.GetCollection<Material>("Materials");
    }
}
