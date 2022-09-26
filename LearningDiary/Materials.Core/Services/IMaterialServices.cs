using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materials.Core
{
    public interface IMaterialServices
    {
        Task <List<Material>> GetMaterials();
        Task <Material> AddMaterial(Material material);
    }
}
