using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITS_System.Migrations
{
    public partial class custbook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ed803ea-cd84-426a-8a76-81166d24c1a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbafa553-c68d-46e2-9b19-61e635729a7f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f744f031-b579-42dd-8a31-a3bb222c9812");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "84bece75-bc86-4ed4-b059-f01e87f679f9", "b8a14e33-3c2e-41bf-9ec0-5b904a25fe20" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84bece75-bc86-4ed4-b059-f01e87f679f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8a14e33-3c2e-41bf-9ec0-5b904a25fe20");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "84bece75-bc86-4ed4-b059-f01e87f679f9", "26875270-5c58-4c0d-ae56-784907724ff6", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9ed803ea-cd84-426a-8a76-81166d24c1a4", "2ac70aad-41f6-44a3-a5e6-d5a50c9d0574", "Studio_Staff", "STUDIO_STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cbafa553-c68d-46e2-9b19-61e635729a7f", "f04c50c5-31ad-4f00-adfb-264ba1666858", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f744f031-b579-42dd-8a31-a3bb222c9812", "8d95706b-8eb8-4ac4-a057-86f80bc333ad", "Management_Team", "MANAGEMENT_TEAM" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b8a14e33-3c2e-41bf-9ec0-5b904a25fe20", 0, "a96b3922-c45b-4fee-9407-f795d783f975", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEOQ8B4m0XFJmuy7/R6jFZ568A+U1fDdPb6OJmgpcbpsC4mmkLCgIIjjsLJMxpKfD1Q==", null, false, "9b6b2345-a749-44c7-a89e-6630314733fa", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "84bece75-bc86-4ed4-b059-f01e87f679f9", "b8a14e33-3c2e-41bf-9ec0-5b904a25fe20" });
        }
    }
}
