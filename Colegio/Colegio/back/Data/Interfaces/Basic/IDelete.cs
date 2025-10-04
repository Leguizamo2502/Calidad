namespace Data.Interfaces.Basic
{
    public interface IDelete
    {
        Task<bool> DeleteAsync(int id);
    }
}
