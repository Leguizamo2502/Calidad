using AutoMapper;
using Business.Implements.Bases;
using Business.Interfaces.Querys;
using Data.Interfaces.Group.Querys;
using Entity.Dtos.Colegio;
using Entity.Model.Colegio;
using Microsoft.Extensions.Logging;
using Utilities.Helpers.Validations;

namespace Business.Implements.CQRS.Cards.Querys
{
    public class CursoAsignaturaBusiness
        : BaseQueryBusiness<CursoAsignatura, CursoAsignaturaQueryDto>,
          IQueryCursoAsignaturaServices
    {
        protected readonly IQueryCursoAsignatura _dataGeneric;
        protected readonly IGenericHerlpers _helpers;

        public CursoAsignaturaBusiness(
            IQueryCursoAsignatura data,
            IMapper mapper,
            ILogger<CursoAsignaturaBusiness> logger,
            IGenericHerlpers helpers
        ) : base(data, mapper, logger, helpers)
        {
            _dataGeneric = data;
            _helpers = helpers;
        }

        /// <summary>
        /// Valida un DTO utilizando las reglas de validación de FluentValidation.
        /// </summary>
        protected async Task EnsureValid(CursoAsignaturaQueryDto dto)
        {
            var validationResult = await _helpers.Validate(dto);
            if (!validationResult.IsValid)
            {
                var errors = string.Join(", ", validationResult.Errors);
                throw new ArgumentException($"Validación fallida: {errors}");
            }
        }

        public override async Task<IEnumerable<CursoAsignaturaQueryDto>> GetAllServices()
        {
            try
            {
                var entities = await _dataGeneric.QueryAllAsyn();
                _logger.LogInformation($"Obteniendo todos los registros de {typeof(CursoAsignaturaQueryDto).Name}");
                return _mapper.Map<IEnumerable<CursoAsignaturaQueryDto>>(entities);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al obtener registros de {typeof(CursoAsignaturaQueryDto).Name}: {ex.Message}");
                throw;
            }
        }


        public override async Task<CursoAsignaturaQueryDto> GetByIdServices(int id)
        {
            try
            {
                var entities = await _data.QueryById(id);
                _logger.LogInformation($"Obteniendo {typeof(CursoAsignaturaQueryDto).Name} con ID: {id}");
                return _mapper.Map<CursoAsignaturaQueryDto>(entities);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al obtener {typeof(CursoAsignaturaQueryDto).Name} con ID {id}: {ex.Message}");
                throw;
            }
        }
    }
}
