using Business.Interfaces.Distribution;
using Entity.Context.Main;
using Entity.Model.Colegio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implements.CQRS.Cards.Distribucion
{
    public class CursoRepository : ICursoRepository
    {
        private readonly AplicationDbContext _context;

        public CursoRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cursos>> GetWithSalonesAsync(int colegioId)
        {
            return await _context.Cursos
                .Include(c => c.Salones)
                .Where(c => c.ColegioId == colegioId)
                .ToListAsync();
        }

        public async Task UpdateSalonesAsync(IEnumerable<Salones> salones)
        {
            _context.Salones.UpdateRange(salones);
            await _context.SaveChangesAsync();
        }

    }

}
