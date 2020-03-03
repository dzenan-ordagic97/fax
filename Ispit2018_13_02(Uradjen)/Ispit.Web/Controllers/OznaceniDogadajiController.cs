using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eUniverzitet.Web.Helper;
using Ispit.Web.Helper;
using Microsoft.AspNetCore.Mvc;
using Ispit.Data;
using Ispit.Data.EntityModels;
using Microsoft.EntityFrameworkCore;
using Ispit.Web.ViewModels;

namespace Ispit.Web.Controllers
{
    [Autorizacija]
    public class OznaceniDogadajiController : Controller
    {
        private readonly MyContext _db;

        public OznaceniDogadajiController(MyContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            DogadjajiVM model = new DogadjajiVM();

            model._NeOznaceniDog = _db.Dogadjaj.Select(x => new DogadjajiVM.RowNeOznaceni()
            {
                BrojObaveza = 0,
                DatumDogadjaja = x.DatumOdrzavanja.ToString("dd.MM.yyyy"),
                Nastavnik = x.Nastavnik.ImePrezime,
                Opis = x.Opis,
                NeOznaceniDogadjajID = x.ID
            }).ToList();
            int idStudent = Autentifikacija.GetLogiraniKorisnik(this.HttpContext).Id;
            model._OznaceniDog = _db.OznacenDogadjaj.Where(x=>x.StudentID == idStudent).Select(x => new DogadjajiVM.RowOznaceni()
            {
                RealizovanoObaveza = _db.StanjeObaveze.Where(y=>y.OznacenDogadjajID == x.ID).Select(y=>y.IzvrsenoProcentualno).Sum() / _db.StanjeObaveze.Where(y => y.OznacenDogadjajID == x.ID).Count(),
                DatumDogadjaja = x.Dogadjaj.DatumOdrzavanja.ToString("dd.MM.yyyy"),
                Nastavnik = x.Dogadjaj.Nastavnik.ImePrezime,
                Opis = x.Dogadjaj.Opis,
                OznaceniDogadjajID = x.ID,
                NeOznaceniDogadjajID = x.DogadjajID
            }).ToList();

            
            foreach (var item in model._OznaceniDog)
            {
                model._NeOznaceniDog.RemoveAll(x => x.NeOznaceniDogadjajID == item.NeOznaceniDogadjajID);
            }


            return View(model);
        }

        public IActionResult Dodaj(int id)
        {
            int idStudent = Autentifikacija.GetLogiraniKorisnik(this.HttpContext).Id;

            OznacenDogadjaj o = _db.Dogadjaj.Where(x => x.ID == id).Select(x => new OznacenDogadjaj
            {
                StudentID = idStudent,
                DogadjajID = x.ID,
                DatumDodavanja = DateTime.Now
            }).FirstOrDefault();

            if (o==null)
            {
            return RedirectToActionPermanent(nameof(Index));

            }
            _db.OznacenDogadjaj.Add(o);
            _db.SaveChanges();

            List<StanjeObaveze> stanjeObaveze = _db.Obaveza.Where(x => x.DogadjajID == o.DogadjajID).Select(x => new StanjeObaveze()
            {
                ObavezaID = x.ID,
                OznacenDogadjajID = o.ID,
                DatumIzvrsenja = DateTime.Now,
                IsZavrseno = false,
                IzvrsenoProcentualno = 0,
                NotifikacijaDanaPrije = x.NotifikacijaDanaPrijeDefault,
                NotifikacijeRekurizivno = x.NotifikacijeRekurizivnoDefault
            }).ToList();
            _db.StanjeObaveze.AddRange(stanjeObaveze);
            _db.SaveChanges();

            return RedirectToActionPermanent(nameof(Index));
        }

        public IActionResult Detalji(int id)
        {
            DogadjajDetaljiVM model = _db.OznacenDogadjaj.Where(x => x.ID == id).Select(x => new DogadjajDetaljiVM()
            {
                DatumDodavanja = x.DatumDodavanja.ToString("dd.MM.yyyy"),
                DatumDogadjaja = x.Dogadjaj.DatumOdrzavanja.ToString("dd.MM.yyyy"),
                Nastavnik = x.Dogadjaj.Nastavnik.ImePrezime,
                Opis = x.Dogadjaj.Opis,
                OznaceniDogadjajID = x.ID
                
            }).FirstOrDefault();

            return View(model);
        } 

        public IActionResult StanjeObavezaPV(int id)
        {
            DogadjajDetaljiVM model = new DogadjajDetaljiVM();

            model._Obaveze = _db.StanjeObaveze.Where(x => x.OznacenDogadjajID == id).Select(x => new DogadjajDetaljiVM.RowObaveze()
            {
                Naziv = x.Obaveza.Naziv,
                NotifikacijaUnaprijedDana = x.NotifikacijaDanaPrije ,
                PonavljajNotiSvakiDan = x.NotifikacijeRekurizivno,
                Procenat = x.IzvrsenoProcentualno,
                StanjeObavezeID = x.Id

            }).ToList();
            return PartialView("ObavezeDogadjajPV",model);
        } 
        
        public IActionResult UrediObavezu(int id)
        {

            return View();
        }


    }
}