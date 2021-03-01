using Microsoft.EntityFrameworkCore.Migrations;

namespace EFConsle.Migrations
{
    public partial class HasDefaultValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "sayici",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "sayici",
                table: "Employees");
        }
    }
}
