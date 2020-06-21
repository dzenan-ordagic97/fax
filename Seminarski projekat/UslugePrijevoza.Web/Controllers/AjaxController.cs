using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UslugePrijevoza.Web.Areas.Identity.ViewModels;
using UslugePrijevoza.Web.Models;
using UslugePrijevoza.Web.Areas.Identity.Pages.Account;
using static UslugePrijevoza.Web.Helpers.Helper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity.UI.Services;
using UslugePrijevoza.Web.Areas.Identity.Data;

namespace UslugePrijevoza.Web.Controllers
{
    public class AjaxController : Controller
    {
        private readonly MojDBContext _db;
        private readonly UserManager<MojIdentityUser> _usermanager;
        private readonly SignInManager<MojIdentityUser> _signInManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public AjaxController(MojDBContext db, UserManager<MojIdentityUser> userManager,
            SignInManager<MojIdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _usermanager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetFormaPV(int id)
        {
            RegisterModel registerModel = new RegisterModel(_usermanager, _signInManager, _logger, _emailSender,_db);
            if (id == (int)UserTip.Klijent)
            {
                registerModel.Input.Klijent = new FormaKlijentVM();
                registerModel.Input.Klijent.Drzave = new List<SelectListItem>();

                registerModel.Input.Klijent.Drzave = _db.Drzava.Select(x => new SelectListItem()
                {
                    Value = x.DrzavaID.ToString(),
                    Text = x.Naziv
                }).ToList();

                return PartialView("FormaKlijentPV", registerModel);
            }
            if (id == (int)UserTip.Prijevoznik)
            {

                registerModel.Input.Prijevoznik = new FormaPrijevoznikVM();
                registerModel.Input.Prijevoznik.Drzave = new List<SelectListItem>();

                registerModel.Input.Prijevoznik.Drzave = _db.Drzava.Select(x => new SelectListItem()
                {
                    Value = x.DrzavaID.ToString(),
                    Text = x.Naziv
                }).ToList();
                
                return PartialView("FormaPrijevoznikPV", registerModel);

            }
            return null;
        }
        public IActionResult GetGradoviPV(int id)
        {
            RegisterModel registerModel = new RegisterModel(_usermanager, _signInManager, _logger, _emailSender, _db);

            registerModel.Input.Klijent = new FormaKlijentVM();
            registerModel.Input.Klijent.Gradovi = new List<SelectListItem>();
            registerModel.Input.Klijent.Gradovi = _db.Grad.Where(x => x.DrzavaID == id).Select(x => new SelectListItem()
            {
                Value = x.GradID.ToString(),
                Text = x.Naziv
            }).ToList();
           
            return PartialView("FormaGradoviPV", registerModel);
        }
        public IActionResult GetGradoviPPV(int id)
        {
            RegisterModel registerModel = new RegisterModel(_usermanager, _signInManager, _logger, _emailSender, _db);

            registerModel.Input.Prijevoznik = new FormaPrijevoznikVM();
            registerModel.Input.Prijevoznik.Gradovi = new List<SelectListItem>();
            registerModel.Input.Prijevoznik.Gradovi = _db.Grad.Where(x => x.DrzavaID == id).Select(x => new SelectListItem()
            {
                Value = x.GradID.ToString(),
                Text = x.Naziv
            }).ToList();
            return PartialView("FormaPrijevoznikGradoviPV", registerModel);
        }
    }
}