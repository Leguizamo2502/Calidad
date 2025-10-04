using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.Card;
using Entity.Dtos.Colegio;
using Entity.Model.Colegio;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Card
{
    public class SalonesController
       : GenericController<
       Salones,
       SalonesDto,
       SalonesDto>
    {
        public SalonesController(
            IQueryServices<Salones, SalonesDto> q,
            ICommandService<Salones, SalonesDto> c)
          : base(q, c) { }
    }

}
