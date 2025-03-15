namespace Examen2POO.API.Dtos.Empleados
{
    public class EmpleadosActionResponseDto
    {
        public Guid Id { get; set; }
        public string Dni { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public DateTime HiringDate { get; set; }
        public string Departament { get; set; }
        public string PuestoTrabajo { get; set; }
        public decimal BaseSalary { get; set; }
        public bool Active { get; set; }
    }
}
