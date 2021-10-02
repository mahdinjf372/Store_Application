using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store_Application.Persistence.Migrations
{
    public partial class initQuestiontbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminIsRead = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ConfirmedByAdmin = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ParentQuestionId = table.Column<int>(type: "int", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemovedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_Questions_ParentQuestionId",
                        column: x => x.ParentQuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 868, DateTimeKind.Local).AddTicks(1398));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 868, DateTimeKind.Local).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 868, DateTimeKind.Local).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 868, DateTimeKind.Local).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 868, DateTimeKind.Local).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 868, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 868, DateTimeKind.Local).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 868, DateTimeKind.Local).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 868, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 868, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 830, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 868, DateTimeKind.Local).AddTicks(3457));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 868, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 868, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 868, DateTimeKind.Local).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 868, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 868, DateTimeKind.Local).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(62));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(68));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(169));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 30,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 40,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 41,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(191));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 42,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(196));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 43,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 44,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 45,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 46,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 55,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 56,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 57,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 58,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 59,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 60,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 62,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 64,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 65,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(334));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 66,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(339));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 67,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 68,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 69,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 70,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 72,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 73,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 74,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 75,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 76,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 77,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 78,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 80,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 81,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 82,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 83,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 84,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 85,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 86,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 91,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 92,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 93,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 94,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 95,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 96,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 97,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 100,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 101,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 102,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 110,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 112,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 113,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 114,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 115,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 116,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 117,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 118,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 119,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 120,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 121,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 870, DateTimeKind.Local).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(1887), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(2949), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(2931) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(2959), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(2955) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(2968), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(2975), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(2987), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(2994), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3002), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3010), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3006) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3020), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3027), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3035), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3043), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3050), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3065), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3062) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3073), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3069) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3083), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3091), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3100), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3108), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3104) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3115), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3123), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3119) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3130), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3138), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3232), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3240), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3248), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3244) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3263), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3271), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3267) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3278), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3296), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3304), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3301) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3312), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3308) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3319), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3335), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3343), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3339) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3350), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3359), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3355) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3366), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3363) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3374), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3382), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3389), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3397), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3405), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3402) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3058), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3255), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3286), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3282) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3327), new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 868, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 868, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 868, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 868, DateTimeKind.Local).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 868, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 868, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 868, DateTimeKind.Local).AddTicks(9987));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 868, DateTimeKind.Local).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 868, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 869, DateTimeKind.Local).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 837, DateTimeKind.Local).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 837, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 837, DateTimeKind.Local).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 837, DateTimeKind.Local).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 844, DateTimeKind.Local).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 844, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 844, DateTimeKind.Local).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "15a835d1-a2bd-4a24-b134-b43af7516ce3", new DateTime(2021, 10, 1, 11, 18, 25, 837, DateTimeKind.Local).AddTicks(2352) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "3c36d01b-b3c6-43f3-b6b7-d5cf2385f233", new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(135) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "bf319de7-e87c-4bee-a77e-ab6dd269cf38", new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(1301) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "a540d9ab-cb16-4a2e-9db8-34819ab9e3ed", new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "203fdfd2-4e8d-49dc-928b-32fa67b7f8e4", new DateTime(2021, 10, 1, 11, 18, 25, 867, DateTimeKind.Local).AddTicks(1414) });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ParentQuestionId",
                table: "Questions",
                column: "ParentQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ProductId",
                table: "Questions",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_UserId",
                table: "Questions",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 439, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 473, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(1585));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 474, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 30,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 40,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 41,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 42,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 43,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 44,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 45,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 46,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 55,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 56,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 57,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 58,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 59,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 60,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 62,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 64,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 65,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 66,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 67,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 68,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 69,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 70,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 72,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 73,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 74,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 75,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 76,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 77,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 78,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 80,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 81,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 82,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 83,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 84,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 85,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 86,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 91,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 92,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 93,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 94,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 95,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 96,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 97,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 100,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 101,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 102,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 110,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 112,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 113,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 114,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 115,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 116,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 117,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 118,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 119,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 120,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 121,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2556));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2806));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2835));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2905));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 476, DateTimeKind.Local).AddTicks(2952));

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(8197), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(7677) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9259), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9268), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9278), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9273) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9286), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9297), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9306), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9302) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9314), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9323), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9333), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9329) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9341), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9337) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9349), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9358), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9354) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9366), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9362) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9382), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9379) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9391), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9400), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9409), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9417), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9425), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9459), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9432) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9468), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9464) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9477), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9473) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9485), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9493), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9489) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9501), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9498) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9510), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9526), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9523) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9535), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9543), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9539) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9562), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9570), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9579), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9587), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9604), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9612), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9621), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9617) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9630), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9638), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9647), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9656), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9664), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9672), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9680), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9374), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9518), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9552), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9548) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9595), new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 475, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 444, DateTimeKind.Local).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 444, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 444, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 444, DateTimeKind.Local).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 452, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 452, DateTimeKind.Local).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 452, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 473, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 473, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 473, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 473, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 9, 20, 14, 12, 47, 473, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "20fc4b4a-7cd0-40a8-90ab-ca90cf24ed3a", new DateTime(2021, 9, 20, 14, 12, 47, 445, DateTimeKind.Local).AddTicks(115) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "0dbbba39-2f7a-4df2-b8bd-1a4cd4fb64f0", new DateTime(2021, 9, 20, 14, 12, 47, 473, DateTimeKind.Local).AddTicks(6491) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "d783d1f5-2b4a-473b-896a-fce5a73507b9", new DateTime(2021, 9, 20, 14, 12, 47, 473, DateTimeKind.Local).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "666e9600-b223-49e3-b1a0-eb62a5f5123b", new DateTime(2021, 9, 20, 14, 12, 47, 473, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "10dd995f-d44a-4621-82ec-26b2ed45a823", new DateTime(2021, 9, 20, 14, 12, 47, 473, DateTimeKind.Local).AddTicks(7791) });
        }
    }
}
