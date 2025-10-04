using Entity.Dtos.Global;
using Entity.Model.Colegio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.Colegio
{
    public class CursosDto : ABaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ColegioId { get; set; }
    }
}
