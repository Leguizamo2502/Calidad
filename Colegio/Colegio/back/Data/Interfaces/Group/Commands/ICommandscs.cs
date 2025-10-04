using Data.Interfaces.Basic;
using Entity.Model.Global;

namespace Data.Interfaces.Group.Commands
{
    /// <summary>
    /// Define lo metodos comunes de comandos comunes
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICommands<T> : IInsert<T>, IUpdate<T>, IDelete, IUpdatePartial<T> where T : ABaseEntity
    {
    }
}
