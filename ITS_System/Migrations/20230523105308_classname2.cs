using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITS_System.Migrations
{
    public partial class classname2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5af183c5-f41f-4c7a-aade-de966f1e5139");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80124d65-aa4b-43c6-8105-e6cb5cf37efa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2d419e0-9f40-44a9-9d73-7bf83369bae4");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1368ff63-b2e0-4a1d-8f5f-86c4b02e55ac", "540d76c7-b138-4bbc-994a-63b2a2f30a18" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1368ff63-b2e0-4a1d-8f5f-86c4b02e55ac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "540d76c7-b138-4bbc-994a-63b2a2f30a18");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Schedule",
                newName: "ClassName");

            migrationBuilder.AddColumn<string>(
                name: "ClassName",
                table: "Bookings",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ClassName",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "ClassName",
                table: "Schedule",
                newName: "Name");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1368ff63-b2e0-4a1d-8f5f-86c4b02e55ac", "afd853fe-c74c-4505-a64f-d06ecf7be935", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5af183c5-f41f-4c7a-aade-de966f1e5139", "7e5e302e-c51f-4a2c-b334-4bdbb0ed4371", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "80124d65-aa4b-43c6-8105-e6cb5cf37efa", "24f165c7-efc4-420f-8ad6-7b981825e7ce", "Management_Team", "MANAGEMENT_TEAM" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c2d419e0-9f40-44a9-9d73-7bf83369bae4", "4247383d-e6ce-4b85-b51c-b4ae3a28f8e1", "Studio_Staff", "STUDIO_STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "540d76c7-b138-4bbc-994a-63b2a2f30a18", 0, "2d824ff9-f54f-4979-9596-a34c2c5bcdc8", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEJ44RkkeGWwsz4kwKLEoOuLkV4RoeIlj3v8HLT8Di8KBuJ0O6zlz7du88aauR8CZUg==", null, false, "8030d8dc-2df9-4f0f-bba1-d06f2ba8d0a3", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1368ff63-b2e0-4a1d-8f5f-86c4b02e55ac", "540d76c7-b138-4bbc-994a-63b2a2f30a18" });
        }
    }
}
