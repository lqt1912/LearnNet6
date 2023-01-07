using LearnNet6.Data.Entity;

namespace LearnNet6.Data.Repositories
{
    public class GroupMemberRepository : BaseRepository<GroupMember>, IGroupMemberRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IConfiguration configuration;
        public GroupMemberRepository(ApplicationDbContext dbContext, IConfiguration configuration, ApplicationDbContext context) : base(dbContext, configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }
    }
}
