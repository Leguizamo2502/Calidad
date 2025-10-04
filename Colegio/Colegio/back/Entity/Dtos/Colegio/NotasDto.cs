using Entity.Dtos.Global;
using Entity.Model.Colegio;

namespace Entity.Dtos.Colegio
{
    public class NotasDto : ABaseDto
    {
        public int AsignaturasId { get; set; }
        public decimal Nota { get; set; }
        public decimal Porcentaje { get; set; }
        public int PeriodosId { get; set; }
        public int MatriculaId { get; set; }
    }

}

