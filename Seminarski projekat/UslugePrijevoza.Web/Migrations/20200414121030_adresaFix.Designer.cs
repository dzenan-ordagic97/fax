﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UslugePrijevoza.Web.Models;

namespace UslugePrijevoza.Web.Migrations
{
    [DbContext(typeof(MojDBContext))]
    [Migration("20200414121030_adresaFix")]
    partial class adresaFix
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Areas.Identity.Data.MojIdentityUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int?>("AdresaID")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("JMBG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SignalRToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slika")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Spol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("AdresaID");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.Adresa", b =>
                {
                    b.Property<int>("AdresaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdresaID");

                    b.HasIndex("GradID");

                    b.ToTable("Adresa");
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.DetaljiVozila", b =>
                {
                    b.Property<int>("DetaljiVozilaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Br_EUPaleta")
                        .HasColumnType("int");

                    b.Property<double>("Cijena_km")
                        .HasColumnType("float");

                    b.Property<double>("MaxDuzina")
                        .HasColumnType("float");

                    b.Property<double>("MaxSirina")
                        .HasColumnType("float");

                    b.Property<double>("MaxTezina")
                        .HasColumnType("float");

                    b.Property<double>("MaxVisina")
                        .HasColumnType("float");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DetaljiVozilaID");

                    b.ToTable("DetaljiVozila");
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.DodatneUsluge", b =>
                {
                    b.Property<int>("DodatneUslugeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cijena")
                        .HasColumnType("float");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PrijevoznikID")
                        .HasColumnType("int");

                    b.HasKey("DodatneUslugeID");

                    b.HasIndex("PrijevoznikID");

                    b.ToTable("DodatneUsluge");
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.DodatneUsluge_Teret", b =>
                {
                    b.Property<int>("DodatneUsluge_TeretID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DodatneUslugeID")
                        .HasColumnType("int");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeretRezervacijaID")
                        .HasColumnType("int");

                    b.Property<double>("UkupnaCijenaUsluge")
                        .HasColumnType("float");

                    b.HasKey("DodatneUsluge_TeretID");

                    b.HasIndex("DodatneUslugeID");

                    b.HasIndex("TeretRezervacijaID");

                    b.ToTable("DodatneUsluge_Teret");
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.Drzava", b =>
                {
                    b.Property<int>("DrzavaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Skracenica")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DrzavaID");

                    b.ToTable("Drzava");
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.Grad", b =>
                {
                    b.Property<int>("GradID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DrzavaID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostanskiBroj")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GradID");

                    b.HasIndex("DrzavaID");

                    b.ToTable("Grad");
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.KomentarOcjena", b =>
                {
                    b.Property<int>("KomentarOcjenaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Komentar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ocjena")
                        .HasColumnType("int");

                    b.Property<int>("PrijevozID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("KomentarOcjenaID");

                    b.HasIndex("PrijevozID");

                    b.HasIndex("UserID");

                    b.ToTable("KomentarOcjena");
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.ModelVozila", b =>
                {
                    b.Property<int>("ModelVozilaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PrijevoznikID")
                        .HasColumnType("int");

                    b.HasKey("ModelVozilaID");

                    b.HasIndex("PrijevoznikID");

                    b.ToTable("ModelVozila");
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.Notifikacija", b =>
                {
                    b.Property<int>("NotifikacijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Otvorena")
                        .HasColumnType("bit");

                    b.Property<string>("Poruka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserFromID")
                        .HasColumnType("int");

                    b.Property<int?>("UserToID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Vrijeme")
                        .HasColumnType("datetime2");

                    b.HasKey("NotifikacijaID");

                    b.HasIndex("UserFromID");

                    b.HasIndex("UserToID");

                    b.ToTable("Notifikacija");
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.Prijevoz", b =>
                {
                    b.Property<int>("PrijevozID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("Cijena")
                        .HasColumnType("float");

                    b.Property<DateTime?>("DatumPotvrde")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumPrijevoza")
                        .HasColumnType("datetime2");

                    b.Property<double?>("Kilometraza")
                        .HasColumnType("float");

                    b.Property<int>("PrijevoznikID")
                        .HasColumnType("int");

                    b.Property<string>("TipPrijevoza")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VoziloID")
                        .HasColumnType("int");

                    b.Property<bool?>("Zavrseno")
                        .HasColumnType("bit");

                    b.HasKey("PrijevozID");

                    b.HasIndex("PrijevoznikID");

                    b.HasIndex("VoziloID");

                    b.ToTable("Prijevoz");
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.Prijevoznik", b =>
                {
                    b.Property<int>("PrijevoznikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailPrijevoznika")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NazivPrijevoznika")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PoslovniTelefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("PrijevoznikID");

                    b.HasIndex("UserID");

                    b.ToTable("Prijevoznik");
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.SlikaVozilo", b =>
                {
                    b.Property<int>("SlikaVoziloID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DetaljiVozilaID")
                        .HasColumnType("int");

                    b.Property<int>("Pozicija")
                        .HasColumnType("int");

                    b.Property<int>("SlikeID")
                        .HasColumnType("int");

                    b.HasKey("SlikaVoziloID");

                    b.HasIndex("DetaljiVozilaID");

                    b.HasIndex("SlikeID");

                    b.ToTable("SlikaVozilo");
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.Slike", b =>
                {
                    b.Property<int>("SlikeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SlikeID");

                    b.ToTable("Slike");
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.SlikeTereta", b =>
                {
                    b.Property<int>("SlikeTeretaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Pozicija")
                        .HasColumnType("int");

                    b.Property<int>("SlikeID")
                        .HasColumnType("int");

                    b.Property<int>("TeretID")
                        .HasColumnType("int");

                    b.HasKey("SlikeTeretaID");

                    b.HasIndex("SlikeID");

                    b.HasIndex("TeretID");

                    b.ToTable("SlikeTereta");
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.Teret", b =>
                {
                    b.Property<int>("TeretID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("MaxSirina")
                        .HasColumnType("float");

                    b.Property<double>("MaxVisina")
                        .HasColumnType("float");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Tezina")
                        .HasColumnType("float");

                    b.HasKey("TeretID");

                    b.ToTable("Teret");
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.TeretRezervacija", b =>
                {
                    b.Property<int>("TeretRezervacijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KrajnjaLokacija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("KrajnjiDatumPrijevoza")
                        .HasColumnType("datetime2");

                    b.Property<string>("PocetnaLokacija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PocetniDatumPrijevoza")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Prihvaceno")
                        .HasColumnType("bit");

                    b.Property<int?>("PrijevozID")
                        .HasColumnType("int");

                    b.Property<int>("TeretID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("TeretRezervacijaID");

                    b.HasIndex("PrijevozID");

                    b.HasIndex("TeretID");

                    b.HasIndex("UserID");

                    b.ToTable("TeretRezervacija");
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.TipTereta", b =>
                {
                    b.Property<int>("TipTeretaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipTeretaID");

                    b.ToTable("TipTereta");
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.TipTereta_Teret", b =>
                {
                    b.Property<int>("TipTereta_TeretID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TeretID")
                        .HasColumnType("int");

                    b.Property<int>("TipTeretaID")
                        .HasColumnType("int");

                    b.HasKey("TipTereta_TeretID");

                    b.HasIndex("TeretID");

                    b.HasIndex("TipTeretaID");

                    b.ToTable("TipTereta_Teret");
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.TipVozila", b =>
                {
                    b.Property<int>("TipVozilaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PrijevoznikID")
                        .HasColumnType("int");

                    b.HasKey("TipVozilaID");

                    b.HasIndex("PrijevoznikID");

                    b.ToTable("TipVozila");
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.Vozilo", b =>
                {
                    b.Property<int>("VoziloID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojMjesta")
                        .HasColumnType("int");

                    b.Property<int?>("DetaljiVozilaID")
                        .HasColumnType("int");

                    b.Property<DateTime>("GodinaProizvodnje")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModelVozilaID")
                        .HasColumnType("int");

                    b.Property<int>("PrijevoznikID")
                        .HasColumnType("int");

                    b.Property<string>("RegistracijskaOznaka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipVozilaID")
                        .HasColumnType("int");

                    b.Property<double>("ZapreminaPrtljaznika")
                        .HasColumnType("float");

                    b.HasKey("VoziloID");

                    b.HasIndex("DetaljiVozilaID");

                    b.HasIndex("ModelVozilaID");

                    b.HasIndex("PrijevoznikID");

                    b.HasIndex("TipVozilaID");

                    b.ToTable("Vozilo");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("UslugePrijevoza.Web.Areas.Identity.Data.MojIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("UslugePrijevoza.Web.Areas.Identity.Data.MojIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UslugePrijevoza.Web.Areas.Identity.Data.MojIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("UslugePrijevoza.Web.Areas.Identity.Data.MojIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Areas.Identity.Data.MojIdentityUser", b =>
                {
                    b.HasOne("UslugePrijevoza.Web.Models.Adresa", "Adresa")
                        .WithMany("Useri")
                        .HasForeignKey("AdresaID");
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.Adresa", b =>
                {
                    b.HasOne("UslugePrijevoza.Web.Models.Grad", "Grad")
                        .WithMany("Adrese")
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.DodatneUsluge", b =>
                {
                    b.HasOne("UslugePrijevoza.Web.Models.Prijevoznik", "Prijevoznik")
                        .WithMany("Usluge")
                        .HasForeignKey("PrijevoznikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.DodatneUsluge_Teret", b =>
                {
                    b.HasOne("UslugePrijevoza.Web.Models.DodatneUsluge", "DodatneUsluge")
                        .WithMany()
                        .HasForeignKey("DodatneUslugeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UslugePrijevoza.Web.Models.TeretRezervacija", "TeretRezervacija")
                        .WithMany("DodatneUsluge")
                        .HasForeignKey("TeretRezervacijaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.Grad", b =>
                {
                    b.HasOne("UslugePrijevoza.Web.Models.Drzava", "Drzava")
                        .WithMany("Gradovi")
                        .HasForeignKey("DrzavaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.KomentarOcjena", b =>
                {
                    b.HasOne("UslugePrijevoza.Web.Models.Prijevoz", "Prijevoz")
                        .WithMany("komentarOcjena")
                        .HasForeignKey("PrijevozID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UslugePrijevoza.Web.Areas.Identity.Data.MojIdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.ModelVozila", b =>
                {
                    b.HasOne("UslugePrijevoza.Web.Models.Prijevoznik", "Prijevoznik")
                        .WithMany()
                        .HasForeignKey("PrijevoznikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.Notifikacija", b =>
                {
                    b.HasOne("UslugePrijevoza.Web.Areas.Identity.Data.MojIdentityUser", "UserFrom")
                        .WithMany()
                        .HasForeignKey("UserFromID");

                    b.HasOne("UslugePrijevoza.Web.Areas.Identity.Data.MojIdentityUser", "UserTo")
                        .WithMany()
                        .HasForeignKey("UserToID");
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.Prijevoz", b =>
                {
                    b.HasOne("UslugePrijevoza.Web.Models.Prijevoznik", "Prijevoznik")
                        .WithMany("Prijevoz")
                        .HasForeignKey("PrijevoznikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UslugePrijevoza.Web.Models.Vozilo", "Vozilo")
                        .WithMany("Prijevoz")
                        .HasForeignKey("VoziloID");
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.Prijevoznik", b =>
                {
                    b.HasOne("UslugePrijevoza.Web.Areas.Identity.Data.MojIdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.SlikaVozilo", b =>
                {
                    b.HasOne("UslugePrijevoza.Web.Models.DetaljiVozila", "DetaljiVozila")
                        .WithMany("Slike")
                        .HasForeignKey("DetaljiVozilaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UslugePrijevoza.Web.Models.Slike", "Slike")
                        .WithMany()
                        .HasForeignKey("SlikeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.SlikeTereta", b =>
                {
                    b.HasOne("UslugePrijevoza.Web.Models.Slike", "Slike")
                        .WithMany()
                        .HasForeignKey("SlikeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UslugePrijevoza.Web.Models.Teret", "Teret")
                        .WithMany("Slike")
                        .HasForeignKey("TeretID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.TeretRezervacija", b =>
                {
                    b.HasOne("UslugePrijevoza.Web.Models.Prijevoz", "Prijevoz")
                        .WithMany()
                        .HasForeignKey("PrijevozID");

                    b.HasOne("UslugePrijevoza.Web.Models.Teret", "Teret")
                        .WithMany()
                        .HasForeignKey("TeretID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UslugePrijevoza.Web.Areas.Identity.Data.MojIdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.TipTereta_Teret", b =>
                {
                    b.HasOne("UslugePrijevoza.Web.Models.Teret", "Teret")
                        .WithMany("TipTereta")
                        .HasForeignKey("TeretID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UslugePrijevoza.Web.Models.TipTereta", "TipTereta")
                        .WithMany()
                        .HasForeignKey("TipTeretaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.TipVozila", b =>
                {
                    b.HasOne("UslugePrijevoza.Web.Models.Prijevoznik", "Prijevoznik")
                        .WithMany()
                        .HasForeignKey("PrijevoznikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UslugePrijevoza.Web.Models.Vozilo", b =>
                {
                    b.HasOne("UslugePrijevoza.Web.Models.DetaljiVozila", "DetaljiVozila")
                        .WithMany()
                        .HasForeignKey("DetaljiVozilaID");

                    b.HasOne("UslugePrijevoza.Web.Models.ModelVozila", "ModelVozila")
                        .WithMany()
                        .HasForeignKey("ModelVozilaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UslugePrijevoza.Web.Models.Prijevoznik", "Prijevoznik")
                        .WithMany("Vozila")
                        .HasForeignKey("PrijevoznikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UslugePrijevoza.Web.Models.TipVozila", "TipVozila")
                        .WithMany()
                        .HasForeignKey("TipVozilaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
