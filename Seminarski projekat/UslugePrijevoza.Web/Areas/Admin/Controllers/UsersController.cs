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
    public class UsersController : BaseController
    {
        public UsersController(MojDBContext db):base(db)
        {
        }
        public IActionResult Index()
        {
            UsersVM model = new UsersVM();
            model.userRow = _db.Users.Select(x => new UsersVM.Row()
            {
                UserID = x.Id,
                Ime = x.Ime,
                Prezime = x.Prezime,
                DatumRodjenja = x.DatumRodjenja.ToString("dd.MM.yyyy"),
                JMBG=x.JMBG,
                Spol=x.Spol,
                Username=x.UserName,
                TipUsera=_db.UserRoles.Where(y=>y.UserId==x.Id).Select(y=>y.RoleId).FirstOrDefault().ToString()
            }).ToList();
            return View(model);
        }
        public IActionResult Obrisi(int id)
        {
            MojIdentityUser x = _db.Users.Where(x => x.Id==id).FirstOrDefault();
            if (x == null || x.Id==1)
            {
                return View(nameof(Index));
            }
            _db.Users.Remove(x);
            _db.SaveChanges();
            return RedirectToActionPermanent(nameof(Index));
        }
    }
}