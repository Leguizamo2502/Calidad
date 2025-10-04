using Entity.Model.Global;

namespace Data.Interfaces.Basic
{
    public interface IUpdatePartial<T> where T : ABaseEntity
    {
        Task<bool> UpdatePartialAsync(T Entity);
    }
}
