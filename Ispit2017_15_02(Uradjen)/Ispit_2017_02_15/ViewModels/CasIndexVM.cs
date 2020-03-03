using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ispit_2017_02_15.ViewModels
{
    public class CasIndexVM
    {
        public int NastavnikID { get; set; }
        public List<Row> casovi { get; set; }
        public CasIndexVM()
        {
            casovi = new List<Row>();
        }
        public class Row
        {
            public int CasID { get; set; }
            public string DatumCasa { get; set; }
            public string AkademskaGodina { get; set; }
            public string Predmet { get; set; }
            public int BrojPrisutnihStudenata { get; set; }
            public double ProsjecnaOcjena { get; set; }
        }
    }
}
