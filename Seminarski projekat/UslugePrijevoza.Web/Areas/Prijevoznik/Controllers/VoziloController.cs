using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UslugePrijevoza.Web.Areas.Identity.Data;
using UslugePrijevoza.Web.Areas.Prijevoznik.ViewModels;
using UslugePrijevoza.Web.Models;

namespace UslugePrijevoza.Web.Areas.Prijevoznik.Controllers
{
   
    public class VoziloController : BaseController
    {
        public VoziloController(MojDBContext _context) :base(_context)
        {
            
        }
        public IActionResult Index()
        {
            VoziloVM vozila = new VoziloVM();
             string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
             int _PrijevoznikID = _db.Prijevoznik.Where(x => x.UserID == int.Parse( id)).Select(x => x.PrijevoznikID).FirstOrDefault();
            vozila.Vozila = _db.Vozilo.Include(x=>x.DetaljiVozila).ThenInclude(x=>x.Slike).Where(x => x.PrijevoznikID == _PrijevoznikID).Select(x => new VoziloVM.RoW()
            {
                BrojMjesta = x.BrojMjesta.ToString(),
                GodinaProizvodnje = x.GodinaProizvodnje.ToString("dd.MM.yyyy"),
                ModelVozila = x.ModelVozila.Naziv,
                RegistracijskaOznaka = x.RegistracijskaOznaka,
                TipVozila = x.TipVozila.Naziv,
                VoziloID = x.VoziloID,
                Zapremina = x.ZapreminaPrtljaznika.ToString(),
                Slika = _db.Slike.Where(y=>y.SlikeID ==  x.DetaljiVozila.Slike.Where(z => z.Pozicija == 1).Select(i => i.SlikeID).FirstOrDefault()).FirstOrDefault()
            }).ToList();

            return View(vozila);
        }
        public IActionResult Dodaj()
        {
            VoziloDodajVM model = new VoziloDodajVM();
            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int _PrijevoznikID = _db.Prijevoznik.Where(x => x.UserID == int.Parse(id)).Select(x => x.PrijevoznikID).FirstOrDefault();
            model.ModelVozila = _db.ModelVozila.Where(x=>x.PrijevoznikID== _PrijevoznikID).Select(x => new SelectListItem()
            {
                Value = x.ModelVozilaID.ToString(),
                Text = x.Naziv

            }).ToList();

            model.TipVozila = _db.TipVozila.Where(x=>x.PrijevoznikID==_PrijevoznikID).Select(x => new SelectListItem()
            {
                Value=x.TipVozilaID.ToString(),
                Text=x.Naziv
            }).ToList();

            return View(model);
        }
        [HttpPost]
        public IActionResult Dodaj(VoziloDodajVM model)
        {
            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int _PrijevoznikID = _db.Prijevoznik.Where(x => x.UserID == int.Parse(id)).Select(x => x.PrijevoznikID).FirstOrDefault();
            List<SlikaVozilo> slikeVozila = new List<SlikaVozilo>();
            int y = 1;
            for (int i = model.Photos.Length-1; i >= 0; i--)
            {
                Guid guid = Guid.NewGuid();
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", guid.ToString()+Path.GetExtension(model.Photos[i].FileName));
                var stream = new FileStream(path, FileMode.Create);
                model.Photos[i].CopyToAsync(stream);
                slikeVozila.Add(new SlikaVozilo()
                {
                    Pozicija = y++,
                    Slike = new Slike()
                    {
                        Naziv = guid.ToString(),
                        URL = "/images/" + guid + Path.GetExtension(model.Photos[i].FileName)
                    }
                });
            }
            Vozilo v = new Vozilo()
            {
                BrojMjesta=model.BrojMjesta,
                ZapreminaPrtljaznika=model.ZapreminaPrtljaznika,
                GodinaProizvodnje=model.GodinaProizvodnje,
                RegistracijskaOznaka=model.RegistracijskaOznaka,
                TipVozilaID=model.TipVozilaID,
                PrijevoznikID = _PrijevoznikID,
                ModelVozilaID=model.ModelVozilaID,
                DetaljiVozila = new DetaljiVozila()
                {
                    Slike = slikeVozila,
                    Br_EUPaleta=model.DetaljiVozila.Br_EUPaleta,
                    Cijena_km=model.DetaljiVozila.Cijena_km,
                    MaxDuzina=model.DetaljiVozila.MaxDuzina,
                    MaxSirina=model.DetaljiVozila.MaxSirina,
                    MaxTezina=model.DetaljiVozila.MaxTezina,
                    MaxVisina=model.DetaljiVozila.MaxVisina,
                    Opis=model.DetaljiVozila.Opis
                }
            };
           
            _db.Vozilo.Add(v);
            _db.SaveChanges();
            return RedirectToActionPermanent(nameof(Index));
        }
        public async Task<string> Obrisi(int id)
        {
            string _id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int _PrijevoznikID = _db.Prijevoznik.Where(x => x.UserID == int.Parse(_id)).Select(x => x.PrijevoznikID).FirstOrDefault();
            Vozilo x = _db.Vozilo.Where(x=>x.PrijevoznikID == _PrijevoznikID && x.VoziloID == id).FirstOrDefault();
            DetaljiVozila d = _db.DetaljiVozila.Where(y => y.DetaljiVozilaID == x.DetaljiVozilaID).FirstOrDefault();
            if(d!=null)
            {
                _db.DetaljiVozila.Remove(d);
                _db.SaveChanges();
            }
            List<Prijevoz> p = _db.Prijevoz.Where(y => y.PrijevoznikID == _PrijevoznikID && y.VoziloID == id).ToList();
            if (p != null)
            {
                foreach (var item in p)
                {
                    item.VoziloID = null;
                }
                _db.SaveChanges();
            }
            if (x == null)
            {
                return "";
            }
            _db.Vozilo.Remove(x);
            await _db.SaveChangesAsync();
            return x.RegistracijskaOznaka;
        }
        public IActionResult Detalji(int id)
        {
            VoziloDetaljiVM model = new VoziloDetaljiVM();
            string _id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int _PrijevoznikID = _db.Prijevoznik.Where(x => x.UserID == int.Parse(_id)).Select(x => x.PrijevoznikID).FirstOrDefault();
            model = _db.Vozilo.Include(x => x.DetaljiVozila).ThenInclude(x => x.Slike).Where(x => x.VoziloID == id && x.PrijevoznikID == _PrijevoznikID).Select(x => new VoziloDetaljiVM
            {
                BrojMjesta = x.BrojMjesta,
                GodinaProizvodnje = x.GodinaProizvodnje.ToString("dd.MM.yyyy"),
                ModelVozila = x.ModelVozila.Naziv,
                RegistracijskaOznaka = x.RegistracijskaOznaka,
                TipVozila = x.TipVozila.Naziv,
                VoziloID = x.VoziloID,
                Zapremina = x.ZapreminaPrtljaznika.ToString()+"m",
                DetaljiVozila = new DetaljiVozilaDodajVM()
                {
                    Br_EUPaleta = x.DetaljiVozila.Br_EUPaleta,
                    Cijena_km = x.DetaljiVozila.Cijena_km,
                    MaxDuzina = x.DetaljiVozila.MaxDuzina,
                    MaxSirina = x.DetaljiVozila.MaxSirina,
                    MaxTezina = x.DetaljiVozila.MaxTezina,
                    MaxVisina = x.DetaljiVozila.MaxVisina,
                    Opis = x.DetaljiVozila.Opis
                }
            }).FirstOrDefault();
            if (model != null)
            {
                model.Slike = _db.SlikaVozilo.Include(x => x.Slike).Where(x => x.DetaljiVozilaID == _db.Vozilo.Where(v => v.VoziloID == model.VoziloID).Select(d => d.DetaljiVozilaID).FirstOrDefault()).ToList();
                return View(nameof(Detalji), model);

            }
            return RedirectToActionPermanent(nameof(Index));
        }
        public IActionResult Detaljno(int id)
        {
            VoziloDetaljnoVM model = new VoziloDetaljnoVM();
            string _id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int _PrijevoznikID = _db.Prijevoznik.Where(x => x.UserID == int.Parse(_id)).Select(x => x.PrijevoznikID).FirstOrDefault();
            model = _db.Vozilo.Include(x => x.DetaljiVozila).ThenInclude(x => x.Slike).Where(x => x.VoziloID == id && x.PrijevoznikID == _PrijevoznikID).Select(x => new VoziloDetaljnoVM()
            {
                VoziloID=x.VoziloID,
                TipVozila=x.TipVozila.Naziv,
                BrojMjesta=x.BrojMjesta,
                Br_EU_Paleta=x.DetaljiVozila.Br_EUPaleta ?? 0,
                Cijena_km=Convert.ToSingle(x.DetaljiVozila.Cijena_km),
                GodinaProizvodnje=x.GodinaProizvodnje.ToString("dd.MM.yyyy"),
                MaxDuzina=Convert.ToSingle(x.DetaljiVozila.MaxDuzina),
                MaxSirina=Convert.ToSingle(x.DetaljiVozila.MaxSirina),
                MaxTezina=Convert.ToSingle(x.DetaljiVozila.MaxTezina),
                MaxVisina=Convert.ToSingle(x.DetaljiVozila.MaxVisina),
                ModelVozila=x.ModelVozila.Naziv,
                Opis=x.DetaljiVozila.Opis,
                RegistracijskaOznaka=x.RegistracijskaOznaka,
                Zapremina=x.ZapreminaPrtljaznika.ToString(),
                Slika= _db.Slike.Where(y => y.SlikeID == x.DetaljiVozila.Slike.Where(z => z.Pozicija == 1).Select(i => i.SlikeID).FirstOrDefault()).FirstOrDefault()
            }).FirstOrDefault();
            return View(model);
        }
    }
}