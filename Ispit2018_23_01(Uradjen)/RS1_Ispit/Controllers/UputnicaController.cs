using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ispit_2017_09_11_DotnetCore.EF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RS1.Ispit.Web.Models;
using RS1_Ispit_asp.net_core.ViewModels;

namespace RS1_Ispit_asp.net_core.Controllers
{
    public class UputnicaController : Controller
    {
        private readonly MojContext _db;
        public UputnicaController(MojContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            UputnicaIndexVM model = new UputnicaIndexVM();
            model.uputnice = _db.Uputnica.Select(x => new UputnicaIndexVM.Row()
            {
                UputnicaID=x.Id,
                Datum=x.DatumUputnice,
                DatumEvidentiranja=x.DatumRezultata,
                Pacijent=x.Pacijent.Ime,
                UputioLjekar=x.UputioLjekar.Ime,
                VrstaPretrage=x.VrstaPretrage.Naziv
            }).ToList();
            return View(model);
        }
        public IActionResult Dodaj()
        {
            UputnicaDodajVM model = new UputnicaDodajVM();
            model.Ljekari = _db.Ljekar.Select(x => new SelectListItem()
            {
                Text=x.Ime,
                Value=x.Id.ToString()
            }).ToList();
            model.Pacijenti = _db.Pacijent.Select(x => new SelectListItem()
            {
                Text = x.Ime,
                Value = x.Id.ToString()
            }).ToList();
            model.VrstaPretraga = _db.VrstaPretrage.Select(x => new SelectListItem()
            {
                Text = x.Naziv,
                Value = x.Id.ToString()
            }).ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult Dodaj(UputnicaDodajVM model)
        {
            Uputnica uputnica = new Uputnica()
            {
                UputioLjekarId=model.LjekarID,
                DatumUputnice=model.Datum,
                PacijentId=model.PacijentID,
                VrstaPretrageId=model.VrstaPretrageID
            };
            _db.Uputnica.Add(uputnica);
            List<RezultatPretrage> rezultatPretrage = new List<RezultatPretrage>();
            rezultatPretrage = _db.LabPretraga.Where(x => x.VrstaPretrageId == model.VrstaPretrageID).Select(x => new RezultatPretrage()
            {
                LabPretragaId=x.Id,
                UputnicaId=uputnica.Id,
                NumerickaVrijednost=0.0,
                
            }).ToList();
            foreach(var item in rezultatPretrage)
            {
                RezultatPretrage rr = new RezultatPretrage()
                {
                    UputnicaId=item.UputnicaId,
                    LabPretragaId=item.LabPretragaId,
                    NumerickaVrijednost=item.NumerickaVrijednost,
                };
                _db.RezultatPretrage.Add(rr);
            }
            _db.SaveChanges();
            return RedirectToActionPermanent(nameof(Index));
        }
        //UputnicaID
        public IActionResult Detalji(int id)
        {
            UputnicaDetaljiVM model = new UputnicaDetaljiVM();
            model = _db.Uputnica.Where(x => x.Id == id).Select(x => new UputnicaDetaljiVM()
            {
                UputnicaID=x.Id,
                DatumRezultata=x.DatumRezultata,
                DatumUplatnice=x.DatumUputnice.ToString("dd.MM.yyyy"),
                Pacijent=x.Pacijent.Ime,
            }).FirstOrDefault();
            return View(model);
        }
        public IActionResult DetaljiPV(int id)
        {
            UputnicaDetaljiVM model = new UputnicaDetaljiVM();
            model.pretrage = _db.RezultatPretrage.Where(x => x.UputnicaId == id).Select(x => new UputnicaDetaljiVM.Row()
            {
                RezultatiPretrageID=x.Id,
                MjernaJedinica=x.LabPretraga.MjernaJedinica,
                NumerickaVrijednost=x.NumerickaVrijednost.ToString() ?? "nije evidentirano",
                Pretraga=x.LabPretraga.Naziv
            }).ToList();
            return PartialView(model);
        }

    }
}