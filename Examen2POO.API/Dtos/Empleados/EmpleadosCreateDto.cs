using System.ComponentModel.DataAnnotations;

namespace Examen2POO.API.Dtos.Empleados
{
    public class EmpleadosCreateDto
    {
        [Display(Name = "Documentos Nacionales de Identificación")]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        [StringLength(13, MinimumLength = 13, ErrorMessage = "El Campo {0} debe Tener un Minimo de {2} y un Máximo de {1} Caracteres")]
        public string DNI { get; set; }

        [Display(Name = "Nombres")]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El Campo {0} debe Tener un Minimo de {2} y un Máximo de {1} Caracteres")]
        public string FirstName { get; set; }

        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El Campo {0} debe Tener un Minimo de {2} y un Máximo de {1} Caracteres")]
        public string LastName { get; set; }

        [Display(Name = "Fecha de Contratación")]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        //[StringLength(ErrorMessage = "El Campo {0} debe Tener un Minimo de {2} y un Máximo de {1} Caracteres")]
        public DateTime HiringDate { get; set; }

        [Display(Name = "Departamento")]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El Campo {0} debe Tener un Minimo de {2} y un Máximo de {1} Caracteres")]
        public string Departament { get; set; }

        [Display(Name = "Puesto de Trabajo")]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El Campo {0} debe Tener un Minimo de {2} y un Máximo de {1} Caracteres")]
        public string PuestoTrabajo { get; set; }

        [Display(Name = "Salario Base")]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public decimal BaseSalary { get; set; }

        [Display(Name = "Empleado Activo")]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public bool Active { get; set; }

        [Display(Name = "Planillas")]
        [Required(ErrorMessage = "El {0} es Requerido.")]
        public Guid? DatosPlanillas { get; set; } = null;



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
