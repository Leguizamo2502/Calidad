using Entity.Model.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Colegio
{
    public class Notas : ABaseEntity
    {

        public Asignaturas Asignaturas { get; set; }
        public int AsignaturasId { get; set; }
        public decimal Nota { get; set; }
        public decimal Porcentaje { get; set; }
        public Periodos Periodos { get; set; }
        public int PeriodosId { get; set; }
        public Matricula Matricula { get; set; }
        public int MatriculaId { get; set; }
    }
}
