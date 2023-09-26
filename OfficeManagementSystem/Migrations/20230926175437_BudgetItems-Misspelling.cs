using Microsoft.EntityFrameworkCore.Migrations;

namespace OfficeManagementSystem.Migrations
{
    public partial class BudgetItemsMisspelling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Decription",
                table: "BudgetItems");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "BudgetItems",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "BudgetItems");

            migrationBuilder.AddColumn<string>(
                name: "Decription",
                table: "BudgetItems",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
