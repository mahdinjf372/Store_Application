using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store_Application.Persistence.Migrations
{
    public partial class updateaddFieldProducttbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TagsForSearch",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TagsForSearch",
                table: "Products");

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
        }
    }
}
