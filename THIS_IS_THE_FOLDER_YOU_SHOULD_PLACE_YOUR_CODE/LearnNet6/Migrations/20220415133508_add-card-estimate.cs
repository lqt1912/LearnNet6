using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnNet6.Migrations
{
    public partial class addcardestimate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "CardAuthor",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EstimateValue",
                table: "Cards",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("0c3662fa-fd25-47db-afb9-e7c74538d6e2"), "f2136d05-d92c-4f9d-a5fb-7939b4e74a74", "Subscriber", "SUBSCRIBER" },
                    { new Guid("292eea4b-5b56-4e41-b4f1-f2137434c178"), "6fc0bb57-ab64-49d4-97a8-b290a64081d4", "Business", "BUSINESS" },
                    { new Guid("4402a846-9c23-4a1c-ac78-26bee34960a3"), "6a13d767-aebd-4788-8d9c-8c70e3955788", "Manager", "MANAGER" },
                    { new Guid("7f2d9677-5037-4efb-9034-aecc99f94b4a"), "3c5b0c66-9188-469e-9cbf-5608195e37db", "Buyer", "BUYER" },
                    { new Guid("acb0a04e-7e80-4cf8-94f6-e2a2062e0005"), "62cc4789-dfb4-4c5a-a2a0-9b86c1a42cca", "Seller", "SELLER" },
                    { new Guid("b6495817-15fc-43f4-9eb3-e605a5bcce07"), "a99136be-d999-42f9-a220-37e141fdd7b0", "Editor", "EDITOR" },
                    { new Guid("f0db8435-acfc-4aa1-9af8-bde05b629a5d"), "e00ace02-8fa4-4d4c-9097-7917abc138d7", "Administrator", "ADMINISTRATOR" },
                    { new Guid("fe584981-bea3-4547-8c54-dc65ba4eb224"), "dc4605e8-0efd-4c23-892b-ca14762ea1d9", "Owner", "OWNER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("d09dbedc-8926-4c04-bc3c-f956f50cebf7"), 0, null, "793a4503-f76b-403e-b028-3c3840bdaa2a", "thanglequoc1912@gmail.com", true, "Lê Quốc", "Thắng", true, null, "thanglequoc1912@gmail.com", "THANGLEQUOC1912@GMAIL.COM", "AQAAAAEAACcQAAAAEAoqZuAyWwiKrsIjkHq7JSjmEEXMZHFcQ3wLHkjVMZ9xTXRwxIb7xehLGAN7xAQEcA==", "091234836721", true, "N2AZ7AT2TAQAB5IBSPE334HYSFJVDGV7", false, "thanglequoc1912@gmail.com" },
                    { new Guid("dd966458-d289-40ca-be0c-46f748d71197"), 0, null, "aaaf5630-3dda-44d2-8bd8-1b39ca36d575", "duyendatthang@gmail.com", true, "Nguyễn Quốc", "Trung", true, null, "DUYENDATTHANG@gmail.com", "DUYENDATTHANG@GMAIL.COM", "AQAAAAEAACcQAAAAEAoqZuAyWwiKrsIjkHq7JSjmEEXMZHFcQ3wLHkjVMZ9xTXRwxIb7xehLGAN7xAQEcA==", "093478329239", true, "DNZOWEXXK7I25QGATY3UPNZPF4JGGPOD", false, "duyendatthang@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardAuthor", "EstimateValue", "Order", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("0cd80f72-85c3-44c1-989d-926cc4b339a1"), null, null, 0, "Harmless Inside", 0 },
                    { new Guid("7e47ae4c-a056-4494-8a0b-43f2c4e28d6a"), null, null, 1, "Unacceptable Figure", 0 },
                    { new Guid("abcb18b6-4b03-4a2a-b368-64bb65ffa523"), null, null, 4, "Red Bend", 0 },
                    { new Guid("bd092cfd-d5eb-4d15-83c3-388fa55de74e"), null, null, 1, "Stark Drama", 1 },
                    { new Guid("bfa99ab3-50a5-4ef7-a483-d6189e69532f"), null, null, 2, "Droopy Reception", 1 },
                    { new Guid("c82ea2f1-5cab-4418-9937-241993259209"), null, null, 3, "Firsthand Vehicle", 1 },
                    { new Guid("e3de7d70-c439-4e3f-8695-860c54dfa05a"), null, null, 3, "Overlooked Instruction", 0 },
                    { new Guid("f524fdbc-cdb8-4c73-b20f-6a5ee6a1c876"), null, null, 2, "Brisk Reality", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0c3662fa-fd25-47db-afb9-e7c74538d6e2"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("292eea4b-5b56-4e41-b4f1-f2137434c178"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4402a846-9c23-4a1c-ac78-26bee34960a3"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7f2d9677-5037-4efb-9034-aecc99f94b4a"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("acb0a04e-7e80-4cf8-94f6-e2a2062e0005"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b6495817-15fc-43f4-9eb3-e605a5bcce07"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0db8435-acfc-4aa1-9af8-bde05b629a5d"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fe584981-bea3-4547-8c54-dc65ba4eb224"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d09dbedc-8926-4c04-bc3c-f956f50cebf7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dd966458-d289-40ca-be0c-46f748d71197"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("0cd80f72-85c3-44c1-989d-926cc4b339a1"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("7e47ae4c-a056-4494-8a0b-43f2c4e28d6a"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("abcb18b6-4b03-4a2a-b368-64bb65ffa523"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("bd092cfd-d5eb-4d15-83c3-388fa55de74e"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("bfa99ab3-50a5-4ef7-a483-d6189e69532f"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("c82ea2f1-5cab-4418-9937-241993259209"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("e3de7d70-c439-4e3f-8695-860c54dfa05a"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("f524fdbc-cdb8-4c73-b20f-6a5ee6a1c876"));

            migrationBuilder.DropColumn(
                name: "CardAuthor",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "EstimateValue",
                table: "Cards");

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
    }
}
