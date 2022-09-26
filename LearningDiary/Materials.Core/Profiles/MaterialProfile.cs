using AutoMapper;
using Materials.Core.DTOs;


namespace Materials.Core.Profiles
{
    public class MaterialProfile: Profile
    {
        public MaterialProfile()
        {
            CreateMap<Material, ReadMaterialDTO>();
            CreateMap<CreateMaterialDTO, Material>();
        }
    }
}
