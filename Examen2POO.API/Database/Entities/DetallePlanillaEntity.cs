using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examen2POO.API.Database.Entities
{
    [Table("DetallePlanillas")]
    public class DetallePlanillaEntity
    {

        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("planilla_id")]
        [Required]
        public int PlanillaId { get; set; }

        [Column("empleado_id")]
        [Required]
        public int EmpleadoId { get; set; }

        [Column("salario_base")]
        [Required]
        public decimal SalarioBase { get; set; }

        [Column("bonificaciones")]
        [Required]
        public decimal Bonificaciones { get; set; }

        [Column("deducciones")]
        [Required]
        public decimal Deducciones { get; set; }

        [Column("salario_neto")]
        [Required]
        public decimal SalarioNeto { get; set; }

        [Column("comentarios")]
        [Required]
        public string comentarios { get; set; }

        //        ● Id(int, clave primaria)
        //● PlanillaId(int, clave foránea)
        //● EmpleadoId(int, clave foránea)
        //● SalarioBase(decimal)
        //● HorasExtra(decimal)
        //● MontoHorasExtra(decimal)
        //● Bonificaciones(decimal)
        //● Deducciones(decimal)
        //● SalarioNeto(decimal)
        //● Comentarios(string)
    }
}
