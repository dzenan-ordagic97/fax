using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UslugePrijevoza.Web.Models;

namespace UslugePrijevoza.Web.Areas.Klijent.Controllers
{
    [Area("Klijent")]
    [Route("[area]/[controller]/[action]")]
    public class DrzavaController : Controller
    {
        private readonly MojDBContext _ctx;

        public DrzavaController(MojDBContext context)
        {
            _ctx = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {


            return View();
        }
        public IActionResult CreateSave(string Naziv)
        {
            Drzava d = new Drzava()
            {
                Naziv = Naziv,
                Skracenica = Naziv.Substring(0, 3)
            };
            _ctx.Add(d);
            _ctx.SaveChanges();
            _ctx.Dispose();
            return RedirectToActionPermanent(nameof(Create));
        }


    }
}