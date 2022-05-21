using LearnNet6.Data.Entity;
using LearnNet6.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LearnNet6.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {

        public DbSet<ApplicationUser> AspNetUsers { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<AdUser> AdUsers { get; set; }
        public DbSet<NotificationToken> NotificationToken { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            string[] roles = new string[] { "Owner", "Administrator", "Manager", "Editor", "Buyer", "Business", "Seller", "Subscriber" };

            var addedRoles = new List<ApplicationRole>();
            foreach (var role in roles)
            {
                var addRole = new ApplicationRole()
                {
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    Id = Guid.NewGuid(),
                    Name = role,
                    NormalizedName = role.ToUpper(),
                };
                addedRoles.Add(addRole);
                builder.Entity<ApplicationRole>().HasData(addRole);
            }


            var addedUsers = new List<ApplicationUser>();
            addedUsers.Add(new ApplicationUser()
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
            });
            addedUsers.Add(new ApplicationUser()
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
            });
            builder.Entity<ApplicationUser>().HasData(addedUsers);

            builder.Entity<Card>().HasData(
                new Card()
                {
                    Id = Guid.NewGuid(),
                    Order = 0,
                    Title = "Harmless Inside",
                    Type = CardType.From
                },
               new Card()
               {
                   Id = Guid.NewGuid(),
                   Order = 1,
                   Title = "Unacceptable Figure",
                   Type = CardType.From
               },
               new Card()
               {
                   Id = Guid.NewGuid(),
                   Order = 2,
                   Title = "Brisk Reality",
                   Type = CardType.From
               },
               new Card()
               {
                   Id = Guid.NewGuid(),
                   Order = 3,
                   Title = "Overlooked Instruction",
                   Type = CardType.From
               },
               new Card()
               {
                   Id = Guid.NewGuid(),
                   Order = 4,
                   Title = "Red Bend",
                   Type = CardType.From
               },
               new Card()
               {
                   Id = Guid.NewGuid(),
                   Order = 1,
                   Title = "Stark Drama",
                   Type = CardType.To
               },
               new Card()
               {
                   Id = Guid.NewGuid(),
                   Order = 2,
                   Title = "Droopy Reception",
                   Type = CardType.To
               },
               new Card()
               {
                   Id = Guid.NewGuid(),
                   Order = 3,
                   Title = "Firsthand Vehicle",
                   Type = CardType.To
               });
            base.OnModelCreating(builder);
        }
    }
}