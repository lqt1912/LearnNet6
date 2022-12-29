using LearnNet6.Data.Entity;

namespace LearnNet6.Data.Repositories
{
    public class PerformanceTableRepository : BaseRepository<PerformanceTable>, IPerformanceTableRepository
    {
        public ApplicationDbContext Context { get; set; }
        private IConfiguration configuration;

        public PerformanceTableRepository(ApplicationDbContext Context, IConfiguration configuration) : base(Context, configuration) => this.Context = Context;

    }
}
