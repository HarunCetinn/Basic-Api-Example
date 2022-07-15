using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api_Denemesi.Migrations
{
    public partial class SeedProductData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 7, 6, 23, 28, 4, 271, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 7, 8, 23, 28, 4, 272, DateTimeKind.Local).AddTicks(2961));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 7, 6, 23, 27, 45, 387, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 7, 8, 23, 27, 45, 399, DateTimeKind.Local).AddTicks(1449));
        }
    }
}
