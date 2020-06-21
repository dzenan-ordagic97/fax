using Microsoft.EntityFrameworkCore.Migrations;

namespace UslugePrijevoza.Web.Migrations
{
    public partial class adresaFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Adresa_AdresaID",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "AdresaID",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Adresa_AdresaID",
                table: "AspNetUsers",
                column: "AdresaID",
                principalTable: "Adresa",
                principalColumn: "AdresaID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Adresa_AdresaID",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "AdresaID",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Adresa_AdresaID",
                table: "AspNetUsers",
                column: "AdresaID",
                principalTable: "Adresa",
                principalColumn: "AdresaID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
