using AutoMapper;
using LearningDiary.Repository;
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
        private readonly IMaterialRepository _materialRepository;
        private IMapper _mapper;
        public DiaryController(IMaterialRepository materialRepository, IMapper mapper)
        {
            _materialRepository = materialRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetAll")]

        public async Task<IActionResult> GetMaterials()
        {
            var materials = await _materialRepository.GetAllMaterials();
            return Ok(_mapper.Map<IEnumerable<ReadMaterialDTO>>(materials));
        }

        [HttpPost]
        [Route("AddMaterial")]
        public async Task<IActionResult> AddMaterial(CreateMaterialDTO materialDTO)
        {
            if (ModelState.IsValid)
            {
                var materialToAdd = _mapper.Map<Material>(materialDTO);
                await _materialRepository.AddMaterial(materialToAdd);
                return Ok(_mapper.Map<ReadMaterialDTO>(materialToAdd));
            }
            return BadRequest();
        }
    }
}
