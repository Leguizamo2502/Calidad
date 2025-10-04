using Entity.Dtos.Global;
using Entity.Model.Global;

namespace Entity.Dtos.Card
{
    public class RoomPlayerDtoQuery : ABaseDto
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int AmountPlayer { get; set; }
        public string End { get; set; }
    }

}

