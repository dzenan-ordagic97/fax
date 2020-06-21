using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UslugePrijevoza.Web.Models;

namespace UslugePrijevoza.Web.Areas.Admin.ViewModels
{
    public class GradVM
    {
        public Grad GradForSave { get; set; }
        public List<RoW> GradRow { get; set; }
        public int DrzavaID { get; set; }
        public List<SelectListItem> Drzava { get; set; }

        public GradVM()
        {
            GradRow = new List<RoW>();
            Drzava = new List<SelectListItem>();
        }
        public class RoW
        {
            public int GradID { get; set; }
            public string Naziv { get; set; }
            public string PostanskiBroj { get; set; }
            public string DrzavaNaziv { get; set; }
        }
    }
}
