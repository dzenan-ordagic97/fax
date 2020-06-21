using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UslugePrijevoza.Web.Areas.Admin.ViewModels;
using UslugePrijevoza.Web.Models;

namespace UslugePrijevoza.Web.Areas.Admin.Controllers
{
    public class DashboardController : BaseController
    {
        public DashboardController(MojDBContext db):base(db)
        {
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Home()
        {
            DashboardVM model = new DashboardVM();
            model = _db.Users.Where(x => x.Id == 1).Select(x => new DashboardVM()
            {
                Ime = x.Ime,
                Prezime = x.Prezime,
                Adresa=x.Adresa.Naziv,
                Email=x.Email,
                JMBG=x.JMBG,
                Spol=x.Spol,
            }).FirstOrDefault();
            return View(model);
        }
    }
}