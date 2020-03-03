using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RS1_Ispit_asp.net_core.Migrations
{
    public partial class DodavanjeIspita : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ispit",
                columns: table => new
                {
                    IspitID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AngazovanID = table.Column<int>(nullable: false),
                    Datum = table.Column<DateTime>(nullable: false),
                    Evidentirani = table.Column<bool>(nullable: false),
                    Napomena = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ispit", x => x.IspitID);
                    table.ForeignKey(
                        name: "FK_Ispit_Angazovan_AngazovanID",
                        column: x => x.AngazovanID,
                        principalTable: "Angazovan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IspitStavke",
                columns: table => new
                {
                    IspitStavkeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IspitID = table.Column<int>(nullable: false),
                    Ocjena = table.Column<int>(nullable: false),
                    Pristupio = table.Column<bool>(nullable: false),
                    StudentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IspitStavke", x => x.IspitStavkeID);
                    table.ForeignKey(
                        name: "FK_IspitStavke_Ispit_IspitID",
                        column: x => x.IspitID,
                        principalTable: "Ispit",
                        principalColumn: "IspitID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IspitStavke_Student_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ispit_AngazovanID",
                table: "Ispit",
                column: "AngazovanID");

            migrationBuilder.CreateIndex(
                name: "IX_IspitStavke_IspitID",
                table: "IspitStavke",
                column: "IspitID");

            migrationBuilder.CreateIndex(
                name: "IX_IspitStavke_StudentID",
                table: "IspitStavke",
                column: "StudentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IspitStavke");

            migrationBuilder.DropTable(
                name: "Ispit");
        }
    }
}
