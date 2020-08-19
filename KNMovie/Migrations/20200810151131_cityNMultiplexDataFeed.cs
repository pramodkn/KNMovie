using Microsoft.EntityFrameworkCore.Migrations;

namespace KNMovie.Migrations
{
    public partial class cityNMultiplexDataFeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01B168FE-810B-432D-9010-233BA0B380E9",
                column: "ConcurrencyStamp",
                value: "8e6cb3cc-d629-4cb7-aa78-fb215ab4c12e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2301D884-221A-4E7D-B509-0113DCC043E1",
                column: "ConcurrencyStamp",
                value: "7eab0602-45c9-4b30-98b5-fcf1aaa94a89");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1856cdf3-82e1-4887-b1d1-14ace50bbcad", "AQAAAAEAACcQAAAAENM2U2kvYEWIeMiwsLsknazxZUyCu2qcKhN9cH6mgY6HbUU1Hxj5p0a/+wUVXtjkrg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01B168FE-810B-432D-9010-233BA0B380E9",
                column: "ConcurrencyStamp",
                value: "00a942df-b228-4732-8874-118f8f153557");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2301D884-221A-4E7D-B509-0113DCC043E1",
                column: "ConcurrencyStamp",
                value: "e83802c8-8ca0-41cc-beb4-c2fb236a8f7e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0ceca427-e711-409a-a0ec-8d7e3157f950", "AQAAAAEAACcQAAAAENwNUZhPJPsId1g+/zD9S5ZeDsBB3+UWfCqoO37nlsoXBqxRGHQqUDJOfEMmShyajg==" });
        }
    }
}
