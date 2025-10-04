using AutoMapper;
using Entity.Dtos.Card;
using Entity.Dtos.Card.move;
using Entity.Dtos.Colegio;

namespace Utilities.MappersApp.Card
{
    public class Matricula : Profile
    {
        public Matricula()
        {
            CreateMap<Matricula, MatriculaDto>().ReverseMap();

            //CreateMap<Matricula, MatriculaDto>()
            //    .ForMember(dest => dest.PlayerId, opt => opt.MapFrom(src => src.Player.Id))
            //    .ForMember(dest => dest.CardId, opt => opt.MapFrom(src => src.Card.Id))
            //    .ForMember(dest => dest.CardName, opt => opt.MapFrom(src => src.Card.Name))
            //    .ForMember(dest => dest.Legenday, opt => opt.MapFrom(src => src.Card.Legenday))
            //    .ForMember(dest => dest.Speed, opt => opt.MapFrom(src => src.Card.Speed))
            //    .ForMember(dest => dest.Endurace, opt => opt.MapFrom(src => src.Card.Endurace))
            //    .ForMember(dest => dest.SpecialPower, opt => opt.MapFrom(src => src.Card.SpecialPower))
            //    .ForMember(dest => dest.Technique, opt => opt.MapFrom(src => src.Card.Technique))
            //    .ForMember(dest => dest.Brutality, opt => opt.MapFrom(src => src.Card.Brutality));
        }
    }
}