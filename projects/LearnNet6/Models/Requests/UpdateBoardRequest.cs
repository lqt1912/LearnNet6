using LearnNet6.Data.Entity;

namespace LearnNet6.Models.Requests
{
    public class UpdateBoardRequest
    {
        public  int CardType { get; set; }
        public List<Card> CardValue { get; set; }
    }
}
