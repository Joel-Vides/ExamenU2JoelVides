using Examen2POO.API.Dtos.Common;
using Examen2POO.API.Dtos.Empleados;

namespace Examen2POO.API.Services.Interfaces
{
    public interface IEmpleadosService
    {
        Task<ResponseDto<EmpleadosActionResponseDto>> CreateAsync(EmpleadosCreateDto dto);
        Task<ResponseDto<EmpleadosActionResponseDto>> DeleteAsync(Guid id);
        Task<ResponseDto<EmpleadosActionResponseDto>> EditAsync(EmpleadosEditDto dto, Guid id);
        Task<ResponseDto<List<EmpleadosDto>>> GetListAsync();
        Task<ResponseDto<EmpleadosDto>> GetOneById(Guid id);
    }
}
