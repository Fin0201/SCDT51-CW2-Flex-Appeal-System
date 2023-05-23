using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITS_System.Migrations
{
    public partial class db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b0e3fd7-164b-4926-bb28-ef205e338f62");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41327ac8-72e8-4aef-a84f-97d7c9bd8ff3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0c4782a-16ef-4bf3-946e-b325ee5089e9");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "daecf86d-b1dd-4088-ae0c-f2c42990daf2", "bf47eebe-7b8b-472f-9d03-d5c59ca5dd4a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "daecf86d-b1dd-4088-ae0c-f2c42990daf2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf47eebe-7b8b-472f-9d03-d5c59ca5dd4a");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "3b0e3fd7-164b-4926-bb28-ef205e338f62", "57726acb-081e-453f-afce-75d13088e4b7", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "41327ac8-72e8-4aef-a84f-97d7c9bd8ff3", "48d0a0b0-6936-4d48-a48c-93dd3997a119", "Studio_Staff", "STUDIO_STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d0c4782a-16ef-4bf3-946e-b325ee5089e9", "37a45820-40c2-4b50-9265-147a64aa008a", "Management_Team", "MANAGEMENT_TEAM" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "daecf86d-b1dd-4088-ae0c-f2c42990daf2", "ae0b10d5-6e6f-402d-b705-aa80f08d5749", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bf47eebe-7b8b-472f-9d03-d5c59ca5dd4a", 0, "7bc22f35-f192-45cc-ba60-2c54aefaa1bf", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAELM+oYcCd/IdR22F8y77SHPq6EKjORLUKHads+ZcUFb3rWdYZaa+RsCZPstWDjb6PA==", null, false, "702c8a22-5d7b-4e50-8395-537cb429e29c", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "daecf86d-b1dd-4088-ae0c-f2c42990daf2", "bf47eebe-7b8b-472f-9d03-d5c59ca5dd4a" });
        }
    }
}
