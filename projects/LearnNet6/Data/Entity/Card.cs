namespace LearnNet6.Data.Entity
{
    public class Card :BaseEntity
    {
        public string Title { get; set; }
        public int Order { get; set; }
        public CardType? Type { get; set; }
        public string? CardAuthor { get; set; }
        public int? EstimateValue { get; set; }
        public string? AssignedTo { get; set; }
    }

    public enum CardType
    {
        From,
        To
    }
}
