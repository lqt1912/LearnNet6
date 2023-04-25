namespace LearnNet6.Data.Entity
{
    public class Card :BaseEntity
    {
        public string Title { get; set; }
        public int Order { get; set; }
        public CardType? Type { get; set; }
        public string? CardAuthor { get; set; }
        public string? CardAuthorName { get; set; }
        public string? CardAuthorEmail { get; set; }
        public int? EstimateValue { get; set; }
        public string? AssignedTo { get; set; }
        public string? AssignedToName { get; set; }
        public string? AssignedToEmail { get; set; }
    }

    public enum CardType
    {
        ToDo,
        Done, 
        NoNeed
    }
}
