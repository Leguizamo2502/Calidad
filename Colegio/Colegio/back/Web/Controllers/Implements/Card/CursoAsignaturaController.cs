using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.Card;
using Entity.Dtos.Colegio;
using Entity.Model.Colegio;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Card
{
    public class CursoAsignaturaController
       : GenericController<
       CursoAsignatura,
       CursoAsignaturaQueryDto,
       CursoAsignaturaDto>
    {

        protected readonly IQueryCursoAsignaturaServices _services;

        public CursoAsignaturaController(
            IQueryCursoAsignaturaServices q,
            ICommandService<CursoAsignatura, CursoAsignaturaDto> c)
          : base(q, c) {}


        

    }

}
