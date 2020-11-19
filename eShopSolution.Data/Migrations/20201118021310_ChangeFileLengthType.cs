using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("354c8efc-cbfe-4e1c-b7ab-37d41fba99f0"),
                column: "ConcurrencyStamp",
                value: "b3c91c65-30a5-48a8-8e65-1517a1f8594e");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e88dc48-f31f-4375-9e3a-ec216126bf53"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d4abc82d-09ef-4b40-ae60-4040103e8f45", "AQAAAAEAACcQAAAAEKGp9emMKLMM9HsGjlbt0cRIP2zSUE6Cj/VOv1ELxbaW2NJmdiuVkYZNlOA7gCiQ3g==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 11, 18, 9, 13, 9, 160, DateTimeKind.Local).AddTicks(7138));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
