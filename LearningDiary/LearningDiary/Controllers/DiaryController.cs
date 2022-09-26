using Materials.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningDiary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiaryController : ControllerBase
    {
        private readonly IMaterialServices _materialServices;
        public DiaryController(IMaterialServices materialServices)
        {
            _materialServices = materialServices;
        }

        [HttpGet]
        public IActionResult GetMaterials()
        {
            return Ok(_materialServices.GetMaterials());
        }

        [HttpPost]

        public IActionResult AddMaterial(Material material)
        {
            _materialServices.AddMaterial(material);
            return Ok(material);
        }
    }
}
