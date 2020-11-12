using Microsoft.EntityFrameworkCore.Migrations;

namespace marvel.Data.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "picutre",
                table: "heros",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "picutre",
                table: "heros");
        }
    }
}
