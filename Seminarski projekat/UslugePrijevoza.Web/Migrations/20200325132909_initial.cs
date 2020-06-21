using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UslugePrijevoza.Web.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DetaljiVozila",
                columns: table => new
                {
                    DetaljiVozilaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaxVisina = table.Column<double>(nullable: false),
                    MaxTezina = table.Column<double>(nullable: false),
                    MaxDuzina = table.Column<double>(nullable: false),
                    MaxSirina = table.Column<double>(nullable: false),
                    Cijena_km = table.Column<double>(nullable: false),
                    Br_EUPaleta = table.Column<int>(nullable: true),
                    Opis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetaljiVozila", x => x.DetaljiVozilaID);
                });

            migrationBuilder.CreateTable(
                name: "Drzava",
                columns: table => new
                {
                    DrzavaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Skracenica = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzava", x => x.DrzavaID);
                });

            migrationBuilder.CreateTable(
                name: "Slike",
                columns: table => new
                {
                    SlikeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    URL = table.Column<string>(nullable: true),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slike", x => x.SlikeID);
                });

            migrationBuilder.CreateTable(
                name: "Teret",
                columns: table => new
                {
                    TeretID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    Tezina = table.Column<double>(nullable: false),
                    MaxVisina = table.Column<double>(nullable: false),
                    MaxSirina = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teret", x => x.TeretID);
                });

            migrationBuilder.CreateTable(
                name: "TipTereta",
                columns: table => new
                {
                    TipTeretaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipTereta", x => x.TipTeretaID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Grad",
                columns: table => new
                {
                    GradID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    PostanskiBroj = table.Column<string>(nullable: true),
                    DrzavaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grad", x => x.GradID);
                    table.ForeignKey(
                        name: "FK_Grad_Drzava_DrzavaID",
                        column: x => x.DrzavaID,
                        principalTable: "Drzava",
                        principalColumn: "DrzavaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SlikaVozilo",
                columns: table => new
                {
                    SlikaVoziloID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pozicija = table.Column<int>(nullable: false),
                    DetaljiVozilaID = table.Column<int>(nullable: false),
                    SlikeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlikaVozilo", x => x.SlikaVoziloID);
                    table.ForeignKey(
                        name: "FK_SlikaVozilo_DetaljiVozila_DetaljiVozilaID",
                        column: x => x.DetaljiVozilaID,
                        principalTable: "DetaljiVozila",
                        principalColumn: "DetaljiVozilaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SlikaVozilo_Slike_SlikeID",
                        column: x => x.SlikeID,
                        principalTable: "Slike",
                        principalColumn: "SlikeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SlikeTereta",
                columns: table => new
                {
                    SlikeTeretaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pozicija = table.Column<int>(nullable: false),
                    TeretID = table.Column<int>(nullable: false),
                    SlikeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlikeTereta", x => x.SlikeTeretaID);
                    table.ForeignKey(
                        name: "FK_SlikeTereta_Slike_SlikeID",
                        column: x => x.SlikeID,
                        principalTable: "Slike",
                        principalColumn: "SlikeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SlikeTereta_Teret_TeretID",
                        column: x => x.TeretID,
                        principalTable: "Teret",
                        principalColumn: "TeretID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TipTereta_Teret",
                columns: table => new
                {
                    TipTereta_TeretID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeretID = table.Column<int>(nullable: false),
                    TipTeretaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipTereta_Teret", x => x.TipTereta_TeretID);
                    table.ForeignKey(
                        name: "FK_TipTereta_Teret_Teret_TeretID",
                        column: x => x.TeretID,
                        principalTable: "Teret",
                        principalColumn: "TeretID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TipTereta_Teret_TipTereta_TipTeretaID",
                        column: x => x.TipTeretaID,
                        principalTable: "TipTereta",
                        principalColumn: "TipTeretaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Adresa",
                columns: table => new
                {
                    AdresaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    GradID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresa", x => x.AdresaID);
                    table.ForeignKey(
                        name: "FK_Adresa_Grad_GradID",
                        column: x => x.GradID,
                        principalTable: "Grad",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Ime = table.Column<string>(maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(maxLength: 50, nullable: false),
                    DatumRodjenja = table.Column<DateTime>(nullable: false),
                    JMBG = table.Column<string>(nullable: true),
                    Spol = table.Column<string>(nullable: true),
                    AdresaID = table.Column<int>(nullable: false),
                    SignalRToken = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Adresa_AdresaID",
                        column: x => x.AdresaID,
                        principalTable: "Adresa",
                        principalColumn: "AdresaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prijevoznik",
                columns: table => new
                {
                    PrijevoznikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivPrijevoznika = table.Column<string>(nullable: true),
                    EmailPrijevoznika = table.Column<string>(nullable: true),
                    PoslovniTelefon = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prijevoznik", x => x.PrijevoznikID);
                    table.ForeignKey(
                        name: "FK_Prijevoznik_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DodatneUsluge",
                columns: table => new
                {
                    DodatneUslugeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Cijena = table.Column<double>(nullable: false),
                    Opis = table.Column<string>(nullable: true),
                    PrijevoznikID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DodatneUsluge", x => x.DodatneUslugeID);
                    table.ForeignKey(
                        name: "FK_DodatneUsluge_Prijevoznik_PrijevoznikID",
                        column: x => x.PrijevoznikID,
                        principalTable: "Prijevoznik",
                        principalColumn: "PrijevoznikID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModelVozila",
                columns: table => new
                {
                    ModelVozilaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    PrijevoznikID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelVozila", x => x.ModelVozilaID);
                    table.ForeignKey(
                        name: "FK_ModelVozila_Prijevoznik_PrijevoznikID",
                        column: x => x.PrijevoznikID,
                        principalTable: "Prijevoznik",
                        principalColumn: "PrijevoznikID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TipVozila",
                columns: table => new
                {
                    TipVozilaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    PrijevoznikID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipVozila", x => x.TipVozilaID);
                    table.ForeignKey(
                        name: "FK_TipVozila_Prijevoznik_PrijevoznikID",
                        column: x => x.PrijevoznikID,
                        principalTable: "Prijevoznik",
                        principalColumn: "PrijevoznikID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vozilo",
                columns: table => new
                {
                    VoziloID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistracijskaOznaka = table.Column<string>(nullable: true),
                    GodinaProizvodnje = table.Column<DateTime>(nullable: false),
                    BrojMjesta = table.Column<int>(nullable: false),
                    ZapreminaPrtljaznika = table.Column<double>(nullable: false),
                    PrijevoznikID = table.Column<int>(nullable: false),
                    TipVozilaID = table.Column<int>(nullable: false),
                    ModelVozilaID = table.Column<int>(nullable: false),
                    DetaljiVozilaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vozilo", x => x.VoziloID);
                    table.ForeignKey(
                        name: "FK_Vozilo_DetaljiVozila_DetaljiVozilaID",
                        column: x => x.DetaljiVozilaID,
                        principalTable: "DetaljiVozila",
                        principalColumn: "DetaljiVozilaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vozilo_ModelVozila_ModelVozilaID",
                        column: x => x.ModelVozilaID,
                        principalTable: "ModelVozila",
                        principalColumn: "ModelVozilaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vozilo_Prijevoznik_PrijevoznikID",
                        column: x => x.PrijevoznikID,
                        principalTable: "Prijevoznik",
                        principalColumn: "PrijevoznikID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Vozilo_TipVozila_TipVozilaID",
                        column: x => x.TipVozilaID,
                        principalTable: "TipVozila",
                        principalColumn: "TipVozilaID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Prijevoz",
                columns: table => new
                {
                    PrijevozID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumPotvrde = table.Column<DateTime>(nullable: true),
                    DatumPrijevoza = table.Column<DateTime>(nullable: true),
                    Cijena = table.Column<double>(nullable: true),
                    Kilometraza = table.Column<double>(nullable: true),
                    TipPrijevoza = table.Column<string>(nullable: true),
                    Zavrseno = table.Column<bool>(nullable: true),
                    PrijevoznikID = table.Column<int>(nullable: false),
                    VoziloID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prijevoz", x => x.PrijevozID);
                    table.ForeignKey(
                        name: "FK_Prijevoz_Prijevoznik_PrijevoznikID",
                        column: x => x.PrijevoznikID,
                        principalTable: "Prijevoznik",
                        principalColumn: "PrijevoznikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prijevoz_Vozilo_VoziloID",
                        column: x => x.VoziloID,
                        principalTable: "Vozilo",
                        principalColumn: "VoziloID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KomentarOcjena",
                columns: table => new
                {
                    KomentarOcjenaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ocjena = table.Column<int>(nullable: false),
                    Komentar = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: false),
                    PrijevozID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KomentarOcjena", x => x.KomentarOcjenaID);
                    table.ForeignKey(
                        name: "FK_KomentarOcjena_Prijevoz_PrijevozID",
                        column: x => x.PrijevozID,
                        principalTable: "Prijevoz",
                        principalColumn: "PrijevozID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KomentarOcjena_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TeretRezervacija",
                columns: table => new
                {
                    TeretRezervacijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PocetnaLokacija = table.Column<string>(nullable: true),
                    KrajnjaLokacija = table.Column<string>(nullable: true),
                    Prihvaceno = table.Column<bool>(nullable: false),
                    PocetniDatumPrijevoza = table.Column<DateTime>(nullable: false),
                    KrajnjiDatumPrijevoza = table.Column<DateTime>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    PrijevozID = table.Column<int>(nullable: true),
                    TeretID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeretRezervacija", x => x.TeretRezervacijaID);
                    table.ForeignKey(
                        name: "FK_TeretRezervacija_Prijevoz_PrijevozID",
                        column: x => x.PrijevozID,
                        principalTable: "Prijevoz",
                        principalColumn: "PrijevozID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeretRezervacija_Teret_TeretID",
                        column: x => x.TeretID,
                        principalTable: "Teret",
                        principalColumn: "TeretID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeretRezervacija_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DodatneUsluge_Teret",
                columns: table => new
                {
                    DodatneUsluge_TeretID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UkupnaCijenaUsluge = table.Column<double>(nullable: false),
                    Kolicina = table.Column<int>(nullable: false),
                    Opis = table.Column<string>(nullable: true),
                    DodatnaUslugaID = table.Column<int>(nullable: false),
                    DodatneUslugeID = table.Column<int>(nullable: true),
                    TeretRezervacijaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DodatneUsluge_Teret", x => x.DodatneUsluge_TeretID);
                    table.ForeignKey(
                        name: "FK_DodatneUsluge_Teret_DodatneUsluge_DodatneUslugeID",
                        column: x => x.DodatneUslugeID,
                        principalTable: "DodatneUsluge",
                        principalColumn: "DodatneUslugeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DodatneUsluge_Teret_TeretRezervacija_TeretRezervacijaID",
                        column: x => x.TeretRezervacijaID,
                        principalTable: "TeretRezervacija",
                        principalColumn: "TeretRezervacijaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notifikacija",
                columns: table => new
                {
                    NotifikacijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vrijeme = table.Column<DateTime>(nullable: false),
                    Otvorena = table.Column<bool>(nullable: false),
                    Poruka = table.Column<string>(nullable: true),
                    TeretRezervacijaID = table.Column<int>(nullable: true),
                    UserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifikacija", x => x.NotifikacijaID);
                    table.ForeignKey(
                        name: "FK_Notifikacija_TeretRezervacija_TeretRezervacijaID",
                        column: x => x.TeretRezervacijaID,
                        principalTable: "TeretRezervacija",
                        principalColumn: "TeretRezervacijaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notifikacija_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adresa_GradID",
                table: "Adresa",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AdresaID",
                table: "AspNetUsers",
                column: "AdresaID");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DodatneUsluge_PrijevoznikID",
                table: "DodatneUsluge",
                column: "PrijevoznikID");

            migrationBuilder.CreateIndex(
                name: "IX_DodatneUsluge_Teret_DodatneUslugeID",
                table: "DodatneUsluge_Teret",
                column: "DodatneUslugeID");

            migrationBuilder.CreateIndex(
                name: "IX_DodatneUsluge_Teret_TeretRezervacijaID",
                table: "DodatneUsluge_Teret",
                column: "TeretRezervacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Grad_DrzavaID",
                table: "Grad",
                column: "DrzavaID");

            migrationBuilder.CreateIndex(
                name: "IX_KomentarOcjena_PrijevozID",
                table: "KomentarOcjena",
                column: "PrijevozID");

            migrationBuilder.CreateIndex(
                name: "IX_KomentarOcjena_UserID",
                table: "KomentarOcjena",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ModelVozila_PrijevoznikID",
                table: "ModelVozila",
                column: "PrijevoznikID");

            migrationBuilder.CreateIndex(
                name: "IX_Notifikacija_TeretRezervacijaID",
                table: "Notifikacija",
                column: "TeretRezervacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Notifikacija_UserID",
                table: "Notifikacija",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Prijevoz_PrijevoznikID",
                table: "Prijevoz",
                column: "PrijevoznikID");

            migrationBuilder.CreateIndex(
                name: "IX_Prijevoz_VoziloID",
                table: "Prijevoz",
                column: "VoziloID");

            migrationBuilder.CreateIndex(
                name: "IX_Prijevoznik_UserID",
                table: "Prijevoznik",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_SlikaVozilo_DetaljiVozilaID",
                table: "SlikaVozilo",
                column: "DetaljiVozilaID");

            migrationBuilder.CreateIndex(
                name: "IX_SlikaVozilo_SlikeID",
                table: "SlikaVozilo",
                column: "SlikeID");

            migrationBuilder.CreateIndex(
                name: "IX_SlikeTereta_SlikeID",
                table: "SlikeTereta",
                column: "SlikeID");

            migrationBuilder.CreateIndex(
                name: "IX_SlikeTereta_TeretID",
                table: "SlikeTereta",
                column: "TeretID");

            migrationBuilder.CreateIndex(
                name: "IX_TeretRezervacija_PrijevozID",
                table: "TeretRezervacija",
                column: "PrijevozID");

            migrationBuilder.CreateIndex(
                name: "IX_TeretRezervacija_TeretID",
                table: "TeretRezervacija",
                column: "TeretID");

            migrationBuilder.CreateIndex(
                name: "IX_TeretRezervacija_UserID",
                table: "TeretRezervacija",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_TipTereta_Teret_TeretID",
                table: "TipTereta_Teret",
                column: "TeretID");

            migrationBuilder.CreateIndex(
                name: "IX_TipTereta_Teret_TipTeretaID",
                table: "TipTereta_Teret",
                column: "TipTeretaID");

            migrationBuilder.CreateIndex(
                name: "IX_TipVozila_PrijevoznikID",
                table: "TipVozila",
                column: "PrijevoznikID");

            migrationBuilder.CreateIndex(
                name: "IX_Vozilo_DetaljiVozilaID",
                table: "Vozilo",
                column: "DetaljiVozilaID");

            migrationBuilder.CreateIndex(
                name: "IX_Vozilo_ModelVozilaID",
                table: "Vozilo",
                column: "ModelVozilaID");

            migrationBuilder.CreateIndex(
                name: "IX_Vozilo_PrijevoznikID",
                table: "Vozilo",
                column: "PrijevoznikID");

            migrationBuilder.CreateIndex(
                name: "IX_Vozilo_TipVozilaID",
                table: "Vozilo",
                column: "TipVozilaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DodatneUsluge_Teret");

            migrationBuilder.DropTable(
                name: "KomentarOcjena");

            migrationBuilder.DropTable(
                name: "Notifikacija");

            migrationBuilder.DropTable(
                name: "SlikaVozilo");

            migrationBuilder.DropTable(
                name: "SlikeTereta");

            migrationBuilder.DropTable(
                name: "TipTereta_Teret");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "DodatneUsluge");

            migrationBuilder.DropTable(
                name: "TeretRezervacija");

            migrationBuilder.DropTable(
                name: "Slike");

            migrationBuilder.DropTable(
                name: "TipTereta");

            migrationBuilder.DropTable(
                name: "Prijevoz");

            migrationBuilder.DropTable(
                name: "Teret");

            migrationBuilder.DropTable(
                name: "Vozilo");

            migrationBuilder.DropTable(
                name: "DetaljiVozila");

            migrationBuilder.DropTable(
                name: "ModelVozila");

            migrationBuilder.DropTable(
                name: "TipVozila");

            migrationBuilder.DropTable(
                name: "Prijevoznik");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Adresa");

            migrationBuilder.DropTable(
                name: "Grad");

            migrationBuilder.DropTable(
                name: "Drzava");
        }
    }
}
