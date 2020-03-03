using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class NastavaIndexVM
    {
        public List<Row> nastavnici { get; set; }
        public NastavaIndexVM()
        {
            nastavnici = new List<Row>();
        }
        public class Row
        {
            public int PredajePredmetID { get; set; }
            public int SkolaID { get; set; }
            public string Skola { get; set; }
            public int NastavnikID { get; set; }
            public string Nastavnik { get; set; }
        }
    }
}
