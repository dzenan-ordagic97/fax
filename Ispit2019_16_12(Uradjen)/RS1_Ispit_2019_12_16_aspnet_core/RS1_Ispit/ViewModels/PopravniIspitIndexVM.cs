using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class PopravniIspitIndexVM
    {
        public int SkolaID { get; set; }
        public List<SelectListItem> Skole { get; set; }
        public int SkolskaGodinaID { get; set; }
        public List<SelectListItem> SkolskeGodine { get; set; }
        public int PredmetID { get; set; }
        public List<SelectListItem> Predmeti { get; set; }
        public PopravniIspitIndexVM()
        {
            Skole = new List<SelectListItem>();
            SkolskeGodine = new List<SelectListItem>();
            Predmeti = new List<SelectListItem>();
        }
    }
}
