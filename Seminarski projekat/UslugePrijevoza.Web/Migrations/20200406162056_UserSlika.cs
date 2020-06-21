using Microsoft.EntityFrameworkCore.Migrations;

namespace UslugePrijevoza.Web.Migrations
{
    public partial class UserSlika : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifikacija_AspNetUsers_UserID",
                table: "Notifikacija");

            migrationBuilder.DropIndex(
                name: "IX_Notifikacija_UserID",
                table: "Notifikacija");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Notifikacija");

            migrationBuilder.AddColumn<int>(
                name: "UserFromID",
                table: "Notifikacija",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserToID",
                table: "Notifikacija",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Slika",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notifikacija_UserFromID",
                table: "Notifikacija",
                column: "UserFromID");

            migrationBuilder.CreateIndex(
                name: "IX_Notifikacija_UserToID",
                table: "Notifikacija",
                column: "UserToID");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifikacija_AspNetUsers_UserFromID",
                table: "Notifikacija",
                column: "UserFromID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notifikacija_AspNetUsers_UserToID",
                table: "Notifikacija",
                column: "UserToID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifikacija_AspNetUsers_UserFromID",
                table: "Notifikacija");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifikacija_AspNetUsers_UserToID",
                table: "Notifikacija");

            migrationBuilder.DropIndex(
                name: "IX_Notifikacija_UserFromID",
                table: "Notifikacija");

            migrationBuilder.DropIndex(
                name: "IX_Notifikacija_UserToID",
                table: "Notifikacija");

            migrationBuilder.DropColumn(
                name: "UserFromID",
                table: "Notifikacija");

            migrationBuilder.DropColumn(
                name: "UserToID",
                table: "Notifikacija");

            migrationBuilder.DropColumn(
                name: "Slika",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Notifikacija",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notifikacija_UserID",
                table: "Notifikacija",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifikacija_AspNetUsers_UserID",
                table: "Notifikacija",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
