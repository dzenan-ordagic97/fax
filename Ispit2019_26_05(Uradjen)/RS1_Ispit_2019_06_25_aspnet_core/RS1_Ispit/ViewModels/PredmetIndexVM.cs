﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class PredmetIndexVM
    {
        public List<Row> angazovani { get; set; }
        public PredmetIndexVM()
        {
            angazovani = new List<Row>();
        }
        public class Row
        {
            public int AngazovanID { get; set; }
            public string Predmet { get; set; }
            public string AkademskaGodina { get; set; }
            public string Nastavnik { get; set; }
            public int BrojOdrzanihCasova { get; set; }
            public int BrojStudenataNaPredmetu { get; set; }
        }
    }
}
