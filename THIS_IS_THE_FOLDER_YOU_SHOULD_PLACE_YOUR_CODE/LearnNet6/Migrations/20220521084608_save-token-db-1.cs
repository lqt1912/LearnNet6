using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnNet6.Migrations
{
    public partial class savetokendb1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationToken_AdUsers_UserId",
                table: "NotificationToken",
                column: "UserId",
                principalTable: "AdUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
