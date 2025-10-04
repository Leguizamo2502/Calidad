using Business.Interfaces;
using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.Global;
using Entity.Model.Global;

namespace Business.Implements.abastract
{
    public abstract class ABaseQuerysBusiness<T, D> : IQueryServices<T, D> where T : ABaseEntity where D : ABaseDto
    {
        /// <summary>
        /// Obtiene una colecci?n de todas las entidades del tipo especificado.
        /// </summary>
        /// <returns>
        /// Tarea asincrona que representa la operaci?n y contiene una colecci?n de entidades 
        /// cuando se completa correctamente.
        /// </returns>
        public abstract Task<IEnumerable<D>> GetAllServices();

        /// <summary>
        /// Recupera una entidad espec?fica por su identificador ?nico.
        /// </summary>
        /// <param name="id">Identificador ?nico de la entidad a recuperar.</param>
        /// <returns>
        /// Tarea asincrona que representa la operaci?n y contiene la entidad solicitada
        /// cuando se completa correctamente. Puede retornar null si no se encuentra la entidad.
        /// </returns>
        public abstract Task<D> GetByIdServices(int id);
    }
}