using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store_Application.Persistence.Migrations
{
    public partial class update_product_tbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMainImage",
                table: "ProductImages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "تصویر برند", "InsertTime", "RemovedTime", "نام برند", "UpdateTime", "isRemoved" },
                values: new object[] { 1, null, new DateTime(2021, 6, 30, 13, 35, 46, 440, DateTimeKind.Local).AddTicks(8745), null, "بدون برند", null, false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "IsMainImage",
                table: "ProductImages");
        }
    }
}
