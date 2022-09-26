using AutoMapper;
using Materials.Core;
using Materials.Core.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningDiary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiaryController : ControllerBase
    {
        private readonly IMaterialServices _materialServices;
        private IMapper _mapper;
        public DiaryController(IMaterialServices materialServices, IMapper mapper)
        {
            _materialServices = materialServices;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetMaterials()
        {
            var materials = _materialServices.GetMaterials();
            return Ok(_mapper.Map<IEnumerable<ReadMaterialDTO>>(materials));
        }

        [HttpPost]

        public IActionResult AddMaterial(CreateMaterialDTO materialDTO)
        {
            if (ModelState.IsValid)
            {
                var materialToAdd = _mapper.Map<Material>(materialDTO);
                _materialServices.AddMaterial(materialToAdd);
                return Ok(_mapper.Map<ReadMaterialDTO>(materialToAdd));
            }
            return BadRequest();
        }
    }
}
