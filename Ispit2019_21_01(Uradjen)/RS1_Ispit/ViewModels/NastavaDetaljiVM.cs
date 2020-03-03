using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class NastavaDetaljiVM
    {
        public int PredajePredmetID { get; set; }
        public int NastavnikID { get; set; }
        public string Nastavnik { get; set; }
        public List<Row> maturskiIspiti { get; set; }
        public NastavaDetaljiVM()
        {
            maturskiIspiti = new List<Row>();
        }
        public class Row
        {
            public int MaturskiIspitID { get; set; }
            public string Datum { get; set; }
            public string Skola { get; set; }
            public string Predmet { get; set; }
            public List<string> NisuPristupiliUcenici { get; set; }
            public Row()
            {
                NisuPristupiliUcenici = new List<string>();
            }
        }
    }
}
