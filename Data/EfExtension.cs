using Microsoft.EntityFrameworkCore;

namespace LearnNet6.Data
{
    public static class EfExtension
    {
        public static void ApplyMigration(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var dataContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                dataContext.Database.Migrate();
            }
        }
    }
}
