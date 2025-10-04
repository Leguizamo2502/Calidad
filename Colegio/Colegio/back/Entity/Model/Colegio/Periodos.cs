using Entity.Model.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Colegio
{
    public class Periodos : ABaseEntity
    {
        public string Name { get; set; }
        public decimal Percentage { get; set; }
        public Colegio Colegio { get; set; }
        public int ColegioId { get; set; }
        public DateTime DateStar { get; set; }
        public DateTime DateEnd { get; set; }
        public IEnumerable<Notas> Notas { get; set; }
    }
}
