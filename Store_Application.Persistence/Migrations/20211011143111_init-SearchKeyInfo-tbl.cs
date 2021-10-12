using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store_Application.Persistence.Migrations
{
    public partial class initSearchKeyInfotbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SearchKeysInfo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SearchKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemovedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchKeysInfo", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 758, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 758, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 758, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 758, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 758, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 758, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 758, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 758, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 758, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 758, DateTimeKind.Local).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 758, DateTimeKind.Local).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 713, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 758, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 758, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 758, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 758, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 758, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 758, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 760, DateTimeKind.Local).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 30,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 40,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 41,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 42,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 43,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 44,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 45,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 46,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 55,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 56,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 57,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 58,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 59,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 60,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 62,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 64,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 65,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 66,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 67,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 68,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(558));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 69,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 70,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 72,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 73,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 74,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 75,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 76,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 77,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 78,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 80,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 81,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 82,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 83,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 84,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 85,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 86,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 91,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 92,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 93,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 94,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 95,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 96,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 97,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 100,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 101,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 102,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 110,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 112,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 113,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 114,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 115,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 116,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 117,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 118,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 119,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 120,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 121,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 761, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 760, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 760, DateTimeKind.Local).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 760, DateTimeKind.Local).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 760, DateTimeKind.Local).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 760, DateTimeKind.Local).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 760, DateTimeKind.Local).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 760, DateTimeKind.Local).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 760, DateTimeKind.Local).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 760, DateTimeKind.Local).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 760, DateTimeKind.Local).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 760, DateTimeKind.Local).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 760, DateTimeKind.Local).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(4816), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6012), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6021), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6029), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6037), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6051), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6059), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6067), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6063) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6075), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6084), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6091), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6099), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6107), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6103) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6115), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6111) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6131), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6127) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6138), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6135) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6148), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6144) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6156), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6152) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6163), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6160) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6172), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6168) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6180), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6176) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6188), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6185) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6196), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6192) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6204), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6212), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6208) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6219), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6216) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6227), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6223) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6243), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6251), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6259), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6255) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6276), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6272) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6284), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6291), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6288) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6299), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6315), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6311) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6322), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6319) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6330), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6326) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6338), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6334) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6346), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6342) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6492), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6485) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6500), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6497) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6508), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6505) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6516), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6512) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6524), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6123), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6119) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6235), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6231) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6267), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6263) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6307), new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 758, DateTimeKind.Local).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 723, DateTimeKind.Local).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 723, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 723, DateTimeKind.Local).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 723, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 732, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 732, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 732, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "ecc7dafe-d709-427b-9a7e-8415c0a4b961", new DateTime(2021, 10, 11, 18, 1, 9, 723, DateTimeKind.Local).AddTicks(2568) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "410f14ef-c451-474c-aee5-fe25279eb637", new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "50554136-508f-443c-aa85-4c0879db4806", new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "2d589dee-58a7-47c3-b9dc-39eb10f9652e", new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "86e139f5-903e-41c1-a77b-fec295299327", new DateTime(2021, 10, 11, 18, 1, 9, 757, DateTimeKind.Local).AddTicks(1723) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SearchKeysInfo");

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 629, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(2257));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 668, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 668, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 668, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 668, DateTimeKind.Local).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 668, DateTimeKind.Local).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 668, DateTimeKind.Local).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 667, DateTimeKind.Local).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 30,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 40,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 41,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 42,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 43,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 44,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 45,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 46,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 55,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 56,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 57,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 58,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 59,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 60,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 62,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 64,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 65,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 66,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 67,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 68,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 69,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 70,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 72,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 73,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 74,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 75,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 76,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 77,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 78,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 80,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 81,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 82,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 83,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7489));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 84,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 85,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 86,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 91,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 92,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 93,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 94,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 95,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 96,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 97,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 100,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 101,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 102,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 110,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 112,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 113,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 114,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 115,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 116,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 117,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 118,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 119,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 120,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 121,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3532));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 668, DateTimeKind.Local).AddTicks(8852), new DateTime(2021, 10, 11, 17, 20, 53, 668, DateTimeKind.Local).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 668, DateTimeKind.Local).AddTicks(9918), new DateTime(2021, 10, 11, 17, 20, 53, 668, DateTimeKind.Local).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 668, DateTimeKind.Local).AddTicks(9927), new DateTime(2021, 10, 11, 17, 20, 53, 668, DateTimeKind.Local).AddTicks(9923) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(23), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(31), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(28) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(44), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(40) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(52), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(48) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(60), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(68), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(64) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(77), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(85), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(92), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(89) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(100), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(97) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(108), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(104) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(123), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(131), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(127) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(140), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(137) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(148), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(156), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(164), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(172), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(168) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(179), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(176) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(187), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(183) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(195), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(191) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(202), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(199) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(210), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(206) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(218), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(233), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(241), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(249), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(245) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(266), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(274), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(270) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(281), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(278) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(289), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(285) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(304), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(312), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(308) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(320), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(328), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(336), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(332) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(343), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(351), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(359), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(366), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(363) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(374), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(116), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(112) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(225), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(257), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(296), new DateTime(2021, 10, 11, 17, 20, 53, 669, DateTimeKind.Local).AddTicks(293) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 668, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 668, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 668, DateTimeKind.Local).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 668, DateTimeKind.Local).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 668, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 668, DateTimeKind.Local).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 668, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 668, DateTimeKind.Local).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 668, DateTimeKind.Local).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 668, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 668, DateTimeKind.Local).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 668, DateTimeKind.Local).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 635, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 635, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 635, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 635, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 643, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 643, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 643, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 666, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 666, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 666, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 666, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 17, 20, 53, 666, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "890d5ac0-baa4-4a85-9a91-73091a12b981", new DateTime(2021, 10, 11, 17, 20, 53, 635, DateTimeKind.Local).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "9bfd1084-40e0-456b-a3d3-584a1e9d9a82", new DateTime(2021, 10, 11, 17, 20, 53, 666, DateTimeKind.Local).AddTicks(7359) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "57307549-dc67-41b4-b6d1-7518e44e524a", new DateTime(2021, 10, 11, 17, 20, 53, 666, DateTimeKind.Local).AddTicks(8491) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "77a79d84-06ae-47e4-9fcd-501fd42882b4", new DateTime(2021, 10, 11, 17, 20, 53, 666, DateTimeKind.Local).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "eeb7fae2-ff88-4cf0-9f95-4acacd35f9cf", new DateTime(2021, 10, 11, 17, 20, 53, 666, DateTimeKind.Local).AddTicks(8733) });
        }
    }
}
