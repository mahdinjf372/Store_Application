using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store_Application.Persistence.Migrations
{
    public partial class UpdateFakeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Advertisings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertTime", "StartDate" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 141, DateTimeKind.Local).AddTicks(3836), new DateTime(2021, 10, 19, 13, 6, 53, 141, DateTimeKind.Local).AddTicks(2493) });

            migrationBuilder.UpdateData(
                table: "Advertisings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertTime", "StartDate" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 141, DateTimeKind.Local).AddTicks(4465), new DateTime(2021, 10, 19, 13, 6, 53, 141, DateTimeKind.Local).AddTicks(4445) });

            migrationBuilder.UpdateData(
                table: "Advertisings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertTime", "StartDate" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 141, DateTimeKind.Local).AddTicks(4477), new DateTime(2021, 10, 19, 13, 6, 53, 141, DateTimeKind.Local).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "Advertisings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertTime", "StartDate" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 141, DateTimeKind.Local).AddTicks(4487), new DateTime(2021, 10, 19, 13, 6, 53, 141, DateTimeKind.Local).AddTicks(4483) });

            migrationBuilder.UpdateData(
                table: "Advertisings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertTime", "StartDate" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 141, DateTimeKind.Local).AddTicks(4497), new DateTime(2021, 10, 19, 13, 6, 53, 141, DateTimeKind.Local).AddTicks(4492) });

            migrationBuilder.UpdateData(
                table: "Advertisings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertTime", "StartDate" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 141, DateTimeKind.Local).AddTicks(4517), new DateTime(2021, 10, 19, 13, 6, 53, 141, DateTimeKind.Local).AddTicks(4512) });

            migrationBuilder.UpdateData(
                table: "Advertisings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InsertTime", "StartDate" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 141, DateTimeKind.Local).AddTicks(4525), new DateTime(2021, 10, 19, 13, 6, 53, 141, DateTimeKind.Local).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "Advertisings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "InsertTime", "StartDate" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 141, DateTimeKind.Local).AddTicks(4536), new DateTime(2021, 10, 19, 13, 6, 53, 141, DateTimeKind.Local).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 141, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 141, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 141, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 141, DateTimeKind.Local).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 141, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 141, DateTimeKind.Local).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 141, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 141, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 145, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 145, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 145, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 86, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 143, DateTimeKind.Local).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 144, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 144, DateTimeKind.Local).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 144, DateTimeKind.Local).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 144, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 144, DateTimeKind.Local).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 144, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 144, DateTimeKind.Local).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 144, DateTimeKind.Local).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 144, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 144, DateTimeKind.Local).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 144, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 144, DateTimeKind.Local).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 144, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 144, DateTimeKind.Local).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 144, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 144, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 144, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 144, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 144, DateTimeKind.Local).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 144, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 144, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 144, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 144, DateTimeKind.Local).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 144, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 144, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 144, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 144, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 144, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertTime", "Rate" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 142, DateTimeKind.Local).AddTicks(3015), (byte)2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertTime", "Rate" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 142, DateTimeKind.Local).AddTicks(6172), (byte)4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertTime", "Rate" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 142, DateTimeKind.Local).AddTicks(6233), (byte)2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 142, DateTimeKind.Local).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertTime", "Rate" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 142, DateTimeKind.Local).AddTicks(6296), (byte)4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertTime", "Rate" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 142, DateTimeKind.Local).AddTicks(6330), (byte)2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InsertTime", "Rate" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 142, DateTimeKind.Local).AddTicks(6481), (byte)1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "InsertTime", "Rate" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 142, DateTimeKind.Local).AddTicks(6514), (byte)4 });

            migrationBuilder.UpdateData(
                table: "Dislikes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 143, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "Dislikes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 143, DateTimeKind.Local).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "Dislikes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 143, DateTimeKind.Local).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "Dislikes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 143, DateTimeKind.Local).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "Dislikes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 143, DateTimeKind.Local).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Dislikes",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 143, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "Dislikes",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 143, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 145, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 145, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 145, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 145, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 145, DateTimeKind.Local).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 145, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 142, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 142, DateTimeKind.Local).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 142, DateTimeKind.Local).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 142, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 142, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 142, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 142, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 142, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageName", "InsertTime" },
                values: new object[] { "sm-1.jpg", new DateTime(2021, 10, 19, 13, 6, 53, 144, DateTimeKind.Local).AddTicks(9768) });

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageName", "InsertTime" },
                values: new object[] { "sm-2.jpg", new DateTime(2021, 10, 19, 13, 6, 53, 145, DateTimeKind.Local).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageName", "InsertTime" },
                values: new object[] { "sm-3.jpg", new DateTime(2021, 10, 19, 13, 6, 53, 145, DateTimeKind.Local).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 30,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 40,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 41,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 42,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 43,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 44,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 45,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 46,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 55,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 56,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 57,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 58,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 59,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 60,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 62,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 64,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 65,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 66,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 67,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 68,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 69,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 70,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 72,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 73,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 74,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 75,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 76,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 77,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 78,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 80,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 81,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 82,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 83,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 84,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 85,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 86,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 91,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 92,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 93,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 94,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 95,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 96,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 97,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 100,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 101,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 102,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 110,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 112,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 113,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 114,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 115,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 116,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 117,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 118,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 119,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 120,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 121,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(3809), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(4929), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(4911) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(4937), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(4934) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(4946), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(4953), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(4950) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(4964), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(4972), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(4980), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(4977) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(4988), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(4984) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(4997), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(4993) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5005), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5014), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5021), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5018) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5029), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5025) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5044), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5041) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5052), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5048) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5061), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5057) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5068), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5076), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5084), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5092), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5088) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5100), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5108), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5115), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5112) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5123), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5209), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5202) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5217), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5213) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5232), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5228) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5240), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5236) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5247), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5244) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5265), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5272), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5269) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5280), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5288), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5303), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5311), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5307) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5319), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5315) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5327), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5334), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5331) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5342), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5351), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5359), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5367), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5363) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5374), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5371) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5037), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5033) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5224), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5221) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5255), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5251) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5296), new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(5292) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "InsertTime" },
                values: new object[] { "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-1.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-2.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-3.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-4.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-5.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-6.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", new DateTime(2021, 10, 19, 13, 6, 53, 145, DateTimeKind.Local).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "InsertTime" },
                values: new object[] { "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-1.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-2.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-3.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-4.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-5.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-6.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(1493) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "InsertTime" },
                values: new object[] { "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-1.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-2.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-3.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-4.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-5.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-6.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "InsertTime" },
                values: new object[] { "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-1.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-2.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-3.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-4.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-5.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-6.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(1677) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "InsertTime" },
                values: new object[] { "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-1.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-2.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-3.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-4.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-5.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-6.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "InsertTime" },
                values: new object[] { "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-1.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-2.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-3.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-4.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-5.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-6.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "InsertTime" },
                values: new object[] { "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-1.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-2.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-3.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-4.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-5.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-6.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "InsertTime" },
                values: new object[] { "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-1.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-2.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-3.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-4.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-5.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-6.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "InsertTime" },
                values: new object[] { "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-1.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-2.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-3.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-4.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-5.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-6.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(1726) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "InsertTime" },
                values: new object[] { "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-1.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-2.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-3.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-4.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-5.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-6.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "InsertTime" },
                values: new object[] { "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-1.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-2.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-3.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-4.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-5.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-6.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(1745) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "InsertTime" },
                values: new object[] { "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-1.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-2.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-3.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-4.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-5.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/note10-6.jpg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", new DateTime(2021, 10, 19, 13, 6, 53, 146, DateTimeKind.Local).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 143, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 143, DateTimeKind.Local).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 143, DateTimeKind.Local).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 143, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 143, DateTimeKind.Local).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 143, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 143, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 143, DateTimeKind.Local).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 92, DateTimeKind.Local).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 92, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 92, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 92, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7489));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 22,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 23,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 30,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 31,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 32,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 33,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 34,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 35,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 36,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 37,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 38,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 39,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 40,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 41,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 42,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 43,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 44,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 45,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 46,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 47,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 48,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 49,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 50,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 51,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 52,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 53,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 54,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 55,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 56,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 57,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 58,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 59,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 60,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 61,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 62,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 63,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 64,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 65,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 66,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 67,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 68,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 69,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 70,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 71,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 72,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 73,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 74,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 75,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 76,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 77,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 78,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 79,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 80,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 81,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 82,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 83,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 84,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 85,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 86,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 87,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 88,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 89,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 90,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 91,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 92,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 93,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 94,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 95,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 96,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 97,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 98,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 99,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 100,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 101,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 102,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 103,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 104,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 105,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 106,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 107,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 108,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 109,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 110,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 111,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 112,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 113,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 114,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 115,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 116,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 117,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 118,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 119,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 120,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 147, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 101, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 102, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 102, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 143, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 143, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 143, DateTimeKind.Local).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 143, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 19, 13, 6, 53, 143, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "b9c361f7-9ca9-47c2-9b75-479e054249fc", new DateTime(2021, 10, 19, 13, 6, 53, 93, DateTimeKind.Local).AddTicks(1471) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "add46b0a-2c24-49a9-89a1-84458bebddf2", new DateTime(2021, 10, 19, 13, 6, 53, 143, DateTimeKind.Local).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "dd1800c9-20f5-48b9-a8f5-b5ec5d4f2297", new DateTime(2021, 10, 19, 13, 6, 53, 143, DateTimeKind.Local).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "21daf9d3-0da0-41e5-8cdf-f96be7371a88", new DateTime(2021, 10, 19, 13, 6, 53, 143, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "b05938ab-8bdc-4d2f-98a0-9cc82e31ac5f", new DateTime(2021, 10, 19, 13, 6, 53, 143, DateTimeKind.Local).AddTicks(8185) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Advertisings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertTime", "StartDate" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(362), new DateTime(2021, 10, 18, 13, 47, 53, 851, DateTimeKind.Local).AddTicks(8108) });

            migrationBuilder.UpdateData(
                table: "Advertisings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertTime", "StartDate" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(1031), new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(1012) });

            migrationBuilder.UpdateData(
                table: "Advertisings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertTime", "StartDate" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(1042), new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(1038) });

            migrationBuilder.UpdateData(
                table: "Advertisings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertTime", "StartDate" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(1051), new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(1047) });

            migrationBuilder.UpdateData(
                table: "Advertisings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertTime", "StartDate" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(1059), new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(1056) });

            migrationBuilder.UpdateData(
                table: "Advertisings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertTime", "StartDate" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(1079), new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(1075) });

            migrationBuilder.UpdateData(
                table: "Advertisings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InsertTime", "StartDate" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(1087), new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(1083) });

            migrationBuilder.UpdateData(
                table: "Advertisings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "InsertTime", "StartDate" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(1095), new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(1091) });

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 798, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertTime", "Rate" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(7950), (byte)4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertTime", "Rate" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(2500), (byte)3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertTime", "Rate" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(2611), (byte)1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertTime", "Rate" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(2677), (byte)2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertTime", "Rate" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(2715), (byte)3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InsertTime", "Rate" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(2745), (byte)2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "InsertTime", "Rate" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(2778), (byte)2 });

            migrationBuilder.UpdateData(
                table: "Dislikes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Dislikes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Dislikes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Dislikes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Dislikes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Dislikes",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Dislikes",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageName", "InsertTime" },
                values: new object[] { "a866effd8dc64a4e91a4a1a024629166.jpg", new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageName", "InsertTime" },
                values: new object[] { "7494777a77864093a32ee9984c0a6520.jpg", new DateTime(2021, 10, 18, 13, 47, 53, 856, DateTimeKind.Local).AddTicks(8423) });

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageName", "InsertTime" },
                values: new object[] { "6d9a11244f8f4bd8a614b81f2e702799.jpg", new DateTime(2021, 10, 18, 13, 47, 53, 856, DateTimeKind.Local).AddTicks(8488) });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 30,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 40,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 41,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 42,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 43,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 44,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 45,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 46,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 55,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 56,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 57,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 58,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 59,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 60,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 62,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 64,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 65,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 66,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 67,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 68,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 69,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 70,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 72,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 73,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 74,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 75,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 76,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 77,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 78,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 80,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 81,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 82,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 83,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 84,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 85,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 86,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 91,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 92,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 93,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 94,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 95,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 96,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 97,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 100,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 101,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 102,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 110,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 112,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 113,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 114,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 115,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 116,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 117,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 118,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 119,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 120,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 121,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2499));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2533));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 861, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(2211), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3336), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3345), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3353), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3349) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3361), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3357) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3376), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3372) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3384), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3381) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3393), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3401), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3397) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3410), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3418), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3426), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3422) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3433), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3466), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3481), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3478) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3489), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3499), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3495) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3507), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3515), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3522), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3519) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3530), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3539), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3536) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3547), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3543) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3555), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3551) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3562), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3570), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3567) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3578), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3574) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3593), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3601), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3597) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3609), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3627), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3634), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3642), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3638) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3650), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3647) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3665), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3662) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3673), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3669) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3681), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3677) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3688), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3685) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3696), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3692) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3704), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3712), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3709) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3720), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3717) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3728), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3725) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3736), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3732) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3474), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3586), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3617), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "EndDate", "InsertTime" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3658), new DateTime(2021, 10, 18, 13, 47, 53, 858, DateTimeKind.Local).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "InsertTime" },
                values: new object[] { "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/84a990c5-6102-4bd2-b587-76be3df30835.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/86e0699c-e0e0-401e-bdc3-84f3b5221258.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6154596f-bc8e-4019-b13f-1c8e4dd94aef.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6e677979-65a3-4f8e-ba50-e80fbc53dbf5.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/c84c5779-be7e-4611-a384-c2b4f54c0d31.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/4c9c6d5a-7d86-4c77-a8ea-467358b61fba.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(4367) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "InsertTime" },
                values: new object[] { "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/84a990c5-6102-4bd2-b587-76be3df30835.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/86e0699c-e0e0-401e-bdc3-84f3b5221258.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6154596f-bc8e-4019-b13f-1c8e4dd94aef.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6e677979-65a3-4f8e-ba50-e80fbc53dbf5.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/c84c5779-be7e-4611-a384-c2b4f54c0d31.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/4c9c6d5a-7d86-4c77-a8ea-467358b61fba.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(9868) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "InsertTime" },
                values: new object[] { "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/84a990c5-6102-4bd2-b587-76be3df30835.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/86e0699c-e0e0-401e-bdc3-84f3b5221258.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6154596f-bc8e-4019-b13f-1c8e4dd94aef.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6e677979-65a3-4f8e-ba50-e80fbc53dbf5.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/c84c5779-be7e-4611-a384-c2b4f54c0d31.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/4c9c6d5a-7d86-4c77-a8ea-467358b61fba.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(9909) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "InsertTime" },
                values: new object[] { "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/84a990c5-6102-4bd2-b587-76be3df30835.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/86e0699c-e0e0-401e-bdc3-84f3b5221258.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6154596f-bc8e-4019-b13f-1c8e4dd94aef.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6e677979-65a3-4f8e-ba50-e80fbc53dbf5.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/c84c5779-be7e-4611-a384-c2b4f54c0d31.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/4c9c6d5a-7d86-4c77-a8ea-467358b61fba.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(9919) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "InsertTime" },
                values: new object[] { "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/84a990c5-6102-4bd2-b587-76be3df30835.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/86e0699c-e0e0-401e-bdc3-84f3b5221258.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6154596f-bc8e-4019-b13f-1c8e4dd94aef.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6e677979-65a3-4f8e-ba50-e80fbc53dbf5.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/c84c5779-be7e-4611-a384-c2b4f54c0d31.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/4c9c6d5a-7d86-4c77-a8ea-467358b61fba.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "InsertTime" },
                values: new object[] { "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/84a990c5-6102-4bd2-b587-76be3df30835.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/86e0699c-e0e0-401e-bdc3-84f3b5221258.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6154596f-bc8e-4019-b13f-1c8e4dd94aef.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6e677979-65a3-4f8e-ba50-e80fbc53dbf5.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/c84c5779-be7e-4611-a384-c2b4f54c0d31.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/4c9c6d5a-7d86-4c77-a8ea-467358b61fba.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "InsertTime" },
                values: new object[] { "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/84a990c5-6102-4bd2-b587-76be3df30835.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/86e0699c-e0e0-401e-bdc3-84f3b5221258.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6154596f-bc8e-4019-b13f-1c8e4dd94aef.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6e677979-65a3-4f8e-ba50-e80fbc53dbf5.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/c84c5779-be7e-4611-a384-c2b4f54c0d31.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/4c9c6d5a-7d86-4c77-a8ea-467358b61fba.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "InsertTime" },
                values: new object[] { "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/84a990c5-6102-4bd2-b587-76be3df30835.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/86e0699c-e0e0-401e-bdc3-84f3b5221258.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6154596f-bc8e-4019-b13f-1c8e4dd94aef.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6e677979-65a3-4f8e-ba50-e80fbc53dbf5.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/c84c5779-be7e-4611-a384-c2b4f54c0d31.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/4c9c6d5a-7d86-4c77-a8ea-467358b61fba.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(9958) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "InsertTime" },
                values: new object[] { "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/84a990c5-6102-4bd2-b587-76be3df30835.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/86e0699c-e0e0-401e-bdc3-84f3b5221258.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6154596f-bc8e-4019-b13f-1c8e4dd94aef.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6e677979-65a3-4f8e-ba50-e80fbc53dbf5.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/c84c5779-be7e-4611-a384-c2b4f54c0d31.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/4c9c6d5a-7d86-4c77-a8ea-467358b61fba.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "InsertTime" },
                values: new object[] { "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/84a990c5-6102-4bd2-b587-76be3df30835.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/86e0699c-e0e0-401e-bdc3-84f3b5221258.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6154596f-bc8e-4019-b13f-1c8e4dd94aef.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6e677979-65a3-4f8e-ba50-e80fbc53dbf5.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/c84c5779-be7e-4611-a384-c2b4f54c0d31.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/4c9c6d5a-7d86-4c77-a8ea-467358b61fba.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "InsertTime" },
                values: new object[] { "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/84a990c5-6102-4bd2-b587-76be3df30835.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/86e0699c-e0e0-401e-bdc3-84f3b5221258.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6154596f-bc8e-4019-b13f-1c8e4dd94aef.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6e677979-65a3-4f8e-ba50-e80fbc53dbf5.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/c84c5779-be7e-4611-a384-c2b4f54c0d31.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/4c9c6d5a-7d86-4c77-a8ea-467358b61fba.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(9983) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "InsertTime" },
                values: new object[] { "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/84a990c5-6102-4bd2-b587-76be3df30835.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/86e0699c-e0e0-401e-bdc3-84f3b5221258.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6154596f-bc8e-4019-b13f-1c8e4dd94aef.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6e677979-65a3-4f8e-ba50-e80fbc53dbf5.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/c84c5779-be7e-4611-a384-c2b4f54c0d31.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/4c9c6d5a-7d86-4c77-a8ea-467358b61fba.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 804, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 804, DateTimeKind.Local).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 804, DateTimeKind.Local).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 804, DateTimeKind.Local).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1032));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 11,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 12,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 13,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 14,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 15,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 16,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 17,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 18,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 19,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 20,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 21,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 22,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 23,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 24,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 25,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 26,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 27,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 28,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 29,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 30,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 31,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 32,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 33,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 34,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 35,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 36,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 37,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 38,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1171));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 39,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 40,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 41,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 42,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 43,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 44,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 45,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 46,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 47,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 48,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 49,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 50,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 51,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 52,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 53,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 54,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 55,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 56,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 57,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 58,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 59,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 60,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 61,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 62,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 63,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 64,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 65,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 66,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1326));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 67,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 68,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 69,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 70,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 71,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 72,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 73,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 74,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 75,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 76,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1365));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 77,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 78,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 79,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 80,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 81,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 82,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 83,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 84,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 85,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 86,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1404));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 87,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1408));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 88,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 89,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1416));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 90,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 91,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 92,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 93,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 94,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 95,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 96,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 97,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 98,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 99,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 100,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 101,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 102,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 103,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 104,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 105,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 106,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 107,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 108,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 109,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 110,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 111,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 112,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 113,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 114,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 115,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 116,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 117,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 118,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 119,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 120,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 814, DateTimeKind.Local).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 814, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 814, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 6,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 7,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 8,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "0f9c62af-c80c-4325-b007-80e99459267e", new DateTime(2021, 10, 18, 13, 47, 53, 804, DateTimeKind.Local).AddTicks(5491) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "e98ae736-f4ea-403e-9b51-3c4e06850bc8", new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(3756) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "d6584434-b22f-4641-892e-81af34fd8e00", new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(4725) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "8a40a2b3-ab50-47fe-87fc-5e3be892bd04", new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(4847) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActiveCode", "InsertTime" },
                values: new object[] { "e112994b-405f-48d2-bd7f-830e321a4515", new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(4889) });
        }
    }
}
