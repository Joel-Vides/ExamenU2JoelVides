using Examen2POO.API.Dtos.Common;
using Examen2POO.API.Dtos.Empleados;
using Examen2POO.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Examen2POO.API.Controllers
{
    [ApiController]
    [Route("api/empleados")]
    public class EmpleadosController : ControllerBase
    {
        private readonly IEmpleadosService _empleadosService;
        public EmpleadosController(IEmpleadosService empleadosService)
        {
            _empleadosService = empleadosService;
        }

        [HttpGet]
        public async Task<ActionResult<ResponseDto<List<EmpleadosCreateDto>>>> GetList()
        {
            var response = await _empleadosService.GetListAsync();

            return StatusCode(response.StatusCode, new
            {
                response.Status,
                response.Message,
                response.Data
            });
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ResponseDto<EmpleadosCreateDto>>> GetOne(Guid id)
        {
            var response = await _empleadosService.GetOneById(id);

            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<ActionResult<ResponseDto<EmpleadosActionResponseDto>>> Post([FromBody] EmpleadosCreateDto dto)
        {
            var reponse = await _empleadosService.CreateAsync(dto);

            return StatusCode(reponse.StatusCode, new
            {
                reponse.Status,
                reponse.Message,
                reponse.Data
            });
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<EmpleadosActionResponseDto>> Edit([FromBody] EmpleadosEditDto dto, Guid id)
        {
            var response = await _empleadosService.EditAsync(dto, id);

            return StatusCode(response.StatusCode, response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<EmpleadosActionResponseDto>> Delete(Guid id)
        {
            var response = await _empleadosService.DeleteAsync(id);

            return StatusCode(response.StatusCode, response);
        }
    }
}
