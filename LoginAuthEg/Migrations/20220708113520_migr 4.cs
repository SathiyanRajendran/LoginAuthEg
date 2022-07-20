using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginAuthEg.Migrations
{
    public partial class migr4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Pimage",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pimage",
                table: "Product");
        }
    }
}
