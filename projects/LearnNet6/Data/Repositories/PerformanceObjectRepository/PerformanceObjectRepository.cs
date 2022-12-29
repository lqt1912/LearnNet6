using LearnNet6.Data.Entity;

namespace LearnNet6.Data.Repositories
{
    public class PerformanceObjectRepository : BaseRepository<PerfomanceObject>, IPerformanceObjectRepository
    {
        public ApplicationDbContext Context { get; set; }
        private IConfiguration configuration;

        public PerformanceObjectRepository(ApplicationDbContext Context, IConfiguration configuration) : base(Context, configuration) => this.Context = Context;
    }
}
