using AutoMapper;
using Entity.Dtos.Card;
using Entity.Dtos.Colegio;
using Entity.Model.Colegio;

namespace Utilities.MappersApp.Card
{
    public class EstudianteMap : Profile
    {
        public EstudianteMap()
        {
            CreateMap<Estudiantes, EstudiantesDto>().ReverseMap();
        }
    }
}