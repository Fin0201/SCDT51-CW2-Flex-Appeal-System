using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITS_System.Migrations
{
    public partial class @class : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equpiments_Schedule_ClassScheduleId",
                table: "Equpiments");

            migrationBuilder.DropIndex(
                name: "IX_Equpiments_ClassScheduleId",
                table: "Equpiments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "551960b0-a037-4315-a2cd-c44248e59ca0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c396a4c-3a2e-48e9-8077-61796e208ebe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8b8ecb9-5a56-4c9a-ace4-0b5225fb6575");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2d75b1b0-f968-4487-add8-aa33ea1f4ede", "e9bdd798-7adf-4a73-ab48-955b5b6e169d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d75b1b0-f968-4487-add8-aa33ea1f4ede");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9bdd798-7adf-4a73-ab48-955b5b6e169d");

            migrationBuilder.DropColumn(
                name: "ClassScheduleId",
                table: "Equpiments");

            migrationBuilder.CreateTable(
                name: "EquipmentListEntry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EquipmentId = table.Column<int>(type: "INTEGER", nullable: false),
                    AddedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ClassScheduleId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentListEntry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquipmentListEntry_Equpiments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equpiments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentListEntry_Schedule_ClassScheduleId",
                        column: x => x.ClassScheduleId,
                        principalTable: "Schedule",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentListEntry_ClassScheduleId",
                table: "EquipmentListEntry",
                column: "ClassScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentListEntry_EquipmentId",
                table: "EquipmentListEntry",
                column: "EquipmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipmentListEntry");

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

            migrationBuilder.AddColumn<int>(
                name: "ClassScheduleId",
                table: "Equpiments",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2d75b1b0-f968-4487-add8-aa33ea1f4ede", "c74d4460-c3ed-4f24-a0ce-a9c9c548e09e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "551960b0-a037-4315-a2cd-c44248e59ca0", "a582059d-23f3-4844-be51-62b2eab0bad2", "Studio_Staff", "STUDIO_STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6c396a4c-3a2e-48e9-8077-61796e208ebe", "bfa7d29e-95b9-455b-a541-6bb356859cff", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f8b8ecb9-5a56-4c9a-ace4-0b5225fb6575", "6b1098e0-99bf-4e81-b841-ab1fe80d0afc", "Management_Team", "MANAGEMENT_TEAM" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e9bdd798-7adf-4a73-ab48-955b5b6e169d", 0, "adeff7e9-9696-470b-afc5-007ab5d75c2f", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEH8vyYGdnz/rhgXDVc7MrHztKQOVJqfmgRfDSgD3RzWzJzInyJ/3BWAeYAwi3iFKTA==", null, false, "d3d76c67-3991-4162-9a04-a96b7733d05a", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2d75b1b0-f968-4487-add8-aa33ea1f4ede", "e9bdd798-7adf-4a73-ab48-955b5b6e169d" });

            migrationBuilder.CreateIndex(
                name: "IX_Equpiments_ClassScheduleId",
                table: "Equpiments",
                column: "ClassScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equpiments_Schedule_ClassScheduleId",
                table: "Equpiments",
                column: "ClassScheduleId",
                principalTable: "Schedule",
                principalColumn: "Id");
        }
    }
}
