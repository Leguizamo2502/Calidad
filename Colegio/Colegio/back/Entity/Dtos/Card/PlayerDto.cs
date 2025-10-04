using Entity.Dtos.Global;
using Entity.Model.Global;

namespace Entity.Dtos.Card
{
    public class PlayerDto : ABaseDto
    {
        public string Name { get; set; }
        public int RoomId { get; set; }
        public int Points { get; set; }
    }

}

