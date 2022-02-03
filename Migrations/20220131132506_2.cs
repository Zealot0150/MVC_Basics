using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Basics.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Crabs",
                keyColumn: "CrabID",
                keyValue: 1,
                column: "IsCrabOfTheWeek",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Crabs",
                keyColumn: "CrabID",
                keyValue: 1,
                column: "IsCrabOfTheWeek",
                value: false);
        }
    }
}
