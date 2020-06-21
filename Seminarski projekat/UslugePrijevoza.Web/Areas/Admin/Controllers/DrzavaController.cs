using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UslugePrijevoza.Web.Areas.Admin.ViewModels;
using UslugePrijevoza.Web.Areas.Identity.Data;
using UslugePrijevoza.Web.Models;

namespace UslugePrijevoza.Web.Areas.Admin.Controllers
{
    public class DrzavaController : BaseController
    {
        public DrzavaController(MojDBContext db) : base(db)
        {
        }
        public IActionResult Index()
        {
            DrzavaVM modelDrzava = new DrzavaVM();
            modelDrzava.DrzavaRow = _db.Drzava.Select(x => new DrzavaVM.RoW()
            {
                Naziv = x.Naziv,
                DrzavaID = x.DrzavaID,
            }).ToList();
            return View(modelDrzava);
        }
        [HttpPost]
        public IActionResult Dodaj(DrzavaVM model)
        {
            List<Drzava> drzave = _db.Drzava.ToList();
            foreach (var item in drzave)
            {
                if (item.Naziv == model.DrzavaForSave.Naziv)
                {
                    return View("Index");
                }
            }
            _db.Drzava.Add(model.DrzavaForSave);
            _db.SaveChanges();
            return PartialView("DrzavaElement", model);
        }
        public IActionResult Edit(int id)
        {
            DrzavaEditVM model = _db.Drzava.Where(x => x.DrzavaID == id).Select(x => new DrzavaEditVM()
            {
                DrzavaID = x.DrzavaID,
                Naziv = x.Naziv,
                Skracenica = x.Skracenica
            }).FirstOrDefault();
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(int id, DrzavaEditVM model)
        {
            Drzava x = _db.Drzava.Where(x => x.DrzavaID == id).FirstOrDefault();
            if (x != null)
            {
                x.Naziv = model.Naziv;
                x.Skracenica = model.Skracenica;
                _db.SaveChanges();
            }
            return RedirectToActionPermanent(nameof(Index));
        }

    }
}