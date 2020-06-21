using Microsoft.EntityFrameworkCore.Migrations;

namespace UslugePrijevoza.Web.Migrations
{
    public partial class BrisanjeTelefonaPrijevoznika : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresa_Grad_GradID",
                table: "Adresa");

            migrationBuilder.DropColumn(
                name: "PoslovniTelefon",
                table: "Prijevoznik");

            migrationBuilder.AlterColumn<int>(
                name: "GradID",
                table: "Adresa",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Adresa_Grad_GradID",
                table: "Adresa",
                column: "GradID",
                principalTable: "Grad",
                principalColumn: "GradID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresa_Grad_GradID",
                table: "Adresa");

            migrationBuilder.AddColumn<string>(
                name: "PoslovniTelefon",
                table: "Prijevoznik",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GradID",
                table: "Adresa",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Adresa_Grad_GradID",
                table: "Adresa",
                column: "GradID",
                principalTable: "Grad",
                principalColumn: "GradID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
