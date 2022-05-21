using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using LearnNet6.Data.Repositories;

namespace LearnNet6.Data.Repositories
{
    public static class RepositoryExtensions
    {
        public static void AddCustomRepository(this IServiceCollection services)
        {
            services.AddTransient<IPostRepository, PostRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IRefreshTokenRepository, RefreshTokenRepository>();
            var googleCredential = GoogleCredential.FromFile(@"wwwroot/angular-demo-8117d-firebase-adminsdk-ukil5-5095ca4481.json");

            FirebaseApp.Create(new AppOptions() { Credential = googleCredential });
        }
    }
}
