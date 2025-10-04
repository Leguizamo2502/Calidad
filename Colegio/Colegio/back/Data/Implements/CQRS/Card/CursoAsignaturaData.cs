using Data.Implements.Querys;
using Data.Interfaces.Group.Querys;
using Entity.Context.Main;
using Entity.Model.Colegio;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Data.Implements.CQRS.Card
{
    public class CursoAsignaturaData : BaseGenericQuerysData<CursoAsignatura>, IQueryCursoAsignatura
    {
        protected readonly ILogger<CursoAsignaturaData> _logger;
        protected readonly AplicationDbContext _dbContext;
    
        public CursoAsignaturaData(ILogger<CursoAsignaturaData> logger, AplicationDbContext dbContext) : base(dbContext, logger)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public override async Task<IEnumerable<CursoAsignatura>> QueryAllAsyn()
        {
            try
            {
                var model = await _dbContext.CursoAsignatura
                    .Include(ur => ur.Asignatura)
                    .Include(ur => ur.Curso)
                    .ToListAsync();

                _logger.LogInformation("Consulta de la enidad {Entity} se realizo exitosamente", typeof(CursoAsignatura).Name);
                return model;
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, "Error en la consulta la entidad {Entity}", typeof(CursoAsignatura).Name);
                throw;
            }
        }

        public override async Task<CursoAsignatura> QueryById(int id)
        {
            return await _dbContext.CursoAsignatura
                    .Include(ur => ur.Asignatura)
                    .Include(ur => ur.Curso)
                    .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
