using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeoAlias",
                table: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 17, 15, 3, 25, 777, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<long>(type: "bigint", nullable: false)
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

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("354c8efc-cbfe-4e1c-b7ab-37d41fba99f0"),
                column: "ConcurrencyStamp",
                value: "13a2146b-bc25-4b80-a11b-a9c679c410ea");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e88dc48-f31f-4375-9e3a-ec216126bf53"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "31c42202-f5bc-48a3-aa14-b7c0482981c9", "AQAAAAEAACcQAAAAEMxhL5MQUfaR+yjU6PjhXvTyZfqyBOt8EK0kwZm6tw8DZgq+Ihwh2MPLiCaNPEhQcQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 11, 17, 19, 12, 7, 534, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AddColumn<string>(
                name: "SeoAlias",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 17, 15, 3, 25, 777, DateTimeKind.Local).AddTicks(6703),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("354c8efc-cbfe-4e1c-b7ab-37d41fba99f0"),
                column: "ConcurrencyStamp",
                value: "7c84a5cc-a261-499b-ad33-7c25b0c3a887");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e88dc48-f31f-4375-9e3a-ec216126bf53"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cd40436b-f00f-48c1-a38a-79a10309697c", "AQAAAAEAACcQAAAAEJED8HKX6ByhHS8NZlOjNxTW4BzkBzT42B89J6KVsokAGtH0z5IODQWPTFc9gr/5Kw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 11, 17, 15, 3, 25, 806, DateTimeKind.Local).AddTicks(1773));
        }
    }
}
