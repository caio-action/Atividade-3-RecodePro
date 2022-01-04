using Microsoft.EntityFrameworkCore.Migrations;

namespace QueerTrip.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Partida = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Destino = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Checkin = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Checkout = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
