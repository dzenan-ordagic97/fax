using Microsoft.EntityFrameworkCore.Migrations;

namespace UslugePrijevoza.Web.Migrations
{
    public partial class Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DodatneUsluge_Teret_DodatneUsluge_DodatneUslugeID",
                table: "DodatneUsluge_Teret");

            migrationBuilder.DropColumn(
                name: "DodatnaUslugaID",
                table: "DodatneUsluge_Teret");

            migrationBuilder.AlterColumn<int>(
                name: "DodatneUslugeID",
                table: "DodatneUsluge_Teret",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DodatneUsluge_Teret_DodatneUsluge_DodatneUslugeID",
                table: "DodatneUsluge_Teret",
                column: "DodatneUslugeID",
                principalTable: "DodatneUsluge",
                principalColumn: "DodatneUslugeID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DodatneUsluge_Teret_DodatneUsluge_DodatneUslugeID",
                table: "DodatneUsluge_Teret");

            migrationBuilder.AlterColumn<int>(
                name: "DodatneUslugeID",
                table: "DodatneUsluge_Teret",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "DodatnaUslugaID",
                table: "DodatneUsluge_Teret",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_DodatneUsluge_Teret_DodatneUsluge_DodatneUslugeID",
                table: "DodatneUsluge_Teret",
                column: "DodatneUslugeID",
                principalTable: "DodatneUsluge",
                principalColumn: "DodatneUslugeID",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
