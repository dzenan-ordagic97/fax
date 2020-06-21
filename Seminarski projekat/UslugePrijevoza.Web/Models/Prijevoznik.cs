using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UslugePrijevoza.Web.Areas.Identity.Data;

namespace UslugePrijevoza.Web.Models
{
    public class Prijevoznik
    {
        public int PrijevoznikID { get; set; }
     
        public string NazivPrijevoznika { get; set; }
        public string EmailPrijevoznika { get; set; }
        //public string PoslovniTelefon { get; set; }

        public int UserID { get; set; }
        public MojIdentityUser User { get; set; }

        public List<Prijevoz> Prijevoz { get; set; }
        public List<Vozilo> Vozila { get; set; }
        public List<DodatneUsluge> Usluge { get; set; }

    }
}
