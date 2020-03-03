using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RS1_Ispit_asp.net_core.EF;
using RS1_Ispit_asp.net_core.EntityModels;
using RS1_Ispit_asp.net_core.ViewModels;

namespace RS1_Ispit_asp.net_core.Controllers
{
    public class PredmetController : Controller
    {
        private readonly MojContext _db;
        public PredmetController(MojContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            PredmetIndexVM model = new PredmetIndexVM();
            model.angazovani = _db.Angazovan.OrderBy(x => x.Predmet.Naziv).Select(x => new PredmetIndexVM.Row()
            {
                AngazovanID=x.Id,
                AkademskaGodina=x.AkademskaGodina.Opis,
                Predmet=x.Predmet.Naziv,
                Nastavnik=x.Nastavnik.Ime+" "+x.Nastavnik.Prezime,
                BrojOdrzanihCasova=_db.OdrzaniCas.Where(y=>y.AngazovaniId==x.Id).Select(y=>y.Id).Count(),
                BrojStudenataNaPredmetu=_db.SlusaPredmet.Where(y=>y.AngazovanId==x.Id).Select(y=>y.Id).Count()
            }).ToList();
            return View(model);
        }
        public IActionResult Detalji(int id)
        {
            PredmetDetaljiVM model = new PredmetDetaljiVM();
            model = _db.Angazovan.Where(x => x.Id == id).Select(x => new PredmetDetaljiVM()
            {
                AngazovanID=x.Id,
                AkademskaGodina=x.AkademskaGodina.Opis,
                Nastavnik=x.Nastavnik.Ime+" "+x.Nastavnik.Prezime,
                Predmet=x.Predmet.Naziv
            }).FirstOrDefault();
            model.ispiti = _db.Ispit.Where(x => x.AngazovanID == id).Select(x => new PredmetDetaljiVM.Row()
            {
                IspitID=x.IspitID,
                Datum=x.Datum.ToString("dd.MM.yyyy"),
                Evidentirani=x.Evidentirani,
                BrojNepolozenih=_db.IspitStavke.Where(y=>y.IspitID==x.IspitID && y.Ocjena<6).Count(),
                BrojPrijavljenih=_db.IspitStavke.Where(y=>y.IspitID==x.IspitID).Count()
            }).ToList();
            return View(model);
        }
        //AngazovanID
        public IActionResult Dodaj(int id)
        {
            PredmetDodajVM model = new PredmetDodajVM();
            model = _db.Angazovan.Where(x => x.Id == id).Select(x => new PredmetDodajVM()
            {
                AngazovanID=x.Id,
                AkademskaGodina=x.AkademskaGodina.Opis,
                Nastavnik=x.Nastavnik.Ime+" "+x.Nastavnik.Prezime,
                Predmet=x.Predmet.Naziv
            }).FirstOrDefault();
            return View(model);
        }
        [HttpPost]
        public IActionResult Dodaj(int id, PredmetDodajVM model)
        {
            Ispit ispit = new Ispit()
            {
                AngazovanID=model.AngazovanID,
                Datum=model.Datum,
                Evidentirani=false,
                Napomena=model.Napomena
            };
            ispit.ispitStavke = _db.SlusaPredmet.Where(x => x.AngazovanId == model.AngazovanID).Select(x => new IspitStavke()
            {
                Ocjena=0,
                Pristupio=false,
                StudentID=x.UpisGodine.StudentId
            }).ToList();
            _db.Ispit.Add(ispit);
            _db.SaveChanges();
            return RedirectToActionPermanent(nameof(Detalji), new { id = ispit.AngazovanID });
        }
        //IspitID
        public IActionResult Uredi(int id)
        {
            PredmetUrediVM model = new PredmetUrediVM();
            model = _db.Ispit.Where(x => x.IspitID == id).Select(x => new PredmetUrediVM()
            {
                IspitID=x.IspitID,
                Datum=x.Datum,
                Napomena=x.Napomena,
                Nastavnik=x.Angazovan.Nastavnik.Ime+" "+x.Angazovan.Nastavnik.Prezime,
                Predmet=x.Angazovan.Predmet.Naziv,
                SkolskaGodina=x.Angazovan.AkademskaGodina.Opis
            }).FirstOrDefault();
            return View(model);
        }
        public IActionResult UrediPV(int id)
        {
            PredmetUrediVM model = new PredmetUrediVM();
            model.Evidentirani = _db.Ispit.Where(x => x.IspitID == id).Select(x => x.Evidentirani).FirstOrDefault();
            model.ispitStavke = _db.IspitStavke.Where(x => x.IspitID == id).Select(x => new PredmetUrediVM.Row()
            {
                IspitStavkeID=x.IspitStavkeID,
                Ocjena=x.Ocjena,
                Pristupio=x.Pristupio,
                StudentNaziv=x.Student.Ime+" "+x.Student.Prezime
            }).ToList();
            return PartialView(model);
        }
        //IspitID
        public IActionResult Zakljucaj(int id)
        {
            Ispit ispit = _db.Ispit.Where(x => x.IspitID == id).FirstOrDefault();
            if(ispit!=null)
            {
                ispit.Evidentirani = true;
                _db.SaveChanges();
            }
            return RedirectToActionPermanent(nameof(Detalji), new { id = ispit.AngazovanID });
        }
        //IspitStavkeID

        public IActionResult Prisustvo(int id)
        {
            IspitStavke ispit = _db.IspitStavke.Include(x=>x.Ispit).Where(x => x.IspitStavkeID == id).FirstOrDefault();
            if(!ispit.Ispit.Evidentirani)
            {
                ispit.Pristupio = !ispit.Pristupio;
                _db.SaveChanges();
            }
            return RedirectToActionPermanent(nameof(UrediPV), new { id = ispit.IspitID });
        }
        public IActionResult UpdateOcjena(int id)
        {
            UpdateOcjenaVM model = new UpdateOcjenaVM();
            model = _db.IspitStavke.Where(x => x.IspitStavkeID == id).Select(x => new UpdateOcjenaVM()
            {
                IspitStavkeID=x.IspitStavkeID,
                Ocjena=x.Ocjena,
                StudentIme=x.Student.Ime+" "+x.Student.Prezime
            }).FirstOrDefault();
            return PartialView("UpdateOcjena", model);
        }
        [HttpPost]
        public IActionResult UpdateOcjena(int IspitStavkeID,int Ocjena)
        {
            IspitStavke ispitStavke = _db.IspitStavke.Where(x => x.IspitStavkeID == IspitStavkeID).FirstOrDefault();
            if(ispitStavke!=null)
            {
                ispitStavke.Ocjena = Ocjena;
                ispitStavke.Pristupio = true;
                _db.SaveChanges();
            }
            return RedirectToActionPermanent(nameof(UrediPV), new { id = ispitStavke.IspitID });

        }

    }
}