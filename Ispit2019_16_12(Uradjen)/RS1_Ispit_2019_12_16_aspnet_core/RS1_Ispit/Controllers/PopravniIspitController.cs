using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RS1_Ispit_asp.net_core.EF;
using RS1_Ispit_asp.net_core.EntityModels;
using RS1_Ispit_asp.net_core.ViewModels;

namespace RS1_Ispit_asp.net_core.Controllers
{
    public class PopravniIspitController : Controller
    {
        private readonly MojContext _db;
        public PopravniIspitController(MojContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            PopravniIspitIndexVM model = new PopravniIspitIndexVM();
            model.Skole = _db.Skola.Select(x => new SelectListItem()
            {
                Text=x.Naziv,
                Value=x.Id.ToString()
            }).ToList();
            model.SkolskeGodine = _db.SkolskaGodina.Select(x => new SelectListItem()
            {
                Text=x.Naziv,
                Value=x.Id.ToString()
            }).ToList();
            model.Predmeti = _db.Predmet.Select(x => new SelectListItem()
            {
                Value=x.Id.ToString(),
                Text=x.Naziv
            }).ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(PopravniIspitIndexVM model)
        {
            if(model==null)
            {
                return RedirectToAction(nameof(Index));
            }
            return RedirectToActionPermanent(nameof(Detalji), new { SkolskaGodinaID = model.SkolskaGodinaID, SkolaID = model.SkolaID, PredmetID=model.PredmetID });
        }
        public IActionResult Detalji(int SkolskaGodinaID, int SkolaID, int PredmetID)
        {
            PopravniIspitDetaljiVM model = new PopravniIspitDetaljiVM();
            model = _db.PredajePredmet.Where(x => x.Odjeljenje.SkolaID == SkolaID && x.Odjeljenje.SkolskaGodinaID == SkolskaGodinaID && x.PredmetID == PredmetID).Select(x => new PopravniIspitDetaljiVM()
            {
                PredajePredmetID=x.Id,
                Predmet=x.Predmet.Naziv,
                Skola=x.Odjeljenje.Skola.Naziv,
                SkolskaGodina=x.Odjeljenje.SkolskaGodina.Naziv
            }).FirstOrDefault();
            model.popravniIspit = _db.PopravniIspit.Where(x => x.PredajePredmetID == model.PredajePredmetID).Select(x => new PopravniIspitDetaljiVM.Row()
            {
                PopravniIspitID=x.PopravniIspitID,
                Datum=x.Datum.ToString("dd.MM.yyyy"),
                ClanKomisije1=x.ClanKomisije1.Ime+" "+x.ClanKomisije1.Prezime,
                BrojPolozenih=_db.PopravniIspitStavke.Where(y=>y.Bodovi>50).Count(),
                BrojUcenika=_db.PopravniIspitStavke.Count()
            }).ToList();
            return View(model);
        }
        //PredajePredmetID
        public IActionResult Dodaj(int id)
        {
            PopravniIspitDodajVM model = new PopravniIspitDodajVM();
            model = _db.PredajePredmet.Where(x => x.Id == id).Select(x => new PopravniIspitDodajVM()
            {
                PredajePredmetID=x.Id,
                Predmet=x.Predmet.Naziv,
                Skola=x.Odjeljenje.Skola.Naziv,
                SkolskaGodina=x.Odjeljenje.SkolskaGodina.Naziv
            }).FirstOrDefault();
            model.ClanKomisije1 = _db.Nastavnik.Select(x => new SelectListItem()
            {
                Text=x.Ime+" "+x.Prezime,
                Value=x.Id.ToString()
            }).ToList();
            model.ClanKomisije2 = _db.Nastavnik.Select(x => new SelectListItem()
            {
                Text = x.Ime + " " + x.Prezime,
                Value = x.Id.ToString()
            }).ToList();
            model.ClanKomisije3 = _db.Nastavnik.Select(x => new SelectListItem()
            {
                Text = x.Ime + " " + x.Prezime,
                Value = x.Id.ToString()
            }).ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult Dodaj(int id, PopravniIspitDodajVM model)
        {
            PredajePredmet pp = _db.PredajePredmet.Include(p => p.Odjeljenje).Include(p => p.Predmet).Where(p => p.Id == id).FirstOrDefault();

            PopravniIspit popravniIspit = new PopravniIspit()
            {
                ClanKomisije1ID=model.ClanKomisije1ID,
                ClanKomisije2ID=model.ClanKomisije2ID,
                ClanKomisije3ID=model.ClanKomisije3ID,
                Datum=model.Datum,
                PredajePredmet=pp
            };
            _db.PopravniIspit.Add(popravniIspit);
            popravniIspit.popravniIspitStavke = _db.DodjeljenPredmet.Where(x => x.PredmetId == pp.PredmetID && x.OdjeljenjeStavka.Odjeljenje.SkolskaGodinaID == pp.Odjeljenje.SkolskaGodinaID && x.ZakljucnoKrajGodine == 1).Select(x => new PopravniIspitStavke()
            {
                Bodovi=0,
                Pristupio=false,
                OdjeljenjeStavkaID=x.OdjeljenjeStavkaId,
            }).ToList();
            _db.SaveChanges();
            return RedirectToActionPermanent(nameof(Detalji), new { SkolskaGodinaID = pp.Odjeljenje.SkolskaGodinaID, SkolaID= pp.Odjeljenje.SkolaID, PredmetID= pp.PredmetID });
        }
        //PopravniIspitID
        public IActionResult Uredi(int id)
        {
            PopravniIspitUrediVM model = new PopravniIspitUrediVM();
            model = _db.PopravniIspit.Where(x => x.PopravniIspitID == id).Select(x => new PopravniIspitUrediVM()
            {
                PopravniIspitID=x.PopravniIspitID,
                Predmet=x.PredajePredmet.Predmet.Naziv,
                Skola=x.PredajePredmet.Odjeljenje.Skola.Naziv,
                SkolskaGodina=x.PredajePredmet.Odjeljenje.SkolskaGodina.Naziv,
                SkolaID=x.PredajePredmet.Odjeljenje.SkolaID,
                PredmetID=x.PredajePredmet.PredmetID,
                SkolskaGodinaID=x.PredajePredmet.Odjeljenje.SkolskaGodinaID
            }).FirstOrDefault();
            model.ClanoviKomisije = _db.Nastavnik.Select(x => new SelectListItem()
            {
                Text=x.Ime+" "+x.Prezime,
                Value=x.Id.ToString()
            }).ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult Uredi(int id, PopravniIspitUrediVM model)
        {
            PopravniIspit ispit = _db.PopravniIspit.Where(x => x.PopravniIspitID == model.PopravniIspitID).FirstOrDefault();
            if(ispit!=null)
            {
                ispit.ClanKomisije1ID = model.ClanKomisije1Id;
                ispit.ClanKomisije2ID = model.ClanKomisije2Id;
                ispit.ClanKomisije3ID = model.ClanKomisije3Id;
                ispit.Datum = model.Datum;
                _db.SaveChanges();
            }
            return RedirectToActionPermanent(nameof(Detalji), new { SkolskaGodinaID = model.SkolskaGodinaID, SkolaID = model.SkolaID, PredmetID = model.PredmetID });
        }
        public IActionResult UrediPV(int id)
        {
            PopravniIspitUrediVM model = new PopravniIspitUrediVM();
            model.popravniIspitStavke = _db.PopravniIspitStavke.Where(x => x.PopravniIspitID == id).Select(x => new PopravniIspitUrediVM.Row()
            {
                PopravniIspitStavkeID=x.PopravniIspitStavkeID,
                Bodovi=x.Bodovi,
                BrojUDnevniku=x.OdjeljenjeStavka.BrojUDnevniku,
                Odjeljenje=x.OdjeljenjeStavka.Odjeljenje.Oznaka,
                Pristupio=x.Pristupio,
                Ucenik=x.OdjeljenjeStavka.Ucenik.ImePrezime
            }).ToList();
            return PartialView(model);
        }
        //PopravniIspitStavkeID
        public IActionResult Prisustvo(int id)
        {
            PopravniIspitStavke popravniIspit = _db.PopravniIspitStavke.Where(x => x.PopravniIspitStavkeID == id).FirstOrDefault();
            if(popravniIspit!=null)
            {
                popravniIspit.Pristupio = true;
                _db.SaveChanges();
            }
            return RedirectToActionPermanent(nameof(UrediPV), new { id = popravniIspit.PopravniIspitID });
        }
        //PopravniIspitStavkeID
        public IActionResult UpdateBodova(int id)
        {
            UpdateBodovaVM model = new UpdateBodovaVM();
            model = _db.PopravniIspitStavke.Where(x => x.PopravniIspitStavkeID == id).Select(x => new UpdateBodovaVM()
            {
                PopravniIspitStavkeID=x.PopravniIspitStavkeID,
                Bodovi=x.Bodovi,
                Ucenik=x.OdjeljenjeStavka.Ucenik.ImePrezime
            }).FirstOrDefault();
            return View(model);
        }
        [HttpPost]
        public IActionResult UpdateBodova(int PopravniIspitStavkeID, int Bodovi)
        {
            PopravniIspitStavke popravniIspit = _db.PopravniIspitStavke.Where(x => x.PopravniIspitStavkeID == PopravniIspitStavkeID).FirstOrDefault();
            if(popravniIspit!=null)
            {
                popravniIspit.Bodovi = Bodovi > 100 ? 100 : Bodovi;
                popravniIspit.Pristupio = true;
                _db.SaveChanges();
            }
            return RedirectToActionPermanent(nameof(UrediPV), new { id = popravniIspit.PopravniIspitID });
        }

    }
}