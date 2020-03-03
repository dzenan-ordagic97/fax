using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ispit_2017_02_15.EF;
using Ispit_2017_02_15.Models;
using Ispit_2017_02_15.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Ispit_2017_02_15.Controllers
{
    public class CasController : Controller
    {
        private readonly MojContext _db;
        public CasController(MojContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            CasIndexVM model = new CasIndexVM();
            model = _db.Nastavnik.Select(x => new CasIndexVM()
            {
                NastavnikID=x.Id
            }).FirstOrDefault();
            model.casovi = _db.OdrzaniCasovi.Include(x => x.Angazovan).Select(x => new CasIndexVM.Row()
            {
                CasID=x.Id,
                AkademskaGodina=x.Angazovan.AkademskaGodina.Opis,
                DatumCasa=x.Datum.ToString("dd.MM.yyyy"),
                Predmet=x.Angazovan.Predmet.Naziv,
                BrojPrisutnihStudenata=_db.OdrzaniCasDetalji.Count(),
                ProsjecnaOcjena=_db.SlusaPredmet.Where(y=>y.AngazovanId==x.AngazovanId).Select(y=>y.Ocjena).Average() ?? 0
            }).ToList();
            return View(model);
        }
        public IActionResult Dodaj(int id)
        {
            CasDodajVM model = new CasDodajVM();
            model = _db.Angazovan.Where(x=>x.NastavnikId==id).Select(x => new CasDodajVM()
            {
                Nastavnik = x.Nastavnik.Ime + " " + x.Nastavnik.Prezime,
            }).FirstOrDefault();
            model.AkademskaPredmet = _db.Angazovan.Include(x=>x.AkademskaGodina).Include(x=>x.Predmet).Where(x=>x.NastavnikId==id).Select(x => new SelectListItem()
            {
                Text=x.AkademskaGodina.Opis+"-"+x.Predmet.Naziv,
                Value=x.Id.ToString()
            }).ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult Dodaj(int id,CasDodajVM model)
        {
            OdrzaniCas odrzaniCas = new OdrzaniCas()
            {
                AngazovanId=model.Akademska,
                Datum=model.Datum,
            };
            _db.OdrzaniCasovi.Add(odrzaniCas);
            _db.SaveChanges();
            List<SlusaPredmet> slusaPredmet = _db.SlusaPredmet.Where(x => x.AngazovanId == odrzaniCas.AngazovanId).ToList();
            foreach(var item in slusaPredmet)
            {
                _db.OdrzaniCasDetalji.Add(new OdrzaniCasDetalji()
                {
                    OdrzaniCasId=odrzaniCas.Id,
                    SlusaPredmetId=item.Id
                });
            }
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        //CasID
        public IActionResult Edit(int id)
        {
            CasEditVM model = new CasEditVM();
            model = _db.OdrzaniCasovi.Include(x=>x.Angazovan).ThenInclude(x=>x.Nastavnik).Where(x => x.Id == id ).Select(x => new CasEditVM()
            {
                CasID=x.Id,
                Nastavnik=x.Angazovan.Nastavnik.Ime+" "+x.Angazovan.Nastavnik.Prezime,
                AkademskaPredmet=x.Angazovan.AkademskaGodina.Opis+"-"+x.Angazovan.Predmet.Naziv
            }).FirstOrDefault();
            
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(int id,CasDodajVM model)
        {
            OdrzaniCas cas = _db.OdrzaniCasovi.Where(x => x.Id == id).FirstOrDefault();
            cas.Datum = model.Datum;
            _db.SaveChanges();
            return RedirectToActionPermanent(nameof(Index));
        }
        //CasID
        public IActionResult EditPV(int id)
        {
            CasEditVM model = new CasEditVM();
            model.odrzaniCasDetalji = _db.OdrzaniCasDetalji.Where(x => x.OdrzaniCasId == id).Select(x => new CasEditVM.Row()
            {
                OdrzaniCasDetaljiID = x.Id,
                Bodovi = x.BodoviNaCasu,
                Prisutan = x.Prisutan,
                StudentIme = x.SlusaPredmet.UpisGodine.Student.Ime + " " + x.SlusaPredmet.UpisGodine.Student.Prezime
            }).ToList();
            return PartialView(model);
        }
        //OdrzaniCasDetaljiID
        public IActionResult Prisustvo(int id)
        {
            OdrzaniCasDetalji odrzaniCas = _db.OdrzaniCasDetalji.Where(x => x.Id == id).FirstOrDefault();
            if(odrzaniCas!=null)
            {
                odrzaniCas.Prisutan = !odrzaniCas.Prisutan;
            }
            _db.SaveChanges();
            return RedirectToAction("Edit", "Cas", new { id = odrzaniCas.OdrzaniCasId });
        }
        //OdrzaniCasDetaljiID
        public IActionResult UpdateBodova(int id)
        {
            UpdateBodovaVM model = _db.OdrzaniCasDetalji.Include(x=>x.SlusaPredmet).ThenInclude(x=>x.UpisGodine).Where(x => x.Id == id).Select(x => new UpdateBodovaVM()
            {
                OdrzaniCasDetaljiID=x.Id,
                Bodovi=x.BodoviNaCasu,
                StudentIme = x.SlusaPredmet.UpisGodine.Student.Ime+" "+x.SlusaPredmet.UpisGodine.Student.Prezime
            }).FirstOrDefault();
            return View("UpdateBodova", model);
        }
        [HttpPost]
        public IActionResult UpdateBodova(int OdrzaniCasDetaljiID, int Bodovi)
        {
            OdrzaniCasDetalji odrzaniCas = _db.OdrzaniCasDetalji.Where(x => x.Id == OdrzaniCasDetaljiID).FirstOrDefault();
            if(odrzaniCas!=null)
            {
                odrzaniCas.BodoviNaCasu = Bodovi > 100 ? 100 : Bodovi;
                _db.SaveChanges();
            }
            return RedirectToAction("Edit", "Cas", new { id = odrzaniCas.OdrzaniCasId });
        }



    }
}