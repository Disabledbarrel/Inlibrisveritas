using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InlibrisVeritas.Migrations
{
    public partial class IdentityAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 3, 9, 17, 55, 35, 688, DateTimeKind.Utc).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 3, 9, 17, 55, 35, 691, DateTimeKind.Utc).AddTicks(3269));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 3, 9, 13, 19, 1, 387, DateTimeKind.Utc).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 3, 9, 13, 19, 1, 388, DateTimeKind.Utc).AddTicks(7945));
        }
    }
}
