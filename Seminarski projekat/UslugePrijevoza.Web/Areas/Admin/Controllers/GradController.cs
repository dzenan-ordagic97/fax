using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using UslugePrijevoza.Web.Areas.Admin.ViewModels;
using UslugePrijevoza.Web.Models;

namespace UslugePrijevoza.Web.Areas.Admin.Controllers
{
    public class GradController : BaseController
    {
        public GradController(MojDBContext db):base(db)
        {
        }
        public IActionResult Index()
        {
            GradVM model = new GradVM();
            model.Drzava = _db.Drzava.Select(x => new SelectListItem()
            {
                Text=x.Naziv,
                Value=x.DrzavaID.ToString()
            }).ToList();
            model.GradRow = _db.Grad.Select(x => new GradVM.RoW()
            {
                GradID=x.GradID,
                Naziv=x.Naziv,
                PostanskiBroj=x.PostanskiBroj,
                DrzavaNaziv=x.Drzava.Naziv
            }).ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult Dodaj(GradVM model)
        {
            List<Grad> gradovi = _db.Grad.ToList();
            foreach (var item in gradovi)
            {
                if (item.Naziv == model.GradForSave.Naziv)
                {
                    return View("Index");
                }
            }
            _db.Grad.Add(model.GradForSave);
            _db.SaveChanges();
            return PartialView("GradElement", model);
        }
        public IActionResult Edit(int id)
        {
            GradEditVM model = _db.Grad.Where(x => x.GradID == id).Select(x => new GradEditVM()
            {
                GradID = x.GradID,
                Naziv = x.Naziv,
                PostanskiBroj = x.PostanskiBroj
            }).FirstOrDefault();
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(int id, GradEditVM model)
        {
            Grad x = _db.Grad.Where(x => x.GradID == id).FirstOrDefault();
            if (x != null)
            {
                x.Naziv = model.Naziv;
                x.PostanskiBroj = model.PostanskiBroj;
                _db.SaveChanges();
            }
            return RedirectToActionPermanent(nameof(Index));
        }
    }
}