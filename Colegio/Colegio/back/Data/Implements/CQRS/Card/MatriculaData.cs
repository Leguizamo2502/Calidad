using Data.Implements.Querys;
using Data.Interfaces.Group.Querys;
using Entity.Context.Main;
using Entity.Model.Colegio;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Data.Implements.CQRS.Card
{
    public class MatriculaData : BaseGenericQuerysData<Matricula>, IQuerysMatricula
    {
        protected readonly ILogger<MatriculaData> _logger;
        protected readonly AplicationDbContext _dbContext;

        public MatriculaData(ILogger<MatriculaData> logger, AplicationDbContext dbContext) : base(dbContext, logger)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public override async Task<IEnumerable<Matricula>> QueryAllAsyn()
        {
            try
            {
                var model = await _dbContext.Matricula
                    .Include(ur => ur.Salones)
                    .Include(ur => ur.Cursos)
                    .Include(ur => ur.Colegio)
                    .Include(ur => ur.Estudiante)
                    .ToListAsync();

                _logger.LogInformation("Consulta de la enidad {Entity} se realizo exitosamente", typeof(Matricula).Name);
                return model;
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, "Error en la consulta la entidad {Entity}", typeof(Matricula).Name);
                throw;
            }
        }



    }
}
