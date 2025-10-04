using Entity.Dtos.Global;
using Entity.Model.Colegio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.Colegio
{
    public class EstudiantesDto : ABaseDto
    {

        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
