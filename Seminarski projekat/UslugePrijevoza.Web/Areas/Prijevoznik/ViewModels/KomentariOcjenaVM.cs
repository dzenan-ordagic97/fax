using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UslugePrijevoza.Web.Areas.Prijevoznik.ViewModels
{
    public class KomentariOcjenaVM
    {
        public  int  Ocjena { get; set; }

        public List<Row> Komentari { get; set; }
        public KomentariOcjenaVM()
        {
            Komentari = new List<Row>();
        }
        public class Row
        {
            public string Komentar { get; set; }
            public string User { get; set; }
            public string UserSlika { get; set; }
            public string Datum { get; set; }
            public string NazivPrijevoza { get; set; }
            public int PrijevozID { get; set; }


        }
    }
}
