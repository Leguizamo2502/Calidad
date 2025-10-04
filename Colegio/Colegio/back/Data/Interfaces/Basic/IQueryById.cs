namespace Data.Interfaces.Basic
{
    public interface IQueryById<T>
    {
        Task<T> QueryById(int id);
    }
}
