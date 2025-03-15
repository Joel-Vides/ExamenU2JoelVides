using System.ComponentModel.DataAnnotations;

namespace Examen2POO.API.Dtos.Detalles
{
    public class DetallePlanillaCreateDto
    {
        [Display(Name = "Id de Planilla")]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        //[StringLength(13, MinimumLength = 13, ErrorMessage = "El Campo {0} debe Tener un Minimo de {2} y un Máximo de {1} Caracteres")]
        public int PlanillaId { get; set; }

        [Display(Name = "Id de Empleado")]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public int EmpleadoId { get; set; }

        [Display(Name = "Salario Base")]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public decimal SalarioBase { get; set; }

        [Display(Name = "Bonificaciones")]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public decimal Bonificaciones { get; set; }

        [Display(Name = "Deducciones")]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public decimal Deducciones { get; set; }

        [Display(Name = "Salario Neto")]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public decimal SalarioNeto { get; set; }

        [Display(Name = "Comentarios")]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public string comentarios { get; set; }

        [Display(Name = "Planillas")]
        [Required(ErrorMessage = "El {0} es Requerido.")]
        public Guid? DatosPlanillas { get; set; } = null;
    }
}
