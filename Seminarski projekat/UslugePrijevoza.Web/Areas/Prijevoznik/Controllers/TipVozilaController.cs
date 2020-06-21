using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using UslugePrijevoza.Web.Areas.Identity.Data;
using UslugePrijevoza.Web.Areas.Prijevoznik.ViewModels;
using UslugePrijevoza.Web.Infrastructure;
using UslugePrijevoza.Web.Models;
using UslugePrijevoza.Web.Services;

namespace UslugePrijevoza.Web.Areas.Prijevoznik.Controllers
{
    public class TipVozilaController : BaseController
    {
        private readonly IHubContext<SignalServer> _hub;
        private readonly INotifikacija _notifikacijaService;

        public TipVozilaController(MojDBContext db, IHubContext<SignalServer> hub,INotifikacija notifikacija) :base(db)
        {
            _hub = hub;
            _notifikacijaService = notifikacija;
        }
        public IActionResult Index()
        {
            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int _PrijevoznikID = _db.Prijevoznik.Where(x => x.UserID == int.Parse(id)).Select(x => x.PrijevoznikID).FirstOrDefault();
            TipVozilaVM tipVozila = new TipVozilaVM();
            tipVozila.MojaVozila = _db.Vozilo.Include(x => x.TipVozila).Where(x => x.PrijevoznikID == _PrijevoznikID).ToList();
            tipVozila.TipoviVozila = _db.TipVozila.Where(x=>x.PrijevoznikID==_PrijevoznikID).Select(x => new TipVozilaVM.RoW()
            {
                Naziv=x.Naziv,
                TipVozilaID=x.TipVozilaID,
                AllowChanges = x.PrijevoznikID == _PrijevoznikID
            }).ToList();
            return View(tipVozila);
        }
        [HttpPost]
        public async Task< IActionResult> Dodaj(TipVozilaVM model)
        {
            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int _PrijevoznikID = _db.Prijevoznik.Where(x => x.UserID == int.Parse(id)).Select(x => x.PrijevoznikID).FirstOrDefault();
            model.TipVozilaForSave.PrijevoznikID = _PrijevoznikID;
            List<TipVozila> tipVozila = _db.TipVozila.Where(x=>x.PrijevoznikID==_PrijevoznikID).ToList();
            foreach (var item in tipVozila)
            {
                if (item.Naziv == model.TipVozilaForSave.Naziv)
                {
                    return View("Index");
                }
            }
            _db.TipVozila.Add(model.TipVozilaForSave);
            await _db.SaveChangesAsync();
            _notifikacijaService.posaljiNotifikacijePrijevozniku(_PrijevoznikID, int.Parse(id), new NotifikacijaVM() { Url = "/Prijevoznik/TipVozila", Poruka = "Dodali ste novi tip vozila" });
            return PartialView("TipVozilaElement",model);
        }
        public async Task<string> Obrisi(int id)
        {

            string _id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int _PrijevoznikID = _db.Prijevoznik.Where(x => x.UserID == int.Parse(_id)).Select(x => x.PrijevoznikID).FirstOrDefault();
            TipVozila x = _db.TipVozila.Where(x => x.PrijevoznikID == _PrijevoznikID && x.TipVozilaID == id).FirstOrDefault();
            if (x == null)
            {
                return "";
            }

            _db.TipVozila.Remove(x);
            await _db.SaveChangesAsync();
            return x.TipVozilaID.ToString();
        }

    }
}