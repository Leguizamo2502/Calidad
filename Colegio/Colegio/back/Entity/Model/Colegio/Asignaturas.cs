using Entity.Model.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Colegio
{
    public class Asignaturas : ABaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<CursoAsignatura> CursoAsignatura { get; set; }
        public IEnumerable<Notas> Notas { get; set; }
    }
}
