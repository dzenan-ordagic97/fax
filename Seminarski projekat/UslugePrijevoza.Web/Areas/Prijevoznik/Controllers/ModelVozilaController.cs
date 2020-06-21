using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UslugePrijevoza.Web.Areas.Prijevoznik.ViewModels;
using UslugePrijevoza.Web.Models;

namespace UslugePrijevoza.Web.Areas.Prijevoznik.Controllers
{
    public class ModelVozilaController : BaseController
    {
        public ModelVozilaController(MojDBContext db) : base(db)
        {
        }
        public IActionResult Index()
        {
            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int _PrijevoznikID = _db.Prijevoznik.Where(x => x.UserID == int.Parse(id)).Select(x => x.PrijevoznikID).FirstOrDefault();
            ModelVozilaVM modelVozila = new ModelVozilaVM();
            modelVozila.MojaVozila = _db.Vozilo.Include(x=>x.ModelVozila).Where(x => x.PrijevoznikID == _PrijevoznikID).ToList();
            modelVozila.ModelVozila = _db.ModelVozila.Where(x=>x.PrijevoznikID==_PrijevoznikID).Select(x => new ModelVozilaVM.RoW()
            {
                Naziv = x.Naziv,
                ModelVozilaID = x.ModelVozilaID,
                AllowChanges = x.PrijevoznikID == _PrijevoznikID
            }).ToList();
            return View(modelVozila);
        }
        [HttpPost]
        public IActionResult Dodaj(ModelVozilaVM model)
        {
            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int _PrijevoznikID = _db.Prijevoznik.Where(x => x.UserID == int.Parse(id)).Select(x => x.PrijevoznikID).FirstOrDefault();
            model.ModelVozilaForSave.PrijevoznikID = _PrijevoznikID;
            List<ModelVozila> modelVozila = _db.ModelVozila.Where(x=>x.PrijevoznikID==_PrijevoznikID).ToList();
            foreach (var item in modelVozila)
            {
                if (item.Naziv == model.ModelVozilaForSave.Naziv)
                {
                    return View("Index");
                }
            }
            _db.ModelVozila.Add(model.ModelVozilaForSave);
            _db.SaveChanges();
            return PartialView("ModelVozilaElement", model);
        }
        public async Task<string> Obrisi(int id)
        {
            string _id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int _PrijevoznikID = _db.Prijevoznik.Where(x => x.UserID == int.Parse(_id)).Select(x => x.PrijevoznikID).FirstOrDefault();
            ModelVozila x = _db.ModelVozila.Where(x => x.ModelVozilaID == id && x.PrijevoznikID == _PrijevoznikID).FirstOrDefault();
            if (x == null)
            {
                return "";
            }
            _db.ModelVozila.Remove(x);
            await _db.SaveChangesAsync();
            return x.ModelVozilaID.ToString();
        }
    }
}