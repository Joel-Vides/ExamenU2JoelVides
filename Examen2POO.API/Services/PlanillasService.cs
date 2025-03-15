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

        public async Task<ResponseDto<PlanillasDto>> GetOneById(Guid id)
        {
            var planillaEntity = await _context.Planillas.FirstOrDefaultAsync(x => x.Id == id);

            if (planillaEntity is null)
            {
                return new ResponseDto<PlanillasDto>
                {
                    StatusCode = Constants.HttpStatusCode.NOT_FOUND,
                    Status = false,
                    Message = "Registro no Encontrado"
                };
            }

            return new ResponseDto<PlanillasDto>
            {
                StatusCode = Constants.HttpStatusCode.OK,
                Status = true,
                Message = "Registro Encontrado Correctamente",
                Data = _mapper.Map<PlanillasDto>(planillaEntity)
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

        public async Task<ResponseDto<PlanillasActionResponseDto>> EditAsync(PlanillasEditDto dto, Guid id)
        {
            {
                var planillasEntity = await _context.Planillas.FirstOrDefaultAsync(x => x.Id == id);

                if (planillasEntity is null)
                {
                    return new ResponseDto<PlanillasActionResponseDto>
                    {
                        StatusCode = Constants.HttpStatusCode.NOT_FOUND,
                        Status = false,
                        Message = "Registro no Encontrado"
                    };
                }

                _mapper.Map<PlanillasEditDto, PlanillaEntity>(dto, planillasEntity);

                _context.Planillas.Update(planillasEntity);
                await _context.SaveChangesAsync();

                return new ResponseDto<PlanillasActionResponseDto>
                {
                    StatusCode = Constants.HttpStatusCode.OK,
                    Status = true,
                    Message = "Registro Editado Correctamente",
                    Data = _mapper.Map<PlanillasActionResponseDto>(planillasEntity)
                };
            }
        }

        public async Task<ResponseDto<PlanillasActionResponseDto>> DeleteAsync(Guid id)
        {
            var planillasEntity = await _context.Planillas.FirstOrDefaultAsync(x => x.Id == id);

            if (planillasEntity is null)
            {
                return new ResponseDto<PlanillasActionResponseDto>
                {
                    StatusCode = Constants.HttpStatusCode.NOT_FOUND,
                    Status = false,
                    Message = "Registro no Encontrado"
                };
            }

            var planillaDeEmpleado = await _context.Empleados.CountAsync(p => p.DatosPlanillas == id);

            if (planillaDeEmpleado > 0)
            {
                return new ResponseDto<PlanillasActionResponseDto>
                {
                    StatusCode = Constants.HttpStatusCode.BAD_REQUEST,
                    Status = false,
                    Message = "No Hay Datos Relacionados"
                };
            }

            _context.Planillas.Remove(planillasEntity);
            await _context.SaveChangesAsync();

            return new ResponseDto<PlanillasActionResponseDto>
            {
                StatusCode = Constants.HttpStatusCode.OK,
                Status = true,
                Message = "Registro Eliminado Correctamente",
                Data = _mapper.Map<PlanillasActionResponseDto>(planillasEntity)
            };
        }
    }
}
