using Business.Interfaces.Commands;
using Entity.Dtos.Global;
using Entity.Model.Global;

namespace Business.Implements.abastract
{
    public abstract class ABaseCommandsBusiness<T, D> : ICommandService<T, D> where T : ABaseEntity where D : ABaseDto
    {
        /// <summary>
        /// Crea una nueva entidad en la fuente de datos.
        /// </summary>
        /// <param name="entity">Entidad a crear. No debe ser null.</param>
        /// <returns>
        /// Tarea asincrona que representa la operaci?n y contiene la entidad creada con sus
        /// valores actualizados (como el ID generado) cuando se completa correctamente.
        /// </returns>
        public abstract Task<D> CreateServices(D dto);

        /// <summary>
        /// Actualiza una entidad existente en la fuente de datos.
        /// </summary>
        /// <param name="entity">Entidad con los valores actualizados. No debe ser null.</param>
        /// <returns>
        /// Tarea asincrona que representa la operaci?n y contiene la entidad actualizada
        /// cuando se completa correctamente.
        /// </returns>
        public abstract Task<bool> UpdateServices(D dto);

        /// <summary>
        /// Elimina una entidad de la fuente de datos por su identificador ?nico.
        /// </summary>
        /// <param name="id">Identificador ?nico de la entidad a eliminar.</param>
        /// <returns>
        /// Tarea asincrona que representa la operaci?n y contiene un valor booleano que indica
        /// si la eliminaci?n fue exitosa (true) o si la entidad no exist?a (false).
        /// </returns>
        public abstract Task<bool> DeleteServices(int id);
    }
}