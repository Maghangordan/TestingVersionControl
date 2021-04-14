using Microsoft.EntityFrameworkCore.Migrations;

namespace tsport.Data.Migrations
{
    public partial class addingtransporters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transporter",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Destination = table.Column<string>(nullable: true),
                    Transporting = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transporter", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transporter");
        }
    }
}
