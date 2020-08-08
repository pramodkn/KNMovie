using Microsoft.EntityFrameworkCore.Migrations;

namespace KNMovie.Migrations
{
    public partial class Init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01B168FE-810B-432D-9010-233BA0B380E9",
                column: "ConcurrencyStamp",
                value: "90e7c56e-9010-4cc7-a0b9-d8621c7a6365");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2301D884-221A-4E7D-B509-0113DCC043E1",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d5a157da-fb1e-400a-819d-b9a98e22421e", "ADMIN", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "fa49b128-9fe6-45c4-bfc5-41cf85046e47", "admin@knmovie.com", "admin@knmovie.com", "AQAAAAEAACcQAAAAEDHqNHh5z3hUaCVKIkTn5jAWqjkyb5WhGMSfSC6TKaeqsFlAJoSCMjmnEpoA+T5a+A==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01B168FE-810B-432D-9010-233BA0B380E9",
                column: "ConcurrencyStamp",
                value: "1b693756-1ebc-46a3-bb05-bd4e2466dff6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2301D884-221A-4E7D-B509-0113DCC043E1",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "542dd22b-363f-47d2-9d4e-7c311e003934", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "1f1e9a7a-8682-4105-8a24-8f4c47a74256", "admin@admin.com", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEKml7/uupamSfHdDpJ0+21/ToeZuIu3nXBIl+GReGp/DrKcwgB3Yy8sQAx4cfwwmtA==" });
        }
    }
}
