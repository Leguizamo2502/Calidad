using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.Card;
using Entity.Dtos.Colegio;
using Entity.Model.Colegio;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Card
{
    public class CursosController
       : GenericController<
       Cursos,
       CursosDto,
       CursosDto>
    {
        public CursosController(
            IQueryServices<Cursos, CursosDto> q,
            ICommandService<Cursos, CursosDto> c)
          : base(q, c) { }
    }

}
