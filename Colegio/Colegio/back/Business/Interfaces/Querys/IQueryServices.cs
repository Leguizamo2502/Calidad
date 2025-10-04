namespace Business.Interfaces.Querys
{
    public interface IQueryServices<TEntity,TReadDto>
    {
        Task<IEnumerable<TReadDto>> GetAllServices();
        Task<TReadDto> GetByIdServices(int id);
    }
}
