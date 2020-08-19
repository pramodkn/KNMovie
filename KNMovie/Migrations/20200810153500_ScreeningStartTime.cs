using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KNMovie.Migrations
{
    public partial class ScreeningStartTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "Screening",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01B168FE-810B-432D-9010-233BA0B380E9",
                column: "ConcurrencyStamp",
                value: "5d30c925-7286-42fe-8441-ab5361c3d45e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2301D884-221A-4E7D-B509-0113DCC043E1",
                column: "ConcurrencyStamp",
                value: "69c6e13a-2395-4972-8966-81692f023b09");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f71ef7f9-187f-48ed-941b-b26a68cf1aad", "AQAAAAEAACcQAAAAEPV9qKxMcsa55WGU7mJWTNOetYuECcLsyGdGfA0yDwpkT10Dl/bqga2xWGstYDKnJw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "Screening");

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
    }
}
