using Entity.Model.Global;

namespace Business.Interfaces.Commands
{
    public interface ICommandService<TEntity, TWriteDto> where TEntity : ABaseEntity
    {
        Task<TWriteDto> CreateServices(TWriteDto dto);
        Task<bool> UpdateServices(TWriteDto dto);
        Task<bool> DeleteServices(int id);
    }
}
