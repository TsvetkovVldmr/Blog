using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.DbTools.Migrations
{
    public partial class musicGenre_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Archetype",
                table: "MusicGenres",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubGenre",
                table: "MusicGenres",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Archetype",
                table: "MusicGenres");

            migrationBuilder.DropColumn(
                name: "SubGenre",
                table: "MusicGenres");
        }
    }
}
