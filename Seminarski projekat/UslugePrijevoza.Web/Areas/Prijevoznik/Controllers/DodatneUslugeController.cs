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
    public class DodatneUslugeController : BaseController
    {
        public DodatneUslugeController(MojDBContext db):base(db)
        {

        }
        public IActionResult Index()
        {
            DodatneUslugeVM dodatneUsluge = new DodatneUslugeVM();
            string _id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int _PrijevoznikID = _db.Prijevoznik.Where(x => x.UserID == int.Parse(_id)).Select(x => x.PrijevoznikID).FirstOrDefault();
            dodatneUsluge.DodatneUsluge_Teret = _db.DodatneUsluge_Teret.Include(x=>x.DodatneUsluge).Where(x => x.DodatneUsluge.PrijevoznikID == _PrijevoznikID).ToList();
            dodatneUsluge.DodatneUsluge = _db.DodatneUsluge.Where(x=>x.PrijevoznikID==_PrijevoznikID).Select(x => new DodatneUslugeVM.Row()
            {
                DodatneUslugeID=x.DodatneUslugeID,
                Cijena=x.Cijena,
                Naziv=x.Naziv,
                Opis=x.Opis,
                AllowChanges=x.PrijevoznikID==_PrijevoznikID
            }).ToList();
            return View(dodatneUsluge);
        }
        [HttpPost]
        public IActionResult Dodaj(DodatneUslugeVM model)
        {
            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int _PrijevoznikID = _db.Prijevoznik.Where(x => x.UserID == int.Parse(id)).Select(x => x.PrijevoznikID).FirstOrDefault();
            model.DodatneUslugeForSave.PrijevoznikID = _PrijevoznikID;
            List<DodatneUsluge> dodatneUsluge = _db.DodatneUsluge.Where(x => x.PrijevoznikID == _PrijevoznikID).ToList();
            foreach (var item in dodatneUsluge)
            {
                if (item.Naziv == model.DodatneUslugeForSave.Naziv)
                {
                    return View("Index");
                }
            }
            _db.DodatneUsluge.Add(model.DodatneUslugeForSave);
            _db.SaveChanges();
            return PartialView("DodatneUslugeElement", model);
        }
        public async Task<string> Obrisi(int id)
        {
            string _id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            int _PrijevoznikID = _db.Prijevoznik.Where(x => x.UserID == int.Parse(_id)).Select(x => x.PrijevoznikID).FirstOrDefault();
            DodatneUsluge dodatneUsluge = _db.DodatneUsluge.Where(x => x.PrijevoznikID == _PrijevoznikID && x.DodatneUslugeID == id).FirstOrDefault();
            if(dodatneUsluge==null)
            {
                return "";
            }
            _db.DodatneUsluge.Remove(dodatneUsluge);
            await _db.SaveChangesAsync();
            return dodatneUsluge.DodatneUslugeID.ToString();
        }
    }
}