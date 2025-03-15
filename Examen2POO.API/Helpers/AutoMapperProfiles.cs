using AutoMapper;
using Examen2POO.API.Database.Entities;
using Examen2POO.API.Dtos.Empleados;

namespace Examen2POO.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<EmpleadosEntity, EmpleadosDto>();
            CreateMap<EmpleadosEntity, EmpleadosActionResponseDto>();
            CreateMap<EmpleadosCreateDto, EmpleadosEntity>();
            CreateMap<EmpleadosEditDto, EmpleadosEntity>();
        }

    }
}
