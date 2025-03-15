namespace Examen2POO.API.Dtos.Planillas
{
    public class PlanillasActionResponseDto
    {
        public Guid Id { get; set; }
        public string Periodo { get; set; }
        public DateTime FechaPago { get; set; }
        public string Estado { get; set; }
    }
}
