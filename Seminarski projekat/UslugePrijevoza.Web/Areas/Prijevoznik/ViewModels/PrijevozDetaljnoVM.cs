using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UslugePrijevoza.Web.Models;

namespace UslugePrijevoza.Web.Areas.Prijevoznik.ViewModels
{
    public class PrijevozDetaljnoVM
    {
        public List<SlikeTereta> Slike { get; set; }
        public int TeretRezervacijaID { get; set; }
        public string PocetnaLokacija { get; set; }
        public string KrajnjaLokacija { get; set; }
        public string PocetniDatumPrijevoza { get; set; }
        public string TipPrijevoza { get; set; }
        public string NazivTereta { get; set; }
        public string OpisTereta { get; set; }
        public string Tezina { get; set; }
        public string MaxVisina { get; set; }
        public string MaxSirina { get; set; }
        public string User { get; set; }
        public string NazivDodatneUsluge { get; set; }
        public string CijenaDodatneUsluge { get; set; }
        public string OpisDodatneUsluge { get; set; }
        public string KolicinaDodatneUsluge { get; set; }
        public bool Trigger { get; set; } = false;
        public List<Row> DodatneUsluge { get; set; }

        public PrijevozDetaljnoVM()
        {
            DodatneUsluge = new List<Row>();
        }
        public class Row
        {
            public string Naziv { get; set; }
            public double Cijena { get; set; }
            public string Opis { get; set; }
            public int Kolicina { get;  set; }
        }
    }
}
