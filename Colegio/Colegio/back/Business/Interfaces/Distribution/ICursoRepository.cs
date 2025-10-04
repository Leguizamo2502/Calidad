using Entity.Model.Colegio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.Distribution
{
    public interface ICursoRepository
    {
        Task<IEnumerable<Cursos>> GetWithSalonesAsync(int colegioId);
        Task UpdateSalonesAsync(IEnumerable<Salones> salones);
    }

}
