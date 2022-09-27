using LearningDiary.Context;
using Materials.Core;
using MongoDB.Driver;

namespace LearningDiary.Repository
{
    public class MaterialRepository : IMaterialRepository
    {
        private readonly IMaterialContext _context;

        public MaterialRepository(IMaterialContext context)
        {
            _context = context;
        }

        public async Task<Material> AddMaterial(Material material)
        {
            await _context.Materials.InsertOneAsync(material);
            return material;
        }

        public async Task<IEnumerable<Material>> GetAllMaterials()
        {
            return await _context
                            .Materials
                            .Find(_ => true)
                            .ToListAsync();
        }
    }
}
