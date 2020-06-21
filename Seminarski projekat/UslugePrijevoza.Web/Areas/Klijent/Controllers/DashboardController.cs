using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UslugePrijevoza.Web.Areas.Prijevoznik.ViewModels;
using UslugePrijevoza.Web.Models;

namespace UslugePrijevoza.Web.Areas.Klijent.Controllers
{
    public class DashboardController : BaseController
    {
        public DashboardController(MojDBContext db) : base(db)
        {
        }

        public IActionResult Home()
        {
            return View();
        }
        
        public IActionResult KomentarOcjena(int ocjena)
        {
            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int _PrijevoznikID = _db.Prijevoznik.Where(x => x.UserID == int.Parse(id)).Select(x => x.PrijevoznikID).FirstOrDefault();
            KomentariOcjenaVM model = new KomentariOcjenaVM();
            model.Ocjena = ocjena;
            model.Komentari = _db.KomentarOcjena.Where(x => x.Ocjena == ocjena && x.Prijevoz.PrijevoznikID == _PrijevoznikID).Select(x => new KomentariOcjenaVM.Row()
            {
                Datum = ((DateTime)x.Prijevoz.DatumPrijevoza).ToString("dd.MM.yyyy"),
                Komentar = x.Komentar,
                UserSlika = x.User.Slika,
                NazivPrijevoza = x.Prijevoz.TipPrijevoza,
                User = x.User.Ime + " " + x.User.Prezime,
                PrijevozID = _db.TeretRezervacija.Where(y => y.PrijevozID == x.PrijevozID).FirstOrDefault().TeretRezervacijaID


            }).ToList();
            return PartialView("KomentariOcjene", model);
        }
    }
}