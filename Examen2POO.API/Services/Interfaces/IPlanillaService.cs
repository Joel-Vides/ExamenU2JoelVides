using Examen2POO.API.Dtos.Common;
using Examen2POO.API.Dtos.Planillas;

namespace Examen2POO.API.Services.Interfaces
{
    public interface IPlanillaService
    {
        Task<ResponseDto<PlanillasActionResponseDto>> CreateAsync(PlanillaCreateDto dto);
        Task<ResponseDto<List<PlanillasDto>>> GetListAsync();
    }
}
