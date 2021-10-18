using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store_Application.Persistence.Migrations
{
    public partial class ApplyFakeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Advertisings",
                columns: new[] { "Id", "Description", "EndDate", "ImageName", "InsertTime", "LinkTo", "Place", "RemovedTime", "StartDate", "Title", "UpdateTime", "isRemoved" },
                values: new object[,]
                {
                    { 1, "توضیحات بنر تستی 1", new DateTime(2999, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "topLeft1_default.jpg", new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(362), "", 1, null, new DateTime(2021, 10, 18, 13, 47, 53, 851, DateTimeKind.Local).AddTicks(8108), "بنر تستی 1", null, false },
                    { 8, "توضیحات بنر تستی 8", new DateTime(2999, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "bottom4_default.jpg", new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(1095), "", 8, null, new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(1091), "بنر تستی 8", null, false },
                    { 7, "توضیحات بنر تستی 7", new DateTime(2999, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "bottom3_default.jpg", new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(1087), "", 7, null, new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(1083), "بنر تستی 7", null, false },
                    { 6, "توضیحات بنر تستی 6", new DateTime(2999, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "bottom2_default.jpg", new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(1079), "", 6, null, new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(1075), "بنر تستی 6", null, false },
                    { 2, "توضیحات بنر تستی 2", new DateTime(2999, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "topLeft2_default.jpg", new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(1031), "", 2, null, new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(1012), "بنر تستی 2", null, false },
                    { 4, "توضیحات بنر تستی 4", new DateTime(2999, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "bottomLong_default.jpg", new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(1051), "", 4, null, new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(1047), "بنر تستی 4", null, false },
                    { 3, "توضیحات بنر تستی 3", new DateTime(2999, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "topRight_default.jpg", new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(1042), "", 3, null, new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(1038), "بنر تستی 3", null, false },
                    { 5, "توضیحات بنر تستی 5", new DateTime(2999, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "bottom1_default.jpg", new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(1059), "", 5, null, new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(1056), "بنر تستی 5", null, false }
                });

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageName", "InsertTime", "LinkTo" },
                values: new object[] { "huawei.png", new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(4524), "" });

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageName", "InsertTime", "LinkTo" },
                values: new object[] { "samsung.png", new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(4575), "" });

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageName", "InsertTime", "LinkTo" },
                values: new object[] { "adata.png", new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(4583), "" });

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageName", "InsertTime", "LinkTo", "Title" },
                values: new object[] { "shahab.png", new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(4587), "", "شهاب" });

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageName", "InsertTime", "LinkTo", "Title" },
                values: new object[] { "nokia.png", new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(4592), "", "نوکیا" });

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageName", "InsertTime", "LinkTo", "Title" },
                values: new object[] { "panasonic.png", new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(4601), "", "پاناسونیک" });

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageName", "InsertTime", "LinkTo", "Title" },
                values: new object[] { "parskhazar.png", new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(4605), "", "پارس خزر" });

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageName", "InsertTime", "LinkTo", "Title" },
                values: new object[] { "xvison.png", new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(4610), "", "ایکس ویژن" });

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

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "AdminIsRead", "ConfirmedByAdmin", "IRecommended", "InsertTime", "ProductId", "Rate", "RemovedTime", "Text", "Title", "UpdateTime", "UserId", "isRemoved" },
                values: new object[,]
                {
                    { 3, true, true, true, new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(2611), 1, (byte)1, null, "در کل سامسونگ کاربردی تر از آیفون هست ولی از نظر کیفیت تصویر و سرعت آیفون بهتره و کلاس!", "بهتر از آیفون", null, 3, false },
                    { 4, true, true, true, new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(2644), 1, (byte)1, null, "عالییه بنظرمن اونایی که میرن پول گوشی های ایفون با اون قیمت رو میدن با استفاده از این گوشی باید نظرشونو عوض کنن", "عالی و صدرصد بهتر از اپل", null, 4, false },
                    { 8, true, true, true, new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(2778), 2, (byte)2, null, "عاااااااالیییییه بنظرم", "عالیه", null, 4, false },
                    { 7, true, true, false, new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(2745), 2, (byte)2, null, "خیلیم خوب نیست به نظرم نمیصرفه", "خیلیم خوب نیس", null, 2, false },
                    { 6, true, true, true, new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(2715), 2, (byte)3, null, "به به عجب چیزیه من که نمیتون وارد شم", "خوبه", null, 5, false },
                    { 2, true, true, false, new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(2500), 1, (byte)3, null, "به نظرم قیمتش خیلی بالاس و مناسب نیس", "قیمت", null, 2, false },
                    { 5, true, true, false, new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(2677), 2, (byte)2, null, "به نظرم طراحی خوبی نداره و زشته یکم", "زشته", null, 3, false },
                    { 1, true, true, true, new DateTime(2021, 10, 18, 13, 47, 53, 852, DateTimeKind.Local).AddTicks(7950), 1, (byte)4, null, "محصول دوست داشتنی به نظر میاد", "دوست داشتنی", null, 1, false }
                });

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
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 856, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 10, 18, 13, 47, 53, 856, DateTimeKind.Local).AddTicks(8488));

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
                columns: new[] { "InsertTime", "TagsForSearch" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(4367), "سامسونگ-samsung-Galaxy-Note-256 گیگابایت-Note_10-Galaxy_Note_10-موبایل-گوشی-mobile" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertTime", "TagsForSearch" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(9868), "اپل-آیفون-apple-iphone-ایکس اس مکس-256 گیگابایت-xs_max-موبایل-گوشی-mobile" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertTime", "TagsForSearch" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(9909), "سامسونگ-samsung-Galaxy-Note-256 گیگابایت-Note_10-Galaxy_Note_10-موبایل-گوشی-mobile" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertTime", "TagsForSearch" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(9919), "اپل-آیفون-apple-iphone-ایکس اس مکس-256 گیگابایت-xs_max-موبایل-گوشی-mobile" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertTime", "TagsForSearch" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(9928), "اپل-آیفون-apple-iphone-ایکس اس مکس-256 گیگابایت-xs_max-موبایل-گوشی-mobile" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertTime", "TagsForSearch" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(9941), "سامسونگ-samsung-Galaxy-Note-256 گیگابایت-Note_10-Galaxy_Note_10-موبایل-گوشی-mobile" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InsertTime", "TagsForSearch" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(9950), "اپل-آیفون-apple-iphone-ایکس اس مکس-256 گیگابایت-xs_max-موبایل-گوشی-mobile" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "InsertTime", "Price", "TagsForSearch" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(9958), 16000000m, "سامسونگ-samsung-Galaxy-Note-256 گیگابایت-Note_10-Galaxy_Note_10-موبایل-گوشی-mobile" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "InsertTime", "TagsForSearch" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(9965), "اپل-آیفون-apple-iphone-ایکس اس مکس-256 گیگابایت-xs_max-موبایل-گوشی-mobile" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "InsertTime", "TagsForSearch" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(9975), "اپل-آیفون-apple-iphone-ایکس اس مکس-256 گیگابایت-xs_max-موبایل-گوشی-mobile" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "InsertTime", "TagsForSearch" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(9983), "سامسونگ-samsung-Galaxy-Note-256 گیگابایت-Note_10-Galaxy_Note_10-موبایل-گوشی-mobile" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "InsertTime", "TagsForSearch" },
                values: new object[] { new DateTime(2021, 10, 18, 13, 47, 53, 857, DateTimeKind.Local).AddTicks(9991), "اپل-آیفون-apple-iphone-ایکس اس مکس-256 گیگابایت-xs_max-موبایل-گوشی-mobile" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "AdminIsRead", "ConfirmedByAdmin", "InsertTime", "ParentQuestionId", "ProductId", "RemovedTime", "Text", "UpdateTime", "UserId", "isRemoved" },
                values: new object[,]
                {
                    { 1, true, true, new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(1200), null, 1, null, "محصول دوست داشتنی به نظر میاد کسی ازش استفاده کرده؟", null, 2, false },
                    { 5, true, true, new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(3139), null, 2, null, "صفحش چند هرتزه؟", null, 2, false },
                    { 4, true, true, new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(3134), null, 2, null, "میتونه اهنگ پخش کنه؟", null, 4, false },
                    { 2, true, true, new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(3107), null, 1, null, "باتریش چند ساعت و نگه میداره؟", null, 1, false },
                    { 7, true, true, new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(3152), null, 2, null, "با 10 تومن اینو بخرم یا اونو؟؟؟", null, 1, false }
                });

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

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "InsertTime", "ProductId", "RemovedTime", "Title", "UpdateTime", "isRemoved" },
                values: new object[,]
                {
                    { 9, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1044), 1, null, "گوشی", null, false },
                    { 11, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1056), 2, null, "اپل", null, false },
                    { 7, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1037), 1, null, "Galaxy_Note_10", null, false },
                    { 6, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1032), 1, null, "Note_10", null, false },
                    { 5, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1013), 1, null, "256 گیگابایت", null, false },
                    { 4, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1009), 1, null, "Note", null, false },
                    { 3, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1004), 1, null, "Galaxy", null, false },
                    { 2, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(981), 1, null, "samsung", null, false },
                    { 1, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(241), 1, null, "سامسونگ", null, false },
                    { 10, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1050), 1, null, "mobile", null, false },
                    { 8, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1041), 1, null, "موبایل", null, false },
                    { 73, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1353), 8, null, "Galaxy", null, false },
                    { 71, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1346), 8, null, "سامسونگ", null, false },
                    { 102, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1468), 11, null, "samsung", null, false },
                    { 103, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1472), 11, null, "Galaxy", null, false }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "InsertTime", "ProductId", "RemovedTime", "Title", "UpdateTime", "isRemoved" },
                values: new object[,]
                {
                    { 104, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1476), 11, null, "Note", null, false },
                    { 105, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1480), 11, null, "256 گیگابایت", null, false },
                    { 106, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1483), 11, null, "Note_10", null, false },
                    { 107, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1487), 11, null, "Galaxy_Note_10", null, false },
                    { 108, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1491), 11, null, "موبایل", null, false },
                    { 109, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1495), 11, null, "گوشی", null, false },
                    { 110, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1499), 11, null, "mobile", null, false },
                    { 111, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1503), 12, null, "اپل", null, false },
                    { 112, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1508), 12, null, "آیفون", null, false },
                    { 113, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1512), 12, null, "apple", null, false },
                    { 114, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1517), 12, null, "iphone", null, false },
                    { 115, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1522), 12, null, "ایکس اس مکس", null, false },
                    { 116, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1527), 12, null, "256 گیگابایت", null, false },
                    { 117, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1532), 12, null, "xs_max", null, false },
                    { 118, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1536), 12, null, "موبایل", null, false },
                    { 119, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1541), 12, null, "گوشی", null, false },
                    { 120, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1545), 12, null, "mobile", null, false },
                    { 72, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1350), 8, null, "samsung", null, false },
                    { 70, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1341), 7, null, "mobile", null, false },
                    { 69, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1337), 7, null, "گوشی", null, false },
                    { 68, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1333), 7, null, "موبایل", null, false },
                    { 101, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1463), 11, null, "سامسونگ", null, false },
                    { 100, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1458), 10, null, "mobile", null, false },
                    { 99, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1455), 10, null, "گوشی", null, false },
                    { 98, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1451), 10, null, "موبایل", null, false },
                    { 74, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1357), 8, null, "Note", null, false },
                    { 75, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1361), 8, null, "256 گیگابایت", null, false },
                    { 76, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1365), 8, null, "Note_10", null, false },
                    { 77, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1369), 8, null, "Galaxy_Note_10", null, false },
                    { 78, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1373), 8, null, "موبایل", null, false },
                    { 79, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1376), 8, null, "گوشی", null, false },
                    { 80, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1380), 8, null, "mobile", null, false },
                    { 81, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1385), 9, null, "اپل", null, false },
                    { 82, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1389), 9, null, "آیفون", null, false },
                    { 83, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1393), 9, null, "apple", null, false },
                    { 84, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1396), 9, null, "iphone", null, false },
                    { 66, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1326), 7, null, "256 گیگابایت", null, false },
                    { 85, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1400), 9, null, "ایکس اس مکس", null, false },
                    { 87, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1408), 9, null, "xs_max", null, false },
                    { 88, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1412), 9, null, "موبایل", null, false },
                    { 89, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1416), 9, null, "گوشی", null, false },
                    { 90, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1419), 9, null, "mobile", null, false }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "InsertTime", "ProductId", "RemovedTime", "Title", "UpdateTime", "isRemoved" },
                values: new object[,]
                {
                    { 91, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1424), 10, null, "اپل", null, false },
                    { 92, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1428), 10, null, "آیفون", null, false },
                    { 93, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1432), 10, null, "apple", null, false },
                    { 94, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1436), 10, null, "iphone", null, false },
                    { 95, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1440), 10, null, "ایکس اس مکس", null, false },
                    { 96, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1443), 10, null, "256 گیگابایت", null, false },
                    { 97, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1447), 10, null, "xs_max", null, false },
                    { 86, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1404), 9, null, "256 گیگابایت", null, false },
                    { 65, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1319), 7, null, "ایکس اس مکس", null, false },
                    { 67, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1330), 7, null, "xs_max", null, false },
                    { 63, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1311), 7, null, "apple", null, false },
                    { 64, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1315), 7, null, "iphone", null, false },
                    { 34, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1156), 4, null, "iphone", null, false },
                    { 33, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1150), 4, null, "apple", null, false },
                    { 32, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1146), 4, null, "آیفون", null, false },
                    { 31, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1142), 4, null, "اپل", null, false },
                    { 30, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1137), 3, null, "mobile", null, false },
                    { 29, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1134), 3, null, "گوشی", null, false },
                    { 28, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1129), 3, null, "موبایل", null, false },
                    { 27, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1126), 3, null, "Galaxy_Note_10", null, false },
                    { 26, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1122), 3, null, "Note_10", null, false },
                    { 25, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1118), 3, null, "256 گیگابایت", null, false },
                    { 36, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1164), 4, null, "256 گیگابایت", null, false },
                    { 24, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1114), 3, null, "Note", null, false },
                    { 22, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1106), 3, null, "samsung", null, false },
                    { 21, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1102), 3, null, "سامسونگ", null, false },
                    { 20, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1097), 2, null, "mobile", null, false },
                    { 19, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1092), 2, null, "گوشی", null, false },
                    { 18, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1088), 2, null, "موبایل", null, false },
                    { 17, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1082), 2, null, "xs_max", null, false },
                    { 16, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1078), 2, null, "256 گیگابایت", null, false },
                    { 15, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1073), 2, null, "ایکس اس مکس", null, false },
                    { 14, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1069), 2, null, "iphone", null, false },
                    { 13, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1066), 2, null, "apple", null, false },
                    { 12, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1062), 2, null, "آیفون", null, false },
                    { 23, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1110), 3, null, "Galaxy", null, false },
                    { 37, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1167), 4, null, "xs_max", null, false },
                    { 35, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1160), 4, null, "ایکس اس مکس", null, false },
                    { 39, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1175), 4, null, "گوشی", null, false },
                    { 62, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1307), 7, null, "آیفون", null, false },
                    { 61, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1303), 7, null, "اپل", null, false },
                    { 60, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1299), 6, null, "mobile", null, false }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "InsertTime", "ProductId", "RemovedTime", "Title", "UpdateTime", "isRemoved" },
                values: new object[,]
                {
                    { 59, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1294), 6, null, "گوشی", null, false },
                    { 58, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1290), 6, null, "موبایل", null, false },
                    { 57, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1286), 6, null, "Galaxy_Note_10", null, false },
                    { 56, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1283), 6, null, "Note_10", null, false },
                    { 55, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1278), 6, null, "256 گیگابایت", null, false },
                    { 38, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1171), 4, null, "موبایل", null, false },
                    { 53, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1230), 6, null, "Galaxy", null, false },
                    { 52, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1226), 6, null, "samsung", null, false },
                    { 54, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1234), 6, null, "Note", null, false },
                    { 50, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1218), 5, null, "mobile", null, false },
                    { 40, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1179), 4, null, "mobile", null, false },
                    { 41, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1184), 5, null, "اپل", null, false },
                    { 51, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1222), 6, null, "سامسونگ", null, false },
                    { 43, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1191), 5, null, "apple", null, false },
                    { 44, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1195), 5, null, "iphone", null, false },
                    { 42, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1188), 5, null, "آیفون", null, false },
                    { 46, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1203), 5, null, "256 گیگابایت", null, false },
                    { 47, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1207), 5, null, "xs_max", null, false },
                    { 48, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1210), 5, null, "موبایل", null, false },
                    { 49, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1214), 5, null, "گوشی", null, false },
                    { 45, new DateTime(2021, 10, 18, 13, 47, 53, 862, DateTimeKind.Local).AddTicks(1199), 5, null, "ایکس اس مکس", null, false }
                });

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

            migrationBuilder.InsertData(
                table: "Dislikes",
                columns: new[] { "Id", "CommentId", "InsertTime", "RemovedTime", "UpdateTime", "UserId", "isRemoved" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(8291), null, null, 5, false },
                    { 7, 3, new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(8369), null, null, 3, false },
                    { 6, 3, new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(8365), null, null, 5, false },
                    { 2, 2, new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(8341), null, null, 2, false },
                    { 3, 2, new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(8348), null, null, 4, false },
                    { 4, 2, new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(8352), null, null, 5, false },
                    { 5, 3, new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(8357), null, null, 2, false }
                });

            migrationBuilder.InsertData(
                table: "Likes",
                columns: new[] { "Id", "CommentId", "InsertTime", "RemovedTime", "UpdateTime", "UserId", "isRemoved" },
                values: new object[,]
                {
                    { 8, 3, new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(5996), null, null, 1, false },
                    { 7, 3, new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(5992), null, null, 4, false },
                    { 5, 2, new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(5979), null, null, 1, false },
                    { 4, 1, new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(5973), null, null, 3, false },
                    { 3, 1, new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(5969), null, null, 2, false },
                    { 2, 1, new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(5961), null, null, 4, false },
                    { 1, 1, new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(5909), null, null, 2, false },
                    { 6, 2, new DateTime(2021, 10, 18, 13, 47, 53, 854, DateTimeKind.Local).AddTicks(5987), null, null, 3, false }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "AdminIsRead", "ConfirmedByAdmin", "InsertTime", "ParentQuestionId", "ProductId", "RemovedTime", "Text", "UpdateTime", "UserId", "isRemoved" },
                values: new object[,]
                {
                    { 6, true, true, new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(3147), 5, 2, null, "تو سایت برندش نوشته 60 هرتز", null, 5, false },
                    { 3, true, true, new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(3128), 1, 1, null, "من دارمش راضیم ازش", null, 3, false },
                    { 8, true, true, new DateTime(2021, 10, 18, 13, 47, 53, 855, DateTimeKind.Local).AddTicks(3157), 7, 2, null, "هیچکدومو", null, 4, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Advertisings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Advertisings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Advertisings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Advertisings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Advertisings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Advertisings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Advertisings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Advertisings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Dislikes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dislikes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dislikes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dislikes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dislikes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dislikes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Dislikes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Likes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageName", "InsertTime", "LinkTo" },
                values: new object[] { "c1aae97de6894801b50b379fdf75e78d.png", new DateTime(2021, 10, 11, 18, 1, 9, 758, DateTimeKind.Local).AddTicks(488), null });

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageName", "InsertTime", "LinkTo" },
                values: new object[] { "8e67672e408d431da4f5710184ca8add.png", new DateTime(2021, 10, 11, 18, 1, 9, 758, DateTimeKind.Local).AddTicks(2199), null });

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageName", "InsertTime", "LinkTo" },
                values: new object[] { "752ed3efe90e41b78fce90b68abb2bdf.png", new DateTime(2021, 10, 11, 18, 1, 9, 758, DateTimeKind.Local).AddTicks(2222), null });

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageName", "InsertTime", "LinkTo", "Title" },
                values: new object[] { "c964b9f4ac4540889fc15227a0cb5aea.png", new DateTime(2021, 10, 11, 18, 1, 9, 758, DateTimeKind.Local).AddTicks(2230), null, "Shahab" });

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageName", "InsertTime", "LinkTo", "Title" },
                values: new object[] { "c1aae97de6894801b50b379fdf75e78d.png", new DateTime(2021, 10, 11, 18, 1, 9, 758, DateTimeKind.Local).AddTicks(2235), null, "هواوی" });

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageName", "InsertTime", "LinkTo", "Title" },
                values: new object[] { "8e67672e408d431da4f5710184ca8add.png", new DateTime(2021, 10, 11, 18, 1, 9, 758, DateTimeKind.Local).AddTicks(2245), null, "سامسونگ" });

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageName", "InsertTime", "LinkTo", "Title" },
                values: new object[] { "752ed3efe90e41b78fce90b68abb2bdf.png", new DateTime(2021, 10, 11, 18, 1, 9, 758, DateTimeKind.Local).AddTicks(2250), null, "ای دیتا" });

            migrationBuilder.UpdateData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageName", "InsertTime", "LinkTo", "Title" },
                values: new object[] { "c964b9f4ac4540889fc15227a0cb5aea.png", new DateTime(2021, 10, 11, 18, 1, 9, 758, DateTimeKind.Local).AddTicks(2255), null, "Shahab" });

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
                columns: new[] { "InsertTime", "TagsForSearch" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 758, DateTimeKind.Local).AddTicks(5933), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InsertTime", "TagsForSearch" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(1895), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InsertTime", "TagsForSearch" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(1940), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InsertTime", "TagsForSearch" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(1947), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InsertTime", "TagsForSearch" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(2170), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InsertTime", "TagsForSearch" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(2187), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InsertTime", "TagsForSearch" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(2193), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "InsertTime", "Price", "TagsForSearch" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(2198), 1600000m, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "InsertTime", "TagsForSearch" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(2203), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "InsertTime", "TagsForSearch" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(2211), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "InsertTime", "TagsForSearch" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(2216), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "InsertTime", "TagsForSearch" },
                values: new object[] { new DateTime(2021, 10, 11, 18, 1, 9, 759, DateTimeKind.Local).AddTicks(2221), null });

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
    }
}
