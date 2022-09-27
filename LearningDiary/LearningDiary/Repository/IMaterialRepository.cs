using Materials.Core;

namespace LearningDiary.Repository
{
    public interface IMaterialRepository
    {
        Task<IEnumerable<Material>> GetAllMaterials();
        Task<Material> AddMaterial(Material material);

    }
}
