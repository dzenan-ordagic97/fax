using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class UputnicaIndexVM
    {
        public List<Row> uputnice { get; set; }
        public UputnicaIndexVM()
        {
            uputnice = new List<Row>();
        }
        public class Row
        {
            public int UputnicaID { get; set; }
            public DateTime Datum { get; set; }
            public string UputioLjekar { get; set; }
            public string Pacijent { get; set; }
            public string VrstaPretrage { get; set; }
            public DateTime? DatumEvidentiranja { get; set; }
        }
    }
}
