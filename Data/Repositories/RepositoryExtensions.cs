using LearnNet6.Data.Repositories;

namespace LearnNet6.Data.Repositories
{
    public static class RepositoryExtensions
    {
        public static void AddCustomRepository(this IServiceCollection services)
        {
            services.AddTransient<IPostRepository, PostRepository>();
            services.AddTransient<IUserRepository, UserRepository>();

        }
    }
}
