using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store_Application.Persistence.Migrations
{
    public partial class initslider_productSliderstbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_برند",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_دسته بندی",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_نقش",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "کلمه عبور",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "کدفعالسازی",
                table: "Users",
                newName: "ActiveCode");

            migrationBuilder.RenameColumn(
                name: "وضعیت حساب",
                table: "Users",
                newName: "isActive");

            migrationBuilder.RenameColumn(
                name: "نقش",
                table: "Users",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "نام کامل",
                table: "Users",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "سن",
                table: "Users",
                newName: "age");

            migrationBuilder.RenameColumn(
                name: "تلفن همراه",
                table: "Users",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "آدرس",
                table: "Users",
                newName: "Address");

            migrationBuilder.RenameIndex(
                name: "IX_Users_نقش",
                table: "Users",
                newName: "IX_Users_RoleId");

            migrationBuilder.RenameColumn(
                name: "نام نقش",
                table: "Roles",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "نمایش در فروشگاه",
                table: "Products",
                newName: "Displayed");

            migrationBuilder.RenameColumn(
                name: "نام محصول",
                table: "Products",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "موجودی",
                table: "Products",
                newName: "Inventory");

            migrationBuilder.RenameColumn(
                name: "مقدار تخفیف",
                table: "Products",
                newName: "DiscountAmount");

            migrationBuilder.RenameColumn(
                name: "قیمت",
                table: "Products",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "دسته بندی",
                table: "Products",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "توضیحات",
                table: "Products",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "توضیح مختصر",
                table: "Products",
                newName: "ShortDescription");

            migrationBuilder.RenameColumn(
                name: "برند",
                table: "Products",
                newName: "BrandId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_دسته بندی",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_برند",
                table: "Products",
                newName: "IX_Products_BrandId");

            migrationBuilder.RenameColumn(
                name: "نام ویژگی",
                table: "Features",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "نام دسته بندی",
                table: "Categories",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "تصویر",
                table: "Categories",
                newName: "ImageName");

            migrationBuilder.RenameColumn(
                name: "نام برند",
                table: "Brands",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "تصویر برند",
                table: "Brands",
                newName: "ImageName");

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemovedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SliderId = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemovedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSliders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSliders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSliders_Sliders_SliderId",
                        column: x => x.SliderId,
                        principalTable: "Sliders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 8, 23, 15, 47, 3, 605, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "InsertTime", "RemovedTime", "Title", "UpdateTime", "isRemoved" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 8, 23, 15, 47, 3, 611, DateTimeKind.Local).AddTicks(1508), null, "پیشنهاد لحظه ای", null, false },
                    { 2, new DateTime(2021, 8, 23, 15, 47, 3, 611, DateTimeKind.Local).AddTicks(1658), null, "دوربین", null, false },
                    { 3, new DateTime(2021, 8, 23, 15, 47, 3, 611, DateTimeKind.Local).AddTicks(1668), null, "موبایل", null, false },
                    { 4, new DateTime(2021, 8, 23, 15, 47, 3, 611, DateTimeKind.Local).AddTicks(1673), null, "لپ تاپ", null, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductSliders_ProductId",
                table: "ProductSliders",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSliders_SliderId",
                table: "ProductSliders",
                column: "SliderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "ProductSliders");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Users",
                newName: "وضعیت حساب");

            migrationBuilder.RenameColumn(
                name: "age",
                table: "Users",
                newName: "سن");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Users",
                newName: "نقش");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Users",
                newName: "تلفن همراه");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "کلمه عبور");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Users",
                newName: "نام کامل");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Users",
                newName: "آدرس");

            migrationBuilder.RenameColumn(
                name: "ActiveCode",
                table: "Users",
                newName: "کدفعالسازی");

            migrationBuilder.RenameIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                newName: "IX_Users_نقش");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Roles",
                newName: "نام نقش");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Products",
                newName: "نام محصول");

            migrationBuilder.RenameColumn(
                name: "ShortDescription",
                table: "Products",
                newName: "توضیح مختصر");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "قیمت");

            migrationBuilder.RenameColumn(
                name: "Inventory",
                table: "Products",
                newName: "موجودی");

            migrationBuilder.RenameColumn(
                name: "Displayed",
                table: "Products",
                newName: "نمایش در فروشگاه");

            migrationBuilder.RenameColumn(
                name: "DiscountAmount",
                table: "Products",
                newName: "مقدار تخفیف");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "توضیحات");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Products",
                newName: "دسته بندی");

            migrationBuilder.RenameColumn(
                name: "BrandId",
                table: "Products",
                newName: "برند");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                newName: "IX_Products_دسته بندی");

            migrationBuilder.RenameIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                newName: "IX_Products_برند");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Features",
                newName: "نام ویژگی");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Categories",
                newName: "نام دسته بندی");

            migrationBuilder.RenameColumn(
                name: "ImageName",
                table: "Categories",
                newName: "تصویر");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Brands",
                newName: "نام برند");

            migrationBuilder.RenameColumn(
                name: "ImageName",
                table: "Brands",
                newName: "تصویر برند");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertTime",
                value: new DateTime(2021, 6, 30, 13, 35, 46, 440, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_برند",
                table: "Products",
                column: "برند",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_دسته بندی",
                table: "Products",
                column: "دسته بندی",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_نقش",
                table: "Users",
                column: "نقش",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
