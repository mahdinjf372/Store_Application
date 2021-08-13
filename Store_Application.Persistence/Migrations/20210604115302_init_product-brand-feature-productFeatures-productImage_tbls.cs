using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store_Application.Persistence.Migrations
{
    public partial class init_productbrandfeatureproductFeaturesproductImage_tbls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

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
                table: "Categories",
                newName: "نام دسته بندی");

            migrationBuilder.RenameColumn(
                name: "ImageName",
                table: "Categories",
                newName: "تصویر");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<bool>(
                name: "وضعیت حساب",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<byte>(
                name: "سن",
                table: "Users",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<int>(
                name: "نقش",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "کدفعالسازی",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    نامبرند = table.Column<string>(name: "نام برند", type: "nvarchar(max)", nullable: true),
                    تصویربرند = table.Column<string>(name: "تصویر برند", type: "nvarchar(max)", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemovedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    نامویژگی = table.Column<string>(name: "نام ویژگی", type: "nvarchar(max)", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemovedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ناممحصول = table.Column<string>(name: "نام محصول", type: "nvarchar(max)", nullable: true),
                    توضیحمختصر = table.Column<string>(name: "توضیح مختصر", type: "nvarchar(max)", nullable: true),
                    توضیحات = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    قیمت = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    مقدارتخفیف = table.Column<decimal>(name: "مقدار تخفیف", type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    موجودی = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    نمایشدرفروشگاه = table.Column<bool>(name: "نمایش در فروشگاه", type: "bit", nullable: false, defaultValue: true),
                    دستهبندی = table.Column<int>(name: "دسته بندی", type: "int", nullable: false),
                    برند = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemovedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_برند",
                        column: x => x.برند,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Categories_دسته بندی",
                        column: x => x.دستهبندی,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isBold = table.Column<bool>(type: "bit", nullable: false),
                    FeatureId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemovedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_Features_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemovedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_FeatureId",
                table: "ProductFeatures",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductId",
                table: "ProductFeatures",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_برند",
                table: "Products",
                column: "برند");

            migrationBuilder.CreateIndex(
                name: "IX_Products_دسته بندی",
                table: "Products",
                column: "دسته بندی");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_نقش",
                table: "Users",
                column: "نقش",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_نقش",
                table: "Users");

            migrationBuilder.DropTable(
                name: "ProductFeatures");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Brands");

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
                name: "نام دسته بندی",
                table: "Categories",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "تصویر",
                table: "Categories",
                newName: "ImageName");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActiveCode",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "isActive",
                table: "Users",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<byte>(
                name: "age",
                table: "Users",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

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
