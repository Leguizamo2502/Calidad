using Entity.Dtos.Card;
using Entity.Dtos.Colegio;
using Entity.Model.Colegio;

namespace Business.Interfaces.Querys
{
    public interface IQueryCursoAsignaturaServices
        : IQueryServices<CursoAsignatura, CursoAsignaturaQueryDto>
    {
    }

}
