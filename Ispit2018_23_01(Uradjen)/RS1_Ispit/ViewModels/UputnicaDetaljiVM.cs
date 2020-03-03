using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class UputnicaDetaljiVM
    {
        public int UputnicaID { get; set; }
        public string DatumUplatnice { get; set; }
        public string Pacijent { get; set; }
        public DateTime? DatumRezultata { get; set; }
        public bool Zakljucaj { get; set; }
        public List<Row> pretrage { get; set; }
        public UputnicaDetaljiVM()
        {
            pretrage = new List<Row>();
        }
        public class Row
        {
            public int RezultatiPretrageID { get; set; }
            public string Pretraga { get; set; }
            public string NumerickaVrijednost { get; set; }
            public string MjernaJedinica { get; set; }
        }
    }
}
