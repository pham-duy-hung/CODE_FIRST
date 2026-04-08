using Microsoft.EntityFrameworkCore.Migrations;

namespace CODE_FIRST.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BacSis",
                columns: table => new
                {
                    MaBS = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenBacSi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ChuyenKhoa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BacSis", x => x.MaBS);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BacSis");
        }
    }
}
