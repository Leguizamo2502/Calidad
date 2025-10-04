using Entity.Dtos.Global;
using Entity.Model.Global;

namespace Entity.Dtos.Card
{
    public class RoundDto : ABaseDto
    {
        public int Number { get; set; }
        public int End { get; set; }
        public int RoomId { get; set; }
    }

}

