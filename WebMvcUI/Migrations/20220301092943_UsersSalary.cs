using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMvcUI.Migrations
{
    public partial class UsersSalary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Salary",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Users");
        }
    }
}
