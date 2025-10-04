using Entity.Model.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Colegio
{
    public class Estudiantes : ABaseEntity
    {
        public string Name { get; set; } 
        public string LastName { get; set; }
        public IEnumerable<Matricula> Matricula { get; set; }

    }
}
