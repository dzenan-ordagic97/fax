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
                name: "PopravniIspit",
                columns: table => new
                {
                    PopravniIspitID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClanKomisije1ID = table.Column<int>(nullable: false),
                    ClanKomisije2ID = table.Column<int>(nullable: false),
                    ClanKomisije3ID = table.Column<int>(nullable: false),
                    Datum = table.Column<DateTime>(nullable: false),
                    PredajePredmetID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PopravniIspit", x => x.PopravniIspitID);
                    table.ForeignKey(
                        name: "FK_PopravniIspit_Nastavnik_ClanKomisije1ID",
                        column: x => x.ClanKomisije1ID,
                        principalTable: "Nastavnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PopravniIspit_Nastavnik_ClanKomisije2ID",
                        column: x => x.ClanKomisije2ID,
                        principalTable: "Nastavnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PopravniIspit_Nastavnik_ClanKomisije3ID",
                        column: x => x.ClanKomisije3ID,
                        principalTable: "Nastavnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PopravniIspit_PredajePredmet_PredajePredmetID",
                        column: x => x.PredajePredmetID,
                        principalTable: "PredajePredmet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "PopravniIspitStavke",
                columns: table => new
                {
                    PopravniIspitStavkeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bodovi = table.Column<int>(nullable: false),
                    OdjeljenjeStavkaID = table.Column<int>(nullable: false),
                    PopravniIspitID = table.Column<int>(nullable: false),
                    Pristupio = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PopravniIspitStavke", x => x.PopravniIspitStavkeID);
                    table.ForeignKey(
                        name: "FK_PopravniIspitStavke_OdjeljenjeStavka_OdjeljenjeStavkaID",
                        column: x => x.OdjeljenjeStavkaID,
                        principalTable: "OdjeljenjeStavka",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PopravniIspitStavke_PopravniIspit_PopravniIspitID",
                        column: x => x.PopravniIspitID,
                        principalTable: "PopravniIspit",
                        principalColumn: "PopravniIspitID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PopravniIspit_ClanKomisije1ID",
                table: "PopravniIspit",
                column: "ClanKomisije1ID");

            migrationBuilder.CreateIndex(
                name: "IX_PopravniIspit_ClanKomisije2ID",
                table: "PopravniIspit",
                column: "ClanKomisije2ID");

            migrationBuilder.CreateIndex(
                name: "IX_PopravniIspit_ClanKomisije3ID",
                table: "PopravniIspit",
                column: "ClanKomisije3ID");

            migrationBuilder.CreateIndex(
                name: "IX_PopravniIspit_PredajePredmetID",
                table: "PopravniIspit",
                column: "PredajePredmetID");

            migrationBuilder.CreateIndex(
                name: "IX_PopravniIspitStavke_OdjeljenjeStavkaID",
                table: "PopravniIspitStavke",
                column: "OdjeljenjeStavkaID");

            migrationBuilder.CreateIndex(
                name: "IX_PopravniIspitStavke_PopravniIspitID",
                table: "PopravniIspitStavke",
                column: "PopravniIspitID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PopravniIspitStavke");

            migrationBuilder.DropTable(
                name: "PopravniIspit");
        }
    }
}
