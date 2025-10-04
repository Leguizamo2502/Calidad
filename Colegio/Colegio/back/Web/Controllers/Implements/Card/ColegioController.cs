using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.Card;
using Entity.Dtos.Colegio;
using Entity.Model.Colegio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Design.Internal;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Card
{
    public class ColegioController
       : GenericController<
       Colegio,
       ColegioDto,
       ColegioDto>
    {


        public ColegioController(
            IQueryServices<Colegio, ColegioDto> q,
            ICommandService<Colegio, ColegioDto> c)
          : base(q, c) {
        }


      
    }

}
