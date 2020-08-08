using Microsoft.EntityFrameworkCore.Migrations;

namespace KNMovie.Migrations
{
    public partial class gerne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01B168FE-810B-432D-9010-233BA0B380E9",
                column: "ConcurrencyStamp",
                value: "3b0fddcb-2c49-4ba7-a99b-a28e484ebf97");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2301D884-221A-4E7D-B509-0113DCC043E1",
                column: "ConcurrencyStamp",
                value: "31e73000-1ae7-4d9f-b43e-77b66322452f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2c91211b-b752-464d-beda-5340e8bf57ac", "AQAAAAEAACcQAAAAEOeTExmVY6xqAzfilZ2nUJaPN5/HcL26lsY3Zn3AHpWyQaao8YTQh5lAZHK8LUQT0w==" });
        }
    }
}
