using Examen2POO.API.Dtos.Common;
using Examen2POO.API.Dtos.Planillas;
using Examen2POO.API.Services;
using Examen2POO.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Examen2POO.API.Controllers
{
    [ApiController]
    [Route("api/planillas")]
    public class PlanillasController : ControllerBase
    {
        private readonly IPlanillaService _planillasService;
        public PlanillasController(IPlanillaService planillasService)
        {
            _planillasService = planillasService;
        }

        [HttpGet]
        public async Task<ActionResult<ResponseDto<List<PlanillaCreateDto>>>> GetList()
        {
            var response = await _planillasService.GetListAsync();

            return StatusCode(response.StatusCode, new
            {
                response.Status,
                response.Message,
                response.Data
            });
        }

        [HttpPost]
        public async Task<ActionResult<ResponseDto<PlanillasActionResponseDto>>> Post([FromBody] PlanillaCreateDto dto)
        {

        }
    }
}
