using Entity.Dtos.Global;

namespace Entity.Dtos.Card
{
    public class MazoPlayerDto : ABaseDto
    {
        public int CardId { get; set; }
        public int PlayerId { get; set; }
        
        public bool Use { get; set; }
    }

}

