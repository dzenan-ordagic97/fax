using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UslugePrijevoza.Web.Models;

namespace UslugePrijevoza.Web.Areas.Admin.ViewModels
{
    public class DashboardVM
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string JMBG { get; set; }
        public string Spol { get; set; }
        public string Adresa { get; set; }
    }
}
