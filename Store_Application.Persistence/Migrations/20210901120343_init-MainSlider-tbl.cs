using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store_Application.Persistence.Migrations
{
    public partial class initMainSlidertbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MainSlides",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemovedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainSlides", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 9, 1, 16, 33, 42, 13, DateTimeKind.Local).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 9, 1, 16, 33, 42, 19, DateTimeKind.Local).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 9, 1, 16, 33, 42, 20, DateTimeKind.Local).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 9, 1, 16, 33, 42, 20, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 9, 1, 16, 33, 42, 20, DateTimeKind.Local).AddTicks(45));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MainSlides");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 8, 23, 15, 47, 3, 605, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 8, 23, 15, 47, 3, 611, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 8, 23, 15, 47, 3, 611, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 8, 23, 15, 47, 3, 611, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 8, 23, 15, 47, 3, 611, DateTimeKind.Local).AddTicks(1673));
        }
    }
}
