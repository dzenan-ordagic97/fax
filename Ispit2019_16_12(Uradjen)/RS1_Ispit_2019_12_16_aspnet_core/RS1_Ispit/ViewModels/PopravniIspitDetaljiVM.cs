using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class PopravniIspitDetaljiVM
    {
        public int PredajePredmetID { get; set; }
        public string Predmet { get; set; }
        public string Skola { get; set; }
        public string SkolskaGodina { get; set; }
        public List<Row> popravniIspit { get; set; }
        public PopravniIspitDetaljiVM()
        {
            popravniIspit = new List<Row>();
        }
        public class Row
        {
            public int PopravniIspitID { get; set; }
            public string Datum { get; set; }
            public string ClanKomisije1 { get; set; }
            public int BrojUcenika { get; set; }
            public int BrojPolozenih { get; set; }
        }
    }
}
