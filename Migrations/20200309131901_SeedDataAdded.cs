using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InlibrisVeritas.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "Created", "ImageUrl", "Title" },
                values: new object[] { 1, "Här kommer lite innehåll i inlägget", new DateTime(2020, 3, 9, 13, 19, 1, 387, DateTimeKind.Utc).AddTicks(403), "http://studenter.miun.se/~ella1800/dt102g/img/brazil.jpg", "Möss och människor" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "Created", "ImageUrl", "Title" },
                values: new object[] { 2, "Här kommer lite innehåll i inlägget", new DateTime(2020, 3, 9, 13, 19, 1, 388, DateTimeKind.Utc).AddTicks(7945), "http://studenter.miun.se/~ella1800/dt102g/img/brazil.jpg", "Aniara" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2);
        }
    }
}
