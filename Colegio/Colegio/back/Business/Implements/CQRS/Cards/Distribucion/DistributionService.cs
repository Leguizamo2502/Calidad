using Business.Interfaces.Distribution;
using Business.Interfaces.DistributionService;
using Entity.Dtos.Colegio.Distribucion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implements.CQRS.Cards.Distribucion
{
    public class DistributionService : IDistributionService
    {
        private readonly ICursoRepository _cursoRepository;

        public DistributionService(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }

        public async Task<IEnumerable<DistribucionResultDto>> DistribuirEstudiantesAsync(int colegioId, int totalEstudiantes)
        {
            var cursos = await _cursoRepository.GetWithSalonesAsync(colegioId);
            var salones = cursos.SelectMany(c => c.Salones).ToList();

            if (!salones.Any())
                throw new Exception("No hay salones registrados para este colegio.");

            var capacidadTotal = salones.Count; // como Amount está null, contamos los salones
            if (totalEstudiantes < capacidadTotal)
                throw new Exception("Hay menos estudiantes que salones.");

            // Distribuir de manera equitativa
            int baseAsignacion = totalEstudiantes / salones.Count;
            int sobrante = totalEstudiantes % salones.Count;

            var result = new List<DistribucionResultDto>();
            int i = 0;

            foreach (var salon in salones)
            {
                int cantidad = baseAsignacion + (i < sobrante ? 1 : 0);

                // actualizar el campo Amount
                salon.Amount = cantidad;
                result.Add(new DistribucionResultDto
                {
                    SalonId = salon.Id,
                    SalonName = salon.Name,
                    CursoId = salon.CursoId,
                    CursoName = cursos.First(c => c.Id == salon.CursoId).Name,
                    CantidadAsignada = cantidad
                });
                i++;
            }

            // Persistir cambios en BD
            await _cursoRepository.UpdateSalonesAsync(salones);

            return result;
        }

    }

}
