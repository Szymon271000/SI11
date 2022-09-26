using Materials.Core.DTOs;
using Microsoft.AspNetCore.Mvc;
using Web.Services;

namespace Web.Controllers
{
    public class MaterialsController : Controller
    {
        private readonly IMaterialsManager _materialsManager;

        public MaterialsController(IMaterialsManager materialsManager)
        {
            _materialsManager = materialsManager;
        }

        public async Task<IActionResult> Index(List<ReadMaterialDTO> materials)
        {
            var result = await _materialsManager.FetchAllMaterials();
            return View(result);
        }

        public ActionResult AddMaterial()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddMaterialToDatabase([Bind("Title", "Description", "Tags")]CreateMaterialDTO material)
        {
            if (ModelState.IsValid)
            {
                await _materialsManager.AddMaterial(material);
            }
            return RedirectToAction("Index", "Materials");
        }
    }
}
