namespace Data.Interfaces.Basic
{
    public interface IInsert<T>
    {
        Task<T> InsertAsync(T entity);
    }
}
