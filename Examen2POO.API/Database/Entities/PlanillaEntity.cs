using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examen2POO.API.Database.Entities
{
    [Table("Planillas")]
    public class PlanillaEntity
    {

        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("periodo")]
        [Required]
        public string Periodo { get; set; }

        [Column("fecha_pago")]
        public DateTime FechaPago { get; set; }

        [Column("Estado")]
        public string Estado { get; set; }

        //        ● Id(int, clave primaria)
        //● Periodo(string, requerido) - Ejemplo: "Marzo 2025"
        //● FechaCreacion(DateTime)
        //● FechaPago(DateTime)
        //● Estado(string) - "Pendiente", "Pagada", "Anulada"
    }
}
