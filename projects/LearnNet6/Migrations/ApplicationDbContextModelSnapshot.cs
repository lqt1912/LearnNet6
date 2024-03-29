﻿// <auto-generated />
using System;
using LearnNet6.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LearnNet6.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LearnNet6.Data.Entity.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longtitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("LearnNet6.Data.Entity.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("bbf2206c-2017-4134-80fa-8d49f34e0dd9"),
                            ConcurrencyStamp = "6ea93b61-3e3f-4405-81b8-f8c0053ef152",
                            Name = "Owner",
                            NormalizedName = "OWNER"
                        },
                        new
                        {
                            Id = new Guid("2ee0f194-60f0-429a-92f3-2a00805ccdba"),
                            ConcurrencyStamp = "1f872e26-a4fa-4a47-bd7c-03100f5d3c4e",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = new Guid("d6eaadb8-d77e-4917-9585-cf33b802364c"),
                            ConcurrencyStamp = "73fe6e58-7eff-47c1-951b-8ecb71baca9c",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = new Guid("06e1f5f2-6f2b-46cd-8dcd-63ca80909dd6"),
                            ConcurrencyStamp = "37835ca6-8508-4fb9-8ca4-38118c8f4c9e",
                            Name = "Editor",
                            NormalizedName = "EDITOR"
                        },
                        new
                        {
                            Id = new Guid("ffb77d67-f3dc-4629-8a64-a6522bae279f"),
                            ConcurrencyStamp = "3789dee5-99cb-4361-9902-47089ec065f4",
                            Name = "Buyer",
                            NormalizedName = "BUYER"
                        },
                        new
                        {
                            Id = new Guid("acfbe5a2-7255-474d-8962-a365445a672d"),
                            ConcurrencyStamp = "b0af2772-deef-43c3-bf48-6aca01758988",
                            Name = "Business",
                            NormalizedName = "BUSINESS"
                        },
                        new
                        {
                            Id = new Guid("f65de9a5-d79b-4615-87a7-6df3960e10d7"),
                            ConcurrencyStamp = "a0f80dbc-911e-4fe6-b9a5-46baebfa3225",
                            Name = "Seller",
                            NormalizedName = "SELLER"
                        },
                        new
                        {
                            Id = new Guid("108385cc-defa-43d7-abd2-abde6623a8a6"),
                            ConcurrencyStamp = "9142d035-8088-40d0-b8fa-7759a7f5bf1c",
                            Name = "Subscriber",
                            NormalizedName = "SUBSCRIBER"
                        });
                });

            modelBuilder.Entity("LearnNet6.Data.Entity.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<Guid?>("AddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("d44efed3-db3d-4501-be29-36b88a202323"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "793a4503-f76b-403e-b028-3c3840bdaa2a",
                            Email = "thanglequoc1912@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Lê Quốc",
                            LastName = "Thắng",
                            LockoutEnabled = true,
                            NormalizedEmail = "thanglequoc1912@gmail.com",
                            NormalizedUserName = "THANGLEQUOC1912@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAoqZuAyWwiKrsIjkHq7JSjmEEXMZHFcQ3wLHkjVMZ9xTXRwxIb7xehLGAN7xAQEcA==",
                            PhoneNumber = "091234836721",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "N2AZ7AT2TAQAB5IBSPE334HYSFJVDGV7",
                            TwoFactorEnabled = false,
                            UserName = "thanglequoc1912@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("5bf3eaed-705d-46ec-a880-3872ba87b3dd"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "aaaf5630-3dda-44d2-8bd8-1b39ca36d575",
                            Email = "duyendatthang@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Nguyễn Quốc",
                            LastName = "Trung",
                            LockoutEnabled = true,
                            NormalizedEmail = "DUYENDATTHANG@gmail.com",
                            NormalizedUserName = "DUYENDATTHANG@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAoqZuAyWwiKrsIjkHq7JSjmEEXMZHFcQ3wLHkjVMZ9xTXRwxIb7xehLGAN7xAQEcA==",
                            PhoneNumber = "093478329239",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "DNZOWEXXK7I25QGATY3UPNZPF4JGGPOD",
                            TwoFactorEnabled = false,
                            UserName = "duyendatthang@gmail.com"
                        });
                });

            modelBuilder.Entity("LearnNet6.Data.Entity.Card", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AssignedTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardAuthor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EstimateValue")
                        .HasColumnType("int");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            Id = new Guid("312259b5-d116-43f7-926e-59dd66539831"),
                            Order = 0,
                            Title = "Harmless Inside",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("68228b59-27f7-4ffb-a7c7-f26ba2d001d0"),
                            Order = 1,
                            Title = "Unacceptable Figure",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("ef89b3d9-7baf-462e-9894-b5b743c9765f"),
                            Order = 2,
                            Title = "Brisk Reality",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("d8ab4def-1902-44c0-8db2-17de04d7a4e6"),
                            Order = 3,
                            Title = "Overlooked Instruction",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("e27da045-1362-4914-8c06-f6e1e40d884d"),
                            Order = 4,
                            Title = "Red Bend",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("486e4f89-838c-4191-8730-825550a07378"),
                            Order = 1,
                            Title = "Stark Drama",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("5cb1f11c-de48-42a5-8ce4-66b183d1f7ae"),
                            Order = 2,
                            Title = "Droopy Reception",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("81b6f1b8-c59d-43cb-b59e-67119fe1ef87"),
                            Order = 3,
                            Title = "Firsthand Vehicle",
                            Type = 1
                        });
                });

            modelBuilder.Entity("LearnNet6.Data.Entity.NotificationToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("NotificationToken");
                });

            modelBuilder.Entity("LearnNet6.Data.Entity.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("LearnNet6.Data.Entity.RefreshToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpiredDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("RevokedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("LearnNet6.Models.AdUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("accountEnabled")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AccountEnabled");

                    b.Property<string>("ageGroup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AgeGroup");

                    b.Property<string>("alternateEmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AlternateEmailAddress");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("City");

                    b.Property<string>("companyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CompanyName");

                    b.Property<string>("consentProvidedForMinor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ConsentProvidedForMinor");

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Country");

                    b.Property<string>("createdDateTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CreatedDateTime");

                    b.Property<string>("creationType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CreationType");

                    b.Property<string>("department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Department");

                    b.Property<string>("directorySynced")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DirectorySynced");

                    b.Property<string>("displayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DisplayName");

                    b.Property<string>("givenName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("GivenName");

                    b.Property<string>("id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("OId");

                    b.Property<string>("identityIssuer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("IdentityIssuer");

                    b.Property<string>("invitationState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("InvitationState");

                    b.Property<string>("jobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("JobTitle");

                    b.Property<string>("legalAgeGroupClassification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LegalAgeGroupClassification");

                    b.Property<string>("mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Mail");

                    b.Property<string>("mobilePhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MobilePhone");

                    b.Property<string>("officeLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("OfficeLocation");

                    b.Property<string>("postalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PostalCode");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("State");

                    b.Property<string>("streetAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("StreetAddress");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Surname");

                    b.Property<string>("telephoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TelephoneNumber");

                    b.Property<string>("usageLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsageLocation");

                    b.Property<string>("userPrincipalName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UserPrincipalName");

                    b.Property<string>("userType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UserType");

                    b.HasKey("Id");

                    b.ToTable("AdUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("LearnNet6.Data.Entity.ApplicationUser", b =>
                {
                    b.HasOne("LearnNet6.Data.Entity.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("LearnNet6.Data.Entity.NotificationToken", b =>
                {
                    b.HasOne("LearnNet6.Models.AdUser", "User")
                        .WithMany("NotificationTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("LearnNet6.Data.Entity.Post", b =>
                {
                    b.HasOne("LearnNet6.Data.Entity.ApplicationUser", "Author")
                        .WithMany("Posts")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("LearnNet6.Data.Entity.RefreshToken", b =>
                {
                    b.HasOne("LearnNet6.Data.Entity.ApplicationUser", "User")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("LearnNet6.Data.Entity.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("LearnNet6.Data.Entity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("LearnNet6.Data.Entity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("LearnNet6.Data.Entity.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LearnNet6.Data.Entity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("LearnNet6.Data.Entity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LearnNet6.Data.Entity.ApplicationUser", b =>
                {
                    b.Navigation("Posts");

                    b.Navigation("RefreshTokens");
                });

            modelBuilder.Entity("LearnNet6.Models.AdUser", b =>
                {
                    b.Navigation("NotificationTokens");
                });
#pragma warning restore 612, 618
        }
    }
}
