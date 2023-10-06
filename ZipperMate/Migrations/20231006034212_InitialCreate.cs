using Microsoft.EntityFrameworkCore.Migrations;

namespace ZipperMate.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Zippers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    Use = table.Column<string>(nullable: true),
                    Durabilty = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Colours = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zippers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Zippers");
        }
    }
}
