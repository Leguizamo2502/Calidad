using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.Card;
using Entity.Dtos.Colegio;
using Entity.Model.Colegio;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Card
{
    public class NotasController
       : GenericController<
       Notas,
       NotasDto,
       NotasDto>
    {
        public NotasController(
            IQueryServices<Notas, NotasDto> q,
            ICommandService<Notas, NotasDto> c)
          : base(q, c) { }
    }

}
