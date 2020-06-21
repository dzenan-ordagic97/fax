using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UslugePrijevoza.Web.Areas.Prijevoznik.ViewModels;
using UslugePrijevoza.Web.Models;

namespace UslugePrijevoza.Web.Areas.Prijevoznik.Controllers
{
    [Area("Prijevoznik")]
    [Authorize(Roles = "Prijevoznik")]
    public class DashboardController : BaseController
    {
        public DashboardController(MojDBContext db) : base(db)
        {
        }
        public IActionResult Index()
        {
            DashboardPrikazVM model = new DashboardPrikazVM();
            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int _PrijevoznikID = _db.Prijevoznik.Where(x => x.UserID == int.Parse(id)).Select(x => x.PrijevoznikID).FirstOrDefault();
            model.BrojacRezervacije = _db.TeretRezervacija.Include(x => x.Prijevoz).ThenInclude(x => x.Prijevoznik).Where(x => x.Prijevoz.PrijevoznikID == _PrijevoznikID && x.Prihvaceno == false).Count();
            model.Cijene = _db.Prijevoz.Where(x => x.PrijevoznikID == _PrijevoznikID && x.Zavrseno == true).Select(x => x.Cijena).Sum() ?? 0;
            model.BrojVozila = _db.Vozilo.Where(x => x.PrijevoznikID == _PrijevoznikID).Select(x => x.VoziloID).Count();
            model.UkupnoPrijevoza = _db.Prijevoz.Where(x => x.PrijevoznikID == _PrijevoznikID && x.Zavrseno==true).Select(x => x.PrijevozID).Count();
            model.naziviModela = _db.Vozilo.Include(x => x.ModelVozila).Where(x => x.PrijevoznikID == _PrijevoznikID).GroupBy(x => new { x.ModelVozila.Naziv }).Select(x => new DashboardPrikazVM.Row()
            {
                NazivModela = x.Key.Naziv,
                BrojacVozila = x.Count()
            }).ToList();
            return View(model);
        }
        public IActionResult Home()
        {
            DashboardVM model = new DashboardVM();
            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int _UserID = _db.Prijevoznik.Where(x => x.UserID == int.Parse(id)).Select(x => x.PrijevoznikID).FirstOrDefault();
            string UserID = _UserID.ToString();

            int _slikaID = _db.Slike.Select(x=>x.SlikeID).FirstOrDefault();
            bool trigger = false;
            if(_slikaID!=0)
            {
                List<Slike> slike = _db.Slike.ToList();
                for (int i = 0; i < slike.Count(); i++)
                {
                    char temp = '0';
                    temp = slike[i].Naziv.LastOrDefault();
                    if (temp.ToString() == UserID)
                    {
                        _slikaID = slike[i].SlikeID;
                        trigger = true;
                    }
                }
            }
            if(_slikaID == 0 || !trigger)
            {
                Slike s = new Slike()
                {
                    Naziv = "Default slika"+_UserID,
                    URL = "https://image.flaticon.com/icons/svg/1738/1738691.svg"
                };
                _db.Slike.Add(s);
                _db.SaveChanges();
                _slikaID = s.SlikeID;
            }
            model = _db.Prijevoznik.Where(x => x.PrijevoznikID == _UserID).Select(x => new DashboardVM()
            {
                Ime = x.User.Ime,
                Prezime = x.User.Prezime,
                EmailPrijevoznika = x.EmailPrijevoznika,
                NazivPrijevoznika = x.NazivPrijevoznika,
                Adresa = x.User.Adresa.Naziv,
                Grad=x.User.Adresa.Grad.Naziv,
                PhoneNumber=x.User.PhoneNumber,
                Slika = _db.Slike.Where(x => x.SlikeID == _slikaID).FirstOrDefault()
            }).FirstOrDefault();
            model.BrojacRezervacije = _db.TeretRezervacija.Include(x => x.Prijevoz).ThenInclude(x => x.Prijevoznik).Where(x => x.Prijevoz.PrijevoznikID==_UserID && x.Prihvaceno == false).Count();
            model.Cijene = _db.Prijevoz.Where(x => x.PrijevoznikID == _UserID && x.Zavrseno == true).Select(x => x.Cijena).Sum();
            model.BrojVozila = _db.Vozilo.Where(x => x.PrijevoznikID == _UserID).Select(x => x.VoziloID).Count();
            model.UkupnoPrijevoza = _db.Prijevoz.Where(x => x.PrijevoznikID == _UserID && x.Zavrseno==true).Select(x => x.PrijevozID).Count();
            return View(model);
        }
        public IActionResult Add()
        {
            DashboardAddVM model = new DashboardAddVM();
            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int _UserID = _db.Prijevoznik.Where(x => x.UserID == int.Parse(id)).Select(x => x.PrijevoznikID).FirstOrDefault();
            model = _db.Prijevoznik.Where(x => x.PrijevoznikID == _UserID).Select(x => new DashboardAddVM()
            {
                NazivPrijevoznika=x.NazivPrijevoznika,
                EmailPrijevoznika=x.EmailPrijevoznika
            }).FirstOrDefault();
            return View(model);
        }
        [HttpPost]
        public IActionResult Add(DashboardAddVM model)
        {

            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int _UserID = _db.Prijevoznik.Where(x => x.UserID == int.Parse(id)).Select(x => x.PrijevoznikID).FirstOrDefault();
            string UserID = _UserID.ToString();
            bool trigger = false;

            Guid guid = Guid.NewGuid();
            int i = 0;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", guid.ToString() + Path.GetExtension(model.Photos[i].FileName));
            var stream = new FileStream(path, FileMode.Create);
            model.Photos[i].CopyToAsync(stream);

            List<Slike> _slike = _db.Slike.ToList();
            for (int y = 0; y < _slike.Count(); y++)
            {
                char temp = '0';
                temp = _slike[y].Naziv.LastOrDefault();
                if (temp.ToString() == UserID)
                {
                    trigger = true;
                    _slike[y].Naziv = guid.ToString() + "_" + _UserID;
                    _slike[y].URL = "/images/" + guid + Path.GetExtension(model.Photos[i].FileName);
                    _db.SaveChanges();
                }
            }
            if (!trigger)
            {
                Slike slike = new Slike()
                {
                    Naziv = guid.ToString() + "_" + _UserID,
                    URL = "/images/" + guid + Path.GetExtension(model.Photos[i].FileName)
                };
                _db.Slike.Add(slike);
            }
            var prijevoznik = _db.Prijevoznik.Where(x => x.PrijevoznikID == _UserID).FirstOrDefault();
            if (prijevoznik != null)
            {
                prijevoznik.NazivPrijevoznika = model.NazivPrijevoznika;
                prijevoznik.EmailPrijevoznika = model.EmailPrijevoznika;
            }
            _db.SaveChanges();
            return RedirectToActionPermanent(nameof(Home));
        }

