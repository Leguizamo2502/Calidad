using Entity.Model.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Colegio
{
    public class    CursoAsignatura : ABaseEntity
    {
        public Cursos Curso { get; set; }
        public int CursoId { get; set; }
        public Asignaturas Asignatura { get; set; }
        public int AsignaturaId { get; set; }
    }
}
