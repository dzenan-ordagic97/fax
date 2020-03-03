using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class PredmetDetaljiVM
    {
        public int AngazovanID { get; set; }
        public string Predmet { get; set; }
        public string Nastavnik { get; set; }
        public string AkademskaGodina { get; set; }
        public List<Row> ispiti { get; set; }
        public PredmetDetaljiVM()
        {
            ispiti = new List<Row>();
        }
        public class Row
        {
            public int IspitID { get; set; }
            public string Datum { get; set; }
            public int BrojNepolozenih { get; set; }
            public int BrojPrijavljenih { get; set; }
            public bool Evidentirani { get; set; }
        }
    }
}
