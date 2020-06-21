using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UslugePrijevoza.Web.Areas.Identity.Data;

namespace UslugePrijevoza.Web.Models
{
    public class Notifikacija
    {
        public int NotifikacijaID { get; set; }
        public DateTime Vrijeme { get; set; }
        public bool Otvorena { get; set; }
        public string Poruka { get; set; }

        public string URL { get; set; }

        public int? UserToID { get; set; }
        public MojIdentityUser UserTo { get; set; }

        public int? UserFromID { get; set; }
        public MojIdentityUser UserFrom { get; set; }
    }
}
