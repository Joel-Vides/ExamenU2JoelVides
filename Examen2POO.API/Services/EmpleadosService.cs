using System.Net;
using AutoMapper;
using Examen2POO.API.Constants;
using Examen2POO.API.Database;
using Examen2POO.API.Database.Entities;
using Examen2POO.API.Dtos.Common;
using Examen2POO.API.Dtos.Empleados;
using Examen2POO.API.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Examen2POO.API.Services
{
    public class EmpleadosService : IEmpleadosService
    {
        private readonly EmpleadosDBContext _context;
        private readonly IMapper _mapper;

        public EmpleadosService(EmpleadosDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ResponseDto<List<EmpleadosDto>>> GetListAsync()
        {
            var empleadoEntity = await _context.Empleados.ToListAsync();

            var empleadoDto = _mapper.Map<List<EmpleadosDto>>(empleadoEntity);

            return new ResponseDto<List<EmpleadosDto>>
            {
                StatusCode = Constants.HttpStatusCode.OK,
                Status = true,
                Message = empleadoEntity.Count() > 0 ? "Registros Encontrados" : "No se Encontraron Registros",
                Data = empleadoDto.ToList()

            };

        }

        public async Task<ResponseDto<EmpleadosDto>> GetOneById(Guid id)
        {
            var empleadoEntity = await _context.Empleados.FirstOrDefaultAsync(x => x.Id == id);

            if (empleadoEntity is null)
            {
                return new ResponseDto<EmpleadosDto>
                {
                    StatusCode = Constants.HttpStatusCode.NOT_FOUND,
                    Status = false,
                    Message = "Registro no Encontrado"
                };
            }

            return new ResponseDto<EmpleadosDto>
            {
                StatusCode = Constants.HttpStatusCode.OK,
                Status = true,
                Message = "Registro Encontrado Correctamente",
                Data = _mapper.Map<EmpleadosDto>(empleadoEntity)
            };
        }

        public async Task<ResponseDto<EmpleadosActionResponseDto>> CreateAsync(EmpleadosCreateDto dto)
        {
            var empleadosEntity = _mapper.Map<EmpleadosEntity>(dto);

            _context.Empleados.Add(empleadosEntity);
            await _context.SaveChangesAsync();

            return new ResponseDto<EmpleadosActionResponseDto>
            {
                StatusCode = Constants.HttpStatusCode.OK,
                Status = true,
                Message = "Registro Creado Correctamente",
                Data = _mapper.Map<EmpleadosActionResponseDto>(empleadosEntity)
            };
        }

        public async Task<ResponseDto<EmpleadosActionResponseDto>> EditAsync(EmpleadosEditDto dto, Guid id)
        {
            var empleadosEntity = await _context.Empleados.FirstOrDefaultAsync(x => x.Id == id);

            if (empleadosEntity is null)
            {
                return new ResponseDto<EmpleadosActionResponseDto>
                {
                    StatusCode = Constants.HttpStatusCode.NOT_FOUND,
                    Status = false,
                    Message = "Registro no Encontrado"
                };
            }

            _mapper.Map<EmpleadosEditDto, EmpleadosEntity>(dto, empleadosEntity);

            _context.Empleados.Update(empleadosEntity);
            await _context.SaveChangesAsync();

            return new ResponseDto<EmpleadosActionResponseDto>
            {
                StatusCode = Constants.HttpStatusCode.OK,
                Status = true,
                Message = "Registro Editado Correctamente",
                Data = _mapper.Map<EmpleadosActionResponseDto>(empleadosEntity)
            };
        }

        public async Task<ResponseDto<EmpleadosActionResponseDto>> DeleteAsync(Guid id)
        {
            var empleadoEntity = await _context.Empleados.FirstOrDefaultAsync(x => x.Id == id);

            if (empleadoEntity is null)
            {
                return new ResponseDto<EmpleadosActionResponseDto>
                {
                    StatusCode = Constants.HttpStatusCode.NOT_FOUND,
                    Status = false,
                    Message = "Registro no Encontrado"
                };
            }

            _context.Empleados.Remove(empleadoEntity);
            await _context.SaveChangesAsync();

            return new ResponseDto<EmpleadosActionResponseDto>
            {
                StatusCode = Constants.HttpStatusCode.OK,
                Status = true,
                Message = "Registro Eliminado Correctamente",
                Data = _mapper.Map<EmpleadosActionResponseDto>(empleadoEntity)
            };
        }

    }
}
