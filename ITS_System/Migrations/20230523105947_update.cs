using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITS_System.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c08dbcb-89a8-4071-ba18-04ffe6562fa9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ebf8b4c-2882-4b1a-a48c-19247c01ac43");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d8ac66f-1ae9-4b94-9d9b-56737697ec4f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c31a87fe-3071-49fd-be14-0d32d7150d11", "9b642167-3631-499c-b3fd-2b2619d72c04" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c31a87fe-3071-49fd-be14-0d32d7150d11");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b642167-3631-499c-b3fd-2b2619d72c04");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0c08dbcb-89a8-4071-ba18-04ffe6562fa9", "16cfbabf-0890-411c-b1ea-3d9e071ef536", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3ebf8b4c-2882-4b1a-a48c-19247c01ac43", "c339c66a-3c4d-4157-896e-7b825062b8c8", "Studio_Staff", "STUDIO_STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6d8ac66f-1ae9-4b94-9d9b-56737697ec4f", "46cda5d6-137b-496b-8274-d1b3b83f5bad", "Management_Team", "MANAGEMENT_TEAM" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c31a87fe-3071-49fd-be14-0d32d7150d11", "23880cf1-050a-4372-98a1-0f7add19deb5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9b642167-3631-499c-b3fd-2b2619d72c04", 0, "00401a40-4f72-4871-b3d0-8e448a3a08f2", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEJnNUkY7k/voPiBHdgrQZ9gq6lyPHB/AcbQLuSxxUlR40ez3s5gD/lbC+lCOGgrwDA==", null, false, "f9eafed7-53ed-4566-b5ef-71b46ae0a243", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c31a87fe-3071-49fd-be14-0d32d7150d11", "9b642167-3631-499c-b3fd-2b2619d72c04" });
        }
    }
}
