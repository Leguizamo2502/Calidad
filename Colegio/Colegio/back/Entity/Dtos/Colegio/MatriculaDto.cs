using Entity.Dtos.Global;
using Entity.Model.Colegio;

namespace Entity.Dtos.Colegio
{
    public class MatriculaDto : ABaseDto
    {
        public int EstudianteId { get; set; }
        public int ColegioId { get; set; }
        public int SalonesId { get; set; }
        public int CursosId { get; set; }
    }

}

