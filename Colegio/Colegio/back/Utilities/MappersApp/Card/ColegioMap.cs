using AutoMapper;
using Entity.Dtos.Colegio;
using Entity.Model.Colegio;

namespace Utilities.MappersApp.Card
{
    public class ColegioMap : Profile
    {
        public ColegioMap()
        {
            CreateMap<Colegio, ColegioDto>().ReverseMap();
        }
    }
}