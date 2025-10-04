using AutoMapper;
using Entity.Dtos.Card;
using Entity.Dtos.Colegio;
using Entity.Model.Colegio;

namespace Utilities.MappersApp.Card
{
    public class CursoAsignaturaMap : Profile
    {
        public CursoAsignaturaMap()
        {
            CreateMap<CursoAsignatura, CursoAsignaturaDto>().ReverseMap();
            CreateMap<CursoAsignatura, CursoAsignaturaQueryDto>()
                .ForMember(dest => dest.CursoName,
                           opt => opt.MapFrom(src => src.Curso != null ? src.Curso.Name : null))
                .ForMember(dest => dest.AsignaturaName,
                           opt => opt.MapFrom(src => src.Asignatura != null ? src.Asignatura.Name : null))
                .ReverseMap();

        }
    }
}