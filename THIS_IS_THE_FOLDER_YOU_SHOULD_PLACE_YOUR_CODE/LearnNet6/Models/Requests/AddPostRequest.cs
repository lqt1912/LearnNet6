namespace LearnNet6.Models.Requests
{
    public class AddPostRequest
    {
        public string Title { get; set; }
        public Guid AuthorId { get; set; }
    }
}
