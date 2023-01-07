using LearnNet6.Data.Entity;

namespace LearnNet6.Data.Repositories
{
    public class MessageTypeRepository : BaseRepository<MessageType>, IMessageTypeRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IConfiguration configuration;

        public MessageTypeRepository(ApplicationDbContext context, IConfiguration configuration) :base (context, configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }
    }
}
