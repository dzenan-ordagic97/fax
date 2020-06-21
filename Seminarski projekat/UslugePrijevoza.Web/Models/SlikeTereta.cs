using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UslugePrijevoza.Web.Models
{
    public class SlikeTereta
    {
        public int SlikeTeretaID { get; set; }
        public int Pozicija { get; set; }

        public int TeretID { get; set; }
        public Teret Teret { get; set; }

        public int SlikeID { get; set; }
        public Slike Slike { get; set; }
    }
}
