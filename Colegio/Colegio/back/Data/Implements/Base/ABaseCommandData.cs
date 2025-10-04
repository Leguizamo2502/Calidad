using Data.Interfaces.Group.Commands;
using Entity.Context.Main;
using Entity.Model.Global;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Data.Implements.Base
{
    public abstract class ABaseCommandData<T> : ICommands<T> where T : ABaseEntity
    {
        protected readonly AplicationDbContext _context;
        protected readonly DbSet<T> _dbSet;
        protected readonly ILogger _logger;

        protected ABaseCommandData(AplicationDbContext context, ILogger logger)
        {
            _context = context;
            _dbSet = context.Set<T>();
            _logger = logger;
        }

        // Métodos abstractos que deben ser implementados por las clases derivadas
        public abstract Task<T> InsertAsync(T entity);
        public abstract Task<bool> UpdateAsync(T entity);
        public abstract Task<bool> DeleteAsync(int id);
        public abstract Task<bool> UpdatePartialAsync(T Entity);
    }
}
