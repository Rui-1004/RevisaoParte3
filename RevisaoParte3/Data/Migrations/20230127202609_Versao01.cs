using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevisaoParte3.Data.Migrations
{
    public partial class Versao01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Authors",
                newName: "ActorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ActorId",
                table: "Authors",
                newName: "AuthorId");
        }
    }
}
