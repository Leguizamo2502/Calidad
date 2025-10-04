using Entity.Dtos.Global;
using Entity.Model.Global;

namespace Entity.Dtos.Card
{
    public class RoomDto : ABaseDto
    {
        public int UserId { get; set; }
        public int AmountPlayer { get; set; }
        public string End { get; set; }
    }

}

