namespace Data.Interfaces.Basic
{
    public interface IUpdate<T>
    {
        Task<bool> UpdateAsync(T entity);
    }
}
