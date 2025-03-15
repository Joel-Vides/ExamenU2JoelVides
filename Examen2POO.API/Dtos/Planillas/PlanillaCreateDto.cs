using System.ComponentModel.DataAnnotations;

namespace Examen2POO.API.Dtos.Planillas
{
    public class PlanillaCreateDto
    {
        [Display(Name = "Periodo")]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "El Campo {0} debe Tener un Minimo de {2} y un Máximo de {1} Caracteres")]
        public string Periodo { get; set; }

        [Display(Name = "Fecha de Pago")]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public DateTime FechaPago { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "El Campo {0} debe Tener un Minimo de {2} y un Máximo de {1} Caracteres")]
        public string Estado { get; set; }
    }
}
