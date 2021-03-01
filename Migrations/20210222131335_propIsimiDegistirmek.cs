using Microsoft.EntityFrameworkCore.Migrations;

namespace EFConsle.Migrations
{
    public partial class propIsimiDegistirmek : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Value",
                table: "baskaIsim",
                newName: "VlauePost");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VlauePost",
                table: "baskaIsim",
                newName: "Value");
        }
    }
}
