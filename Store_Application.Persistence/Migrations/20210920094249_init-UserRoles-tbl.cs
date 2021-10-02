using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store_Application.Persistence.Migrations
{
    public partial class initUserRolestbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemovedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
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

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "InsertTime", "RemovedTime", "RoleId", "UpdateTime", "UserId", "isRemoved" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 9, 20, 14, 12, 47, 452, DateTimeKind.Local).AddTicks(2370), null, 1, null, 1, false },
                    { 8, new DateTime(2021, 9, 20, 14, 12, 47, 473, DateTimeKind.Local).AddTicks(8039), null, 3, null, 5, false },
                    { 7, new DateTime(2021, 9, 20, 14, 12, 47, 473, DateTimeKind.Local).AddTicks(8035), null, 3, null, 4, false },
                    { 6, new DateTime(2021, 9, 20, 14, 12, 47, 473, DateTimeKind.Local).AddTicks(8030), null, 3, null, 3, false },
                    { 5, new DateTime(2021, 9, 20, 14, 12, 47, 473, DateTimeKind.Local).AddTicks(8025), null, 3, null, 2, false },
                    { 4, new DateTime(2021, 9, 20, 14, 12, 47, 473, DateTimeKind.Local).AddTicks(8010), null, 2, null, 2, false },
                    { 3, new DateTime(2021, 9, 20, 14, 12, 47, 452, DateTimeKind.Local).AddTicks(3604), null, 2, null, 1, false },
                    { 2, new DateTime(2021, 9, 20, 14, 12, 47, 452, DateTimeKind.Local).AddTicks(3582), null, 3, null, 1, false }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(9718));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 729, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 766, DateTimeKind.Local).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 30,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 40,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 41,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 42,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 43,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 44,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 45,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 46,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 55,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 56,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 57,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 58,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 59,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 60,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 62,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 64,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 65,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 66,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 67,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 68,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 69,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 70,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 72,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 73,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 74,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 75,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 76,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 77,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 78,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 80,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 81,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 82,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 83,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 84,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 85,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 86,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 91,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 92,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 93,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 94,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 95,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 96,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1329));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 97,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 100,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 101,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 102,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 110,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 112,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 113,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 114,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 115,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 116,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 117,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 118,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 119,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1398));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 120,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 121,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1408));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7301));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(2469), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3580), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3561) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3589), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3585) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3598), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3608), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3622), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3631), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3640), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3636) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3649), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3645) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3660), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3656) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3670), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3678), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3674) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3687), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3683) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3696), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3692) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3714), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3723), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3719) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3734), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3729) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3743), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3739) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3751), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3747) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3760), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3756) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3769), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3765) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3778), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3774) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3787), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3783) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3796), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3792) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3805), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3800) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3813), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3809) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3822), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3818) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3840), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3849), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3845) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3858), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3854) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3878), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3874) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3887), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3883) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3896), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3892) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3905), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3901) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3923), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3919) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3931), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3927) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3940), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3936) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3949), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3945) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3958), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3954) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3967), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3962) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3976), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3972) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3985), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3981) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(4017), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(4026), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(4022) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3705), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3701) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3831), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3827) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3867), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3863) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3914), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 736, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 736, DateTimeKind.Local).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 736, DateTimeKind.Local).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 9, 13, 11, 57, 15, 736, DateTimeKind.Local).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActiveCode", "InsertTime", "RoleId" },
                values: new object[] { "2194d334-662f-4c93-a1e2-19c07f69d103", new DateTime(2021, 9, 13, 11, 57, 15, 736, DateTimeKind.Local).AddTicks(9515), 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActiveCode", "InsertTime", "RoleId" },
                values: new object[] { "69283c77-1b1d-4498-bc28-304cc63a6ba5", new DateTime(2021, 9, 13, 11, 57, 15, 765, DateTimeKind.Local).AddTicks(9643), 3 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActiveCode", "InsertTime", "RoleId" },
                values: new object[] { "94c42a50-abfe-4ed2-8be5-5fa0b2576010", new DateTime(2021, 9, 13, 11, 57, 15, 766, DateTimeKind.Local).AddTicks(821), 3 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActiveCode", "InsertTime", "RoleId" },
                values: new object[] { "0a673b10-6681-4342-a410-e5e979df65a1", new DateTime(2021, 9, 13, 11, 57, 15, 766, DateTimeKind.Local).AddTicks(891), 3 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActiveCode", "InsertTime", "RoleId" },
                values: new object[] { "37e3fc24-9820-40af-9da9-5ae1ecaa47a0", new DateTime(2021, 9, 13, 11, 57, 15, 766, DateTimeKind.Local).AddTicks(953), 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
