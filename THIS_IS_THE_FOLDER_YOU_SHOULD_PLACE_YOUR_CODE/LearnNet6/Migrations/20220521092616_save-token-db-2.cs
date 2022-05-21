using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnNet6.Migrations
{
    public partial class savetokendb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotificationTokens_AdUsers_UserId",
                table: "NotificationTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NotificationTokens",
                table: "NotificationTokens");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1bf4440b-14a2-4816-9e5a-696043fcae9e"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("27864069-85a4-43d8-b54f-f168927ce629"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4b41574e-551a-431b-ae4d-225171b7747a"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("546a9d6f-6acc-4b60-94e7-32ed02725eab"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("64d2a6f7-3656-4899-9326-df3b175912d0"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7a13f57c-34f9-4f69-82f5-7e2383fb07bb"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ecbaf38e-6949-449c-a2ac-8d2235716893"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fd6717d7-6b2e-491e-9441-42ce5edf911b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("425ff1c2-c168-450e-bd77-0e32b2f009d1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f3a9b10b-c91f-4dbb-86eb-17114636dead"));

            migrationBuilder.RenameTable(
                name: "NotificationTokens",
                newName: "NotificationToken");

            migrationBuilder.RenameIndex(
                name: "IX_NotificationTokens_UserId",
                table: "NotificationToken",
                newName: "IX_NotificationToken_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NotificationToken",
                table: "NotificationToken",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("06e1f5f2-6f2b-46cd-8dcd-63ca80909dd6"), "37835ca6-8508-4fb9-8ca4-38118c8f4c9e", "Editor", "EDITOR" },
                    { new Guid("108385cc-defa-43d7-abd2-abde6623a8a6"), "9142d035-8088-40d0-b8fa-7759a7f5bf1c", "Subscriber", "SUBSCRIBER" },
                    { new Guid("2ee0f194-60f0-429a-92f3-2a00805ccdba"), "1f872e26-a4fa-4a47-bd7c-03100f5d3c4e", "Administrator", "ADMINISTRATOR" },
                    { new Guid("acfbe5a2-7255-474d-8962-a365445a672d"), "b0af2772-deef-43c3-bf48-6aca01758988", "Business", "BUSINESS" },
                    { new Guid("bbf2206c-2017-4134-80fa-8d49f34e0dd9"), "6ea93b61-3e3f-4405-81b8-f8c0053ef152", "Owner", "OWNER" },
                    { new Guid("d6eaadb8-d77e-4917-9585-cf33b802364c"), "73fe6e58-7eff-47c1-951b-8ecb71baca9c", "Manager", "MANAGER" },
                    { new Guid("f65de9a5-d79b-4615-87a7-6df3960e10d7"), "a0f80dbc-911e-4fe6-b9a5-46baebfa3225", "Seller", "SELLER" },
                    { new Guid("ffb77d67-f3dc-4629-8a64-a6522bae279f"), "3789dee5-99cb-4361-9902-47089ec065f4", "Buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("5bf3eaed-705d-46ec-a880-3872ba87b3dd"), 0, null, "aaaf5630-3dda-44d2-8bd8-1b39ca36d575", "duyendatthang@gmail.com", true, "Nguyễn Quốc", "Trung", true, null, "DUYENDATTHANG@gmail.com", "DUYENDATTHANG@GMAIL.COM", "AQAAAAEAACcQAAAAEAoqZuAyWwiKrsIjkHq7JSjmEEXMZHFcQ3wLHkjVMZ9xTXRwxIb7xehLGAN7xAQEcA==", "093478329239", true, "DNZOWEXXK7I25QGATY3UPNZPF4JGGPOD", false, "duyendatthang@gmail.com" },
                    { new Guid("d44efed3-db3d-4501-be29-36b88a202323"), 0, null, "793a4503-f76b-403e-b028-3c3840bdaa2a", "thanglequoc1912@gmail.com", true, "Lê Quốc", "Thắng", true, null, "thanglequoc1912@gmail.com", "THANGLEQUOC1912@GMAIL.COM", "AQAAAAEAACcQAAAAEAoqZuAyWwiKrsIjkHq7JSjmEEXMZHFcQ3wLHkjVMZ9xTXRwxIb7xehLGAN7xAQEcA==", "091234836721", true, "N2AZ7AT2TAQAB5IBSPE334HYSFJVDGV7", false, "thanglequoc1912@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "AssignedTo", "CardAuthor", "EstimateValue", "Order", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("312259b5-d116-43f7-926e-59dd66539831"), null, null, null, 0, "Harmless Inside", 0 },
                    { new Guid("486e4f89-838c-4191-8730-825550a07378"), null, null, null, 1, "Stark Drama", 1 },
                    { new Guid("5cb1f11c-de48-42a5-8ce4-66b183d1f7ae"), null, null, null, 2, "Droopy Reception", 1 },
                    { new Guid("68228b59-27f7-4ffb-a7c7-f26ba2d001d0"), null, null, null, 1, "Unacceptable Figure", 0 },
                    { new Guid("81b6f1b8-c59d-43cb-b59e-67119fe1ef87"), null, null, null, 3, "Firsthand Vehicle", 1 },
                    { new Guid("d8ab4def-1902-44c0-8db2-17de04d7a4e6"), null, null, null, 3, "Overlooked Instruction", 0 },
                    { new Guid("e27da045-1362-4914-8c06-f6e1e40d884d"), null, null, null, 4, "Red Bend", 0 },
                    { new Guid("ef89b3d9-7baf-462e-9894-b5b743c9765f"), null, null, null, 2, "Brisk Reality", 0 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationToken_AdUsers_UserId",
                table: "NotificationToken",
                column: "UserId",
                principalTable: "AdUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotificationToken_AdUsers_UserId",
                table: "NotificationToken");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NotificationToken",
                table: "NotificationToken");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("06e1f5f2-6f2b-46cd-8dcd-63ca80909dd6"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("108385cc-defa-43d7-abd2-abde6623a8a6"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2ee0f194-60f0-429a-92f3-2a00805ccdba"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("acfbe5a2-7255-474d-8962-a365445a672d"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bbf2206c-2017-4134-80fa-8d49f34e0dd9"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d6eaadb8-d77e-4917-9585-cf33b802364c"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f65de9a5-d79b-4615-87a7-6df3960e10d7"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ffb77d67-f3dc-4629-8a64-a6522bae279f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5bf3eaed-705d-46ec-a880-3872ba87b3dd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d44efed3-db3d-4501-be29-36b88a202323"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("312259b5-d116-43f7-926e-59dd66539831"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("486e4f89-838c-4191-8730-825550a07378"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("5cb1f11c-de48-42a5-8ce4-66b183d1f7ae"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("68228b59-27f7-4ffb-a7c7-f26ba2d001d0"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("81b6f1b8-c59d-43cb-b59e-67119fe1ef87"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("d8ab4def-1902-44c0-8db2-17de04d7a4e6"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("e27da045-1362-4914-8c06-f6e1e40d884d"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("ef89b3d9-7baf-462e-9894-b5b743c9765f"));

            migrationBuilder.RenameTable(
                name: "NotificationToken",
                newName: "NotificationTokens");

            migrationBuilder.RenameIndex(
                name: "IX_NotificationToken_UserId",
                table: "NotificationTokens",
                newName: "IX_NotificationTokens_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NotificationTokens",
                table: "NotificationTokens",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1bf4440b-14a2-4816-9e5a-696043fcae9e"), "4c97e326-4a48-4882-88d6-b6895288e7cc", "Owner", "OWNER" },
                    { new Guid("27864069-85a4-43d8-b54f-f168927ce629"), "6cbabcf8-aeb1-47fe-b1d2-40a800d8fcc0", "Seller", "SELLER" },
                    { new Guid("4b41574e-551a-431b-ae4d-225171b7747a"), "c5f0ab44-f1fc-4dfb-8850-f36f4ed6ecb5", "Administrator", "ADMINISTRATOR" },
                    { new Guid("546a9d6f-6acc-4b60-94e7-32ed02725eab"), "84a65571-4426-4ec8-aefa-83c8c96a4c87", "Subscriber", "SUBSCRIBER" },
                    { new Guid("64d2a6f7-3656-4899-9326-df3b175912d0"), "463af1f4-27fa-4e7f-9f65-173e9deb896d", "Business", "BUSINESS" },
                    { new Guid("7a13f57c-34f9-4f69-82f5-7e2383fb07bb"), "4fbb72f3-7b69-41a7-9a80-a7213c572716", "Manager", "MANAGER" },
                    { new Guid("ecbaf38e-6949-449c-a2ac-8d2235716893"), "68e44204-4688-4692-b706-9b37c1955eec", "Editor", "EDITOR" },
                    { new Guid("fd6717d7-6b2e-491e-9441-42ce5edf911b"), "def5915a-8875-498b-8be3-b4a589535eb2", "Buyer", "BUYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("425ff1c2-c168-450e-bd77-0e32b2f009d1"), 0, null, "793a4503-f76b-403e-b028-3c3840bdaa2a", "thanglequoc1912@gmail.com", true, "Lê Quốc", "Thắng", true, null, "thanglequoc1912@gmail.com", "THANGLEQUOC1912@GMAIL.COM", "AQAAAAEAACcQAAAAEAoqZuAyWwiKrsIjkHq7JSjmEEXMZHFcQ3wLHkjVMZ9xTXRwxIb7xehLGAN7xAQEcA==", "091234836721", true, "N2AZ7AT2TAQAB5IBSPE334HYSFJVDGV7", false, "thanglequoc1912@gmail.com" },
                    { new Guid("f3a9b10b-c91f-4dbb-86eb-17114636dead"), 0, null, "aaaf5630-3dda-44d2-8bd8-1b39ca36d575", "duyendatthang@gmail.com", true, "Nguyễn Quốc", "Trung", true, null, "DUYENDATTHANG@gmail.com", "DUYENDATTHANG@GMAIL.COM", "AQAAAAEAACcQAAAAEAoqZuAyWwiKrsIjkHq7JSjmEEXMZHFcQ3wLHkjVMZ9xTXRwxIb7xehLGAN7xAQEcA==", "093478329239", true, "DNZOWEXXK7I25QGATY3UPNZPF4JGGPOD", false, "duyendatthang@gmail.com" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationTokens_AdUsers_UserId",
                table: "NotificationTokens",
                column: "UserId",
                principalTable: "AdUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
