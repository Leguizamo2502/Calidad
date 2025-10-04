using Entity.Dtos.Colegio.Distribucion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.DistributionService
{
    public interface IDistributionService
    {
        Task<IEnumerable<DistribucionResultDto>> DistribuirEstudiantesAsync(int colegioId, int totalEstudiantes);
    }

}
