using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITS_System.Migrations
{
    public partial class redb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "851553e7-e510-4c78-a54b-be0ab0bb91e1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2e58fd4-d280-43e3-87dc-e63b12d13c5f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de69fb7c-3c3c-4c08-90f3-71e5246df6a8");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f23e392b-87c1-47a9-abe8-ec244e539fb9", "fb5f7f18-d67d-4c39-9eac-34175a78ebd9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f23e392b-87c1-47a9-abe8-ec244e539fb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fb5f7f18-d67d-4c39-9eac-34175a78ebd9");

            migrationBuilder.DropColumn(
                name: "ClassName",
                table: "Bookings");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0acbcaf0-709d-4336-8a7d-54287337533a", "441ac009-a80f-4118-91ad-31edebac565b", "Management_Team", "MANAGEMENT_TEAM" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1d8091dc-a699-4f4a-89d7-d20fa5b7ca8c", "64596a6f-021b-4681-9e95-232d4ababe54", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f7c5f173-446a-4a1b-85d5-45d69311c163", "49898aae-0245-4359-bbdd-23051a62bfd1", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fe514737-a768-4c83-8130-4e9a9757a971", "62a26ebc-2d01-4771-82be-d251298e7c0c", "Studio_Staff", "STUDIO_STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "48d19f71-800f-446c-8032-e8ad3f71ff70", 0, "e49b340e-7fa2-4ba5-aba3-5bed3fd5884a", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEJNeHEbwbaake1AIUAghqo+g3HFl0vkJLpbIhWBpUQKaunfLEU+OOF8UJS0pGkUXqw==", null, false, "fd210a23-8719-48fd-b050-f4fb626b73b3", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1d8091dc-a699-4f4a-89d7-d20fa5b7ca8c", "48d19f71-800f-446c-8032-e8ad3f71ff70" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0acbcaf0-709d-4336-8a7d-54287337533a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7c5f173-446a-4a1b-85d5-45d69311c163");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe514737-a768-4c83-8130-4e9a9757a971");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1d8091dc-a699-4f4a-89d7-d20fa5b7ca8c", "48d19f71-800f-446c-8032-e8ad3f71ff70" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d8091dc-a699-4f4a-89d7-d20fa5b7ca8c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48d19f71-800f-446c-8032-e8ad3f71ff70");

            migrationBuilder.AddColumn<string>(
                name: "ClassName",
                table: "Bookings",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "851553e7-e510-4c78-a54b-be0ab0bb91e1", "0fcf6022-28be-48cb-9f7d-038bbfd0087c", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c2e58fd4-d280-43e3-87dc-e63b12d13c5f", "7a0be6bb-b6a3-4c9b-abe4-9f393258682d", "Studio_Staff", "STUDIO_STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "de69fb7c-3c3c-4c08-90f3-71e5246df6a8", "cea22c0d-9c9c-48f8-bbdf-a77698cc147e", "Management_Team", "MANAGEMENT_TEAM" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f23e392b-87c1-47a9-abe8-ec244e539fb9", "cc84abe9-0a7f-4bf1-8fbb-0dfa2846cacf", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fb5f7f18-d67d-4c39-9eac-34175a78ebd9", 0, "46d35098-3a69-4e73-b4a7-4a0071c56287", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEHLOrwbujFpTuHdNu5H81XhaQJMx5CjFE8OlaLSBeL5y66xv/e6ifSZzinXTjhSVBw==", null, false, "9e0755ef-cc72-4861-84b5-cde0804f1b19", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f23e392b-87c1-47a9-abe8-ec244e539fb9", "fb5f7f18-d67d-4c39-9eac-34175a78ebd9" });
        }
    }
}
