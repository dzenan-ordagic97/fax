using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UslugePrijevoza.Web.Models;

namespace UslugePrijevoza.Web.Areas.Prijevoznik.ViewModels
{
    public class PrijevozPregledVM
    {
        public  string Prijevoznik { get; set; }
        public List<Row> pregledi { get; set; }

        public PrijevozPregledVM()
        {
            pregledi = new List<Row>();
        }
        public class Row
        {
            public int TeretRezervacijaID { get; set; }
            public int PrijevoznikID { get; set; }
            public int? PrijevozID { get; set; }
            public string PocetnaLokacija { get; set; }
            public string KrajnjaLokacija { get; set; }
            public string PocetniDatumPrijevoza { get; set; }
            public string KrajnjiDatumPrijevoza { get; set; }
            public int TeretID { get; set; }
            public string Naziv { get; set; }
            public string Opis { get; set; }
            public string Tezina { get; set; }
            public string MaxVisina { get; set; }
            public string MaxSirina { get; set; }
            public string User { get; set; }
            public bool Prihvaceno { get; set; }
            public bool Zavrseno { get; set; }

        }
    }
}
