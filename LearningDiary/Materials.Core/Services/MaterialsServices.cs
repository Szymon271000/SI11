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

        public Material AddMaterial(Material material)
        {
            _materials.InsertOne(material);
            return material;
        }

        public List<Material> GetMaterials()
        {
            return _materials.Find(material => true).ToList();
        }
    }
}