        public IActionResult KomentarOcjena(int ocjena)
        {
            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int _PrijevoznikID = _db.Prijevoznik.Where(x => x.UserID == int.Parse(id)).Select(x => x.PrijevoznikID).FirstOrDefault();
            KomentariOcjenaVM model = new KomentariOcjenaVM();
            model.Ocjena = ocjena;
            model.Komentari = _db.KomentarOcjena.Where(x => x.Ocjena == ocjena && x.Prijevoz.PrijevoznikID == _PrijevoznikID).Select(x => new KomentariOcjenaVM.Row()
            {
                Datum = ((DateTime) x.Prijevoz.DatumPrijevoza).ToString("dd.MM.yyyy"),
                Komentar = x.Komentar,
                UserSlika = x.User.Slika,
                NazivPrijevoza = x.Prijevoz.TipPrijevoza,
                User = x.User.Ime+" "+x.User.Prezime,
                PrijevozID = _db.TeretRezervacija.Where(y=>y.PrijevozID == x.PrijevozID).FirstOrDefault().TeretRezervacijaID

                
            }).ToList();
            return PartialView("KomentariOcjene", model);
        }
        public IActionResult Prikaz()
        {
            DashboardPrikazVM model = new DashboardPrikazVM();
            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int _PrijevoznikID = _db.Prijevoznik.Where(x => x.UserID == int.Parse(id)).Select(x => x.PrijevoznikID).FirstOrDefault();
            model = _db.Prijevoz.Include(x=>x.Prijevoznik).Where(x => x.PrijevoznikID == _PrijevoznikID).Select(x => new DashboardPrikazVM()
            {
                PrijevoznikID = x.PrijevoznikID,
                Ocjena1 = _db.KomentarOcjena.Where(y => y.Ocjena == 1 && y.Prijevoz.PrijevoznikID == _PrijevoznikID).Count(),
                Ocjena2 = _db.KomentarOcjena.Where(y => y.Ocjena == 2 && y.Prijevoz.PrijevoznikID == _PrijevoznikID).Count(),
                Ocjena3 = _db.KomentarOcjena.Where(y => y.Ocjena == 3 && y.Prijevoz.PrijevoznikID == _PrijevoznikID).Count(),
                Ocjena4 = _db.KomentarOcjena.Where(y => y.Ocjena == 4 && y.Prijevoz.PrijevoznikID==_PrijevoznikID).Count(),
                Ocjena5 = _db.KomentarOcjena.Where(y => y.Ocjena == 5 && y.Prijevoz.PrijevoznikID == _PrijevoznikID).Count(),
            }).FirstOrDefault();
            if (model == null)
            {
                return RedirectToActionPermanent("Index");
            }
            else
            {
                model.BrojacRezervacije = _db.TeretRezervacija.Include(x => x.Prijevoz).ThenInclude(x => x.Prijevoznik).Where(x => x.Prijevoz.PrijevoznikID==_PrijevoznikID && x.Prihvaceno == false).Count();
                model.Cijene = _db.Prijevoz.Where(x => x.PrijevoznikID == _PrijevoznikID && x.Zavrseno==true).Select(x => x.Cijena).Sum() ?? 0;
                model.BrojVozila = _db.Vozilo.Where(x => x.PrijevoznikID == _PrijevoznikID).Select(x => x.VoziloID).Count();
                model.UkupnoPrijevoza = _db.Prijevoz.Where(x => x.PrijevoznikID == _PrijevoznikID && x.Zavrseno == true).Select(x => x.PrijevozID).Count();
                model.naziviModela = _db.Vozilo.Include(x => x.ModelVozila).Where(x => x.PrijevoznikID == _PrijevoznikID).GroupBy(x => new { x.ModelVozila.Naziv }).Select(x => new DashboardPrikazVM.Row()
                {
                    NazivModela = x.Key.Naziv,
                    BrojacVozila = x.Count()
                }).ToList();
            }
            return View(model);
        }

    }
}