using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store_Application.Persistence.Migrations
{
    public partial class initComparetbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Compares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrowserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemovedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compares_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Compares_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 496, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(1889));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 542, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 542, DateTimeKind.Local).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 542, DateTimeKind.Local).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 542, DateTimeKind.Local).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 542, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 542, DateTimeKind.Local).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 541, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 30,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 40,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 41,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 42,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 43,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 44,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 45,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 46,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 55,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 56,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 57,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 58,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 59,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 60,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 62,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 64,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 65,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 66,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 67,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 68,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 69,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 70,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 72,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 73,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 74,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 75,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 76,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 77,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 78,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 80,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 81,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 82,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 83,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 84,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 85,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 86,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 91,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 92,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 93,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 94,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 95,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 96,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 97,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 100,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 101,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 102,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 110,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 112,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 113,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 114,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 115,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 116,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 117,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 118,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 119,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 120,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 121,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(101), new DateTime(2021, 10, 4, 11, 26, 28, 542, DateTimeKind.Local).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1243), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1224) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1252), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1260), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1256) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1267), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1264) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1279), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1275) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1286), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1283) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1294), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1303), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1298) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1313), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1309) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1321), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1329), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1325) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1337), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1344), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1360), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1368), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1364) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1377), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1385), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1382) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1393), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1389) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1401), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1397) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1409), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1405) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1416), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1424), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1421) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1432), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1429) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1440), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1448), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1456), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1452) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1471), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1467) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1479), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1487), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1483) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1504), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1501) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1512), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1508) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1520), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1516) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1527), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1524) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1542), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1539) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1550), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1558), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1554) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1565), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1591), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1599), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1607), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1614), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1611) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1622), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1630), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1352), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1349) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1463), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1460) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1495), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1491) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1535), new DateTime(2021, 10, 4, 11, 26, 28, 543, DateTimeKind.Local).AddTicks(1531) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 542, DateTimeKind.Local).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 542, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 542, DateTimeKind.Local).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 542, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 542, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 542, DateTimeKind.Local).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 542, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 542, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 542, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 542, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 542, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 542, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 503, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 503, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 503, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 503, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 516, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 516, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 516, DateTimeKind.Local).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 540, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 540, DateTimeKind.Local).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 540, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 540, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 4, 11, 26, 28, 540, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "d206915a-09f7-4861-a7e0-c13fadf87846", new DateTime(2021, 10, 4, 11, 26, 28, 503, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "8581f476-8329-4bbb-b29f-57759af73328", new DateTime(2021, 10, 4, 11, 26, 28, 540, DateTimeKind.Local).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "7b7dd785-c66d-4a40-b0e9-e194aa288b6d", new DateTime(2021, 10, 4, 11, 26, 28, 540, DateTimeKind.Local).AddTicks(8041) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "87a56815-8043-453f-9329-8a8ee39984d2", new DateTime(2021, 10, 4, 11, 26, 28, 540, DateTimeKind.Local).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "9fc11800-81a7-42fb-882b-8dc0f092dbb5", new DateTime(2021, 10, 4, 11, 26, 28, 540, DateTimeKind.Local).AddTicks(8152) });

            migrationBuilder.CreateIndex(
                name: "IX_Compares_ProductId",
                table: "Compares",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Compares_UserId",
                table: "Compares",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compares");

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 980, DateTimeKind.Local).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 980, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 980, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 980, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 980, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 980, DateTimeKind.Local).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 980, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 980, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 980, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 980, DateTimeKind.Local).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 980, DateTimeKind.Local).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 942, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 980, DateTimeKind.Local).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 980, DateTimeKind.Local).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 980, DateTimeKind.Local).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 980, DateTimeKind.Local).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 980, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 980, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 980, DateTimeKind.Local).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 980, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 980, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 30,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 40,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 41,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 42,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 43,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 44,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 45,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 46,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 55,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 56,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 57,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 58,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 59,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 60,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 62,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 64,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 65,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 66,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 67,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 68,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 69,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 70,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 72,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 73,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 74,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 75,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 76,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 77,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 78,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 80,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 81,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 82,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 83,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 84,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 85,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 86,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 91,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 92,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 93,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 94,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 95,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 96,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 97,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 100,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 101,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 102,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 110,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 112,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 113,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 114,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 115,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 116,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 117,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 118,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 119,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 120,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 121,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(114));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 982, DateTimeKind.Local).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(5326), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(4802) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6401), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6382) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6410), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6406) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6507), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6501) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6516), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6512) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6528), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6524) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6535), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6532) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6543), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6551), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6560), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6557) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6568), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6564) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6575), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6572) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6583), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6579) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6591), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6587) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6606), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6602) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6614), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6623), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6631), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6627) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6639), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6635) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6646), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6657), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6665), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6661) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6672), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6669) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6680), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6676) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6687), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6684) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6695), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6691) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6703), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6699) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6718), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6714) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6725), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6722) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6733), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6729) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6750), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6747) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6758), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6754) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6766), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6773), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6789), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6796), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6804), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6811), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6819), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6827), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6835), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6843), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6851), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6858), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6598), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6595) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6710), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6741), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6738) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6781), new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 980, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 981, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 948, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 948, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 948, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 948, DateTimeKind.Local).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 956, DateTimeKind.Local).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 956, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 956, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "10b451a9-6bfd-46ff-9d75-39c7f792210e", new DateTime(2021, 10, 2, 20, 5, 53, 948, DateTimeKind.Local).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "4f6d6c8e-1d12-40f6-b2d6-339d6c63e535", new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "e8d6d83b-7513-40d9-ba3a-01c5d0cf168a", new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "c9231a2d-f865-4937-a718-27c383204f28", new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(4716) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "216a911a-0e41-45a7-9a6a-620f7d7e04de", new DateTime(2021, 10, 2, 20, 5, 53, 979, DateTimeKind.Local).AddTicks(4775) });
        }
    }
}
