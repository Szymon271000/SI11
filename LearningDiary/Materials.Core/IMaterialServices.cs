using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materials.Core
{
    public interface IMaterialServices
    {
        List<Material> GetMaterials();
        Material AddMaterial(Material material);
    }
}
