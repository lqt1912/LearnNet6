using LearnNet6.Data.Entity;

namespace LearnNet6.Data.Repositories
{
    public class UserRepository : BaseRepository<ApplicationUser>, IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context) :base(context)
        {
            _context = context;
        }
    }
}
