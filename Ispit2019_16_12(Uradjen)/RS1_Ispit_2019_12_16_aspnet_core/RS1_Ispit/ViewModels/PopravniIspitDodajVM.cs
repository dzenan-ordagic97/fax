using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class PopravniIspitDodajVM
    {
        public int PredajePredmetID { get; set; }
        public int ClanKomisije1ID { get; set; }
        public List<SelectListItem> ClanKomisije1 { get; set; }
        public int ClanKomisije2ID { get; set; }
        public List<SelectListItem> ClanKomisije2 { get; set; }
        public int ClanKomisije3ID { get; set; }
        public List<SelectListItem> ClanKomisije3 { get; set; }
        public DateTime Datum { get; set; }
        public string Skola { get; set; }
        public string SkolskaGodina { get; set; }
        public string Predmet { get; set; }
        public PopravniIspitDodajVM()
        {
            ClanKomisije1 = new List<SelectListItem>();
            ClanKomisije2 = new List<SelectListItem>();
            ClanKomisije3 = new List<SelectListItem>();
        }
    }
}
