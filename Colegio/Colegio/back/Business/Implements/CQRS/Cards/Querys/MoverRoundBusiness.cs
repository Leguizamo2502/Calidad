//using AutoMapper;
//using Business.Implements.Bases;
//using Business.Interfaces.Querys;
//using Data.Interfaces.Group.Querys;
//using Entity.Dtos.Card;
//using Entity.Dtos.Card.move;
//using Entity.Model.Card;
//using Microsoft.Extensions.Logging;
//using Utilities.Helpers.Validations;

//namespace Business.Implements.CQRS.Cards.Querys
//{

//    public class MoverRoundBusiness : BaseQueryBusiness<Move, MoveDto>, IQueryCardRoundServices
//    {
//        protected readonly IQuerysMove _data;
       
//        public MoverRoundBusiness(
//            IQuerysMove data,
//            IMapper mapper,
//            ILogger<MoverRoundBusiness> _logger,
//            IGenericHerlpers helpers) : base(data, mapper, _logger, helpers)
//        {
//            _data = data;
//        }

//        protected async Task EnsureValid(MoveDto dto)
//        {
//            var validationResult = await _helpers.Validate(dto);
//            if (!validationResult.IsValid)
//            {
//                var errors = string.Join(", ", validationResult.Errors);
//                throw new ArgumentException($"Validación fallida: {errors}");
//            }
//        }

//        public async Task<IEnumerable<MoverRoundDto>> GetCardsRound(int id)
//        {
//            try
//            {
//                var entities = await _data.QueryMoveRound(id);
//                _logger.LogInformation($"Obteniendo {typeof(Move).Name} con ID: {id}");

//                var result = _mapper.Map<IEnumerable<MoverRoundDto>>(entities);
//                return result;
//            }
//            catch (Exception ex)
//            {
//                _logger.LogError($"Error al obtener {typeof(MoverRoundDto).Name} con ID {id}: {ex.Message}");
//                throw;
//            }
//        }

//    }

//}
