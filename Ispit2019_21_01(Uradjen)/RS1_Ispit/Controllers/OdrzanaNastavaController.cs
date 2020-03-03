using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RS1_Ispit_asp.net_core.EF;
using RS1_Ispit_asp.net_core.EntityModels;
using RS1_Ispit_asp.net_core.ViewModels;

namespace RS1_Ispit_asp.net_core.Controllers
{
    public class OdrzanaNastavaController : Controller
    {
        private readonly MojContext _db;
        public OdrzanaNastavaController(MojContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            NastavaIndexVM model = new NastavaIndexVM();
            model.nastavnici = _db.PredajePredmet.GroupBy(x => new { x.NastavnikID,x.Odjeljenje.SkolaID }).Select(x => new NastavaIndexVM.Row()
            {
                NastavnikID=x.Key.NastavnikID,
                Nastavnik=_db.Nastavnik.Where(y=>y.Id==x.Key.NastavnikID).Select(y=>y.Ime+" "+y.Prezime).FirstOrDefault(),
                SkolaID=x.Key.SkolaID,
                Skola=_db.Skola.Where(y=>y.Id==x.Key.SkolaID).Select(y=>y.Naziv).FirstOrDefault(),
                PredajePredmetID=_db.PredajePredmet.Where(y=>y.NastavnikID==x.Key.NastavnikID && y.Odjeljenje.SkolaID==x.Key.SkolaID).Select(y=>y.Id).FirstOrDefault()
            }).ToList();
            return View(model);
        }
        //PredajePredmetID
        public IActionResult Detalji(int id)
        {
            NastavaDetaljiVM model = new NastavaDetaljiVM();
            model = _db.PredajePredmet.Where(x => x.Id==id).Select(x => new NastavaDetaljiVM()
            {
                PredajePredmetID=x.Id,
                Nastavnik=x.Nastavnik.Ime+" "+x.Nastavnik.Prezime,
            }).FirstOrDefault();
            model.maturskiIspiti = _db.MaturskiIspit.Where(x => x.PredajePredmetID == model.PredajePredmetID).Select(x => new NastavaDetaljiVM.Row()
            {
                Datum=x.Datum.ToString("dd.MM.yyyy"),
                MaturskiIspitID=x.MaturskiIspitID,
                Predmet=x.Predmet.Naziv,
                Skola=x.Skola.Naziv,
                NisuPristupiliUcenici=_db.MaturskiIspitStavke.Where(y=>y.MaturskiIspitID==x.MaturskiIspitID && y.Pristupio==false).Select(y=>y.OdjeljenjeStavka.Ucenik.ImePrezime).ToList()
            }).ToList();
            return View(model);
        }
        //PredajePredmetID
        public IActionResult Dodaj(int id)
        {
            NastavaDodajVM model = new NastavaDodajVM();
            model = _db.PredajePredmet.Where(x => x.Id == id).Select(x => new NastavaDodajVM()
            {
                PredajePredmetID=x.Id,
                Nastavnik=x.Nastavnik.Ime+" "+x.Nastavnik.Prezime,
                SkolskaGodina=x.Odjeljenje.SkolskaGodina.Naziv
            }).FirstOrDefault();
            int nastavnikID = _db.PredajePredmet.Where(x => x.Id == id).Select(x => x.NastavnikID).FirstOrDefault();
            model.Skole = _db.PredajePredmet.GroupBy(x => new { x.NastavnikID, x.Odjeljenje.SkolaID, x.Odjeljenje.Skola.Naziv })
                .Where(x => x.Key.NastavnikID == nastavnikID)
                .Select(x => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem()
                {
                    Text=x.Key.Naziv,
                    Value=x.Key.SkolaID.ToString()
                }).ToList();
            model.Predmeti = _db.PredajePredmet.GroupBy(x => new { x.NastavnikID, x.PredmetID, x.Predmet.Naziv })
                .Where(x => x.Key.NastavnikID == nastavnikID).Select(x => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem()
                {
                    Text=x.Key.Naziv,
                    Value=x.Key.PredmetID.ToString()
                }).ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult Dodaj(NastavaDodajVM model)
        {
            MaturskiIspit maturskiIspit = new MaturskiIspit()
            {
                SkolaID=model.SkolaID,
                PredmetID=model.PredmetID,
                Datum=model.Datum,
                PredajePredmetID=model.PredajePredmetID
            };
            _db.MaturskiIspit.Add(maturskiIspit);
            _db.SaveChanges();
            List<MaturskiIspitStavke> temp = new List<MaturskiIspitStavke>();
            temp = _db.OdjeljenjeStavka.Where(x => x.Odjeljenje.Skola.Id == model.SkolaID && x.Odjeljenje.Razred == 4).Select(x => new MaturskiIspitStavke()
            {
                OdjeljenjeStavkaID=x.Id,
                Pristupio=false,
                Prosjek=0,
                Bodovi=0,
                MaturskiIspitID=maturskiIspit.MaturskiIspitID,
            }).ToList();
            maturskiIspit.maturskiIspitStavke = new List<MaturskiIspitStavke>();
            foreach(var item in temp)
            {
                if(_db.DodjeljenPredmet.Where(x=>x.OdjeljenjeStavkaId==item.OdjeljenjeStavkaID).Select(x=>x.ZakljucnoKrajGodine>1).FirstOrDefault())
                {
                    maturskiIspit.maturskiIspitStavke.Add(item);
                }
            }
            _db.SaveChanges();
            return RedirectToAction(nameof(Detalji), new { id = model.PredajePredmetID });
        }
        //MaturskiIspitID
        public IActionResult Uredi(int id)
        {
            NastavaUrediVM model = new NastavaUrediVM();
            model = _db.MaturskiIspit.Where(x => x.MaturskiIspitID == id).Select(x => new NastavaUrediVM()
            {
                MaturskiIspitID=x.MaturskiIspitID,
                Datum=x.Datum.ToString("dd.MM.yyyy"),
                Predmet=x.Predmet.Naziv,
            }).FirstOrDefault();
            return View(model);
        }
        [HttpPost]
        public IActionResult Uredi(int id, NastavaUrediVM model)
        {
            MaturskiIspit ispit = _db.MaturskiIspit.Where(x => x.MaturskiIspitID == id).FirstOrDefault();
            if(ispit!=null)
            {
                ispit.Napomena = model.Napomena;
            }
            _db.SaveChanges();
            return RedirectToActionPermanent(nameof(Uredi), new { model.MaturskiIspitID });
        }
        //MaturskiIspitID
        public IActionResult UrediPV(int id)
        {
            NastavaUrediVM model = new NastavaUrediVM();
            model.maturskiIspitStavke = _db.MaturskiIspitStavke.Where(x => x.MaturskiIspitID == id).Select(x => new NastavaUrediVM.Row()
            {
                Bodovi=x.Bodovi,
                MaturskiIspitStavkeID=x.MaturskiIspitStavkeID,
                Pristupio=x.Pristupio,
                Prosjek=x.Prosjek,
                Ucenik=x.OdjeljenjeStavka.Ucenik.ImePrezime
            }).ToList();
            return PartialView(model);
        }
        public IActionResult Prisustvo(int id)
        {
            MaturskiIspitStavke stavke = _db.MaturskiIspitStavke.Where(x => x.MaturskiIspitStavkeID == id).FirstOrDefault();
            if(stavke!=null)
            {
                stavke.Pristupio = true;
                _db.SaveChanges();
            }
            return RedirectToActionPermanent(nameof(UrediPV), new { stavke.MaturskiIspitID });
        }
        public IActionResult UpdateBodova(int id)
        {
            NastavaUpdateBodovaVM model = new NastavaUpdateBodovaVM();
            model = _db.MaturskiIspitStavke.Where(x => x.MaturskiIspitStavkeID == id).Select(x => new NastavaUpdateBodovaVM()
            {
                MaturskiIspitStavkeID=x.MaturskiIspitStavkeID,
                Bodovi=x.Bodovi,
                Ucenik=x.OdjeljenjeStavka.Ucenik.ImePrezime
            }).FirstOrDefault();
            return PartialView("UpdateBodova", model);
        }
        [HttpPost]
        public IActionResult UpdateBodova(int MaturskiIspitStavkeID, int Bodovi)
        {
            MaturskiIspitStavke ispitStavke = _db.MaturskiIspitStavke.Where(x => x.MaturskiIspitStavkeID == MaturskiIspitStavkeID).FirstOrDefault();
            if(ispitStavke!=null)
            {
                ispitStavke.Bodovi = Bodovi > 100 ? 100 : Bodovi;
                ispitStavke.Pristupio = true;
                _db.SaveChanges();
            }
            return RedirectToActionPermanent(nameof(UrediPV), new { ispitStavke.MaturskiIspitID });
        }

    }
}