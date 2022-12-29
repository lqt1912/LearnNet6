using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnNet6.Migrations
{
    public partial class savetokendb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "NotificationToken",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotificationToken_AdUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AdUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1b106d8b-d41a-4e96-a586-639c900495d0"), "b13a7ec1-ca7d-4846-99d4-37e2af385067", "Manager", "MANAGER" },
                    { new Guid("23d26e98-92dc-43de-8466-e5c90f650b0a"), "0fcdc6fb-40ae-4a13-91de-dcf6f19f4621", "Owner", "OWNER" },
                    { new Guid("388d6108-914f-48f2-b586-77e07d2eaf8a"), "82f9a02c-c77a-45c5-aa41-92d393e65d3f", "Administrator", "ADMINISTRATOR" },
                    { new Guid("5a550f5a-e402-4625-b63a-170b53367780"), "b1ed69e0-4e53-4baa-9fcb-4a7c42af50eb", "Business", "BUSINESS" },
                    { new Guid("7a8cbc13-c59c-4be5-8a9e-96a0d49a11b0"), "5dfa45c8-b674-4367-9f34-82e8753b7205", "Buyer", "BUYER" },
                    { new Guid("a837c92a-7c73-4c31-896f-755de16ed956"), "c7b77bb8-7312-4d2f-ad39-ad69076bd21f", "Subscriber", "SUBSCRIBER" },
                    { new Guid("c3d5d06f-b883-4f68-9f40-99596838d447"), "bd2e3f1d-412b-46b1-8258-7494d0a578ba", "Seller", "SELLER" },
                    { new Guid("e8587682-39d3-4cd9-abcb-b4d5d6774b84"), "0ac2840a-09ca-4e89-a3b6-c9fc3df61950", "Editor", "EDITOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("3bcb1bf9-9ffb-4328-9c9b-d4a78b3821f0"), 0, null, "aaaf5630-3dda-44d2-8bd8-1b39ca36d575", "duyendatthang@gmail.com", true, "Nguyễn Quốc", "Trung", true, null, "DUYENDATTHANG@gmail.com", "DUYENDATTHANG@GMAIL.COM", "AQAAAAEAACcQAAAAEAoqZuAyWwiKrsIjkHq7JSjmEEXMZHFcQ3wLHkjVMZ9xTXRwxIb7xehLGAN7xAQEcA==", "093478329239", true, "DNZOWEXXK7I25QGATY3UPNZPF4JGGPOD", false, "duyendatthang@gmail.com" },
                    { new Guid("f0660915-a74c-474a-ad26-c1c190fe5fde"), 0, null, "793a4503-f76b-403e-b028-3c3840bdaa2a", "thanglequoc1912@gmail.com", true, "Lê Quốc", "Thắng", true, null, "thanglequoc1912@gmail.com", "THANGLEQUOC1912@GMAIL.COM", "AQAAAAEAACcQAAAAEAoqZuAyWwiKrsIjkHq7JSjmEEXMZHFcQ3wLHkjVMZ9xTXRwxIb7xehLGAN7xAQEcA==", "091234836721", true, "N2AZ7AT2TAQAB5IBSPE334HYSFJVDGV7", false, "thanglequoc1912@gmail.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_NotificationToken_UserId",
                table: "NotificationToken",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotificationToken");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1b106d8b-d41a-4e96-a586-639c900495d0"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("23d26e98-92dc-43de-8466-e5c90f650b0a"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("388d6108-914f-48f2-b586-77e07d2eaf8a"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5a550f5a-e402-4625-b63a-170b53367780"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7a8cbc13-c59c-4be5-8a9e-96a0d49a11b0"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a837c92a-7c73-4c31-896f-755de16ed956"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c3d5d06f-b883-4f68-9f40-99596838d447"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e8587682-39d3-4cd9-abcb-b4d5d6774b84"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3bcb1bf9-9ffb-4328-9c9b-d4a78b3821f0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f0660915-a74c-474a-ad26-c1c190fe5fde"));

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
    }
}
