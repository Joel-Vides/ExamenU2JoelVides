using AutoMapper;
using Examen2POO.API.Database;
using Examen2POO.API.Dtos.Common;
using Examen2POO.API.Dtos.Detalles;
using Examen2POO.API.Dtos.Empleados;
using Examen2POO.API.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Examen2POO.API.Services
{
    public class DetallePlanillaService : IDetallesPlanillaService
    {
        private readonly EmpleadosDBContext _context;
        private readonly IMapper _mapper;

        public DetallePlanillaService(EmpleadosDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ResponseDto<List<DetallePlanillaDto>>> GetListAsync()
        {
            var detallesEntity = await _context.DetallePlanillas.ToListAsync();

            var detallesDto = _mapper.Map<List<DetallePlanillaDto>>(detallesEntity);

            return new ResponseDto<List<DetallePlanillaDto>>
            {
                StatusCode = Constants.HttpStatusCode.OK,
                Status = true,
                Message = detallesEntity.Count() > 0 ? "Registros Encontrados" : "No se Encontraron Registros",
                Data = detallesDto.ToList()

            };

        }
    }
}
