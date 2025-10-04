using Entity.Model.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Colegio
{
    public class Salones : ABaseEntity
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public Cursos Curso { get; set; }
        public int CursoId { get; set; }
    }
}
