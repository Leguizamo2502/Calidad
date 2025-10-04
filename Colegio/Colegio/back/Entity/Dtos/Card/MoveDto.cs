using Entity.Dtos.Global;
using Entity.Model.Global;

namespace Entity.Dtos.Card
{
    public class MoveDto : ABaseDto
    {
        public int CardId { get; set; }
        public int PlayerId { get; set; }
        public int Result { get; set; }
        public int RoundId { get; set; }
    }

}

