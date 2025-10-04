namespace Data.Interfaces.Basic
{
    public interface IDeleteLogical<T>
    {
        Task<bool> DeleteLogicalAsyn(int id, T Entity);

    }
}
