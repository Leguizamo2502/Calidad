
using Entity.Dtos.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.Colegio
{
    public class CursoAsignaturaQueryDto : ABaseDto
    {

        public int CursoId { get; set; }
        public string CursoName { get; set; }
        public int AsignaturaId { get; set; }
        public string AsignaturaName { get; set; }
    }
}
