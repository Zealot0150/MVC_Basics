using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Basics.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crabs_Categories_CategoryID",
                table: "Crabs");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "Crabs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Description", "Name" },
                values: new object[] { 1, null, "Red Crabs" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Description", "Name" },
                values: new object[] { 2, null, "Brown Crabs" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Description", "Name" },
                values: new object[] { 3, null, "Blue Crabs" });

            migrationBuilder.InsertData(
                table: "Crabs",
                columns: new[] { "CrabID", "CategoryID", "Description", "ImageUrl", "IsCrabOfTheWeek", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Description brown crab", "https://images.unsplash.com/photo-1615834751896-b15e2330b289?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1434&q=80", false, "Brown Crab", 1.0 },
                    { 4, 1, "Description brown crab", "https://images.unsplash.com/photo-1615834751896-b15e2330b289?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1434&q=80", false, "Browner Crab", 4.0 },
                    { 2, 2, "Description bluecrab", "https://images.unsplash.com/photo-1509415173911-37ff7a1aa29c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1135&q=80", false, "Blue Crab", 2.0 },
                    { 5, 2, "Description bluercrab", "https://images.unsplash.com/photo-1509415173911-37ff7a1aa29c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1135&q=80", false, "Bluer Crab", 5.0 },
                    { 3, 3, "Description bluecrab", "https://images.unsplash.com/photo-1580841129862-bc2a2d113c45?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2073&q=80", false, "Red Crab", 3.0 },
                    { 6, 3, "Description bluecrab", "https://images.unsplash.com/photo-1580841129862-bc2a2d113c45?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2073&q=80", false, "Reder Crab", 6.0 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Crabs_Categories_CategoryID",
                table: "Crabs",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crabs_Categories_CategoryID",
                table: "Crabs");

            migrationBuilder.DeleteData(
                table: "Crabs",
                keyColumn: "CrabID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Crabs",
                keyColumn: "CrabID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Crabs",
                keyColumn: "CrabID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Crabs",
                keyColumn: "CrabID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Crabs",
                keyColumn: "CrabID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Crabs",
                keyColumn: "CrabID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "Crabs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Crabs_Categories_CategoryID",
                table: "Crabs",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
