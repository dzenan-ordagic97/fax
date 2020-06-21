using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UslugePrijevoza.Web.Areas.Identity.Data;

namespace UslugePrijevoza.Web.Models
{
    public class TeretRezervacija
    {
        public int TeretRezervacijaID { get; set; }
        public string PocetnaLokacija { get; set; }
        public string KrajnjaLokacija { get; set; }
        public bool Prihvaceno { get; set; }
        public DateTime PocetniDatumPrijevoza { get; set; }
        public DateTime KrajnjiDatumPrijevoza { get; set; }

        public int UserID { get; set; }
        public MojIdentityUser User { get; set; }

        public int? PrijevozID { get; set; }
        public Prijevoz Prijevoz { get; set; }

        public int TeretID { get; set; }
        public Teret Teret { get; set; }

        public List<DodatneUsluge_Teret> DodatneUsluge { get; set; }

    }
}
