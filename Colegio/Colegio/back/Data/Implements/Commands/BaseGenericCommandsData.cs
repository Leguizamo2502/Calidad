using Data.Implements.Base;
using Entity.Context.Main;
using Entity.Model.Global;
using Microsoft.Extensions.Logging;

namespace Data.Implements.Commands
{
    public class BaseGenericCommandsData<T> : ABaseCommandData<T> where T : ABaseEntity
    {
        public BaseGenericCommandsData(AplicationDbContext context, ILogger<BaseGenericCommandsData<T>> logger) : base(context, logger)
        {
        }


        public override async Task<T> InsertAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public override async Task<bool> UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public override async Task<bool> DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            if (entity == null) return false;

            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
        public override async Task<bool> UpdatePartialAsync(T entity)
        {
            var dbEntity = await _dbSet.FindAsync(entity.Id);
            if (dbEntity == null) return false;

            // Solo se marcan las propiedades modificadas
            _context.Entry(dbEntity).CurrentValues.SetValues(entity);

            // Opcional: ignorar propiedades nulas (actualización parcial real)
            foreach (var prop in typeof(T).GetProperties())
            {
                var newValue = prop.GetValue(entity);
                if (newValue == null)
                {
                    _context.Entry(dbEntity).Property(prop.Name).IsModified = false;
                }
            }

            await _context.SaveChangesAsync();
            return true;
        }

    }
}
