using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.Card;
using Entity.Dtos.Colegio;
using Entity.Model.Colegio;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Card
{
    public class EstudiantesController
       : GenericController<
       Estudiantes,
       EstudiantesDto,
       EstudiantesDto>
    {
        public EstudiantesController(
            IQueryServices<Estudiantes, EstudiantesDto> q,
            ICommandService<Estudiantes, EstudiantesDto> c)
          : base(q, c) { }
    }

}
