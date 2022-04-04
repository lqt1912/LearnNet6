using LearnNet6.Data.Entity;

namespace LearnNet6.Data.Repositories
{
    public class RefreshTokenRepository : BaseRepository<RefreshToken>, IRefreshTokenRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IConfiguration configuration;

        public RefreshTokenRepository(ApplicationDbContext context, IConfiguration configuration) : base(context, configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }
    }
}
