using Data.Implements.Base;
using Entity.Context.Main;
using Entity.Model.Global;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Data.Implements.Querys
{
    public class BaseGenericQuerysData<T> : ABaseQuerysData<T> where T : ABaseEntity
    {
        public BaseGenericQuerysData(AplicationDbContext context, ILogger<BaseGenericQuerysData<T>> logger) : base(context, logger)
        {
        }
        public override async Task<IEnumerable<T>> QueryAllAsyn()
        {
            try
            {
                var model = await _dbSet.ToListAsync();
                _logger.LogInformation("Consulta de la enidad {Entity} se realizo exitosamente", typeof(T).Name);
                return model;
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, "Error en la consulta la entidad {Entity}", typeof(T).Name);
                throw;
            }
        }

        public override async Task<T> QueryById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

    }
}
