using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store_Application.Persistence.Migrations
{
    public partial class initSiteRequesttbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SiteRequests",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasFormContentType = table.Column<bool>(type: "bit", nullable: false),
                    HasJsonContentType = table.Column<bool>(type: "bit", nullable: false),
                    IsHttps = table.Column<bool>(type: "bit", nullable: false),
                    Methode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAuthenticated = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    BrowserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemovedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteRequests", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SiteRequests");

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 612, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 612, DateTimeKind.Local).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 612, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 612, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 612, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 612, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 612, DateTimeKind.Local).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 612, DateTimeKind.Local).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 612, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 612, DateTimeKind.Local).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 612, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 576, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 612, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 612, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 612, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 612, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 612, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 612, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 612, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 612, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 612, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3172));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 30,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 40,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 41,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 42,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 43,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 44,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 45,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 46,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 55,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 56,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 57,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 58,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 59,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 60,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 62,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 64,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 65,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 66,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 67,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 68,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 69,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 70,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3469));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 72,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3474));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 73,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 74,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 75,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 76,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 77,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 78,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 80,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 81,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 82,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 83,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 84,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 85,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 86,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3532));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 91,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 92,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 93,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 94,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 95,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 96,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 97,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 100,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 101,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 102,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 110,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 112,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 113,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3595));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 114,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 115,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 116,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 117,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 118,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 119,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 120,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 121,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 615, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(4314), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(3744) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5443), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5423) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5452), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5460), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5456) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5468), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5465) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5481), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5477) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5490), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5486) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5498), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5494) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5505), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5515), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5522), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5519) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5531), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5527) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5538), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5535) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5546), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5561), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5558) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5569), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5705), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5699) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5713), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5721), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5717) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5730), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5738), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5745), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5742) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5753), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5749) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5761), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5757) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5768), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5765) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5776), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5772) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5784), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5799), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5796) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5807), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5803) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5814), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5811) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5832), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5840), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5837) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5848), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5855), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5852) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5871), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5879), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5886), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5894), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5902), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5898) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5910), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5918), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5925), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5933), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5941), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5554), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5791), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5788) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5822), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5863), new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 613, DateTimeKind.Local).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 614, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 582, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 582, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 582, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 582, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 590, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 590, DateTimeKind.Local).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 590, DateTimeKind.Local).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "3c593000-5681-4a3b-97b8-13047a458d8c", new DateTime(2021, 10, 11, 13, 22, 27, 582, DateTimeKind.Local).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "05a0c812-7365-427d-a4c6-5df8315d07ec", new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(4198) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "9d6f16fe-9a45-431b-84ea-743a3046ec45", new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "c5af2cea-6e8a-4539-bb82-fa67e0cfdce6", new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(5416) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "d558d3c2-7ea6-4736-90b7-3568f70df606", new DateTime(2021, 10, 11, 13, 22, 27, 611, DateTimeKind.Local).AddTicks(5458) });
        }
    }
}
