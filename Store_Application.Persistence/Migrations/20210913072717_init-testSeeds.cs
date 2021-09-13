using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store_Application.Persistence.Migrations
{
    public partial class inittestSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BrandSlides",
                columns: new[] { "Id", "ImageName", "InsertTime", "LinkTo", "RemovedTime", "Title", "UpdateTime", "isRemoved" },
                values: new object[,]
                {
                    { 3, "752ed3efe90e41b78fce90b68abb2bdf.png", new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(1423), null, null, "ای دیتا", null, false },
                    { 8, "c964b9f4ac4540889fc15227a0cb5aea.png", new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(1453), null, null, "Shahab", null, false },
                    { 7, "752ed3efe90e41b78fce90b68abb2bdf.png", new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(1448), null, null, "ای دیتا", null, false },
                    { 6, "8e67672e408d431da4f5710184ca8add.png", new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(1443), null, null, "سامسونگ", null, false },
                    { 5, "c1aae97de6894801b50b379fdf75e78d.png", new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(1434), null, null, "هواوی", null, false },
                    { 4, "c964b9f4ac4540889fc15227a0cb5aea.png", new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(1429), null, null, "Shahab", null, false },
                    { 2, "8e67672e408d431da4f5710184ca8add.png", new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(1401), null, null, "سامسونگ", null, false },
                    { 1, "c1aae97de6894801b50b379fdf75e78d.png", new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(9718), null, null, "هواوی", null, false }
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertTime", "Title" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(2064), "سامسونگ" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "InsertTime", "RemovedTime", "Title", "UpdateTime", "isRemoved" },
                values: new object[,]
                {
                    { 4, new DateTime(2021, 9, 13, 11, 57, 15, 729, DateTimeKind.Local).AddTicks(6801), null, "بدون برند", null, false },
                    { 3, new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(2096), null, "نوکیا", null, false },
                    { 2, new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(2089), null, "اپل", null, false }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImageName", "InsertTime", "ParentCategoryId", "RemovedTime", "Title", "UpdateTime", "isRemoved" },
                values: new object[,]
                {
                    { 7, null, new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4386), null, null, "کودک و نوزاد", null, false },
                    { 1, null, new DateTime(2021, 9, 13, 11, 57, 15, 766, DateTimeKind.Local).AddTicks(3275), null, null, "کالای دیجیتال", null, false },
                    { 2, null, new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4316), null, null, "آرایشی و بهداشتی", null, false },
                    { 3, null, new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4366), null, null, "ابزار و اداری", null, false },
                    { 6, null, new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4381), null, null, "لوازم تحریر و هنر", null, false },
                    { 5, null, new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4376), null, null, "خانه و آشپزخانه", null, false },
                    { 4, null, new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4371), null, null, "مد و پوشاک", null, false }
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "InsertTime", "RemovedTime", "Title", "UpdateTime", "isRemoved" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(3303), null, "سیستم عامل", null, false },
                    { 6, new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(3948), null, "دوربین جلو", null, false },
                    { 5, new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(3940), null, "دوبین عقب", null, false },
                    { 4, new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(3935), null, "بلوتوث", null, false },
                    { 3, new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(3929), null, "ورژن سیستم عامل", null, false },
                    { 2, new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(3910), null, "رنگ", null, false }
                });

            migrationBuilder.InsertData(
                table: "MainSlides",
                columns: new[] { "Id", "ImageName", "InsertTime", "LinkTo", "RemovedTime", "Title", "UpdateTime", "isRemoved" },
                values: new object[,]
                {
                    { 1, "a866effd8dc64a4e91a4a1a024629166.jpg", new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(6454), null, null, "اسلایدر تستی 1", null, false },
                    { 2, "7494777a77864093a32ee9984c0a6520.jpg", new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(8257), null, null, "اسلایدر تستی 2", null, false },
                    { 3, "6d9a11244f8f4bd8a614b81f2e702799.jpg", new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(8278), null, null, "اسلایدر تستی 3", null, false }
                });

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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ActiveCode", "Address", "Email", "FullName", "InsertTime", "Password", "Phone", "RemovedTime", "RoleId", "UpdateTime", "Username", "age", "isActive", "isRemoved" },
                values: new object[,]
                {
                    { 4, "0a673b10-6681-4342-a410-e5e979df65a1", null, "mohammad@gmail.com", "محمد", new DateTime(2021, 9, 13, 11, 57, 15, 766, DateTimeKind.Local).AddTicks(891), "25-D5-5A-D2-83-AA-40-0A-F4-64-C7-6D-71-3C-07-AD", null, null, 3, null, "mmd", null, true, false },
                    { 3, "94c42a50-abfe-4ed2-8be5-5fa0b2576010", null, "ali@gmail.com", "علی", new DateTime(2021, 9, 13, 11, 57, 15, 766, DateTimeKind.Local).AddTicks(821), "25-D5-5A-D2-83-AA-40-0A-F4-64-C7-6D-71-3C-07-AD", null, null, 3, null, "Ali", null, true, false },
                    { 1, "2194d334-662f-4c93-a1e2-19c07f69d103", null, "mahdinjf372@gmail.com", "مهدی نجفی پسند", new DateTime(2021, 9, 13, 11, 57, 15, 736, DateTimeKind.Local).AddTicks(9515), "25-D5-5A-D2-83-AA-40-0A-F4-64-C7-6D-71-3C-07-AD", null, null, 1, null, "mahdinjf372", null, true, false },
                    { 5, "37e3fc24-9820-40af-9da9-5ae1ecaa47a0", null, "ehsan@gmail.com", "احسان", new DateTime(2021, 9, 13, 11, 57, 15, 766, DateTimeKind.Local).AddTicks(953), "25-D5-5A-D2-83-AA-40-0A-F4-64-C7-6D-71-3C-07-AD", null, null, 3, null, "Ehsan", null, true, false },
                    { 2, "69283c77-1b1d-4498-bc28-304cc63a6ba5", null, "sara@gmail.com", "سارا", new DateTime(2021, 9, 13, 11, 57, 15, 765, DateTimeKind.Local).AddTicks(9643), "25-D5-5A-D2-83-AA-40-0A-F4-64-C7-6D-71-3C-07-AD", null, null, 3, null, "Sara", null, true, false }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImageName", "InsertTime", "ParentCategoryId", "RemovedTime", "Title", "UpdateTime", "isRemoved" },
                values: new object[,]
                {
                    { 8, null, new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(3980), 1, null, "لپ تاپ", null, false },
                    { 9, null, new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4093), 1, null, "موبایل", null, false },
                    { 10, null, new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4294), 1, null, "دوربین", null, false },
                    { 22, null, new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4321), 2, null, "لوازم آرایشی", null, false },
                    { 26, null, new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4345), 2, null, "لوازم شخصی برقی", null, false }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImageName", "InsertTime", "ParentCategoryId", "RemovedTime", "Title", "UpdateTime", "isRemoved" },
                values: new object[,]
                {
                    { 11, null, new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4063), 8, null, "ایسوس", null, false },
                    { 27, null, new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4350), 26, null, "ماشین اصلاح صورت", null, false },
                    { 25, null, new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4339), 22, null, "آرایش چشم", null, false },
                    { 24, null, new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4334), 22, null, "آرایش لب", null, false },
                    { 23, null, new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4328), 22, null, "آرایش چشم و ابرو", null, false },
                    { 21, null, new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4310), 10, null, "متفرقه", null, false },
                    { 20, null, new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4305), 10, null, "سامسونگ", null, false },
                    { 28, null, new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4356), 26, null, "ماشین اصلاح سر", null, false },
                    { 19, null, new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4299), 10, null, "کنون", null, false },
                    { 17, null, new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4110), 9, null, "نوکیا", null, false },
                    { 16, null, new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4103), 9, null, "سامسونگ", null, false },
                    { 15, null, new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4098), 9, null, "اپل", null, false },
                    { 14, null, new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4087), 8, null, "ایسر", null, false },
                    { 13, null, new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4075), 8, null, "مایکروسافت", null, false },
                    { 12, null, new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4070), 8, null, "اپل", null, false },
                    { 18, null, new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4285), 9, null, "شیاومی", null, false },
                    { 29, null, new DateTime(2021, 9, 13, 11, 57, 15, 767, DateTimeKind.Local).AddTicks(4361), 26, null, "سشوار", null, false }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Description", "DiscountAmount", "Displayed", "InsertTime", "Inventory", "Price", "RemovedTime", "ShortDescription", "Title", "UpdateTime", "isRemoved" },
                values: new object[,]
                {
                    { 1, 1, 11, "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/84a990c5-6102-4bd2-b587-76be3df30835.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/86e0699c-e0e0-401e-bdc3-84f3b5221258.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6154596f-bc8e-4019-b13f-1c8e4dd94aef.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6e677979-65a3-4f8e-ba50-e80fbc53dbf5.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/c84c5779-be7e-4611-a384-c2b4f54c0d31.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/4c9c6d5a-7d86-4c77-a8ea-467358b61fba.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", 1000000m, true, new DateTime(2021, 9, 13, 11, 57, 15, 768, DateTimeKind.Local).AddTicks(5426), 15, 20000000m, null, "اولین گوشی همراه سری گلکسی نوت در سال 2011 روانه بازار شد تا خانواده افسانه‌ای نوت را برای اولین بار به دنیا معرفی و تعریفی نو برای محصولات «فبلت‌» ارائه کند. حدود 8 سال پس از آن، سامسونگ برای عرضه عضو جدید خانواده نوت(Galaxy Note 10) با چالش‌های جدیدی مواجه است؛ این چالش‌ها ویژگی‌های مدرنی هستند که در محصولات رقیب دیده می‌شوند.گلکسی نوت‌ها به‌طور عمومی شبیه سری Galaxy S هستند؛ با این تفاوت که صفحه‌نمایش بزرگ‌تر و یک قلم دیجیتال S Pen دارند.گوشی موبایل Samsung Galaxy Note10 با دوربین سه گانه در قاب پشتی روانه بازار شده است؛ این سه سنسور با داشتن ویژگی‌هایی مانند لرزشگیر تصویر و قابلیت فیلم‌برداری 4K خروجی تصویر مطلوبی را برای جدیدترین عضو خانواده Note به همراه دارند.پردازش محاسبات در این تازه‌وارد از طریق تراشه‌ی Exynos 9825 انجام می‌شود که در رده تراشه‌های 7 نانومتری قرار می‌گیرد و با سرعت بالای خود، گلکسی نوت 10 را برای انجام کارهای بسیار سنگین کاربردی کرده است.تراشه‌ی گرافیکی Mali - G76 هم در اجرای بازی‌های سنگین و پردازش‌های گرافیکی، گلکسی نوت 10 را سربلند خواهد بود. صفحه‌نمایش سوپر آمولد با رزولوشن 1080 در 2280 و قابلیت نمایش 401 پیکسل در هر اینچ، تجربه‌ی تصویری شفاف و بسیار مطلوب را برای کاربران فراهم می‌کند.نسخه 256 گیگابایتی گوشی گلکسی نوت 10 با 8 گیگابایت رم عرضه شده است تا میزان مطلوبی از فضا و حافظه تصادفی را در اختیار کاربر قرار دهد.حسگر اثرانگشت زیرصفحه‌نمایش، حسگر فشارسنج و ژیروسکوپ تنها تعدادی از امکانات این دستگاه قدرتمند است و کار را برای رقبای این محصول بزرگ سخت کرده است.البته در این محصول خبری از سنسور عنبیه چشم و خروجی 3.5 میلی‌متری صدا نیست که دلیل آن را می‌توان در بزرگ شدن قاب و ظرافت در طراحی و ساخت جست‌وجو کرد. گفتنی است، باتری این محصول از نوع غیرقابل تعویض و لیتیوم‌یون با ظرفیت 3500 میلی‌آمپر ساعت است که از فناوری‌های شارژ سریع و شارژ بی‌سیم پشتیبانی می‌کند.این محصول قادر است دستگاه‌های دیگر را هم به‌صورت بی‌سیم شارژ کند و از این طریق نقش یک پاوربانک را هم ایفا کند.", "سامسونگ مدل Galaxy Note 10 SM-N970F/DS دو سیم‌کارت ظرفیت 256 گیگابایت", null, false },
                    { 3, 3, 11, "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/84a990c5-6102-4bd2-b587-76be3df30835.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/86e0699c-e0e0-401e-bdc3-84f3b5221258.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6154596f-bc8e-4019-b13f-1c8e4dd94aef.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6e677979-65a3-4f8e-ba50-e80fbc53dbf5.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/c84c5779-be7e-4611-a384-c2b4f54c0d31.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/4c9c6d5a-7d86-4c77-a8ea-467358b61fba.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", 610000m, true, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(222), 5, 6000000m, null, "اولین گوشی همراه سری گلکسی نوت در سال 2011 روانه بازار شد تا خانواده افسانه‌ای نوت را برای اولین بار به دنیا معرفی و تعریفی نو برای محصولات «فبلت‌» ارائه کند. حدود 8 سال پس از آن، سامسونگ برای عرضه عضو جدید خانواده نوت(Galaxy Note 10) با چالش‌های جدیدی مواجه است؛ این چالش‌ها ویژگی‌های مدرنی هستند که در محصولات رقیب دیده می‌شوند.گلکسی نوت‌ها به‌طور عمومی شبیه سری Galaxy S هستند؛ با این تفاوت که صفحه‌نمایش بزرگ‌تر و یک قلم دیجیتال S Pen دارند.گوشی موبایل Samsung Galaxy Note10 با دوربین سه گانه در قاب پشتی روانه بازار شده است؛ این سه سنسور با داشتن ویژگی‌هایی مانند لرزشگیر تصویر و قابلیت فیلم‌برداری 4K خروجی تصویر مطلوبی را برای جدیدترین عضو خانواده Note به همراه دارند.پردازش محاسبات در این تازه‌وارد از طریق تراشه‌ی Exynos 9825 انجام می‌شود که در رده تراشه‌های 7 نانومتری قرار می‌گیرد و با سرعت بالای خود، گلکسی نوت 10 را برای انجام کارهای بسیار سنگین کاربردی کرده است.تراشه‌ی گرافیکی Mali - G76 هم در اجرای بازی‌های سنگین و پردازش‌های گرافیکی، گلکسی نوت 10 را سربلند خواهد بود. صفحه‌نمایش سوپر آمولد با رزولوشن 1080 در 2280 و قابلیت نمایش 401 پیکسل در هر اینچ، تجربه‌ی تصویری شفاف و بسیار مطلوب را برای کاربران فراهم می‌کند.نسخه 256 گیگابایتی گوشی گلکسی نوت 10 با 8 گیگابایت رم عرضه شده است تا میزان مطلوبی از فضا و حافظه تصادفی را در اختیار کاربر قرار دهد.حسگر اثرانگشت زیرصفحه‌نمایش، حسگر فشارسنج و ژیروسکوپ تنها تعدادی از امکانات این دستگاه قدرتمند است و کار را برای رقبای این محصول بزرگ سخت کرده است.البته در این محصول خبری از سنسور عنبیه چشم و خروجی 3.5 میلی‌متری صدا نیست که دلیل آن را می‌توان در بزرگ شدن قاب و ظرافت در طراحی و ساخت جست‌وجو کرد. گفتنی است، باتری این محصول از نوع غیرقابل تعویض و لیتیوم‌یون با ظرفیت 3500 میلی‌آمپر ساعت است که از فناوری‌های شارژ سریع و شارژ بی‌سیم پشتیبانی می‌کند.این محصول قادر است دستگاه‌های دیگر را هم به‌صورت بی‌سیم شارژ کند و از این طریق نقش یک پاوربانک را هم ایفا کند.", "سامسونگ مدل Galaxy Note 10 SM-N970F/DS دو سیم‌کارت ظرفیت 256 گیگابایت", null, false },
                    { 7, 1, 11, "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/84a990c5-6102-4bd2-b587-76be3df30835.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/86e0699c-e0e0-401e-bdc3-84f3b5221258.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6154596f-bc8e-4019-b13f-1c8e4dd94aef.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6e677979-65a3-4f8e-ba50-e80fbc53dbf5.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/c84c5779-be7e-4611-a384-c2b4f54c0d31.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/4c9c6d5a-7d86-4c77-a8ea-467358b61fba.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", 1100000m, true, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(336), 15, 22000000m, null, "اولین گوشی همراه سری گلکسی نوت در سال 2011 روانه بازار شد تا خانواده افسانه‌ای نوت را برای اولین بار به دنیا معرفی و تعریفی نو برای محصولات «فبلت‌» ارائه کند. حدود 8 سال پس از آن، سامسونگ برای عرضه عضو جدید خانواده نوت(Galaxy Note 10) با چالش‌های جدیدی مواجه است؛ این چالش‌ها ویژگی‌های مدرنی هستند که در محصولات رقیب دیده می‌شوند.گلکسی نوت‌ها به‌طور عمومی شبیه سری Galaxy S هستند؛ با این تفاوت که صفحه‌نمایش بزرگ‌تر و یک قلم دیجیتال S Pen دارند.گوشی موبایل Samsung Galaxy Note10 با دوربین سه گانه در قاب پشتی روانه بازار شده است؛ این سه سنسور با داشتن ویژگی‌هایی مانند لرزشگیر تصویر و قابلیت فیلم‌برداری 4K خروجی تصویر مطلوبی را برای جدیدترین عضو خانواده Note به همراه دارند.پردازش محاسبات در این تازه‌وارد از طریق تراشه‌ی Exynos 9825 انجام می‌شود که در رده تراشه‌های 7 نانومتری قرار می‌گیرد و با سرعت بالای خود، گلکسی نوت 10 را برای انجام کارهای بسیار سنگین کاربردی کرده است.تراشه‌ی گرافیکی Mali - G76 هم در اجرای بازی‌های سنگین و پردازش‌های گرافیکی، گلکسی نوت 10 را سربلند خواهد بود. صفحه‌نمایش سوپر آمولد با رزولوشن 1080 در 2280 و قابلیت نمایش 401 پیکسل در هر اینچ، تجربه‌ی تصویری شفاف و بسیار مطلوب را برای کاربران فراهم می‌کند.نسخه 256 گیگابایتی گوشی گلکسی نوت 10 با 8 گیگابایت رم عرضه شده است تا میزان مطلوبی از فضا و حافظه تصادفی را در اختیار کاربر قرار دهد.حسگر اثرانگشت زیرصفحه‌نمایش، حسگر فشارسنج و ژیروسکوپ تنها تعدادی از امکانات این دستگاه قدرتمند است و کار را برای رقبای این محصول بزرگ سخت کرده است.البته در این محصول خبری از سنسور عنبیه چشم و خروجی 3.5 میلی‌متری صدا نیست که دلیل آن را می‌توان در بزرگ شدن قاب و ظرافت در طراحی و ساخت جست‌وجو کرد. گفتنی است، باتری این محصول از نوع غیرقابل تعویض و لیتیوم‌یون با ظرفیت 3500 میلی‌آمپر ساعت است که از فناوری‌های شارژ سریع و شارژ بی‌سیم پشتیبانی می‌کند.این محصول قادر است دستگاه‌های دیگر را هم به‌صورت بی‌سیم شارژ کند و از این طریق نقش یک پاوربانک را هم ایفا کند.", "اپل آیفون ایکس اس مکس – 256 گیگابایت – دو سیم کارت", null, false },
                    { 4, 1, 12, "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/84a990c5-6102-4bd2-b587-76be3df30835.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/86e0699c-e0e0-401e-bdc3-84f3b5221258.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6154596f-bc8e-4019-b13f-1c8e4dd94aef.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6e677979-65a3-4f8e-ba50-e80fbc53dbf5.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/c84c5779-be7e-4611-a384-c2b4f54c0d31.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/4c9c6d5a-7d86-4c77-a8ea-467358b61fba.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", 5600000m, true, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(229), 15, 1200000m, null, "اولین گوشی همراه سری گلکسی نوت در سال 2011 روانه بازار شد تا خانواده افسانه‌ای نوت را برای اولین بار به دنیا معرفی و تعریفی نو برای محصولات «فبلت‌» ارائه کند. حدود 8 سال پس از آن، سامسونگ برای عرضه عضو جدید خانواده نوت(Galaxy Note 10) با چالش‌های جدیدی مواجه است؛ این چالش‌ها ویژگی‌های مدرنی هستند که در محصولات رقیب دیده می‌شوند.گلکسی نوت‌ها به‌طور عمومی شبیه سری Galaxy S هستند؛ با این تفاوت که صفحه‌نمایش بزرگ‌تر و یک قلم دیجیتال S Pen دارند.گوشی موبایل Samsung Galaxy Note10 با دوربین سه گانه در قاب پشتی روانه بازار شده است؛ این سه سنسور با داشتن ویژگی‌هایی مانند لرزشگیر تصویر و قابلیت فیلم‌برداری 4K خروجی تصویر مطلوبی را برای جدیدترین عضو خانواده Note به همراه دارند.پردازش محاسبات در این تازه‌وارد از طریق تراشه‌ی Exynos 9825 انجام می‌شود که در رده تراشه‌های 7 نانومتری قرار می‌گیرد و با سرعت بالای خود، گلکسی نوت 10 را برای انجام کارهای بسیار سنگین کاربردی کرده است.تراشه‌ی گرافیکی Mali - G76 هم در اجرای بازی‌های سنگین و پردازش‌های گرافیکی، گلکسی نوت 10 را سربلند خواهد بود. صفحه‌نمایش سوپر آمولد با رزولوشن 1080 در 2280 و قابلیت نمایش 401 پیکسل در هر اینچ، تجربه‌ی تصویری شفاف و بسیار مطلوب را برای کاربران فراهم می‌کند.نسخه 256 گیگابایتی گوشی گلکسی نوت 10 با 8 گیگابایت رم عرضه شده است تا میزان مطلوبی از فضا و حافظه تصادفی را در اختیار کاربر قرار دهد.حسگر اثرانگشت زیرصفحه‌نمایش، حسگر فشارسنج و ژیروسکوپ تنها تعدادی از امکانات این دستگاه قدرتمند است و کار را برای رقبای این محصول بزرگ سخت کرده است.البته در این محصول خبری از سنسور عنبیه چشم و خروجی 3.5 میلی‌متری صدا نیست که دلیل آن را می‌توان در بزرگ شدن قاب و ظرافت در طراحی و ساخت جست‌وجو کرد. گفتنی است، باتری این محصول از نوع غیرقابل تعویض و لیتیوم‌یون با ظرفیت 3500 میلی‌آمپر ساعت است که از فناوری‌های شارژ سریع و شارژ بی‌سیم پشتیبانی می‌کند.این محصول قادر است دستگاه‌های دیگر را هم به‌صورت بی‌سیم شارژ کند و از این طریق نقش یک پاوربانک را هم ایفا کند.", "اپل آیفون ایکس اس مکس – 256 گیگابایت – دو سیم کارت", null, false },
                    { 5, 1, 12, "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/84a990c5-6102-4bd2-b587-76be3df30835.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/86e0699c-e0e0-401e-bdc3-84f3b5221258.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6154596f-bc8e-4019-b13f-1c8e4dd94aef.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6e677979-65a3-4f8e-ba50-e80fbc53dbf5.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/c84c5779-be7e-4611-a384-c2b4f54c0d31.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/4c9c6d5a-7d86-4c77-a8ea-467358b61fba.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", 100000m, true, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(316), 5, 1300000m, null, "اولین گوشی همراه سری گلکسی نوت در سال 2011 روانه بازار شد تا خانواده افسانه‌ای نوت را برای اولین بار به دنیا معرفی و تعریفی نو برای محصولات «فبلت‌» ارائه کند. حدود 8 سال پس از آن، سامسونگ برای عرضه عضو جدید خانواده نوت(Galaxy Note 10) با چالش‌های جدیدی مواجه است؛ این چالش‌ها ویژگی‌های مدرنی هستند که در محصولات رقیب دیده می‌شوند.گلکسی نوت‌ها به‌طور عمومی شبیه سری Galaxy S هستند؛ با این تفاوت که صفحه‌نمایش بزرگ‌تر و یک قلم دیجیتال S Pen دارند.گوشی موبایل Samsung Galaxy Note10 با دوربین سه گانه در قاب پشتی روانه بازار شده است؛ این سه سنسور با داشتن ویژگی‌هایی مانند لرزشگیر تصویر و قابلیت فیلم‌برداری 4K خروجی تصویر مطلوبی را برای جدیدترین عضو خانواده Note به همراه دارند.پردازش محاسبات در این تازه‌وارد از طریق تراشه‌ی Exynos 9825 انجام می‌شود که در رده تراشه‌های 7 نانومتری قرار می‌گیرد و با سرعت بالای خود، گلکسی نوت 10 را برای انجام کارهای بسیار سنگین کاربردی کرده است.تراشه‌ی گرافیکی Mali - G76 هم در اجرای بازی‌های سنگین و پردازش‌های گرافیکی، گلکسی نوت 10 را سربلند خواهد بود. صفحه‌نمایش سوپر آمولد با رزولوشن 1080 در 2280 و قابلیت نمایش 401 پیکسل در هر اینچ، تجربه‌ی تصویری شفاف و بسیار مطلوب را برای کاربران فراهم می‌کند.نسخه 256 گیگابایتی گوشی گلکسی نوت 10 با 8 گیگابایت رم عرضه شده است تا میزان مطلوبی از فضا و حافظه تصادفی را در اختیار کاربر قرار دهد.حسگر اثرانگشت زیرصفحه‌نمایش، حسگر فشارسنج و ژیروسکوپ تنها تعدادی از امکانات این دستگاه قدرتمند است و کار را برای رقبای این محصول بزرگ سخت کرده است.البته در این محصول خبری از سنسور عنبیه چشم و خروجی 3.5 میلی‌متری صدا نیست که دلیل آن را می‌توان در بزرگ شدن قاب و ظرافت در طراحی و ساخت جست‌وجو کرد. گفتنی است، باتری این محصول از نوع غیرقابل تعویض و لیتیوم‌یون با ظرفیت 3500 میلی‌آمپر ساعت است که از فناوری‌های شارژ سریع و شارژ بی‌سیم پشتیبانی می‌کند.این محصول قادر است دستگاه‌های دیگر را هم به‌صورت بی‌سیم شارژ کند و از این طریق نقش یک پاوربانک را هم ایفا کند.", "اپل آیفون ایکس اس مکس – 256 گیگابایت – دو سیم کارت", null, false },
                    { 9, 1, 12, "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/84a990c5-6102-4bd2-b587-76be3df30835.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/86e0699c-e0e0-401e-bdc3-84f3b5221258.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6154596f-bc8e-4019-b13f-1c8e4dd94aef.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6e677979-65a3-4f8e-ba50-e80fbc53dbf5.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/c84c5779-be7e-4611-a384-c2b4f54c0d31.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/4c9c6d5a-7d86-4c77-a8ea-467358b61fba.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", 800000m, true, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(351), 5, 1900000m, null, "اولین گوشی همراه سری گلکسی نوت در سال 2011 روانه بازار شد تا خانواده افسانه‌ای نوت را برای اولین بار به دنیا معرفی و تعریفی نو برای محصولات «فبلت‌» ارائه کند. حدود 8 سال پس از آن، سامسونگ برای عرضه عضو جدید خانواده نوت(Galaxy Note 10) با چالش‌های جدیدی مواجه است؛ این چالش‌ها ویژگی‌های مدرنی هستند که در محصولات رقیب دیده می‌شوند.گلکسی نوت‌ها به‌طور عمومی شبیه سری Galaxy S هستند؛ با این تفاوت که صفحه‌نمایش بزرگ‌تر و یک قلم دیجیتال S Pen دارند.گوشی موبایل Samsung Galaxy Note10 با دوربین سه گانه در قاب پشتی روانه بازار شده است؛ این سه سنسور با داشتن ویژگی‌هایی مانند لرزشگیر تصویر و قابلیت فیلم‌برداری 4K خروجی تصویر مطلوبی را برای جدیدترین عضو خانواده Note به همراه دارند.پردازش محاسبات در این تازه‌وارد از طریق تراشه‌ی Exynos 9825 انجام می‌شود که در رده تراشه‌های 7 نانومتری قرار می‌گیرد و با سرعت بالای خود، گلکسی نوت 10 را برای انجام کارهای بسیار سنگین کاربردی کرده است.تراشه‌ی گرافیکی Mali - G76 هم در اجرای بازی‌های سنگین و پردازش‌های گرافیکی، گلکسی نوت 10 را سربلند خواهد بود. صفحه‌نمایش سوپر آمولد با رزولوشن 1080 در 2280 و قابلیت نمایش 401 پیکسل در هر اینچ، تجربه‌ی تصویری شفاف و بسیار مطلوب را برای کاربران فراهم می‌کند.نسخه 256 گیگابایتی گوشی گلکسی نوت 10 با 8 گیگابایت رم عرضه شده است تا میزان مطلوبی از فضا و حافظه تصادفی را در اختیار کاربر قرار دهد.حسگر اثرانگشت زیرصفحه‌نمایش، حسگر فشارسنج و ژیروسکوپ تنها تعدادی از امکانات این دستگاه قدرتمند است و کار را برای رقبای این محصول بزرگ سخت کرده است.البته در این محصول خبری از سنسور عنبیه چشم و خروجی 3.5 میلی‌متری صدا نیست که دلیل آن را می‌توان در بزرگ شدن قاب و ظرافت در طراحی و ساخت جست‌وجو کرد. گفتنی است، باتری این محصول از نوع غیرقابل تعویض و لیتیوم‌یون با ظرفیت 3500 میلی‌آمپر ساعت است که از فناوری‌های شارژ سریع و شارژ بی‌سیم پشتیبانی می‌کند.این محصول قادر است دستگاه‌های دیگر را هم به‌صورت بی‌سیم شارژ کند و از این طریق نقش یک پاوربانک را هم ایفا کند.", "اپل آیفون ایکس اس مکس – 256 گیگابایت – دو سیم کارت", null, false },
                    { 12, 1, 12, "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/84a990c5-6102-4bd2-b587-76be3df30835.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/86e0699c-e0e0-401e-bdc3-84f3b5221258.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6154596f-bc8e-4019-b13f-1c8e4dd94aef.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6e677979-65a3-4f8e-ba50-e80fbc53dbf5.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/c84c5779-be7e-4611-a384-c2b4f54c0d31.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/4c9c6d5a-7d86-4c77-a8ea-467358b61fba.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", 6500000m, true, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(371), 5, 15000000m, null, "اولین گوشی همراه سری گلکسی نوت در سال 2011 روانه بازار شد تا خانواده افسانه‌ای نوت را برای اولین بار به دنیا معرفی و تعریفی نو برای محصولات «فبلت‌» ارائه کند. حدود 8 سال پس از آن، سامسونگ برای عرضه عضو جدید خانواده نوت(Galaxy Note 10) با چالش‌های جدیدی مواجه است؛ این چالش‌ها ویژگی‌های مدرنی هستند که در محصولات رقیب دیده می‌شوند.گلکسی نوت‌ها به‌طور عمومی شبیه سری Galaxy S هستند؛ با این تفاوت که صفحه‌نمایش بزرگ‌تر و یک قلم دیجیتال S Pen دارند.گوشی موبایل Samsung Galaxy Note10 با دوربین سه گانه در قاب پشتی روانه بازار شده است؛ این سه سنسور با داشتن ویژگی‌هایی مانند لرزشگیر تصویر و قابلیت فیلم‌برداری 4K خروجی تصویر مطلوبی را برای جدیدترین عضو خانواده Note به همراه دارند.پردازش محاسبات در این تازه‌وارد از طریق تراشه‌ی Exynos 9825 انجام می‌شود که در رده تراشه‌های 7 نانومتری قرار می‌گیرد و با سرعت بالای خود، گلکسی نوت 10 را برای انجام کارهای بسیار سنگین کاربردی کرده است.تراشه‌ی گرافیکی Mali - G76 هم در اجرای بازی‌های سنگین و پردازش‌های گرافیکی، گلکسی نوت 10 را سربلند خواهد بود. صفحه‌نمایش سوپر آمولد با رزولوشن 1080 در 2280 و قابلیت نمایش 401 پیکسل در هر اینچ، تجربه‌ی تصویری شفاف و بسیار مطلوب را برای کاربران فراهم می‌کند.نسخه 256 گیگابایتی گوشی گلکسی نوت 10 با 8 گیگابایت رم عرضه شده است تا میزان مطلوبی از فضا و حافظه تصادفی را در اختیار کاربر قرار دهد.حسگر اثرانگشت زیرصفحه‌نمایش، حسگر فشارسنج و ژیروسکوپ تنها تعدادی از امکانات این دستگاه قدرتمند است و کار را برای رقبای این محصول بزرگ سخت کرده است.البته در این محصول خبری از سنسور عنبیه چشم و خروجی 3.5 میلی‌متری صدا نیست که دلیل آن را می‌توان در بزرگ شدن قاب و ظرافت در طراحی و ساخت جست‌وجو کرد. گفتنی است، باتری این محصول از نوع غیرقابل تعویض و لیتیوم‌یون با ظرفیت 3500 میلی‌آمپر ساعت است که از فناوری‌های شارژ سریع و شارژ بی‌سیم پشتیبانی می‌کند.این محصول قادر است دستگاه‌های دیگر را هم به‌صورت بی‌سیم شارژ کند و از این طریق نقش یک پاوربانک را هم ایفا کند.", "اپل آیفون ایکس اس مکس – 256 گیگابایت – دو سیم کارت", null, false },
                    { 2, 2, 13, "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/84a990c5-6102-4bd2-b587-76be3df30835.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/86e0699c-e0e0-401e-bdc3-84f3b5221258.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6154596f-bc8e-4019-b13f-1c8e4dd94aef.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6e677979-65a3-4f8e-ba50-e80fbc53dbf5.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/c84c5779-be7e-4611-a384-c2b4f54c0d31.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/4c9c6d5a-7d86-4c77-a8ea-467358b61fba.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", 6500000m, true, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(198), 5, 15000000m, null, "اولین گوشی همراه سری گلکسی نوت در سال 2011 روانه بازار شد تا خانواده افسانه‌ای نوت را برای اولین بار به دنیا معرفی و تعریفی نو برای محصولات «فبلت‌» ارائه کند. حدود 8 سال پس از آن، سامسونگ برای عرضه عضو جدید خانواده نوت(Galaxy Note 10) با چالش‌های جدیدی مواجه است؛ این چالش‌ها ویژگی‌های مدرنی هستند که در محصولات رقیب دیده می‌شوند.گلکسی نوت‌ها به‌طور عمومی شبیه سری Galaxy S هستند؛ با این تفاوت که صفحه‌نمایش بزرگ‌تر و یک قلم دیجیتال S Pen دارند.گوشی موبایل Samsung Galaxy Note10 با دوربین سه گانه در قاب پشتی روانه بازار شده است؛ این سه سنسور با داشتن ویژگی‌هایی مانند لرزشگیر تصویر و قابلیت فیلم‌برداری 4K خروجی تصویر مطلوبی را برای جدیدترین عضو خانواده Note به همراه دارند.پردازش محاسبات در این تازه‌وارد از طریق تراشه‌ی Exynos 9825 انجام می‌شود که در رده تراشه‌های 7 نانومتری قرار می‌گیرد و با سرعت بالای خود، گلکسی نوت 10 را برای انجام کارهای بسیار سنگین کاربردی کرده است.تراشه‌ی گرافیکی Mali - G76 هم در اجرای بازی‌های سنگین و پردازش‌های گرافیکی، گلکسی نوت 10 را سربلند خواهد بود. صفحه‌نمایش سوپر آمولد با رزولوشن 1080 در 2280 و قابلیت نمایش 401 پیکسل در هر اینچ، تجربه‌ی تصویری شفاف و بسیار مطلوب را برای کاربران فراهم می‌کند.نسخه 256 گیگابایتی گوشی گلکسی نوت 10 با 8 گیگابایت رم عرضه شده است تا میزان مطلوبی از فضا و حافظه تصادفی را در اختیار کاربر قرار دهد.حسگر اثرانگشت زیرصفحه‌نمایش، حسگر فشارسنج و ژیروسکوپ تنها تعدادی از امکانات این دستگاه قدرتمند است و کار را برای رقبای این محصول بزرگ سخت کرده است.البته در این محصول خبری از سنسور عنبیه چشم و خروجی 3.5 میلی‌متری صدا نیست که دلیل آن را می‌توان در بزرگ شدن قاب و ظرافت در طراحی و ساخت جست‌وجو کرد. گفتنی است، باتری این محصول از نوع غیرقابل تعویض و لیتیوم‌یون با ظرفیت 3500 میلی‌آمپر ساعت است که از فناوری‌های شارژ سریع و شارژ بی‌سیم پشتیبانی می‌کند.این محصول قادر است دستگاه‌های دیگر را هم به‌صورت بی‌سیم شارژ کند و از این طریق نقش یک پاوربانک را هم ایفا کند.", "اپل آیفون ایکس اس مکس – 256 گیگابایت – دو سیم کارت", null, false },
                    { 6, 1, 13, "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/84a990c5-6102-4bd2-b587-76be3df30835.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/86e0699c-e0e0-401e-bdc3-84f3b5221258.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6154596f-bc8e-4019-b13f-1c8e4dd94aef.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6e677979-65a3-4f8e-ba50-e80fbc53dbf5.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/c84c5779-be7e-4611-a384-c2b4f54c0d31.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/4c9c6d5a-7d86-4c77-a8ea-467358b61fba.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", 10000m, true, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(330), 5, 18800000m, null, "اولین گوشی همراه سری گلکسی نوت در سال 2011 روانه بازار شد تا خانواده افسانه‌ای نوت را برای اولین بار به دنیا معرفی و تعریفی نو برای محصولات «فبلت‌» ارائه کند. حدود 8 سال پس از آن، سامسونگ برای عرضه عضو جدید خانواده نوت(Galaxy Note 10) با چالش‌های جدیدی مواجه است؛ این چالش‌ها ویژگی‌های مدرنی هستند که در محصولات رقیب دیده می‌شوند.گلکسی نوت‌ها به‌طور عمومی شبیه سری Galaxy S هستند؛ با این تفاوت که صفحه‌نمایش بزرگ‌تر و یک قلم دیجیتال S Pen دارند.گوشی موبایل Samsung Galaxy Note10 با دوربین سه گانه در قاب پشتی روانه بازار شده است؛ این سه سنسور با داشتن ویژگی‌هایی مانند لرزشگیر تصویر و قابلیت فیلم‌برداری 4K خروجی تصویر مطلوبی را برای جدیدترین عضو خانواده Note به همراه دارند.پردازش محاسبات در این تازه‌وارد از طریق تراشه‌ی Exynos 9825 انجام می‌شود که در رده تراشه‌های 7 نانومتری قرار می‌گیرد و با سرعت بالای خود، گلکسی نوت 10 را برای انجام کارهای بسیار سنگین کاربردی کرده است.تراشه‌ی گرافیکی Mali - G76 هم در اجرای بازی‌های سنگین و پردازش‌های گرافیکی، گلکسی نوت 10 را سربلند خواهد بود. صفحه‌نمایش سوپر آمولد با رزولوشن 1080 در 2280 و قابلیت نمایش 401 پیکسل در هر اینچ، تجربه‌ی تصویری شفاف و بسیار مطلوب را برای کاربران فراهم می‌کند.نسخه 256 گیگابایتی گوشی گلکسی نوت 10 با 8 گیگابایت رم عرضه شده است تا میزان مطلوبی از فضا و حافظه تصادفی را در اختیار کاربر قرار دهد.حسگر اثرانگشت زیرصفحه‌نمایش، حسگر فشارسنج و ژیروسکوپ تنها تعدادی از امکانات این دستگاه قدرتمند است و کار را برای رقبای این محصول بزرگ سخت کرده است.البته در این محصول خبری از سنسور عنبیه چشم و خروجی 3.5 میلی‌متری صدا نیست که دلیل آن را می‌توان در بزرگ شدن قاب و ظرافت در طراحی و ساخت جست‌وجو کرد. گفتنی است، باتری این محصول از نوع غیرقابل تعویض و لیتیوم‌یون با ظرفیت 3500 میلی‌آمپر ساعت است که از فناوری‌های شارژ سریع و شارژ بی‌سیم پشتیبانی می‌کند.این محصول قادر است دستگاه‌های دیگر را هم به‌صورت بی‌سیم شارژ کند و از این طریق نقش یک پاوربانک را هم ایفا کند.", "سامسونگ مدل Galaxy Note 10 SM-N970F/DS دو سیم‌کارت ظرفیت 256 گیگابایت", null, false },
                    { 8, 1, 13, "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/84a990c5-6102-4bd2-b587-76be3df30835.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/86e0699c-e0e0-401e-bdc3-84f3b5221258.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6154596f-bc8e-4019-b13f-1c8e4dd94aef.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6e677979-65a3-4f8e-ba50-e80fbc53dbf5.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/c84c5779-be7e-4611-a384-c2b4f54c0d31.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/4c9c6d5a-7d86-4c77-a8ea-467358b61fba.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", 6500000m, true, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(344), 5, 1600000m, null, "اولین گوشی همراه سری گلکسی نوت در سال 2011 روانه بازار شد تا خانواده افسانه‌ای نوت را برای اولین بار به دنیا معرفی و تعریفی نو برای محصولات «فبلت‌» ارائه کند. حدود 8 سال پس از آن، سامسونگ برای عرضه عضو جدید خانواده نوت(Galaxy Note 10) با چالش‌های جدیدی مواجه است؛ این چالش‌ها ویژگی‌های مدرنی هستند که در محصولات رقیب دیده می‌شوند.گلکسی نوت‌ها به‌طور عمومی شبیه سری Galaxy S هستند؛ با این تفاوت که صفحه‌نمایش بزرگ‌تر و یک قلم دیجیتال S Pen دارند.گوشی موبایل Samsung Galaxy Note10 با دوربین سه گانه در قاب پشتی روانه بازار شده است؛ این سه سنسور با داشتن ویژگی‌هایی مانند لرزشگیر تصویر و قابلیت فیلم‌برداری 4K خروجی تصویر مطلوبی را برای جدیدترین عضو خانواده Note به همراه دارند.پردازش محاسبات در این تازه‌وارد از طریق تراشه‌ی Exynos 9825 انجام می‌شود که در رده تراشه‌های 7 نانومتری قرار می‌گیرد و با سرعت بالای خود، گلکسی نوت 10 را برای انجام کارهای بسیار سنگین کاربردی کرده است.تراشه‌ی گرافیکی Mali - G76 هم در اجرای بازی‌های سنگین و پردازش‌های گرافیکی، گلکسی نوت 10 را سربلند خواهد بود. صفحه‌نمایش سوپر آمولد با رزولوشن 1080 در 2280 و قابلیت نمایش 401 پیکسل در هر اینچ، تجربه‌ی تصویری شفاف و بسیار مطلوب را برای کاربران فراهم می‌کند.نسخه 256 گیگابایتی گوشی گلکسی نوت 10 با 8 گیگابایت رم عرضه شده است تا میزان مطلوبی از فضا و حافظه تصادفی را در اختیار کاربر قرار دهد.حسگر اثرانگشت زیرصفحه‌نمایش، حسگر فشارسنج و ژیروسکوپ تنها تعدادی از امکانات این دستگاه قدرتمند است و کار را برای رقبای این محصول بزرگ سخت کرده است.البته در این محصول خبری از سنسور عنبیه چشم و خروجی 3.5 میلی‌متری صدا نیست که دلیل آن را می‌توان در بزرگ شدن قاب و ظرافت در طراحی و ساخت جست‌وجو کرد. گفتنی است، باتری این محصول از نوع غیرقابل تعویض و لیتیوم‌یون با ظرفیت 3500 میلی‌آمپر ساعت است که از فناوری‌های شارژ سریع و شارژ بی‌سیم پشتیبانی می‌کند.این محصول قادر است دستگاه‌های دیگر را هم به‌صورت بی‌سیم شارژ کند و از این طریق نقش یک پاوربانک را هم ایفا کند.", "سامسونگ مدل Galaxy Note 10 SM-N970F/DS دو سیم‌کارت ظرفیت 256 گیگابایت", null, false },
                    { 10, 1, 14, "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/84a990c5-6102-4bd2-b587-76be3df30835.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/86e0699c-e0e0-401e-bdc3-84f3b5221258.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6154596f-bc8e-4019-b13f-1c8e4dd94aef.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6e677979-65a3-4f8e-ba50-e80fbc53dbf5.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/c84c5779-be7e-4611-a384-c2b4f54c0d31.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/4c9c6d5a-7d86-4c77-a8ea-467358b61fba.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", 1000000m, true, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(358), 14, 20000000m, null, "اولین گوشی همراه سری گلکسی نوت در سال 2011 روانه بازار شد تا خانواده افسانه‌ای نوت را برای اولین بار به دنیا معرفی و تعریفی نو برای محصولات «فبلت‌» ارائه کند. حدود 8 سال پس از آن، سامسونگ برای عرضه عضو جدید خانواده نوت(Galaxy Note 10) با چالش‌های جدیدی مواجه است؛ این چالش‌ها ویژگی‌های مدرنی هستند که در محصولات رقیب دیده می‌شوند.گلکسی نوت‌ها به‌طور عمومی شبیه سری Galaxy S هستند؛ با این تفاوت که صفحه‌نمایش بزرگ‌تر و یک قلم دیجیتال S Pen دارند.گوشی موبایل Samsung Galaxy Note10 با دوربین سه گانه در قاب پشتی روانه بازار شده است؛ این سه سنسور با داشتن ویژگی‌هایی مانند لرزشگیر تصویر و قابلیت فیلم‌برداری 4K خروجی تصویر مطلوبی را برای جدیدترین عضو خانواده Note به همراه دارند.پردازش محاسبات در این تازه‌وارد از طریق تراشه‌ی Exynos 9825 انجام می‌شود که در رده تراشه‌های 7 نانومتری قرار می‌گیرد و با سرعت بالای خود، گلکسی نوت 10 را برای انجام کارهای بسیار سنگین کاربردی کرده است.تراشه‌ی گرافیکی Mali - G76 هم در اجرای بازی‌های سنگین و پردازش‌های گرافیکی، گلکسی نوت 10 را سربلند خواهد بود. صفحه‌نمایش سوپر آمولد با رزولوشن 1080 در 2280 و قابلیت نمایش 401 پیکسل در هر اینچ، تجربه‌ی تصویری شفاف و بسیار مطلوب را برای کاربران فراهم می‌کند.نسخه 256 گیگابایتی گوشی گلکسی نوت 10 با 8 گیگابایت رم عرضه شده است تا میزان مطلوبی از فضا و حافظه تصادفی را در اختیار کاربر قرار دهد.حسگر اثرانگشت زیرصفحه‌نمایش، حسگر فشارسنج و ژیروسکوپ تنها تعدادی از امکانات این دستگاه قدرتمند است و کار را برای رقبای این محصول بزرگ سخت کرده است.البته در این محصول خبری از سنسور عنبیه چشم و خروجی 3.5 میلی‌متری صدا نیست که دلیل آن را می‌توان در بزرگ شدن قاب و ظرافت در طراحی و ساخت جست‌وجو کرد. گفتنی است، باتری این محصول از نوع غیرقابل تعویض و لیتیوم‌یون با ظرفیت 3500 میلی‌آمپر ساعت است که از فناوری‌های شارژ سریع و شارژ بی‌سیم پشتیبانی می‌کند.این محصول قادر است دستگاه‌های دیگر را هم به‌صورت بی‌سیم شارژ کند و از این طریق نقش یک پاوربانک را هم ایفا کند.", "اپل آیفون ایکس اس مکس – 256 گیگابایت – دو سیم کارت", null, false },
                    { 11, 1, 14, "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/84a990c5-6102-4bd2-b587-76be3df30835.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/86e0699c-e0e0-401e-bdc3-84f3b5221258.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6154596f-bc8e-4019-b13f-1c8e4dd94aef.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6e677979-65a3-4f8e-ba50-e80fbc53dbf5.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/c84c5779-be7e-4611-a384-c2b4f54c0d31.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/4c9c6d5a-7d86-4c77-a8ea-467358b61fba.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>", 6500000m, true, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(364), 5, 15000000m, null, "اولین گوشی همراه سری گلکسی نوت در سال 2011 روانه بازار شد تا خانواده افسانه‌ای نوت را برای اولین بار به دنیا معرفی و تعریفی نو برای محصولات «فبلت‌» ارائه کند. حدود 8 سال پس از آن، سامسونگ برای عرضه عضو جدید خانواده نوت(Galaxy Note 10) با چالش‌های جدیدی مواجه است؛ این چالش‌ها ویژگی‌های مدرنی هستند که در محصولات رقیب دیده می‌شوند.گلکسی نوت‌ها به‌طور عمومی شبیه سری Galaxy S هستند؛ با این تفاوت که صفحه‌نمایش بزرگ‌تر و یک قلم دیجیتال S Pen دارند.گوشی موبایل Samsung Galaxy Note10 با دوربین سه گانه در قاب پشتی روانه بازار شده است؛ این سه سنسور با داشتن ویژگی‌هایی مانند لرزشگیر تصویر و قابلیت فیلم‌برداری 4K خروجی تصویر مطلوبی را برای جدیدترین عضو خانواده Note به همراه دارند.پردازش محاسبات در این تازه‌وارد از طریق تراشه‌ی Exynos 9825 انجام می‌شود که در رده تراشه‌های 7 نانومتری قرار می‌گیرد و با سرعت بالای خود، گلکسی نوت 10 را برای انجام کارهای بسیار سنگین کاربردی کرده است.تراشه‌ی گرافیکی Mali - G76 هم در اجرای بازی‌های سنگین و پردازش‌های گرافیکی، گلکسی نوت 10 را سربلند خواهد بود. صفحه‌نمایش سوپر آمولد با رزولوشن 1080 در 2280 و قابلیت نمایش 401 پیکسل در هر اینچ، تجربه‌ی تصویری شفاف و بسیار مطلوب را برای کاربران فراهم می‌کند.نسخه 256 گیگابایتی گوشی گلکسی نوت 10 با 8 گیگابایت رم عرضه شده است تا میزان مطلوبی از فضا و حافظه تصادفی را در اختیار کاربر قرار دهد.حسگر اثرانگشت زیرصفحه‌نمایش، حسگر فشارسنج و ژیروسکوپ تنها تعدادی از امکانات این دستگاه قدرتمند است و کار را برای رقبای این محصول بزرگ سخت کرده است.البته در این محصول خبری از سنسور عنبیه چشم و خروجی 3.5 میلی‌متری صدا نیست که دلیل آن را می‌توان در بزرگ شدن قاب و ظرافت در طراحی و ساخت جست‌وجو کرد. گفتنی است، باتری این محصول از نوع غیرقابل تعویض و لیتیوم‌یون با ظرفیت 3500 میلی‌آمپر ساعت است که از فناوری‌های شارژ سریع و شارژ بی‌سیم پشتیبانی می‌کند.این محصول قادر است دستگاه‌های دیگر را هم به‌صورت بی‌سیم شارژ کند و از این طریق نقش یک پاوربانک را هم ایفا کند.", "سامسونگ مدل Galaxy Note 10 SM-N970F/DS دو سیم‌کارت ظرفیت 256 گیگابایت", null, false }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "FeatureId", "InsertTime", "ProductId", "RemovedTime", "UpdateTime", "Value", "isBold", "isRemoved" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(9319), 1, null, null, "اندروید", true, false },
                    { 13, 5, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(903), 2, null, null, "40", true, false },
                    { 12, 1, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(897), 2, null, null, "دارد", true, false },
                    { 11, 3, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(892), 2, null, null, "10", true, false },
                    { 10, 2, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(886), 2, null, null, "مشکی", true, false },
                    { 9, 2, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(879), 2, null, null, "مشکی", true, false },
                    { 8, 1, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(874), 2, null, null, "اندروید", true, false },
                    { 121, 6, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1408), 12, null, null, "20", true, false },
                    { 120, 5, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1403), 12, null, null, "40", true, false },
                    { 119, 1, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1398), 12, null, null, "دارد", true, false },
                    { 118, 3, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1393), 12, null, null, "10", true, false },
                    { 117, 2, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1387), 12, null, null, "مشکی", true, false },
                    { 116, 2, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1382), 12, null, null, "مشکی", true, false },
                    { 115, 1, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1376), 12, null, null, "اندروید", true, false },
                    { 86, 6, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1295), 9, null, null, "20", true, false },
                    { 85, 5, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1290), 9, null, null, "40", true, false },
                    { 84, 1, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1285), 9, null, null, "دارد", true, false },
                    { 83, 3, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1280), 9, null, null, "10", true, false },
                    { 82, 2, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1274), 9, null, null, "مشکی", true, false },
                    { 81, 2, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1269), 9, null, null, "مشکی", true, false },
                    { 80, 1, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1261), 9, null, null, "اندروید", true, false },
                    { 46, 6, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1025), 5, null, null, "20", true, false },
                    { 45, 5, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1019), 5, null, null, "40", true, false },
                    { 44, 1, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1010), 5, null, null, "دارد", true, false },
                    { 43, 3, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1005), 5, null, null, "10", true, false },
                    { 42, 2, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(999), 5, null, null, "مشکی", true, false },
                    { 14, 6, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(908), 2, null, null, "20", true, false },
                    { 41, 2, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(994), 5, null, null, "مشکی", true, false },
                    { 55, 1, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1030), 6, null, null, "اندروید", true, false },
                    { 57, 2, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1040), 6, null, null, "مشکی", true, false },
                    { 114, 6, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1371), 11, null, null, "20", true, false },
                    { 113, 5, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1366), 11, null, null, "40", true, false },
                    { 112, 1, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1361), 11, null, null, "دارد", true, false },
                    { 110, 3, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1355), 11, null, null, "10", true, false },
                    { 102, 2, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1350), 11, null, null, "مشکی", true, false },
                    { 101, 2, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1345), 11, null, null, "مشکی", true, false },
                    { 100, 1, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1340), 11, null, null, "اندروید", true, false },
                    { 97, 6, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1335), 10, null, null, "20", true, false },
                    { 96, 5, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1329), 10, null, null, "40", true, false },
                    { 95, 1, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1324), 10, null, null, "دارد", true, false },
                    { 94, 3, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1319), 10, null, null, "10", true, false },
                    { 93, 2, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1313), 10, null, null, "مشکی", true, false }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "FeatureId", "InsertTime", "ProductId", "RemovedTime", "UpdateTime", "Value", "isBold", "isRemoved" },
                values: new object[,]
                {
                    { 92, 2, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1306), 10, null, null, "مشکی", true, false },
                    { 91, 1, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1300), 10, null, null, "اندروید", true, false },
                    { 78, 6, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1134), 8, null, null, "20", true, false },
                    { 77, 5, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1129), 8, null, null, "40", true, false },
                    { 76, 1, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1123), 8, null, null, "دارد", true, false },
                    { 75, 3, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1117), 8, null, null, "10", true, false },
                    { 74, 2, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1112), 8, null, null, "مشکی", true, false },
                    { 73, 2, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1107), 8, null, null, "مشکی", true, false },
                    { 72, 1, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1102), 8, null, null, "اندروید", true, false },
                    { 62, 6, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1061), 6, null, null, "20", true, false },
                    { 60, 5, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1056), 6, null, null, "40", true, false },
                    { 59, 1, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1050), 6, null, null, "دارد", true, false },
                    { 58, 3, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1045), 6, null, null, "10", true, false },
                    { 56, 2, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1035), 6, null, null, "مشکی", true, false },
                    { 40, 1, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(989), 5, null, null, "اندروید", true, false },
                    { 4, 1, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(855), 12, null, null, "دارد", true, false },
                    { 5, 5, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(863), 1, null, null, "40", true, false },
                    { 68, 1, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1087), 7, null, null, "دارد", true, false },
                    { 3, 3, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(850), 1, null, null, "10", true, false },
                    { 6, 2, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(844), 1, null, null, "مشکی", true, false },
                    { 25, 1, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(952), 4, null, null, "اندروید", true, false },
                    { 24, 2, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(958), 4, null, null, "مشکی", true, false },
                    { 26, 2, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(963), 4, null, null, "مشکی", true, false },
                    { 2, 2, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(824), 1, null, null, "مشکی", true, false },
                    { 70, 6, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1097), 7, null, null, "20", true, false },
                    { 69, 5, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1092), 7, null, null, "40", true, false },
                    { 21, 6, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(947), 3, null, null, "20", true, false },
                    { 7, 6, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(869), 1, null, null, "20", true, false },
                    { 19, 1, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(937), 3, null, null, "دارد", true, false },
                    { 20, 5, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(942), 3, null, null, "40", true, false },
                    { 27, 3, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(968), 4, null, null, "10", true, false },
                    { 28, 1, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(974), 4, null, null, "دارد", true, false },
                    { 29, 5, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(979), 4, null, null, "40", true, false },
                    { 30, 6, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(984), 4, null, null, "20", true, false },
                    { 17, 2, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(924), 3, null, null, "مشکی", true, false },
                    { 16, 2, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(919), 3, null, null, "مشکی", true, false },
                    { 15, 1, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(914), 3, null, null, "اندروید", true, false },
                    { 64, 1, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1066), 7, null, null, "اندروید", true, false },
                    { 65, 2, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1071), 7, null, null, "مشکی", true, false },
                    { 66, 2, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1076), 7, null, null, "مشکی", true, false },
                    { 67, 3, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(1082), 7, null, null, "10", true, false },
                    { 18, 3, new DateTime(2021, 9, 13, 11, 57, 15, 770, DateTimeKind.Local).AddTicks(931), 3, null, null, "10", true, false }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "InsertTime", "IsMainImage", "Name", "ProductId", "RemovedTime", "UpdateTime", "isRemoved" },
                values: new object[,]
                {
                    { 10, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7067), false, "product-img-note10-big-1.jpg", 2, null, null, false },
                    { 9, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7061), false, "product-img-note10-big-7.jpg", 2, null, null, false },
                    { 8, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7056), false, "product-img-note10-big-6.jpg", 2, null, null, false },
                    { 46, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7247), true, "Samsung-S10Plus.jpg", 10, null, null, false },
                    { 6, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7046), true, "iphone-xs-max-space.jpg", 2, null, null, false },
                    { 19, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7113), false, "product-img-note10-big-7.jpg", 4, null, null, false },
                    { 47, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7252), false, "product-img-note10-big-5.jpg", 10, null, null, false },
                    { 7, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7051), false, "product-img-note10-big-5.jpg", 2, null, null, false },
                    { 3, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7027), false, "product-img-note10-big-6.jpg", 1, null, null, false },
                    { 20, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7117), false, "product-img-note10-big-1.jpg", 4, null, null, false },
                    { 5, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7037), false, "product-img-note10-big-1.jpg", 1, null, null, false },
                    { 39, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7212), false, "product-img-note10-big-7.jpg", 8, null, null, false },
                    { 38, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7208), false, "product-img-note10-big-6.jpg", 8, null, null, false },
                    { 37, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7203), false, "product-img-note10-big-5.jpg", 8, null, null, false },
                    { 36, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7198), true, "iphone-xs-max-space.jpg", 8, null, null, false },
                    { 30, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7167), false, "product-img-note10-big-1.jpg", 6, null, null, false },
                    { 29, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7162), false, "product-img-note10-big-7.jpg", 6, null, null, false },
                    { 4, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7032), false, "product-img-note10-big-7.jpg", 1, null, null, false },
                    { 28, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7156), false, "product-img-note10-big-6.jpg", 6, null, null, false },
                    { 26, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7147), true, "honer.jpg", 6, null, null, false },
                    { 11, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7072), true, "honer.jpg", 3, null, null, false },
                    { 12, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7077), false, "product-img-note10-big-5.jpg", 3, null, null, false },
                    { 13, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7081), false, "product-img-note10-big-6.jpg", 3, null, null, false },
                    { 14, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7086), false, "product-img-note10-big-7.jpg", 3, null, null, false },
                    { 15, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7091), false, "product-img-note10-big-1.jpg", 3, null, null, false },
                    { 27, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7152), false, "product-img-note10-big-5.jpg", 6, null, null, false },
                    { 48, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7257), false, "product-img-note10-big-6.jpg", 10, null, null, false },
                    { 64, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7315), false, "product-img-note10-big-1.jpg", 12, null, null, false },
                    { 50, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7266), false, "product-img-note10-big-1.jpg", 10, null, null, false },
                    { 43, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7232), false, "product-img-note10-big-6.jpg", 9, null, null, false },
                    { 49, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7262), false, "product-img-note10-big-7.jpg", 10, null, null, false },
                    { 41, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7222), true, "honer.jpg", 9, null, null, false },
                    { 51, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7271), true, "iphone-xs-max-space.jpg", 11, null, null, false },
                    { 52, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7277), false, "product-img-note10-big-5.jpg", 11, null, null, false },
                    { 53, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7281), false, "product-img-note10-big-6.jpg", 11, null, null, false },
                    { 25, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7142), false, "product-img-note10-big-1.jpg", 5, null, null, false },
                    { 44, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7237), false, "product-img-note10-big-7.jpg", 9, null, null, false },
                    { 24, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7137), false, "product-img-note10-big-7.jpg", 5, null, null, false },
                    { 22, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7127), false, "product-img-note10-big-5.jpg", 5, null, null, false },
                    { 21, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7122), true, "iphone-xs-max-space.jpg", 5, null, null, false },
                    { 16, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7096), true, "Samsung-S10Plus.jpg", 4, null, null, false },
                    { 17, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7100), false, "product-img-note10-big-5.jpg", 4, null, null, false }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "InsertTime", "IsMainImage", "Name", "ProductId", "RemovedTime", "UpdateTime", "isRemoved" },
                values: new object[,]
                {
                    { 18, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7107), false, "product-img-note10-big-6.jpg", 4, null, null, false },
                    { 54, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7286), false, "product-img-note10-big-7.jpg", 11, null, null, false },
                    { 55, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7292), false, "product-img-note10-big-1.jpg", 11, null, null, false },
                    { 23, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7132), false, "product-img-note10-big-6.jpg", 5, null, null, false },
                    { 45, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7242), false, "product-img-note10-big-1.jpg", 9, null, null, false },
                    { 42, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7227), false, "product-img-note10-big-5.jpg", 9, null, null, false },
                    { 33, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7182), false, "product-img-note10-big-6.jpg", 7, null, null, false },
                    { 2, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7007), false, "product-img-note10-big-5.jpg", 1, null, null, false },
                    { 40, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7217), false, "product-img-note10-big-1.jpg", 8, null, null, false },
                    { 35, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7193), false, "product-img-note10-big-1.jpg", 7, null, null, false },
                    { 34, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7188), false, "product-img-note10-big-7.jpg", 7, null, null, false },
                    { 63, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7311), false, "product-img-note10-big-7.jpg", 12, null, null, false },
                    { 62, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7306), false, "product-img-note10-big-6.jpg", 12, null, null, false },
                    { 61, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7301), false, "product-img-note10-big-5.jpg", 12, null, null, false },
                    { 60, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7296), true, "honer.jpg", 12, null, null, false },
                    { 1, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(5448), true, "Samsung-S10Plus.jpg", 1, null, null, false },
                    { 32, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7177), false, "product-img-note10-big-5.jpg", 7, null, null, false },
                    { 31, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(7172), true, "Samsung-S10Plus.jpg", 7, null, null, false }
                });

            migrationBuilder.InsertData(
                table: "ProductSliders",
                columns: new[] { "Id", "EndDate", "InsertTime", "ProductId", "RemovedTime", "SliderId", "UpdateTime", "isRemoved" },
                values: new object[,]
                {
                    { 41, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3949), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3945), 11, null, 2, null, false },
                    { 40, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3940), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3936), 11, null, 1, null, false },
                    { 35, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3905), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3901), 10, null, 1, null, false },
                    { 2, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3580), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3561), 1, null, 2, null, false },
                    { 30, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3858), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3854), 8, null, 4, null, false },
                    { 4, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3598), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3594), 1, null, 4, null, false },
                    { 3, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3589), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3585), 1, null, 3, null, false },
                    { 311, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3914), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3910), 10, null, 2, null, false },
                    { 36, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3923), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3919), 10, null, 3, null, false },
                    { 37, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3931), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3927), 10, null, 4, null, false },
                    { 1, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(2469), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(1829), 1, null, 1, null, false },
                    { 29, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3849), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3845), 8, null, 3, null, false },
                    { 28, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3840), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3836), 8, null, 2, null, false },
                    { 5, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3608), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3604), 2, null, 1, null, false },
                    { 23, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3787), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3783), 6, null, 4, null, false },
                    { 13, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3687), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3683), 4, null, 1, null, false },
                    { 14, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3696), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3692), 4, null, 2, null, false },
                    { 100, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3705), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3701), 4, null, 3, null, false },
                    { 15, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3714), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3710), 4, null, 4, null, false },
                    { 16, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3723), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3719), 5, null, 1, null, false },
                    { 17, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3734), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3729), 5, null, 2, null, false },
                    { 18, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3743), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3739), 5, null, 3, null, false },
                    { 19, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3751), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3747), 5, null, 4, null, false },
                    { 27, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3822), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3818), 7, null, 4, null, false }
                });

            migrationBuilder.InsertData(
                table: "ProductSliders",
                columns: new[] { "Id", "EndDate", "InsertTime", "ProductId", "RemovedTime", "SliderId", "UpdateTime", "isRemoved" },
                values: new object[,]
                {
                    { 26, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3813), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3809), 7, null, 3, null, false },
                    { 25, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3805), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3800), 7, null, 2, null, false },
                    { 24, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3796), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3792), 7, null, 1, null, false },
                    { 110, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3867), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3863), 9, null, 1, null, false },
                    { 32, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3878), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3874), 9, null, 2, null, false },
                    { 33, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3887), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3883), 9, null, 3, null, false },
                    { 34, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3896), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3892), 9, null, 4, null, false },
                    { 42, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3958), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3954), 11, null, 3, null, false },
                    { 22, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3778), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3774), 6, null, 3, null, false },
                    { 21, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3769), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3765), 6, null, 2, null, false },
                    { 20, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3760), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3756), 6, null, 1, null, false },
                    { 9, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3649), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3645), 3, null, 1, null, false },
                    { 10, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3660), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3656), 3, null, 2, null, false },
                    { 8, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3640), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3636), 2, null, 4, null, false },
                    { 105, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3831), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3827), 8, null, 1, null, false },
                    { 7, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3631), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3627), 2, null, 3, null, false },
                    { 11, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3670), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3665), 3, null, 3, null, false },
                    { 12, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3678), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3674), 3, null, 4, null, false },
                    { 58, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(4026), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(4022), 12, null, 4, null, false },
                    { 56, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(4017), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3990), 12, null, 3, null, false },
                    { 55, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3985), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3981), 12, null, 2, null, false },
                    { 50, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3976), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3972), 12, null, 1, null, false },
                    { 6, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3622), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3616), 2, null, 2, null, false },
                    { 45, new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3967), new DateTime(2021, 9, 13, 11, 57, 15, 769, DateTimeKind.Local).AddTicks(3962), 11, null, 4, null, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BrandSlides",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MainSlides",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ProductSliders",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InsertTime", "Title" },
                values: new object[] { new DateTime(2021, 9, 12, 0, 54, 37, 659, DateTimeKind.Local).AddTicks(9275), "بدون برند" });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 9, 12, 0, 54, 37, 665, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertTime",
                value: new DateTime(2021, 9, 12, 0, 54, 37, 665, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 3,
                column: "InsertTime",
                value: new DateTime(2021, 9, 12, 0, 54, 37, 665, DateTimeKind.Local).AddTicks(3474));

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 4,
                column: "InsertTime",
                value: new DateTime(2021, 9, 12, 0, 54, 37, 665, DateTimeKind.Local).AddTicks(3479));
        }
    }
}
