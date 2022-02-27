using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceMVC.Migrations
{
    public partial class updactor2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Actors",
                newName: "ActorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ActorId",
                table: "Actors",
                newName: "Id");
        }
    }
}
