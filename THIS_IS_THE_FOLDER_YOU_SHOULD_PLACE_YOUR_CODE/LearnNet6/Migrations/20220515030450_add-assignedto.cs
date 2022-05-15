using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnNet6.Migrations
{
    public partial class addassignedto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "AssignedTo",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "AssignedTo",
                table: "Cards");

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
    }
}
