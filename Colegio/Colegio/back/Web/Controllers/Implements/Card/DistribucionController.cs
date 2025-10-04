using Business.Interfaces.DistributionService;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Implements.Card
{
    [ApiController]
    [Route("api/[controller]")]
    public class DistribucionController : ControllerBase
    {
        private readonly IDistributionService _distributionService;

        public DistribucionController(IDistributionService distributionService)
        {
            _distributionService = distributionService;
        }

        [HttpGet("{colegioId}/distribuir/{totalEstudiantes}")]
        public async Task<IActionResult> Distribuir(int colegioId, int totalEstudiantes)
        {
            var result = await _distributionService.DistribuirEstudiantesAsync(colegioId, totalEstudiantes);
            return Ok(result);
        }
    }

}
