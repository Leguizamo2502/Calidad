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

//    public class PlayerBusiness : BaseQueryBusiness<Player, PlayerDto>, IQueryPlayerServices
//    {
//        protected readonly IQuerysPlayer _data;
       
//        public PlayerBusiness(
//            IQuerysPlayer data,
//            IMapper mapper,
//            ILogger<PlayerBusiness> _logger,
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

//        public async Task<IEnumerable<PlayerDto>> GetPlayersRoom(int id)
//        {
//            try
//            {
//                var entities = await _data.QueryPlayerRoom(id);
//                _logger.LogInformation($"Obteniendo {typeof(Player).Name} con ID: {id}");

//                var result = _mapper.Map<IEnumerable<PlayerDto>>(entities);
//                return result;
//            }
//            catch (Exception ex)
//            {
//                _logger.LogError($"Error al obtener {typeof(Player).Name} con ID {id}: {ex.Message}");
//                throw;
//            }
//        }

//    }

//}
