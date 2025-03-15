using AutoMapper;
using Examen2POO.API.Database;
using Examen2POO.API.Database.Entities;
using Examen2POO.API.Dtos.Common;
using Examen2POO.API.Dtos.Empleados;
using Examen2POO.API.Dtos.Planillas;
using Examen2POO.API.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Examen2POO.API.Services
{
    public class PlanillasService : IPlanillaService
    {
        private readonly EmpleadosDBContext _context;
        private readonly IMapper _mapper;

        public PlanillasService(EmpleadosDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ResponseDto<List<PlanillasDto>>> GetListAsync()
        {
            var planillaEntity = await _context.Planillas.ToListAsync();

            var planillaDto = _mapper.Map<List<PlanillasDto>>(planillaEntity);

            return new ResponseDto<List<PlanillasDto>>
            {
                StatusCode = Constants.HttpStatusCode.OK,
                Status = true,
                Message = planillaEntity.Count() > 0 ? "Registros Encontrados" : "No se Encontraron Registros",
                Data = planillaDto.ToList()

            };

        }

        public async Task<ResponseDto<PlanillasActionResponseDto>> CreateAsync(PlanillaCreateDto dto)
        {
            var planillasEntity = _mapper.Map<PlanillaEntity>(dto);

            _context.Planillas.Add(planillasEntity);
            await _context.SaveChangesAsync();

            return new ResponseDto<PlanillasActionResponseDto>
            {
                StatusCode = Constants.HttpStatusCode.OK,
                Status = true,
                Message = "Registro Creado Correctamente",
                Data = _mapper.Map<PlanillasActionResponseDto>(planillasEntity)
            };
        }
    }
}
