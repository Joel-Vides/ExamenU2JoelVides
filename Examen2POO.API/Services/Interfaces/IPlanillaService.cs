using Examen2POO.API.Dtos.Common;
using Examen2POO.API.Dtos.Planillas;

namespace Examen2POO.API.Services.Interfaces
{
    public interface IPlanillaService
    {
        Task<ResponseDto<PlanillasActionResponseDto>> CreateAsync(PlanillaCreateDto dto);
        Task<ResponseDto<PlanillasActionResponseDto>> DeleteAsync(Guid id);
        Task<ResponseDto<PlanillasActionResponseDto>> EditAsync(PlanillasEditDto dto, Guid id);
        Task<ResponseDto<List<PlanillasDto>>> GetListAsync();
        Task<ResponseDto<PlanillasDto>> GetOneById(Guid id);
    }
}
