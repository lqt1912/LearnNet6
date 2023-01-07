using LearnNet6.Data.Entity;

namespace LearnNet6.Data.Repositories
{
    public class MessageGroupRepository : BaseRepository<MessageGroup>, IMessageGroupRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IConfiguration configuration;

        public MessageGroupRepository(ApplicationDbContext context, IConfiguration configuration): base(context, configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }
    }
}
