﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class NastavaDodajVM
    {
        public int PredajePredmetID { get; set; }
        public int SkolaID { get; set; }
        public List<SelectListItem> Skole { get; set; }
        public string Nastavnik { get; set; }
        public int SkolskaGodinaid { get; set; }
        public string SkolskaGodina { get; set; }
        public DateTime Datum { get; set; }
        public int PredmetID { get; set; }
        public List<SelectListItem> Predmeti { get; set; }
        public NastavaDodajVM()
        {
            Skole = new List<SelectListItem>();
            Predmeti = new List<SelectListItem>();
        }
    }
}
