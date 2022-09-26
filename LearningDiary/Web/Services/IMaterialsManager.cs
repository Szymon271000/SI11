using Materials.Core.DTOs;

namespace Web.Services
{
    public interface IMaterialsManager
    {
        public Task<List<ReadMaterialDTO>> FetchAllMaterials();
        public Task AddMaterial(CreateMaterialDTO material);
    }
}
