using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store_Application.Persistence.Migrations
{
    public partial class initTagstbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemovedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tags_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 722, DateTimeKind.Local).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 722, DateTimeKind.Local).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 722, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 722, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 722, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 722, DateTimeKind.Local).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 722, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 722, DateTimeKind.Local).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 722, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 722, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 722, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 672, DateTimeKind.Local).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(9811));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 722, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 722, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 722, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 722, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 722, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 722, DateTimeKind.Local).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 722, DateTimeKind.Local).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 722, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 722, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7867));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 30,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 40,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 41,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 42,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 43,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 44,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 45,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 46,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 55,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 56,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 57,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 58,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 59,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 60,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 62,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 64,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 65,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 66,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 67,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 68,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 69,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 70,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 72,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 73,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 74,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 75,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 76,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 77,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 78,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 80,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 81,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 82,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 83,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 84,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 85,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 86,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 91,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 92,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 93,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 94,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 95,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 96,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 97,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 100,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 101,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 102,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 110,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 112,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 113,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 114,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 115,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 116,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 117,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 118,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 119,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 120,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 121,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 723, DateTimeKind.Local).AddTicks(8874), new DateTime(2021, 10, 11, 12, 38, 0, 723, DateTimeKind.Local).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(26), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(6) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(35), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(43), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(40) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(52), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(48) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(65), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(95), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(91) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(103), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(99) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(110), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(107) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(121), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(117) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(129), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(125) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(137), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(144), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(141) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(152), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(148) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(167), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(175), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(171) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(185), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(193), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(189) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(200), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(197) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(209), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(205) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(216), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(225), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(232), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(229) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(240), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(237) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(482), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(490), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(498), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(514), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(522), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(530), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(526) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(549), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(545) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(557), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(564), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(572), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(569) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(588), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(584) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(596), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(603), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(600) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(611), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(607) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(619), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(615) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(627), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(636), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(632) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(644), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(651), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(648) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(659), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(656) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(159), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(156) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(506), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(537), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(534) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(580), new DateTime(2021, 10, 11, 12, 38, 0, 724, DateTimeKind.Local).AddTicks(576) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 723, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 723, DateTimeKind.Local).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 723, DateTimeKind.Local).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 723, DateTimeKind.Local).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 723, DateTimeKind.Local).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 723, DateTimeKind.Local).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 723, DateTimeKind.Local).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 723, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 723, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 723, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 723, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 723, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 679, DateTimeKind.Local).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 679, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 679, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 679, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 695, DateTimeKind.Local).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 695, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 695, DateTimeKind.Local).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "3be50f56-d7f5-4151-8957-094db9391ddd", new DateTime(2021, 10, 11, 12, 38, 0, 679, DateTimeKind.Local).AddTicks(3034) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "36343b34-18ed-4e91-a745-5b96b9a9dc5b", new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "6f7c0fbc-dea3-44aa-a503-37d7c2f24ff7", new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "3cc76171-a635-41ed-8319-471b4878d2ce", new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "e63c0026-8a59-41b3-82c8-d8573be85471", new DateTime(2021, 10, 11, 12, 38, 0, 721, DateTimeKind.Local).AddTicks(5995) });

            migrationBuilder.CreateIndex(
                name: "IX_Tags_ProductId",
                table: "Tags",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tags");

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
        }
    }
}
