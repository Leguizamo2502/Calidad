using Data.Interfaces.Group.Querys;
using Entity.Context.Main;
using Entity.Model.Global;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Data.Implements.Base
{
    public abstract class ABaseQuerysData<T> : IQuerys<T> where T : ABaseEntity
    {
        protected readonly AplicationDbContext _context;
        protected readonly DbSet<T> _dbSet;
        protected readonly ILogger _logger;

        protected ABaseQuerysData(AplicationDbContext context, ILogger logger)
        {
            _context = context;
            _dbSet = context.Set<T>();
            _logger = logger;
        }

        // Métodos abstractos que deben ser implementados por las clases derivadas
        public abstract Task<IEnumerable<T>> QueryAllAsyn();
        public abstract Task<T> QueryById(int id);
    }
}
