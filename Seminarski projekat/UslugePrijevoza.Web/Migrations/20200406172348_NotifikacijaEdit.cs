using Microsoft.EntityFrameworkCore.Migrations;

namespace UslugePrijevoza.Web.Migrations
{
    public partial class NotifikacijaEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifikacija_TeretRezervacija_TeretRezervacijaID",
                table: "Notifikacija");

            migrationBuilder.DropIndex(
                name: "IX_Notifikacija_TeretRezervacijaID",
                table: "Notifikacija");

            migrationBuilder.DropColumn(
                name: "TeretRezervacijaID",
                table: "Notifikacija");

            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "Notifikacija",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "URL",
                table: "Notifikacija");

            migrationBuilder.AddColumn<int>(
                name: "TeretRezervacijaID",
                table: "Notifikacija",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notifikacija_TeretRezervacijaID",
                table: "Notifikacija",
                column: "TeretRezervacijaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifikacija_TeretRezervacija_TeretRezervacijaID",
                table: "Notifikacija",
                column: "TeretRezervacijaID",
                principalTable: "TeretRezervacija",
                principalColumn: "TeretRezervacijaID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
