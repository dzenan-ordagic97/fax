using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.EntityModels
{
    public class MaturskiIspit
    {
        public int MaturskiIspitID { get; set; }
        public int PredajePredmetID { get; set; }
        public virtual PredajePredmet PredajePredmet { get; set; }
        public int SkolaID { get; set; }
        public virtual Skola Skola { get; set; }
        public int PredmetID { get; set; }
        public virtual Predmet Predmet { get; set; }
        public DateTime Datum { get; set; }
        public string Napomena { get; set; }
        public List<MaturskiIspitStavke> maturskiIspitStavke { get; set; }
        public MaturskiIspit()
        {
            maturskiIspitStavke = new List<MaturskiIspitStavke>();
        }
    }
}
