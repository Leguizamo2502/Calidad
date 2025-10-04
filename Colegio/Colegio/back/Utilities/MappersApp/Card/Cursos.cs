using AutoMapper;
using Entity.Dtos.Colegio;

namespace Utilities.MappersApp.Card
{
    public class Cursos : Profile
    {
        public Cursos()
        {
            CreateMap< Entity.Model.Colegio.Cursos, CursosDto>().ReverseMap();
        }
    }
}