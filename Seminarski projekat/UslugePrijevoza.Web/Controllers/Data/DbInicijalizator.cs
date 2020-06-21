using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UslugePrijevoza.Web.Areas.Identity.Data;
using UslugePrijevoza.Web.Models;

namespace UslugePrijevoza.Web.Controllers.Data
{
    public class DbInicijalizator
    {
        public static async Task Napuni(MojDBContext context, UserManager<MojIdentityUser> userManager, RoleManager<IdentityRole<int>> roleManager, ILogger<DbInicijalizator> logger)
        {

            if (context.Grad.Any())
            {
                return;
            }

            var gradoviBiH = new List<Grad>();
            var gradoviHR = new List<Grad>();
            var drzave = new List<Drzava>();
            var adrese = new List<Adresa>();
            var tereti = new List<Teret>();
            var teretRezervacija = new List<TeretRezervacija>();
            var prijevoznikList = new List<Prijevoznik>();
            var prijevoz = new List<Prijevoz>();
            var dodatneUsluge = new List<DodatneUsluge>();
            var dodatneUsluge_Teret = new List<DodatneUsluge_Teret>();
            var komentar_ocjena = new List<KomentarOcjena>();
            var vozila = new List<Vozilo>();
            var modelVozila = new List<ModelVozila>();
            var tipVozila = new List<TipVozila>();
            var detaljiVozila = new List<DetaljiVozila>();
            var slike = new List<Slike>();
            var slikaVozilo = new List<SlikaVozilo>();
            var slikeTeret = new List<SlikeTereta>();




            //Gradovi
            gradoviBiH.Add(new Grad { Naziv = "Sarajevo" });
            gradoviBiH.Add(new Grad { Naziv = "Mostar" });
            gradoviBiH.Add(new Grad { Naziv = "Velika Kladusa" });
            gradoviBiH.Add(new Grad { Naziv = "Tuzla" });
            gradoviBiH.Add(new Grad { Naziv = "Banja Luka" });
            gradoviBiH.Add(new Grad { Naziv = "Brcko" });
            gradoviHR.Add(new Grad { Naziv = "Zagreb" });
            gradoviHR.Add(new Grad { Naziv = "Karlovac" });
            gradoviHR.Add(new Grad { Naziv = "Pula" });
            //Drzave
            drzave.Add(new Drzava { Naziv = "Bosna i Hercegovina", Skracenica = "BiH", Gradovi = gradoviBiH });
            drzave.Add(new Drzava { Naziv = "Hrvatska", Skracenica = "HR", Gradovi = gradoviHR });
            context.Drzava.AddRange(drzave);
            context.SaveChanges();

            //Adrese
            adrese.Add(new Adresa { Naziv = "Sarajevska bb", GradID = 1 });
            adrese.Add(new Adresa { Naziv = "Mostarska bb",GradID=2 });
            adrese.Add(new Adresa { Naziv = "Barake bb",GradID=3 });
            adrese.Add(new Adresa { Naziv = "Zagrebacka bb", GradID = 7 });
            context.Adresa.AddRange(adrese);
            context.SaveChanges();

            //Odabir adrese
            var Mostar = context.Adresa.Select(s => s).SingleOrDefault(p => p.Naziv == "Mostarska bb");
            var Zagreb = context.Adresa.Select(s => s).SingleOrDefault(p => p.Naziv == "Zagrebacka bb");
            var Sarajevo = context.Adresa.Select(s => s).SingleOrDefault(p => p.Naziv == "Sarajevska bb");
            var VelikaKladusa = context.Adresa.Select(s => s).SingleOrDefault(p => p.Naziv == "Barake bb");

            //KREIRANJE ULOGA ADMINISTRATOR, UPOSLENIK, KLIJENT ...
            string admin = "Administrator";
            string prijevoznik = "Prijevoznik";
            string klijent = "Klijent";

            await roleManager.CreateAsync(new IdentityRole<int> { Name = prijevoznik, NormalizedName = prijevoznik.ToUpper() });
            await roleManager.CreateAsync(new IdentityRole<int> { Name = klijent, NormalizedName = klijent.ToUpper() });
            await roleManager.CreateAsync(new IdentityRole<int> { Name = admin, NormalizedName = admin.ToUpper() });

            //KREIRANJE ADMINISTRATORA
            await KreirajKorisnika(userManager, "admin@fitransport.com", "James", "Willems", "0133546579", new DateTime(1996, 5, 6), "Male","060-505-378",  "P@sword123",Mostar, admin);
            //KREIRANJE KLIJENTA
            await KreirajKorisnika(userManager, "John.Doe@gmail.com", "John", "Doe", "123456789", new DateTime(1999, 10, 6), "Male", "062-100-200", "Jd123+-", Zagreb, klijent);
            await KreirajKorisnika(userManager, "Jane.Doe@gmail.com", "Jane", "Doe", "987654321", new DateTime(1980, 11, 12), "Female", "063-300-500", "Jd123+-", Sarajevo, klijent);
            //KREIRANJE PRIJEVOZNIKA
            await KreirajKorisnika(userManager, "Jonathan.Byers@gmail.com", "Jonathan", "Byers", "567891234", new DateTime(1975, 10, 6), "Male", "064-400-200", "Jb123+-", VelikaKladusa, prijevoznik);
            prijevoznikList.Add(new Prijevoznik { UserID = 4, EmailPrijevoznika = "Jonathan.Transport@gmail.com", NazivPrijevoznika = "StrangerTransport"});
            context.Prijevoznik.AddRange(prijevoznikList);
            context.SaveChanges();

            //Slike
            slike.Add(new Slike { Naziv = "Teret_drvaa", URL = "/images/Teret/teret_hrpa_drva.jpg" });
            slike.Add(new Slike { Naziv = "Teret_drva", URL = "/images/Teret/teret_drva.jpg" });
            slike.Add(new Slike { Naziv = "Lamborghini Tractor", URL = "/images/Vozila/Traktor.jpg" });
            slike.Add(new Slike { Naziv = "Scania Truck", URL = "/images/Vozila/Scania.jpg" });
            slike.Add(new Slike { Naziv = "Volvo Truck", URL = "/images/Vozila/Volvo.jpg" });
            context.Slike.AddRange(slike);
            context.SaveChanges();

            //Detalji vozila
            detaljiVozila.Add(new DetaljiVozila { Br_EUPaleta = 5, Cijena_km = 100, MaxDuzina = 200, MaxSirina = 100, MaxTezina = 200, MaxVisina = 300, Opis = "TESTNI_OPIS", Slike = slikaVozilo });
            //Slike vozilo
            slikaVozilo.Add(new SlikaVozilo { SlikeID = 1, DetaljiVozilaID = 1, Pozicija = 1 });
            context.DetaljiVozila.AddRange(detaljiVozila);
            context.SlikaVozilo.AddRange(slikaVozilo);
            context.SaveChanges();

            //Model vozila
            modelVozila.Add(new ModelVozila { Naziv = "Lamborghini", PrijevoznikID = 1 });
            modelVozila.Add(new ModelVozila { Naziv = "Scania", PrijevoznikID = 1 });
            modelVozila.Add(new ModelVozila { Naziv = "Volvo", PrijevoznikID = 1 });
            context.ModelVozila.AddRange(modelVozila);

            //Tip vozila
            tipVozila.Add(new TipVozila { Naziv = "Traktor", PrijevoznikID = 1 });
            tipVozila.Add(new TipVozila { Naziv = "Kamion", PrijevoznikID = 1 });
            context.TipVozila.AddRange(tipVozila);

            //Vozila
            vozila.Add(new Vozilo { TipVozilaID = 1, ZapreminaPrtljaznika = 2000, RegistracijskaOznaka = "123-456", PrijevoznikID = 1, ModelVozilaID = 1, GodinaProizvodnje = new DateTime(2020, 01, 01), BrojMjesta = 2, DetaljiVozilaID = 1 });
            context.Vozilo.AddRange(vozila);

            //Tereti
            tereti.Add(new Teret { MaxSirina = 200, MaxVisina = 100, Naziv = "Prijevoz namjestaja", Opis = "Potreban prijevoz namjestaja-detalji", Tezina = 1000 });
            tereti.Add(new Teret { MaxSirina = 100, MaxVisina = 300, Naziv = "Prijevoz drva", Opis = "Potreban prijevoz drva-detalji", Tezina = 5000 });
            context.Teret.AddRange(tereti);
            context.SaveChanges();

            //Slike teret
            slikeTeret.Add(new SlikeTereta { SlikeID = 4, Pozicija = 2, TeretID = 1 });
            slikeTeret.Add(new SlikeTereta { SlikeID = 5, Pozicija = 3, TeretID = 1 });
            context.SlikeTereta.AddRange(slikeTeret);
            context.SaveChanges();

            //Prijevoz
            prijevoz.Add(new Prijevoz { PrijevoznikID = 1, });
            prijevoz.Add(new Prijevoz { Cijena = 500, DatumPotvrde = new DateTime(2020, 01, 01), DatumPrijevoza = new DateTime(2020, 02, 02), Kilometraza = 200, PrijevoznikID = 1, Zavrseno = true,VoziloID=1 });
            prijevoz.Add(new Prijevoz { Cijena = 1000, DatumPotvrde = new DateTime(2020, 03, 04), DatumPrijevoza = new DateTime(2020, 04, 04), Kilometraza = 2000, PrijevoznikID = 1, Zavrseno = true,VoziloID=1 });
            prijevoz.Add(new Prijevoz { Cijena = 20000, DatumPotvrde = new DateTime(2020, 05, 06), DatumPrijevoza = new DateTime(2020, 07, 07), Kilometraza = 3000, PrijevoznikID = 1, Zavrseno = true,VoziloID=1 });
            //prijevoz.Add(new Prijevoz { Cijena = 2000, DatumPotvrde = new DateTime(2020, 05, 07), DatumPrijevoza = new DateTime(2020, 07, 07), Kilometraza = 3000, PrijevoznikID = 1, Zavrseno = true });
            context.Prijevoz.AddRange(prijevoz);
            context.SaveChanges();

            //KomentarOcjena
            komentar_ocjena.Add(new KomentarOcjena { Komentar = "neki_komenta4", Ocjena = 4, PrijevozID = 4, UserID = 2 });
            komentar_ocjena.Add(new KomentarOcjena { Komentar = "neki_komentar", Ocjena = 5, PrijevozID = 2, UserID = 2 });
            komentar_ocjena.Add(new KomentarOcjena { Komentar = "neki_komentar2", Ocjena = 4, PrijevozID = 3, UserID = 3 });
            komentar_ocjena.Add(new KomentarOcjena { Komentar = "neki_komenta3", Ocjena = 3, PrijevozID = 1, UserID = 2 });
            context.KomentarOcjena.AddRange(komentar_ocjena);
            context.SaveChanges();

            //DodatneUsluge
            dodatneUsluge.Add(new DodatneUsluge { PrijevoznikID = 1, Cijena = 500, Naziv = "testni", Opis = "testni_opis" });
            context.DodatneUsluge.AddRange(dodatneUsluge);
            context.SaveChanges();

            //TeretRezervacije
            teretRezervacija.Add(new TeretRezervacija { PocetnaLokacija = "Bihac", KrajnjaLokacija = "Zagreb", PocetniDatumPrijevoza = new DateTime(2020, 09, 09), KrajnjiDatumPrijevoza = new DateTime(2020, 10, 10), Prihvaceno = false, PrijevozID = 4, TeretID = 1, UserID = 2, DodatneUsluge = dodatneUsluge_Teret });
            teretRezervacija.Add(new TeretRezervacija { PocetnaLokacija = "Mostar", KrajnjaLokacija = "Sarajevo", PocetniDatumPrijevoza = new DateTime(2020, 06, 06), KrajnjiDatumPrijevoza = new DateTime(2020, 08, 08), Prihvaceno = false, TeretID = 2, UserID = 3 });
            teretRezervacija.Add(new TeretRezervacija { PocetnaLokacija = "Karlovac", KrajnjaLokacija = "Zenica", PocetniDatumPrijevoza = new DateTime(2020, 06, 06), KrajnjiDatumPrijevoza = new DateTime(2020, 08, 08), Prihvaceno = false, TeretID = 1, UserID = 2 });
            teretRezervacija.Add(new TeretRezervacija { PocetnaLokacija = "Zenica", KrajnjaLokacija = "Buzim", PocetniDatumPrijevoza = new DateTime(2020, 07, 06), KrajnjiDatumPrijevoza = new DateTime(2020, 09, 08), Prihvaceno = true,PrijevozID=3, TeretID = 1, UserID = 2 });
            teretRezervacija.Add(new TeretRezervacija { PocetnaLokacija = "Doboj", KrajnjaLokacija = "Gorazde", PocetniDatumPrijevoza = new DateTime(2020, 02, 01), KrajnjiDatumPrijevoza = new DateTime(2020, 03, 01), Prihvaceno = true, PrijevozID = 2, TeretID = 1, UserID = 3 });
            teretRezervacija.Add(new TeretRezervacija { PocetnaLokacija = "Prijedor", KrajnjaLokacija = "Mostar", PocetniDatumPrijevoza = new DateTime(2020, 01, 01), KrajnjiDatumPrijevoza = new DateTime(2020, 03, 01), Prihvaceno = true, PrijevozID = 1, TeretID = 1, UserID = 3 });
            dodatneUsluge_Teret.Add(new DodatneUsluge_Teret { DodatneUslugeID = 1, Kolicina = 500, Opis = "testni_opis_dodatne", TeretRezervacijaID = 1, UkupnaCijenaUsluge = 500 });
            context.TeretRezervacija.AddRange(teretRezervacija);
            context.DodatneUsluge_Teret.AddRange(dodatneUsluge_Teret);
            context.SaveChanges();



        }
        private static async Task KreirajKorisnika(UserManager<MojIdentityUser> um, string username, string ime, string prezime, string jmbg, DateTime datumRodjena, string spol,string telefon, string password,Adresa adresa, string rola)
        {
            await um.CreateAsync(new MojIdentityUser
            {
                UserName = username,
                Email = username,
                Ime = ime,
                Prezime = prezime,
                JMBG = jmbg,
                DatumRodjenja = datumRodjena,
                Spol = spol,
                Adresa=adresa,
                PhoneNumber=telefon,
                EmailConfirmed=true
            });

            var korisnik = await um.FindByEmailAsync(username);
            await um.AddPasswordAsync(korisnik, password);
            await um.AddToRoleAsync(korisnik, rola);
        }
    }
}
