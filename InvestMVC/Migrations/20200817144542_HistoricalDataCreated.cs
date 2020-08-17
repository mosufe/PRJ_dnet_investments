using Microsoft.EntityFrameworkCore.Migrations;

namespace InvestMVC.Migrations
{
    public partial class HistoricalDataCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
            {
            migrationBuilder.CreateTable(
                name: "HistoricalData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricalData", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoricalData");
        }
    }
}
