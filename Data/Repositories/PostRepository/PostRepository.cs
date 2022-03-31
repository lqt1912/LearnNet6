using LearnNet6.Data.Entity;

namespace LearnNet6.Data.Repositories
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        public ApplicationDbContext Context { get; set; }
        public PostRepository(ApplicationDbContext Context) : base(Context)
        {
            this.Context = Context;
        }
    }
}
