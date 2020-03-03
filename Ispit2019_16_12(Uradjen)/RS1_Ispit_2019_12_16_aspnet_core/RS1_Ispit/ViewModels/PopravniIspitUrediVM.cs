using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class PopravniIspitUrediVM
    {
        public int PopravniIspitID { get; set; }
        public int ClanKomisije1Id { get; set; }
        public List<SelectListItem> ClanoviKomisije { get; set; }
        public int ClanKomisije2Id { get; set; }
        public int ClanKomisije3Id { get; set; }
        public DateTime Datum { get; set; }
        public int SkolaID { get; set; }
        public string Skola { get; set; }
        public int SkolskaGodinaID { get; set; }

        public string SkolskaGodina { get; set; }
        public int PredmetID { get; set; }

        public string Predmet { get; set; }
        public List<Row> popravniIspitStavke { get; set; }
        public PopravniIspitUrediVM()
        {
            popravniIspitStavke = new List<Row>();
        }
        public class Row
        {
            public int PopravniIspitStavkeID { get; set; }
            public string Ucenik { get; set; }
            public string Odjeljenje { get; set; }
            public int BrojUDnevniku { get; set; }
            public bool Pristupio { get; set; }
            public string PristupioString { get { return Pristupio ? "DA" : "NE"; } }
            public int Bodovi { get; set; }
        }
    }
}
