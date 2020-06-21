using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UslugePrijevoza.Web.Models
{
    public class DodatneUsluge
    {
        public int DodatneUslugeID { get; set; }
        public string Naziv { get; set; }
        public double Cijena { get; set; }
        public string Opis { get; set; }

        public int PrijevoznikID { get; set; }
        public Prijevoznik Prijevoznik { get; set; }
    }
}
