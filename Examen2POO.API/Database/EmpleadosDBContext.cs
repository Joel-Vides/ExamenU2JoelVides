using Examen2POO.API.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Examen2POO.API.Database
{
    public class EmpleadosDBContext : DbContext
    {
        public EmpleadosDBContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<EmpleadosEntity> Empleados { get; set; }

        public DbSet<PlanillaEntity> Planillas { get; set; }

        public DbSet<PlanillaEntity> DetallePlanillas { get; set; }
    }
}
