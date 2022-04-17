using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnNet6.Migrations
{
    public partial class addcard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("58261c78-5843-4bf3-b91d-0562f9948cd3"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5a9c1ffb-1d54-4bd5-8a8e-48982917252a"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("77345076-f217-493d-9ed0-c4c12be703d5"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9a32f434-2dc6-4ebb-8416-8f4f555ef7f3"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a04a791b-6ff1-4a3f-bc8c-bd386c401519"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a3593554-5bff-4029-939c-0d5cc6426e27"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bbb6cbff-26a2-403e-b36e-02c714e472ae"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ecce7ea5-338c-4de2-8065-70ddf026dce4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("003f8dfe-bb10-4338-a873-f074d128eaab"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7302b1ee-72be-4b94-b3b0-dd160e14b627"));

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("02d07b33-d455-436d-98aa-a74a99a2e3b7"), "b9d13caa-b21a-4efe-a8de-9a729ec8c3e1", "Subscriber", "SUBSCRIBER" },
                    { new Guid("3bf7abde-b47f-49c2-8c8d-570898c4ea38"), "179624fe-5c29-4b90-a77f-620da3e765f9", "Buyer", "BUYER" },
                    { new Guid("42eed468-9a84-4553-adee-ad9982dc5bc8"), "dee13b99-1002-4d00-909b-d336c0387d66", "Manager", "MANAGER" },
                    { new Guid("4b2d6db1-8e45-437e-8540-739ecf1cc97f"), "cb272dfa-2322-4cfc-bf45-0a30bc4c59ad", "Seller", "SELLER" },
                    { new Guid("926110fa-aee7-4c5f-9439-38424a0d2b3f"), "bf3af882-68df-49f5-866e-401095ed84aa", "Business", "BUSINESS" },
                    { new Guid("ade00268-5fea-4438-9dd7-930840db6737"), "e759a4bd-a01c-485a-bc58-5a359ebbedd8", "Administrator", "ADMINISTRATOR" },
                    { new Guid("ae2a1896-1426-4228-b058-e2d05ab4e9c9"), "62e0c5cb-f22b-4590-bbae-47ac9ecee95b", "Owner", "OWNER" },
                    { new Guid("d21bde88-a8fe-47fe-8994-589b678aeeda"), "53bd245f-5e7f-4b3b-b734-58b84ed74557", "Editor", "EDITOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("8cf38777-a041-478c-8ced-e4b3369d1079"), 0, null, "aaaf5630-3dda-44d2-8bd8-1b39ca36d575", "duyendatthang@gmail.com", true, "Nguyễn Quốc", "Trung", true, null, "DUYENDATTHANG@gmail.com", "DUYENDATTHANG@GMAIL.COM", "AQAAAAEAACcQAAAAEAoqZuAyWwiKrsIjkHq7JSjmEEXMZHFcQ3wLHkjVMZ9xTXRwxIb7xehLGAN7xAQEcA==", "093478329239", true, "DNZOWEXXK7I25QGATY3UPNZPF4JGGPOD", false, "duyendatthang@gmail.com" },
                    { new Guid("b431662c-aa0a-4aaa-8407-7e646e9c088f"), 0, null, "793a4503-f76b-403e-b028-3c3840bdaa2a", "thanglequoc1912@gmail.com", true, "Lê Quốc", "Thắng", true, null, "thanglequoc1912@gmail.com", "THANGLEQUOC1912@GMAIL.COM", "AQAAAAEAACcQAAAAEAoqZuAyWwiKrsIjkHq7JSjmEEXMZHFcQ3wLHkjVMZ9xTXRwxIb7xehLGAN7xAQEcA==", "091234836721", true, "N2AZ7AT2TAQAB5IBSPE334HYSFJVDGV7", false, "thanglequoc1912@gmail.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("02d07b33-d455-436d-98aa-a74a99a2e3b7"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3bf7abde-b47f-49c2-8c8d-570898c4ea38"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("42eed468-9a84-4553-adee-ad9982dc5bc8"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4b2d6db1-8e45-437e-8540-739ecf1cc97f"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("926110fa-aee7-4c5f-9439-38424a0d2b3f"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ade00268-5fea-4438-9dd7-930840db6737"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ae2a1896-1426-4228-b058-e2d05ab4e9c9"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d21bde88-a8fe-47fe-8994-589b678aeeda"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8cf38777-a041-478c-8ced-e4b3369d1079"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b431662c-aa0a-4aaa-8407-7e646e9c088f"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("58261c78-5843-4bf3-b91d-0562f9948cd3"), "e247da6b-f674-4573-89f4-b2e18fc43694", "Administrator", "ADMINISTRATOR" },
                    { new Guid("5a9c1ffb-1d54-4bd5-8a8e-48982917252a"), "9765cf31-ffd0-4468-bec0-cdac97925aa1", "Buyer", "BUYER" },
                    { new Guid("77345076-f217-493d-9ed0-c4c12be703d5"), "d1590591-fbe9-4344-a2f6-2bdbe3d6d08b", "Business", "BUSINESS" },
                    { new Guid("9a32f434-2dc6-4ebb-8416-8f4f555ef7f3"), "057d2073-2b99-4b41-9781-f213e807d8f3", "Editor", "EDITOR" },
                    { new Guid("a04a791b-6ff1-4a3f-bc8c-bd386c401519"), "84ba44a3-4ff2-4e83-a714-def41a4d129d", "Owner", "OWNER" },
                    { new Guid("a3593554-5bff-4029-939c-0d5cc6426e27"), "d683f064-0a43-41a0-bf93-dbfe0029f493", "Manager", "MANAGER" },
                    { new Guid("bbb6cbff-26a2-403e-b36e-02c714e472ae"), "bd05d173-3a0f-4342-aed0-2a794a6867cf", "Seller", "SELLER" },
                    { new Guid("ecce7ea5-338c-4de2-8065-70ddf026dce4"), "03cf2055-ca0c-494f-846d-d9fdc2cc3ee3", "Subscriber", "SUBSCRIBER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("003f8dfe-bb10-4338-a873-f074d128eaab"), 0, null, "793a4503-f76b-403e-b028-3c3840bdaa2a", "thanglequoc1912@gmail.com", true, "Lê Quốc", "Thắng", true, null, "thanglequoc1912@gmail.com", "THANGLEQUOC1912@GMAIL.COM", "AQAAAAEAACcQAAAAEAoqZuAyWwiKrsIjkHq7JSjmEEXMZHFcQ3wLHkjVMZ9xTXRwxIb7xehLGAN7xAQEcA==", "091234836721", true, "N2AZ7AT2TAQAB5IBSPE334HYSFJVDGV7", false, "thanglequoc1912@gmail.com" },
                    { new Guid("7302b1ee-72be-4b94-b3b0-dd160e14b627"), 0, null, "aaaf5630-3dda-44d2-8bd8-1b39ca36d575", "duyendatthang@gmail.com", true, "Nguyễn Quốc", "Trung", true, null, "DUYENDATTHANG@gmail.com", "DUYENDATTHANG@GMAIL.COM", "AQAAAAEAACcQAAAAEAoqZuAyWwiKrsIjkHq7JSjmEEXMZHFcQ3wLHkjVMZ9xTXRwxIb7xehLGAN7xAQEcA==", "093478329239", true, "DNZOWEXXK7I25QGATY3UPNZPF4JGGPOD", false, "duyendatthang@gmail.com" }
                });
        }
    }
}
