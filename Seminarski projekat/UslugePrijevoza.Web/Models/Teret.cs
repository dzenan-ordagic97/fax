using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UslugePrijevoza.Web.Models
{
    public class Teret
    {
        public int TeretID { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public double Tezina { get; set; }
        public double MaxVisina { get; set; }
        public double MaxSirina { get; set; }
        public List<TipTereta_Teret> TipTereta{ get; set; }
        public List<SlikeTereta> Slike { get; set; }
    }
}
