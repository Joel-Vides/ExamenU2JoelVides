using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Examen2POO.API.Dtos.Detalles
{
    public class DetallePlanillaDto
    {
        public Guid Id { get; set; }

        public int PlanillaId { get; set; }

        public int EmpleadoId { get; set; }

        public decimal SalarioBase { get; set; }

        public decimal Bonificaciones { get; set; }

        public decimal Deducciones { get; set; }

        public decimal SalarioNeto { get; set; }

        public string comentarios { get; set; }
    }
}
