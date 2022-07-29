using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Poiskfile.Migrations
{
    public partial class intial7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "indx",
                table: "Meteostations",
                newName: "station");

            migrationBuilder.RenameColumn(
                name: "indx",
                table: "MeteoDatas",
                newName: "station");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "station",
                table: "Meteostations",
                newName: "indx");

            migrationBuilder.RenameColumn(
                name: "station",
                table: "MeteoDatas",
                newName: "indx");
        }
    }
}
