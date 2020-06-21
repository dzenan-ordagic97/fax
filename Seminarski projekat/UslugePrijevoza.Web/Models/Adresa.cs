using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UslugePrijevoza.Web.Areas.Identity.Data;

namespace UslugePrijevoza.Web.Models
{
    public class Adresa
    {
        public int AdresaID { get; set; }
        public string Naziv { get; set; }
       
        public int? GradID { get; set; }
        public Grad Grad { get; set; }

        public List<MojIdentityUser> Useri { get; set; }
    }
}
