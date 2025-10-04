using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.Card;
using Entity.Dtos.Colegio;
using Entity.Model.Colegio;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Card
{
    public class AsignaturaController
       : GenericController<
       Asignaturas,
       AsignaturasDto,
       AsignaturasDto>
    {
        public AsignaturaController(
            IQueryServices<Asignaturas, AsignaturasDto> q,
            ICommandService<Asignaturas, AsignaturasDto> c)
          : base(q, c) { }

    }

}
