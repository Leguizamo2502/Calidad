using Entity.Model.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Colegio
{
    public class Matricula : ABaseEntity
    {
        public Estudiantes Estudiante { get; set; }
        public int EstudianteId { get; set; }
        public Colegio Colegio { get; set; }
        public int ColegioId { get; set; }
        public Salones Salones { get; set; }
        public int SalonesId { get; set; }
        public Cursos Cursos { get; set; }
        public int CursosId { get; set; }
        public IEnumerable<Notas> Notas { get; set; }
    }
}
