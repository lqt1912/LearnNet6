using LearnNet6.Data.Entity;

namespace LearnNet6.Data.Repositories
{
    public class UserRepository : BaseRepository<ApplicationUser>, IUserRepository
    {
        private readonly ApplicationDbContext _context;
        private IConfiguration configuration;

        public UserRepository(ApplicationDbContext context, IConfiguration configuration) :base(context, configuration)
        {
            _context = context;
        }
    }
}
