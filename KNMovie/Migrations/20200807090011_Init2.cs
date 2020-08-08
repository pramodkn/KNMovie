using Microsoft.EntityFrameworkCore.Migrations;

namespace KNMovie.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9bae8093-929f-4c8e-aaae-7f698fbd3e11", "9bae8093-929f-4c8e-aaae-7f698fbd3e11" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "9bae8093-929f-4c8e-aaae-7f698fbd3e11", "0f7c5eaf-0d32-4be7-8893-ccce66786924" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "9bae8093-929f-4c8e-aaae-7f698fbd3e11", "254c6361-d71c-4cac-9dcd-c840bffd9b10" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2301D884-221A-4E7D-B509-0113DCC043E1", "542dd22b-363f-47d2-9d4e-7c311e003934", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "01B168FE-810B-432D-9010-233BA0B380E9", "1b693756-1ebc-46a3-bb05-bd4e2466dff6", "User", "User" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "B22698B8-42A2-4115-9631-1C2D1E2AC5F7", 0, "1f1e9a7a-8682-4105-8a24-8f4c47a74256", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "Admin", "AQAAAAEAACcQAAAAEKml7/uupamSfHdDpJ0+21/ToeZuIu3nXBIl+GReGp/DrKcwgB3Yy8sQAx4cfwwmtA==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "B22698B8-42A2-4115-9631-1C2D1E2AC5F7", "2301D884-221A-4E7D-B509-0113DCC043E1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "01B168FE-810B-432D-9010-233BA0B380E9", "1b693756-1ebc-46a3-bb05-bd4e2466dff6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "B22698B8-42A2-4115-9631-1C2D1E2AC5F7", "2301D884-221A-4E7D-B509-0113DCC043E1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "2301D884-221A-4E7D-B509-0113DCC043E1", "542dd22b-363f-47d2-9d4e-7c311e003934" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "B22698B8-42A2-4115-9631-1C2D1E2AC5F7", "1f1e9a7a-8682-4105-8a24-8f4c47a74256" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9bae8093-929f-4c8e-aaae-7f698fbd3e11", "0f7c5eaf-0d32-4be7-8893-ccce66786924", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9bae8093-929f-4c8e-aaae-7f698fbd3e11", 0, "254c6361-d71c-4cac-9dcd-c840bffd9b10", "admin@x.com", true, false, null, "ADMIN@X.COM", "ADMIN@X.COM", "AQAAAAEAACcQAAAAEA+ZS9syUdhtmnDr5T/Zwh4EDEcZdoWTGMc1rUbJSw6kCsjCOkfw4QajZsJfOOiUZQ==", null, false, "", false, "admin@x.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "9bae8093-929f-4c8e-aaae-7f698fbd3e11", "9bae8093-929f-4c8e-aaae-7f698fbd3e11" });
        }
    }
}
