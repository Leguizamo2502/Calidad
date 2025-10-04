using Data.Implements.Querys;
using Data.Interfaces.Group.Querys;
using Entity.Context.Main;
using Entity.Model.Colegio;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Data.Implements.CQRS.Card
{
    public class NotasData : BaseGenericQuerysData<Notas>, IQuerysNotas
    {
        protected readonly ILogger<NotasData> _logger;
        protected readonly AplicationDbContext _dbContext;

        public NotasData(ILogger<NotasData> logger, AplicationDbContext dbContext) : base(dbContext, logger)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public override async Task<IEnumerable<Notas>> QueryAllAsyn()
        {
            try
            {
                var model = await _dbContext.Notas
                    .Include(ur => ur.Asignaturas)
                    .Include(ur => ur.Matricula)
                    .Include(ur => ur.Periodos)
                    .ToListAsync();

                _logger.LogInformation("Consulta de la enidad {Entity} se realizo exitosamente", typeof(Notas).Name);
                return model;
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, "Error en la consulta la entidad {Entity}", typeof(Notas).Name);
                throw;
            }
        }





    }
}
