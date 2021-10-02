using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store_Application.Persistence.Migrations
{
    public partial class initCommenttbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rate = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: (byte)1),
                    IRecommended = table.Column<bool>(type: "bit", nullable: false),
                    AdminIsRead = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ConfirmedByAdmin = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemovedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dislikes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CommentId = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemovedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dislikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dislikes_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Dislikes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CommentId = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemovedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Likes_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Likes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 519, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 519, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 519, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 519, DateTimeKind.Local).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 519, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 519, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 519, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 519, DateTimeKind.Local).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 520, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 520, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 520, DateTimeKind.Local).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 484, DateTimeKind.Local).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 520, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 520, DateTimeKind.Local).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 520, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 520, DateTimeKind.Local).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 520, DateTimeKind.Local).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 520, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 30,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 40,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 41,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 42,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 43,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 44,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 45,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 46,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 55,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 56,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 57,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 58,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 59,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 60,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 62,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 64,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 65,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 66,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 67,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 68,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 69,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 70,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 72,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 73,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 74,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 75,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 76,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 77,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 78,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 80,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9655));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 81,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 82,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 83,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 84,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 85,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 86,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 91,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 92,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 93,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 94,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 95,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 96,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 97,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 100,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 101,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9725));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 102,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 110,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 112,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 113,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 114,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 115,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 116,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 117,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 118,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9765));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 119,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 120,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 121,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(704), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(172) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1779), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1788), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1796), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1792) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1804), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1801) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1816), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1812) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1824), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1820) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1831), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1839), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1836) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1848), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1855), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1863), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1871), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1879), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1875) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1897), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1905), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2012), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2005) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2020), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2016) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2027), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2024) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2035), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2043), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2051), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2047) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2059), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2055) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2067), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2063) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2074), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2071) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2082), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2090), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2086) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2106), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2113), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2121), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2139), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2146), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2154), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2150) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2163), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2180), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2188), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2195), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2203), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2210), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2218), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2225), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2233), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2241), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2248), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1889), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2098), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2094) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2129), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2125) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2172), new DateTime(2021, 10, 2, 12, 59, 39, 521, DateTimeKind.Local).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 520, DateTimeKind.Local).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 520, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 520, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 520, DateTimeKind.Local).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 520, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 520, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 520, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 520, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 520, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 520, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 520, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 520, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 489, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 489, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 489, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 489, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 497, DateTimeKind.Local).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 497, DateTimeKind.Local).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 497, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "d884748f-afe5-4f61-a49a-43583336a858", new DateTime(2021, 10, 2, 12, 59, 39, 490, DateTimeKind.Local).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "1abb0878-bf73-4609-b3e4-82b55f88b1d4", new DateTime(2021, 10, 2, 12, 59, 39, 517, DateTimeKind.Local).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "d7d28a6b-8ca0-43aa-8bfa-9fe9f82aae80", new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "f7c116c8-39c6-45b9-b54e-ac9745383f76", new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(1182) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "3978aafb-8e33-422f-a5ab-be1e31a688cf", new DateTime(2021, 10, 2, 12, 59, 39, 518, DateTimeKind.Local).AddTicks(1246) });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProductId",
                table: "Comments",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Dislikes_CommentId",
                table: "Dislikes",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Dislikes_UserId",
                table: "Dislikes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_CommentId",
                table: "Likes",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_UserId",
                table: "Likes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dislikes");

            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropTable(
                name: "Comments");

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
        }
    }
}
