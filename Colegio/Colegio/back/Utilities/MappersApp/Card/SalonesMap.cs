using AutoMapper;
using Entity.Dtos.Card;
using Entity.Dtos.Colegio;
using Entity.Model.Colegio;


namespace Utilities.MappersApp.Card
{
    public class SalonesMap : Profile
    {
        public SalonesMap()
        {
            //CreateMap<Salones, UserQueryDto>()
            //    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
      
            //    .ReverseMap();

            CreateMap<Salones, SalonesDto>().ReverseMap();
        }
    }
}