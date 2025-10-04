using Entity.Model.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Colegio
{
    public class Cursos : ABaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Colegio Colegio { get; set; }
        public int ColegioId { get; set; }
        public IEnumerable<Salones> Salones { get; set; }
        public IEnumerable<CursoAsignatura> CursoAsignatura { get; set; }
        public IEnumerable<Matricula> Matricula { get; set; }
    }
}
