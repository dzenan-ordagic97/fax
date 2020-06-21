using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UslugePrijevoza.Web.Areas.Prijevoznik.ViewModels
{
    public class DashboardAddVM
    {
        public string NazivPrijevoznika { get; set; }
        public string EmailPrijevoznika { get; set; }
        public IFormFile[] Photos { get; set; }
    }
}
