using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.Card;
using Entity.Dtos.Colegio;
using Entity.Model.Colegio;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Card
{
    public class PeriodoController
       : GenericController<
       Periodos,
       PeriodosDto,
       PeriodosDto>
    {
        public PeriodoController(
            IQueryServices<Periodos, PeriodosDto> q,
            ICommandService<Periodos, PeriodosDto> c)
          : base(q, c) { }
    }

}
