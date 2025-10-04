using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.Colegio.Distribucion
{
    public class DistribucionResultDto
    {
        public int SalonId { get; set; }
        public string SalonName { get; set; }
        public int CursoId { get; set; }
        public string CursoName { get; set; }
        public int CantidadAsignada { get; set; }
    }

}
