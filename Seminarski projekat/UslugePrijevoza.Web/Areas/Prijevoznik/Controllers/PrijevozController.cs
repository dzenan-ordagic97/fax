using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UslugePrijevoza.Web.Areas.Prijevoznik.ViewModels;
using UslugePrijevoza.Web.Models;
using UslugePrijevoza.Web.Services;

namespace UslugePrijevoza.Web.Areas.Prijevoznik.Controllers
{
    public class PrijevozController : BaseController
    {
        private readonly INotifikacija _notifikacijaService;

        public PrijevozController(MojDBContext db, INotifikacija notifikacija) : base(db)
        {
            _notifikacijaService = notifikacija;
        }
        public IActionResult Index()
        {
            PrijevozIndexVM prijevoz = new PrijevozIndexVM();
            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int _PrijevoznikID = _db.Prijevoznik.Where(x => x.UserID == int.Parse(id)).Select(x => x.PrijevoznikID).FirstOrDefault();
            prijevoz.rezervacije = _db.TeretRezervacija.OrderBy(x => x.KrajnjiDatumPrijevoza).Include(x => x.Teret).Where(x => x.Prijevoz.PrijevoznikID == _PrijevoznikID || x.PrijevozID == null).Select(x => new PrijevozIndexVM.Row()
            {
                TeretRezervacijaID = x.TeretRezervacijaID,
                PocetnaLokacija = x.PocetnaLokacija,
                KrajnjaLokacija = x.KrajnjaLokacija,
                PocetniDatumPrijevoza = x.PocetniDatumPrijevoza.ToString("dd.MM.yyyy"),
                KrajnjiDatumPrijevoza = x.KrajnjiDatumPrijevoza.ToString("dd.MM.yyyy"),
                User = x.User.Ime + " " + x.User.Prezime,
                Naziv = x.Teret.Naziv,
                Opis = x.Teret.Opis,
                Tezina = x.Teret.Tezina.ToString() + "kg",
                MaxSirina = x.Teret.MaxSirina.ToString() + "m",
                MaxVisina = x.Teret.MaxVisina.ToString() + "m",
                Prihvaceno = x.Prihvaceno,
                Zavrseno = x.Prijevoz.Zavrseno ?? false,
                PrijevozID = x.PrijevozID
            }).ToList();
            prijevoz.BrojacGlobalno = _db.TeretRezervacija.Where(y => y.PrijevozID == null).Count();
            prijevoz.BrojacPrijevoznik = _db.TeretRezervacija.Where(y => y.Prijevoz.PrijevoznikID == _PrijevoznikID && y.Prijevoz.DatumPotvrde == null).Count();
            prijevoz.BrojacPrihvacenih = _db.TeretRezervacija.Where(y => y.Prijevoz.PrijevoznikID == _PrijevoznikID && y.Prijevoz.Zavrseno == null && y.Prihvaceno==true).Count();
            return View(prijevoz);
        }
        public IActionResult Detaljno(int id)
        {
            if (id == 0)
            {
                return View(nameof(Index));
            }
            string _id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int _PrijevoznikID = _db.Prijevoznik.Where(x => x.UserID == int.Parse(_id)).Select(x => x.PrijevoznikID).FirstOrDefault();
            PrijevozDetaljnoVM model = new PrijevozDetaljnoVM();
            model = _db.TeretRezervacija.Include(x => x.Teret).Include(x => x.DodatneUsluge).Include(x => x.Prijevoz).Where(x => x.TeretRezervacijaID == id).Select(x => new PrijevozDetaljnoVM()
            {
                CijenaDodatneUsluge = x.DodatneUsluge.Where(y => y.TeretRezervacijaID == x.TeretRezervacijaID).Select(y => y.DodatneUsluge.Cijena).FirstOrDefault().ToString(),
                KolicinaDodatneUsluge = x.DodatneUsluge.Where(y => y.TeretRezervacijaID == x.TeretRezervacijaID).Select(y => y.Kolicina).FirstOrDefault().ToString(),
                KrajnjaLokacija = x.KrajnjaLokacija,
                MaxSirina = x.Teret.MaxSirina.ToString(),
                TeretRezervacijaID = x.TeretRezervacijaID,
                MaxVisina = x.Teret.MaxVisina.ToString(),
                NazivDodatneUsluge = x.DodatneUsluge.Where(y => y.TeretRezervacijaID == x.TeretRezervacijaID).Select(y => y.DodatneUsluge.Naziv).FirstOrDefault(),
                NazivTereta = x.Teret.Naziv,
                OpisDodatneUsluge = x.DodatneUsluge.Where(y => y.TeretRezervacijaID == x.TeretRezervacijaID).Select(y => y.DodatneUsluge.Opis).FirstOrDefault(),
                OpisTereta = x.Teret.Opis,
                PocetnaLokacija = x.PocetnaLokacija,
                PocetniDatumPrijevoza = x.PocetniDatumPrijevoza.ToString("dd.MM.yyyy"),
                Tezina = x.Teret.Tezina.ToString(),
                TipPrijevoza = x.Prijevoz.TipPrijevoza,
                User = x.User.Ime + " " + x.User.Prezime,
                Slike = _db.SlikeTereta.Include(y => y.Slike).Where(y => y.TeretID == x.TeretID).ToList()

            }).FirstOrDefault();

            model.DodatneUsluge = _db.DodatneUsluge_Teret.Where(x => x.TeretRezervacijaID == model.TeretRezervacijaID).Select(x => new PrijevozDetaljnoVM.Row()
            {
                Cijena = x.UkupnaCijenaUsluge,
                Naziv = x.DodatneUsluge.Naziv,
                Opis = x.Opis,
                Kolicina = x.Kolicina
            }).ToList();
            if(_db.TeretRezervacija.Where(x=>x.TeretRezervacijaID==id && x.Prihvaceno==true).Select(x=>x.Prihvaceno).FirstOrDefault()==true)
            {
                model.Trigger = true;
            }
            return View(model);
        }
        public IActionResult Dodaj(int id)
        {
            string _id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int _PrijevoznikID = _db.Prijevoznik.Where(x => x.UserID == int.Parse(_id)).Select(x => x.PrijevoznikID).FirstOrDefault();
            PrijevozDodajVM model = new PrijevozDodajVM();
            model.PrijevoznikID = _PrijevoznikID;
            model.TeretRezervacijaID = id;
            model.BrojacVozila = _db.Vozilo.Where(x => x.PrijevoznikID == _PrijevoznikID).Count();
            model.Vozila = _db.Vozilo.Include(x => x.ModelVozila).Where(x => x.PrijevoznikID == _PrijevoznikID).Select(x => new SelectListItem()
            {
                Text = x.ModelVozila.Naziv,
                Value = x.VoziloID.ToString()
            }).ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult Dodaj(PrijevozDodajVM model, int id)
        {
            string _id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int _PrijevoznikID = _db.Prijevoznik.Where(x => x.UserID == int.Parse(_id)).Select(x => x.PrijevoznikID).FirstOrDefault();
            bool trigger = false;
            List<Prijevoz> prijevozi = _db.Prijevoz.ToList();
            List<TeretRezervacija> teretRezervacija = _db.TeretRezervacija.ToList();
            foreach (var item in teretRezervacija)
            {
                foreach (var item2 in prijevozi)
                {
                    if (item.PrijevozID == item2.PrijevozID && item2.DatumPotvrde == null && item.Prijevoz.PrijevoznikID == _PrijevoznikID)
                    {
                        Prijevoz prijevoz = _db.Prijevoz.Where(x => x.PrijevozID == item2.PrijevozID).FirstOrDefault();
                        if (prijevoz != null)
                        {
                            prijevoz.DatumPotvrde = DateTime.Now;
                            prijevoz.DatumPrijevoza = model.DatumPrijevoza;
                            prijevoz.Kilometraza = model.Kilometraza;
                            prijevoz.Cijena = model.Cijena;
                            prijevoz.TipPrijevoza = model.TipPrijevoza;
                            prijevoz.VoziloID = model.VoziloID;
                            TeretRezervacija temp = _db.TeretRezervacija.Where(x => x.TeretRezervacijaID == id).FirstOrDefault();
                            temp.Prihvaceno = true;
                            _db.SaveChanges();
                            _notifikacijaService.posaljiNotifikacijeKlijentu(temp.UserID, temp.Prijevoz.PrijevoznikID, new NotifikacijaVM()
                            {
                                Poruka = "Prijevoznik je prihvatio vasu rezervaciju!",
                                Url = "#"
                            });
                        }
                        trigger = true;
                    }
                }
            }
            if (!trigger)
            {
                Prijevoz p = new Prijevoz()
                {
                    PrijevoznikID = _PrijevoznikID,
                    Cijena = model.Cijena,
                    DatumPotvrde = DateTime.Now,
                    DatumPrijevoza = model.DatumPrijevoza,
                    Kilometraza = model.Kilometraza,
                    TipPrijevoza = model.TipPrijevoza,
                    VoziloID = model.VoziloID
                };
                _db.Prijevoz.Add(p);
                _db.SaveChanges();
                TeretRezervacija temp = _db.TeretRezervacija.Where(x => x.TeretRezervacijaID == id).FirstOrDefault();
                if (temp != null)
                {
                    temp.PrijevozID = p.PrijevozID;
                    temp.Prihvaceno = true;
                    _db.SaveChanges();
                }
                _notifikacijaService.posaljiNotifikacijeKlijentu(temp.UserID, temp.Prijevoz.PrijevoznikID, new NotifikacijaVM()
                {
                    Poruka = "Prijevoznik je prihvatio vasu rezervaciju!",
                    Url = "#"
                });
            }
            return RedirectToActionPermanent(nameof(Index));
        }
        public IActionResult Ukloni(int id)
        {
            int to, from;
            TeretRezervacija teret = _db.TeretRezervacija.Where(x => x.TeretRezervacijaID == id).FirstOrDefault();
            Prijevoz prijevoz = _db.Prijevoz.Where(x => x.PrijevozID == teret.PrijevozID).FirstOrDefault();
            to = teret.UserID;
            from = teret.Prijevoz.PrijevoznikID;
            if (prijevoz != null)
            {
                _db.Prijevoz.Remove(prijevoz);
                teret.PrijevozID = null;
                teret.Prihvaceno = false;
                _db.SaveChanges();
            }
            _notifikacijaService.posaljiNotifikacijeKlijentu(to, from, new NotifikacijaVM()
            {
                Poruka = "Prijevoznik je otkazao vasu rezervaciju!",
                Url = "#"
            });
            return RedirectToActionPermanent(nameof(Index));
        }

        public IActionResult Zavrsi(int id)
        {
            TeretRezervacija teret = _db.TeretRezervacija.Include(x => x.Prijevoz).Where(x => x.TeretRezervacijaID == id).FirstOrDefault();
            if (teret != null)
            {
                teret.Prijevoz.Zavrseno = true;
                _db.SaveChanges();
            }

            _notifikacijaService.posaljiNotifikacijeKlijentu(teret.UserID, teret.Prijevoz.PrijevoznikID, new NotifikacijaVM()
            {
                Poruka = "Prijevoznik je zavrsio vas prijevoz!",
                Url = "#"
            });
            return RedirectToActionPermanent(nameof(Index));
        }
        public IActionResult Pregled()
        {
            PrijevozPregledVM prijevoz = new PrijevozPregledVM();
            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int _PrijevoznikID = _db.Prijevoznik.Where(x => x.UserID == int.Parse(id)).Select(x => x.PrijevoznikID).FirstOrDefault();
            prijevoz.pregledi = _db.TeretRezervacija.Include(x => x.Teret).Where(x => x.Prijevoz.PrijevoznikID == _PrijevoznikID || x.PrijevozID == null).Select(x => new PrijevozPregledVM.Row()
            {
                TeretRezervacijaID = x.TeretRezervacijaID,
                PocetnaLokacija = x.PocetnaLokacija,
                KrajnjaLokacija = x.KrajnjaLokacija,
                PocetniDatumPrijevoza = x.PocetniDatumPrijevoza.ToString("dd.MM.yyyy"),
                KrajnjiDatumPrijevoza = x.KrajnjiDatumPrijevoza.ToString("dd.MM.yyyy"),
                User = x.User.Ime + " " + x.User.Prezime,
                Naziv = x.Teret.Naziv,
                Opis = x.Teret.Opis,
                Tezina = x.Teret.Tezina.ToString() + "kg",
                MaxSirina = x.Teret.MaxSirina.ToString() + "m",
                MaxVisina = x.Teret.MaxVisina.ToString() + "m",
                Prihvaceno = x.Prihvaceno,
                Zavrseno = x.Prijevoz.Zavrseno ?? false,
                PrijevozID = x.PrijevozID,
            }).ToList();
            prijevoz.Prijevoznik = _db.Prijevoznik.Where(x => x.UserID == int.Parse(id)).Select(x => x.User.Ime + " " + x.User.Prezime).FirstOrDefault();
            return View(prijevoz);
        }
        public IActionResult PrikaziMapu(int id)
        {
            PrijevozMapaVM model = new PrijevozMapaVM();
            string _id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int _PrijevoznikID = _db.Prijevoznik.Where(x => x.UserID == int.Parse(_id)).Select(x => x.PrijevoznikID).FirstOrDefault();
            model = _db.TeretRezervacija.Where(x => x.TeretRezervacijaID == id).Select(x => new PrijevozMapaVM()
            {
                KrajnjaLokacija = x.KrajnjaLokacija,
                PocetnaLokacija = x.PocetnaLokacija
            }).FirstOrDefault();
            return View(model);
        }

    }
}