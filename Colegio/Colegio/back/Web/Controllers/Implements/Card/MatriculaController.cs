using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.Card;
using Entity.Dtos.Colegio;
using Entity.Model.Colegio;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Card
{
    public class MatriculaController
       : GenericController<
       Matricula,
       MatriculaDto,
       MatriculaDto>
    {
      

        public MatriculaController(
            IQueryServices<Matricula, MatriculaDto> q,
            ICommandService<Matricula, MatriculaDto> c)
          : base(q, c) 
        {
 
        }
    }

}
