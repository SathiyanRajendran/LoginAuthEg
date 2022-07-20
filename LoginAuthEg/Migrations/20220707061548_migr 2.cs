using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginAuthEg.Migrations
{
    public partial class migr2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "suppliers",
                columns: table => new
                {
                    Sid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suppliers", x => x.Sid);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Pid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    SidNavigationSid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Pid);
                    table.ForeignKey(
                        name: "FK_Product_suppliers_SidNavigationSid",
                        column: x => x.SidNavigationSid,
                        principalTable: "suppliers",
                        principalColumn: "Sid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_SidNavigationSid",
                table: "Product",
                column: "SidNavigationSid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "suppliers");
        }
    }
}
