using Data.Interfaces.Basic;
using Entity.Model.Global;

namespace Data.Interfaces.Group.Querys
{

    /// <summary>
    /// Interfaz que me define los métodos de consultas comunes
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IQuerys<T> : IQueryAll<T>, IQueryById<T>  where T : ABaseEntity
    {
    }
}
