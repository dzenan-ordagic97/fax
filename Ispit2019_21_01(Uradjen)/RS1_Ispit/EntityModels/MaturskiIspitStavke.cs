using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.EntityModels
{
    public class MaturskiIspitStavke
    {
        public int MaturskiIspitStavkeID { get; set; }
        public int OdjeljenjeStavkaID { get; set; }
        public virtual OdjeljenjeStavka OdjeljenjeStavka { get; set; }
        public float Prosjek { get; set; }
        public bool Pristupio { get; set; }
        public int Bodovi { get; set; }
        public int MaturskiIspitID { get; set; }
        public virtual MaturskiIspit MaturskiIspit { get; set; }
    }
}
