using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITS_System.Migrations
{
    public partial class classname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ee1638c-7eb2-4556-b5d7-9e953886ada3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "960ac616-32cf-4e23-a520-5958e103e18f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce39bf73-8588-4bc5-8e3a-48f1ea4082db");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bf9eb88e-0e9c-4e31-a7eb-22d5eec9dc53", "9f76efc3-cf30-4082-bcbf-66a1f7418b70" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf9eb88e-0e9c-4e31-a7eb-22d5eec9dc53");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f76efc3-cf30-4082-bcbf-66a1f7418b70");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Schedule",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Schedule");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3ee1638c-7eb2-4556-b5d7-9e953886ada3", "aca0ad26-26b0-4a67-816b-de07a9d92d9c", "Studio_Staff", "STUDIO_STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "960ac616-32cf-4e23-a520-5958e103e18f", "2339fa53-b395-45ee-b9d4-71f7d307f525", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bf9eb88e-0e9c-4e31-a7eb-22d5eec9dc53", "254551d4-5458-4ce9-a4ff-2b58d09a6a09", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce39bf73-8588-4bc5-8e3a-48f1ea4082db", "8fa3b007-1cc9-4a18-a2c8-6754c7309666", "Management_Team", "MANAGEMENT_TEAM" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9f76efc3-cf30-4082-bcbf-66a1f7418b70", 0, "7a2d6052-aadc-4788-b2f9-646e569b63a4", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEFN9VWVsLYLC+55CDQVnDpIUFDw6EDSZpi+qlgX21gCGO+r6QDCr8Rs3zXQeuzZN/g==", null, false, "6ee7499c-1e33-48ff-9498-391dbe4604a3", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bf9eb88e-0e9c-4e31-a7eb-22d5eec9dc53", "9f76efc3-cf30-4082-bcbf-66a1f7418b70" });
        }
    }
}
