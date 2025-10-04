using Entity.Dtos.Global;


namespace Entity.Dtos.Card.move
{
    public class MoverRoundDto : ABaseDto
    {
        public int CardId { get; set; }
        public int PlayerId { get; set; }
        public string CardName { get; set; }
        public int Legenday { get; set; }
        public double Focer { get; set; }
        public double Speed { get; set; }
        public double Endurace { get; set; }
        public double SpecialPower { get; set; }
        public double Technique { get; set; }
        public double Brutality { get; set; }
    }

}

