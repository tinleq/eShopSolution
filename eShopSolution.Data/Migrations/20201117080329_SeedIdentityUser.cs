using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 17, 15, 3, 25, 777, DateTimeKind.Local).AddTicks(6703),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 17, 14, 43, 13, 543, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("354c8efc-cbfe-4e1c-b7ab-37d41fba99f0"), "7c84a5cc-a261-499b-ad33-7c25b0c3a887", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("354c8efc-cbfe-4e1c-b7ab-37d41fba99f0"), new Guid("1e88dc48-f31f-4375-9e3a-ec216126bf53") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("1e88dc48-f31f-4375-9e3a-ec216126bf53"), 0, "cd40436b-f00f-48c1-a38a-79a10309697c", new DateTime(1995, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "tinleq95@gmail.com", true, "Tin", "Le", false, null, "tinleq95@gmail.com", "admin", "AQAAAAEAACcQAAAAEJED8HKX6ByhHS8NZlOjNxTW4BzkBzT42B89J6KVsokAGtH0z5IODQWPTFc9gr/5Kw==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 11, 17, 15, 3, 25, 806, DateTimeKind.Local).AddTicks(1773));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("354c8efc-cbfe-4e1c-b7ab-37d41fba99f0"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("354c8efc-cbfe-4e1c-b7ab-37d41fba99f0"), new Guid("1e88dc48-f31f-4375-9e3a-ec216126bf53") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e88dc48-f31f-4375-9e3a-ec216126bf53"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 17, 14, 43, 13, 543, DateTimeKind.Local).AddTicks(4068),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 17, 15, 3, 25, 777, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 11, 17, 14, 43, 13, 573, DateTimeKind.Local).AddTicks(6152));
        }
    }
}
