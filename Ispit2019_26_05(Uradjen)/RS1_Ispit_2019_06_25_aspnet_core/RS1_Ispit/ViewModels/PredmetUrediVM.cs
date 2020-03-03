using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class PredmetUrediVM
    {
        public int IspitID { get; set; }
        public string Predmet { get; set; }
        public string Nastavnik { get; set; }
        public string SkolskaGodina { get; set; }
        public DateTime Datum { get; set; }
        public string Napomena { get; set; }
        public bool Evidentirani { get; set; }
        public List<Row> ispitStavke { get; set; }
        public PredmetUrediVM()
        {
            ispitStavke = new List<Row>();
        }
        public class Row
        {
            public int IspitStavkeID { get; set; }
            public string StudentNaziv { get; set; }
            public bool Pristupio { get; set; }
            public string PristupioString { get { return Pristupio ? "Pristupio" : "Nije pristupio"; } }
            public int Ocjena { get; set; }
        }
    }
}
