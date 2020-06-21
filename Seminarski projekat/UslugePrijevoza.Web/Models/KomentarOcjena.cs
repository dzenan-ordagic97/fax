using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UslugePrijevoza.Web.Areas.Identity.Data;

namespace UslugePrijevoza.Web.Models
{
    public class KomentarOcjena
    {
        public int KomentarOcjenaID { get; set; }
        public int Ocjena { get; set; }
        public string Komentar { get; set; }

        public int UserID { get; set; }
        public MojIdentityUser User { get; set; }

        public int PrijevozID { get; set; }
        public Prijevoz Prijevoz { get; set; }
    }
}
