using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UslugePrijevoza.Web.Models
{
    public class TipTereta_Teret
    {
        public int TipTereta_TeretID { get; set; }

        public int TeretID { get; set; }
        public Teret Teret { get; set; }

        public int TipTeretaID { get; set; }
        public TipTereta TipTereta { get; set; }
    }
}
