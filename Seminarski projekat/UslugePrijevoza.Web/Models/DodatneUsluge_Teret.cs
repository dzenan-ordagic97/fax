using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UslugePrijevoza.Web.Models
{
    public class DodatneUsluge_Teret
    {
        public int DodatneUsluge_TeretID { get; set; }
        public double UkupnaCijenaUsluge { get; set; }
        public int Kolicina { get; set; }
        public string Opis { get; set; }

        public int DodatneUslugeID { get; set; }
        public DodatneUsluge DodatneUsluge { get; set; }

        public int TeretRezervacijaID { get; set; }
        public TeretRezervacija TeretRezervacija { get; set; }

    }
}
