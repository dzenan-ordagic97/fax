using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ispit_2017_02_15.ViewModels
{
    public class CasDodajVM
    {
        public string Nastavnik { get; set; }
        public DateTime Datum { get; set; }
        public int Akademska { get; set; }
        public List<SelectListItem> AkademskaPredmet { get; set; }
        public CasDodajVM()
        {
            AkademskaPredmet = new List<SelectListItem>();
        }

    }
}
