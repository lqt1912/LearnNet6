using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnNet6.Migrations
{
    public partial class Addaduser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("174cc810-d36b-42be-af56-fed163552106"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("29d150fb-c571-465a-bb6e-3793ded06421"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4464cd67-2bff-4f90-85c6-9cdf076ac60f"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("60e50704-3ce0-4c69-896a-2904dc1f8aa1"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("72e8ad05-12f4-4112-bea3-be48a7c811de"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c5d06d85-0239-4547-bce2-94865eb831d5"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cbb98a27-3636-4517-95a2-ba6ab41c9791"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ebf8e452-e611-414e-851b-c3d93ff91d9f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4cde14c3-4e01-450b-b857-e1f610e6ad69"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ad1b040d-58fd-4b46-9619-88092ec2d5e3"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("11409098-1baf-4ba9-a4e3-09c74ee22d82"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("16b68534-6a02-4aff-9a70-e1c0d4ea9312"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("74f37c02-1c5e-41e7-b58e-161b67d5a118"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("75da8c6c-20f1-4bf1-9e29-9d3712c0ed99"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("8363d777-06da-41d5-afd0-4f9c33050d01"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("918ffc5f-059d-4e1c-99c1-aa3ff950bec2"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("d7fc4c95-2b55-4bfa-9cce-02f7e4a5c498"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("d901d349-589f-437a-bedd-745d16239902"));

            migrationBuilder.CreateTable(
                name: "AdUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserPrincipalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GivenName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountEnabled = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsageLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OfficeLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelephoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobilePhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlternateEmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgeGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConsentProvidedForMinor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LegalAgeGroupClassification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DirectorySynced = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvitationState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentityIssuer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDateTime = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdUsers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("4d26377e-6819-4865-a059-02444dba0dd1"), "909dd37a-f495-4245-b2b6-5f107affb6bb", "Administrator", "ADMINISTRATOR" },
                    { new Guid("82c1b501-9ca2-4eb7-aca1-6941b72bba83"), "b477c9f7-d09a-44b0-965f-b78579488776", "Seller", "SELLER" },
                    { new Guid("9df57068-8a07-450e-bfd9-8dfddb9975b3"), "e1940488-4af5-4f1e-bce9-919170359fd8", "Buyer", "BUYER" },
                    { new Guid("a1ba5c1b-e51d-4c9c-bfa2-5279e4f128c4"), "d58e211d-5b4b-4550-a5ef-0c10365bd716", "Editor", "EDITOR" },
                    { new Guid("c505cf7d-da59-464c-90d6-7e1742dc22e9"), "cd3699cd-b8a7-45e7-b2ae-ae7d3cc715f6", "Manager", "MANAGER" },
                    { new Guid("c8c679c7-23ba-42f7-881f-ef99b70c19a8"), "95c2947c-a3fc-4410-8ec6-6db7028ba470", "Owner", "OWNER" },
                    { new Guid("e880b585-2cef-4f49-98a2-2cece45f91b1"), "f7c709d8-3de8-49c3-bd59-de52a433812c", "Business", "BUSINESS" },
                    { new Guid("f94b9216-bf72-4d45-ae81-69d9a3afdb9b"), "1acf05fb-f545-402a-a69c-54af71e2c89b", "Subscriber", "SUBSCRIBER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("2669d33c-6002-4cc1-b293-496705de75a9"), 0, null, "793a4503-f76b-403e-b028-3c3840bdaa2a", "thanglequoc1912@gmail.com", true, "Lê Quốc", "Thắng", true, null, "thanglequoc1912@gmail.com", "THANGLEQUOC1912@GMAIL.COM", "AQAAAAEAACcQAAAAEAoqZuAyWwiKrsIjkHq7JSjmEEXMZHFcQ3wLHkjVMZ9xTXRwxIb7xehLGAN7xAQEcA==", "091234836721", true, "N2AZ7AT2TAQAB5IBSPE334HYSFJVDGV7", false, "thanglequoc1912@gmail.com" },
                    { new Guid("b0154a95-589c-4220-a675-4f48ad1e8750"), 0, null, "aaaf5630-3dda-44d2-8bd8-1b39ca36d575", "duyendatthang@gmail.com", true, "Nguyễn Quốc", "Trung", true, null, "DUYENDATTHANG@gmail.com", "DUYENDATTHANG@GMAIL.COM", "AQAAAAEAACcQAAAAEAoqZuAyWwiKrsIjkHq7JSjmEEXMZHFcQ3wLHkjVMZ9xTXRwxIb7xehLGAN7xAQEcA==", "093478329239", true, "DNZOWEXXK7I25QGATY3UPNZPF4JGGPOD", false, "duyendatthang@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "AssignedTo", "CardAuthor", "EstimateValue", "Order", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("1a9018a4-d013-47eb-ba2b-c3c2d4cc346d"), null, null, null, 3, "Overlooked Instruction", 0 },
                    { new Guid("5b2cfd21-15c8-4b9d-a375-a55b9a508bbc"), null, null, null, 1, "Unacceptable Figure", 0 },
                    { new Guid("821b22a1-ce71-479c-9429-f66a1963c506"), null, null, null, 1, "Stark Drama", 1 },
                    { new Guid("88bc4f3a-016e-4a5c-9672-bf4eba8d698b"), null, null, null, 0, "Harmless Inside", 0 },
                    { new Guid("a306a9a3-b54f-465d-b5de-0ce4518a67c2"), null, null, null, 2, "Droopy Reception", 1 },
                    { new Guid("b9af4e1c-5101-4715-a28e-6eb3befb06cb"), null, null, null, 4, "Red Bend", 0 },
                    { new Guid("db4744a9-d626-4755-9b48-982b82caccb4"), null, null, null, 2, "Brisk Reality", 0 },
                    { new Guid("ef07b326-39d3-47d4-8fce-990b53ea1f6c"), null, null, null, 3, "Firsthand Vehicle", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4d26377e-6819-4865-a059-02444dba0dd1"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("82c1b501-9ca2-4eb7-aca1-6941b72bba83"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9df57068-8a07-450e-bfd9-8dfddb9975b3"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a1ba5c1b-e51d-4c9c-bfa2-5279e4f128c4"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c505cf7d-da59-464c-90d6-7e1742dc22e9"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c8c679c7-23ba-42f7-881f-ef99b70c19a8"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e880b585-2cef-4f49-98a2-2cece45f91b1"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f94b9216-bf72-4d45-ae81-69d9a3afdb9b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2669d33c-6002-4cc1-b293-496705de75a9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0154a95-589c-4220-a675-4f48ad1e8750"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("1a9018a4-d013-47eb-ba2b-c3c2d4cc346d"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("5b2cfd21-15c8-4b9d-a375-a55b9a508bbc"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("821b22a1-ce71-479c-9429-f66a1963c506"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("88bc4f3a-016e-4a5c-9672-bf4eba8d698b"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("a306a9a3-b54f-465d-b5de-0ce4518a67c2"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("b9af4e1c-5101-4715-a28e-6eb3befb06cb"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("db4744a9-d626-4755-9b48-982b82caccb4"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("ef07b326-39d3-47d4-8fce-990b53ea1f6c"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("174cc810-d36b-42be-af56-fed163552106"), "d9533613-8000-4ed2-b042-52071739c415", "Subscriber", "SUBSCRIBER" },
                    { new Guid("29d150fb-c571-465a-bb6e-3793ded06421"), "f8236e94-25a6-473c-81f8-432149319967", "Owner", "OWNER" },
                    { new Guid("4464cd67-2bff-4f90-85c6-9cdf076ac60f"), "5cbd35a9-a6c6-4a8e-bc54-57e408571a4f", "Business", "BUSINESS" },
                    { new Guid("60e50704-3ce0-4c69-896a-2904dc1f8aa1"), "af71d4e7-8d50-47cc-b380-d59599945ee1", "Editor", "EDITOR" },
                    { new Guid("72e8ad05-12f4-4112-bea3-be48a7c811de"), "b07bf41f-6d81-4fd8-9109-03bf44d20a2b", "Buyer", "BUYER" },
                    { new Guid("c5d06d85-0239-4547-bce2-94865eb831d5"), "f425d1c1-685e-4d46-adad-58aae5cdec33", "Seller", "SELLER" },
                    { new Guid("cbb98a27-3636-4517-95a2-ba6ab41c9791"), "776b7b07-e222-49b6-9973-fe8f9f93ceae", "Administrator", "ADMINISTRATOR" },
                    { new Guid("ebf8e452-e611-414e-851b-c3d93ff91d9f"), "a0f1dced-e08e-45a8-880c-bcc4dc1b9009", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("4cde14c3-4e01-450b-b857-e1f610e6ad69"), 0, null, "793a4503-f76b-403e-b028-3c3840bdaa2a", "thanglequoc1912@gmail.com", true, "Lê Quốc", "Thắng", true, null, "thanglequoc1912@gmail.com", "THANGLEQUOC1912@GMAIL.COM", "AQAAAAEAACcQAAAAEAoqZuAyWwiKrsIjkHq7JSjmEEXMZHFcQ3wLHkjVMZ9xTXRwxIb7xehLGAN7xAQEcA==", "091234836721", true, "N2AZ7AT2TAQAB5IBSPE334HYSFJVDGV7", false, "thanglequoc1912@gmail.com" },
                    { new Guid("ad1b040d-58fd-4b46-9619-88092ec2d5e3"), 0, null, "aaaf5630-3dda-44d2-8bd8-1b39ca36d575", "duyendatthang@gmail.com", true, "Nguyễn Quốc", "Trung", true, null, "DUYENDATTHANG@gmail.com", "DUYENDATTHANG@GMAIL.COM", "AQAAAAEAACcQAAAAEAoqZuAyWwiKrsIjkHq7JSjmEEXMZHFcQ3wLHkjVMZ9xTXRwxIb7xehLGAN7xAQEcA==", "093478329239", true, "DNZOWEXXK7I25QGATY3UPNZPF4JGGPOD", false, "duyendatthang@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "AssignedTo", "CardAuthor", "EstimateValue", "Order", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("11409098-1baf-4ba9-a4e3-09c74ee22d82"), null, null, null, 1, "Stark Drama", 1 },
                    { new Guid("16b68534-6a02-4aff-9a70-e1c0d4ea9312"), null, null, null, 3, "Overlooked Instruction", 0 },
                    { new Guid("74f37c02-1c5e-41e7-b58e-161b67d5a118"), null, null, null, 2, "Droopy Reception", 1 },
                    { new Guid("75da8c6c-20f1-4bf1-9e29-9d3712c0ed99"), null, null, null, 0, "Harmless Inside", 0 },
                    { new Guid("8363d777-06da-41d5-afd0-4f9c33050d01"), null, null, null, 4, "Red Bend", 0 },
                    { new Guid("918ffc5f-059d-4e1c-99c1-aa3ff950bec2"), null, null, null, 1, "Unacceptable Figure", 0 },
                    { new Guid("d7fc4c95-2b55-4bfa-9cce-02f7e4a5c498"), null, null, null, 3, "Firsthand Vehicle", 1 },
                    { new Guid("d901d349-589f-437a-bedd-745d16239902"), null, null, null, 2, "Brisk Reality", 0 }
                });
        }
    }
}
