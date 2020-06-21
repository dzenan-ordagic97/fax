using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UslugePrijevoza.Web.Areas.Identity.Data;
using UslugePrijevoza.Web.Models;

namespace UslugePrijevoza.Web.Areas.Klijent.Controllers
{
    [Area("Klijent")]
    [Authorize(Roles = "Klijent")]
    public class BaseController : Controller
    {
        public MojDBContext _db;
        public BaseController(MojDBContext db)
        {
            _db = db;
        }
    }
}