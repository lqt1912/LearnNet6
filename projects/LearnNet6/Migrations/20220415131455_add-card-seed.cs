using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnNet6.Migrations
{
    public partial class addcardseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("060da187-0521-4a10-b951-4891ce70c097"), "76e95fd3-55c1-4278-958d-88a68c3aee3e", "Owner", "OWNER" },
                    { new Guid("17737c34-68cb-444d-ab7d-6d52757b31e0"), "fa6879a6-f2e8-4735-9f5a-7f57f81d55a6", "Editor", "EDITOR" },
                    { new Guid("4aba22af-148c-49a8-8f99-0d08bff1d6bf"), "fba22c9c-fae8-4cd3-af50-25567463c79f", "Administrator", "ADMINISTRATOR" },
                    { new Guid("553ca4f0-9748-4b12-a3e0-1015a5e5077e"), "27e0b6d0-d6d4-4d2c-b162-dc8c4da43e01", "Business", "BUSINESS" },
                    { new Guid("9fbc8ff8-2850-44ea-b6b4-0754ee15792d"), "ff492e6c-6939-4f7d-8ab1-a7ee6ba9dc86", "Manager", "MANAGER" },
                    { new Guid("a6ea4b04-6e02-46c7-92a3-bb19d32e0b75"), "343dc8e7-70d4-4b85-bb86-22291fd6d8a4", "Buyer", "BUYER" },
                    { new Guid("ae07942a-ed73-482c-b70d-17d18c209af2"), "9acb12b5-7f02-4c01-8de5-2244d13ed409", "Seller", "SELLER" },
                    { new Guid("d068c2be-bc5c-4758-8b51-e6b03920503b"), "494ce117-8a06-4fa4-b685-510ede36f161", "Subscriber", "SUBSCRIBER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("21e3ccdf-5100-491b-8a71-0ebe7aac6925"), 0, null, "793a4503-f76b-403e-b028-3c3840bdaa2a", "thanglequoc1912@gmail.com", true, "Lê Quốc", "Thắng", true, null, "thanglequoc1912@gmail.com", "THANGLEQUOC1912@GMAIL.COM", "AQAAAAEAACcQAAAAEAoqZuAyWwiKrsIjkHq7JSjmEEXMZHFcQ3wLHkjVMZ9xTXRwxIb7xehLGAN7xAQEcA==", "091234836721", true, "N2AZ7AT2TAQAB5IBSPE334HYSFJVDGV7", false, "thanglequoc1912@gmail.com" },
                    { new Guid("2533c2f6-936a-4d34-ae62-60937ae0ce18"), 0, null, "aaaf5630-3dda-44d2-8bd8-1b39ca36d575", "duyendatthang@gmail.com", true, "Nguyễn Quốc", "Trung", true, null, "DUYENDATTHANG@gmail.com", "DUYENDATTHANG@GMAIL.COM", "AQAAAAEAACcQAAAAEAoqZuAyWwiKrsIjkHq7JSjmEEXMZHFcQ3wLHkjVMZ9xTXRwxIb7xehLGAN7xAQEcA==", "093478329239", true, "DNZOWEXXK7I25QGATY3UPNZPF4JGGPOD", false, "duyendatthang@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Order", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("0bca066c-d1ad-4be9-94f8-c9ab15a81d2c"), 1, "Stark Drama", 1 },
                    { new Guid("25a2f55e-ab80-412b-a0d8-26b261604ec0"), 3, "Overlooked Instruction", 0 },
                    { new Guid("4e4f639f-60b4-4d45-a639-33b4fbd59632"), 2, "Brisk Reality", 0 },
                    { new Guid("4f5c2d94-2ae4-42b2-a56b-fe2f6074778e"), 0, "Harmless Inside", 0 },
                    { new Guid("77c782ad-538e-4653-a7be-5dc4bd43147f"), 3, "Firsthand Vehicle", 1 },
                    { new Guid("88cd016a-7b5e-4d07-98bf-0c850d6f5ce4"), 4, "Red Bend", 0 },
                    { new Guid("a7fe19bd-623b-45cf-bc40-9b41e9b3d650"), 2, "Droopy Reception", 1 },
                    { new Guid("fa1af238-1ec0-4c8d-afa7-52669ae16244"), 1, "Unacceptable Figure", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("060da187-0521-4a10-b951-4891ce70c097"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("17737c34-68cb-444d-ab7d-6d52757b31e0"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4aba22af-148c-49a8-8f99-0d08bff1d6bf"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("553ca4f0-9748-4b12-a3e0-1015a5e5077e"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9fbc8ff8-2850-44ea-b6b4-0754ee15792d"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a6ea4b04-6e02-46c7-92a3-bb19d32e0b75"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ae07942a-ed73-482c-b70d-17d18c209af2"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d068c2be-bc5c-4758-8b51-e6b03920503b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("21e3ccdf-5100-491b-8a71-0ebe7aac6925"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2533c2f6-936a-4d34-ae62-60937ae0ce18"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("0bca066c-d1ad-4be9-94f8-c9ab15a81d2c"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("25a2f55e-ab80-412b-a0d8-26b261604ec0"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("4e4f639f-60b4-4d45-a639-33b4fbd59632"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("4f5c2d94-2ae4-42b2-a56b-fe2f6074778e"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("77c782ad-538e-4653-a7be-5dc4bd43147f"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("88cd016a-7b5e-4d07-98bf-0c850d6f5ce4"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("a7fe19bd-623b-45cf-bc40-9b41e9b3d650"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("fa1af238-1ec0-4c8d-afa7-52669ae16244"));

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
    }
}
