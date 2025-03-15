using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examen2POO.API.Database.Entities
{
    [Table("Empleados")]
    public class EmpleadosEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("dni")]
        [Required]
        public string Dni { get; set; }

        [Column("first_name")]
        [Required]
        public string FirstName { get; set; }

        [Column("Last_name")]
        [Required]
        public string LastName { get; set; }

        [Column("document")]
        public string Document { get; set; }

        [Column("hiring_date")]
        [Required]
        public DateTime HiringDate { get; set; }

        [Column("departament")]
        public string Departament { get; set; }

        [Column("puesto_trabajo")]
        public string PuestoTrabajo { get; set; }

        [Column("base_salary")]
        public decimal BaseSalary { get; set; }

        [Column("active")]
        public bool Active { get; set; }

        [Column("planillas")]
        public Guid? DatosPlanillas { get; set; }

        [ForeignKey(nameof(DatosPlanillas))]
        public virtual PlanillaEntity Planillas { get; set; }


        //        Id(int, clave primaria)
        //● Nombre(string, requerido)
        //● Apellido(string, requerido)
        //● Documento(string, requerido, único)
        //● FechaContratacion(DateTime)
        //● Departamento(string)
        //● PuestoTrabajo(string)
        //● SalarioBase(decimal)
        //● Activo(bool)
    }
}
