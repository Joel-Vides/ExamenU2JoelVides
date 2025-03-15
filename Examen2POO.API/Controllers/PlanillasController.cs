using Examen2POO.API.Dtos.Common;
using Examen2POO.API.Dtos.Empleados;
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

        [HttpGet("{id}")]
        public async Task<ActionResult<ResponseDto<PlanillaCreateDto>>> GetOne(Guid id)
        {
            var response = await _planillasService.GetOneById(id);

            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<ActionResult<ResponseDto<PlanillasActionResponseDto>>> Post([FromBody] PlanillaCreateDto dto)
        {
            var reponse = await _planillasService.CreateAsync(dto);

            return StatusCode(reponse.StatusCode, new
            {
                reponse.Status,
                reponse.Message,
                reponse.Data
            });
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<PlanillasActionResponseDto>> Edit([FromBody] PlanillasEditDto dto, Guid id)
        {
            var response = await _planillasService.EditAsync(dto, id);

            return StatusCode(response.StatusCode, response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<PlanillasActionResponseDto>> Delete(Guid id)
        {
            var response = await _planillasService.DeleteAsync(id);

            return StatusCode(response.StatusCode, response);
        }
    }
}
