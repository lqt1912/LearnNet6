using LearnNet6.Data.Entity;

namespace LearnNet6.Data.Repositories
{

    public class MessageItemRepository : BaseRepository<MessageItem>, IMessageItemRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IConfiguration configuration;

        public MessageItemRepository(ApplicationDbContext context, IConfiguration configuration) : base(context, configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }
    }
}
