using Examen2POO.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Examen2POO.API.Controllers
{
    [ApiController]
    [Route("api/DetallePlanilla")]
    public class DetallesPlanillaController : ControllerBase
    {
        private readonly IDetallesPlanillaService _detallePlanillaService;
        public DetallesPlanillaController(IDetallesPlanillaService detallesPlanillaService)
        {
            _detallePlanillaService = detallesPlanillaService;
        }

    }
}
