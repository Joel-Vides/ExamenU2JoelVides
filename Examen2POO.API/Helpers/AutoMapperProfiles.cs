using AutoMapper;
using Examen2POO.API.Database.Entities;
using Examen2POO.API.Dtos.Empleados;
using Examen2POO.API.Dtos.Planillas;

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

            CreateMap<PlanillaEntity, PlanillasDto>();
            CreateMap<PlanillaEntity, PlanillasActionResponseDto>();
            CreateMap<PlanillaCreateDto, PlanillaEntity>();
            CreateMap<PlanillasEditDto, PlanillaEntity>();

            CreateMap<DetallePlanillaEntity, PlanillasDto>();
            CreateMap<PlanillaEntity, PlanillasActionResponseDto>();
            CreateMap<PlanillaCreateDto, PlanillaEntity>();
            CreateMap<PlanillasEditDto, PlanillaEntity>();
        }

    }
}
