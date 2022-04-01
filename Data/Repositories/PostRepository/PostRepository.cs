using LearnNet6.Data.Entity;

namespace LearnNet6.Data.Repositories
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        public ApplicationDbContext Context { get; set; }
        private IConfiguration configuration;

        public PostRepository(ApplicationDbContext Context, IConfiguration configuration) : base(Context, configuration)
        {
            this.Context = Context;
        }
    }
}
