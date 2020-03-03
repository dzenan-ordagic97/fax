using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class NastavaUrediVM
    {
        public int MaturskiIspitID { get; set; }

        public string Datum { get; set; }
        public string Predmet { get; set; }
        public string Napomena { get; set; }
        public List<Row> maturskiIspitStavke { get; set; }
        public NastavaUrediVM()
        {
            maturskiIspitStavke = new List<Row>();
        }
        public class Row
        {
            public int MaturskiIspitStavkeID { get; set; }
            public string Ucenik { get; set; }
            public float Prosjek { get; set; }
            public bool Pristupio { get; set; }
            public string PristupioString { get { return Pristupio ? "DA" : "NE"; } }
            public int Bodovi { get; set; }
        }
    }
}
