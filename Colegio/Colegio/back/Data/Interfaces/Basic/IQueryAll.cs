namespace Data.Interfaces.Basic 
{ 
    public interface IQueryAll<T>
    {
        Task<IEnumerable<T>> QueryAllAsyn(); 
    }
}
