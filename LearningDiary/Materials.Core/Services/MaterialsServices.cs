using MongoDB.Driver;

namespace Materials.Core
{
    public class MaterialsServices : IMaterialServices
    {

        private readonly IMongoCollection<Material> _materials;
        public MaterialsServices(IDbClient dbClient)
        {
            _materials = dbClient.GetBooksCollection();
        }

        public async Task<Material> AddMaterial(Material material)
        {
            await _materials.InsertOneAsync(material);
            return material;
        }

        public async Task<List<Material>> GetMaterials()
        {
            return await _materials.Find(material => true).ToListAsync();
        }
    }
}