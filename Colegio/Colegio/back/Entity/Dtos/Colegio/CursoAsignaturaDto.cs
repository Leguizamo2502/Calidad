using Entity.Dtos.Global;
using Entity.Model.Colegio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.Colegio
{
    public class CursoAsignaturaDto : ABaseDto
    {

        public int CursoId { get; set; }
        public int AsignaturaId { get; set; }
    }
}
