using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.EntityModels
{
    public class PopravniIspitStavke
    {
        public int PopravniIspitStavkeID { get; set; }
        public int OdjeljenjeStavkaID { get; set; }
        public virtual OdjeljenjeStavka OdjeljenjeStavka { get; set; }
        public bool Pristupio { get; set; }
        public int Bodovi { get; set; }
        public int PopravniIspitID { get; set; }
        public virtual PopravniIspit PopravniIspit { get; set; }

    }
}
