using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.EntityModels
{
    public class PopravniIspit
    {
        public int PopravniIspitID { get; set; }
        public int PredajePredmetID { get; set; }
        public virtual PredajePredmet PredajePredmet { get; set; }
        public DateTime Datum { get; set; }
        public int ClanKomisije1ID { get; set; }
        public virtual Nastavnik ClanKomisije1 { get; set; }
        public int ClanKomisije2ID { get; set; }
        public virtual Nastavnik ClanKomisije2 { get; set; }
        public int ClanKomisije3ID { get; set; }
        public virtual Nastavnik ClanKomisije3 { get; set; }
        public List<PopravniIspitStavke> popravniIspitStavke { get; set; }
        public PopravniIspit()
        {
            popravniIspitStavke = new List<PopravniIspitStavke>();
        }
    }
}
