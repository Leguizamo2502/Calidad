using AutoMapper;
using Entity.Dtos.Colegio;
using Entity.Model.Colegio;


namespace Utilities.MappersApp.Card
{
    public class AsignaturaMap : Profile
    {
        public AsignaturaMap()
        {
            CreateMap<Asignaturas, AsignaturasDto>().ReverseMap();
        }
    }
}