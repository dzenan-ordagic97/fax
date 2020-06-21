using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UslugePrijevoza.Web.Areas.Identity.Data;

namespace UslugePrijevoza.Web.Models
{
    public class MojDBContext : IdentityDbContext<MojIdentityUser, IdentityRole<int>, int>
    {
        public MojDBContext(DbContextOptions<MojDBContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public DbSet<Drzava> Drzava { get; set; }
        public DbSet<Adresa> Adresa { get; set; }
        public DbSet<Grad> Grad { get; set; }
        public DbSet<Prijevoznik> Prijevoznik { get; set; }
        public DbSet<DetaljiVozila> DetaljiVozila { get; set; }
        public DbSet<DodatneUsluge> DodatneUsluge { get; set; }
        public DbSet<DodatneUsluge_Teret> DodatneUsluge_Teret { get; set; }
        public DbSet<KomentarOcjena> KomentarOcjena { get; set; }
        public DbSet<ModelVozila> ModelVozila { get; set; }
        public DbSet<Prijevoz> Prijevoz { get; set; }
        public DbSet<SlikaVozilo> SlikaVozilo { get; set; }
        public DbSet<Slike> Slike { get; set; }
        public DbSet<SlikeTereta> SlikeTereta { get; set; }
        public DbSet<Teret> Teret { get; set; }
        public DbSet<TeretRezervacija> TeretRezervacija { get; set; }
        public DbSet<TipTereta> TipTereta { get; set; }
        public DbSet<TipTereta_Teret> TipTereta_Teret { get; set; }
        public DbSet<TipVozila> TipVozila { get; set; }
        public DbSet<Vozilo> Vozilo { get; set; }
        public DbSet<Notifikacija> Notifikacija { get; set; }
    }
}
