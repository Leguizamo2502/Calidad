using Entity.Dtos.Global;
using Entity.Model.Colegio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.Colegio
{
    public class PeriodosDto : ABaseDto
    {

        public string Name { get; set; }
        public decimal Percentage { get; set; }
        public int ColegioId { get; set; }
        public DateTime DateStar { get; set; }
        public DateTime DateEnd { get; set; }
    }
}
