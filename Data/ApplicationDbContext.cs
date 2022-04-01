using LearnNet6.Data.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LearnNet6.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid> 
    {

        public DbSet<ApplicationUser> AspNetUsers { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>().HasData(
                 new ApplicationUser()
                 {
                     Id = Guid.NewGuid(),
                     FirstName = "Lê Quốc",
                     LastName = "Thắng",
                     UserName = "thanglequoc1912@gmail.com",
                     NormalizedUserName = "THANGLEQUOC1912@GMAIL.COM",
                     Email = "thanglequoc1912@gmail.com",
                     NormalizedEmail = "thanglequoc1912@gmail.com",
                     EmailConfirmed = true,
                     PasswordHash = "AQAAAAEAACcQAAAAEAoqZuAyWwiKrsIjkHq7JSjmEEXMZHFcQ3wLHkjVMZ9xTXRwxIb7xehLGAN7xAQEcA==",
                     SecurityStamp = "N2AZ7AT2TAQAB5IBSPE334HYSFJVDGV7",
                     ConcurrencyStamp = "793a4503-f76b-403e-b028-3c3840bdaa2a",
                     PhoneNumber = "091234836721",
                     PhoneNumberConfirmed = true,
                     TwoFactorEnabled = false,
                     LockoutEnabled = true,
                     LockoutEnd = null,
                     AccessFailedCount = 0
                 },
                  new ApplicationUser()
                  {
                      Id = Guid.NewGuid(),
                      FirstName = "Nguyễn Quốc",
                      LastName = "Trung",
                      UserName = "duyendatthang@gmail.com",
                      NormalizedUserName = "DUYENDATTHANG@GMAIL.COM",
                      Email = "duyendatthang@gmail.com",
                      NormalizedEmail = "DUYENDATTHANG@gmail.com",
                      EmailConfirmed = true,
                      PasswordHash = "AQAAAAEAACcQAAAAEAoqZuAyWwiKrsIjkHq7JSjmEEXMZHFcQ3wLHkjVMZ9xTXRwxIb7xehLGAN7xAQEcA==",
                      SecurityStamp = "DNZOWEXXK7I25QGATY3UPNZPF4JGGPOD",
                      ConcurrencyStamp = "aaaf5630-3dda-44d2-8bd8-1b39ca36d575",
                      PhoneNumber = "093478329239",
                      PhoneNumberConfirmed = true,
                      TwoFactorEnabled = false,
                      LockoutEnabled = true,
                      LockoutEnd = null,
                      AccessFailedCount = 0
                  }
            );
            base.OnModelCreating(builder);
        }
    }
}