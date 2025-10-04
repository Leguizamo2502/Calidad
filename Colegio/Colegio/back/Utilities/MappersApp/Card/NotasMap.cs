using AutoMapper;
using Entity.Dtos.Card;
using Entity.Dtos.Colegio;
using Entity.Model.Colegio;



namespace Utilities.MappersApp.Card
{
    public class NotasMap : Profile
    {
        public NotasMap()
        {
            //CreateMap<Notas, NotasDto>()
            //    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
      
            //    .ReverseMap();

            CreateMap<Notas, NotasDto>().ReverseMap();
        }
    }
}