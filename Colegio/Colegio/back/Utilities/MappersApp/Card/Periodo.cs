using AutoMapper;
using Entity.Dtos.Card;
using Entity.Dtos.Colegio;
using Entity.Model.Colegio;


namespace Utilities.MappersApp.Card
{
    public class Perido : Profile
    {
        public Perido()
        {
            //CreateMap<Periodos, PeriodosDto>()
            //    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
      
            //    .ReverseMap();

            CreateMap<Periodos, PeriodosDto>().ReverseMap();
        }
    }
}