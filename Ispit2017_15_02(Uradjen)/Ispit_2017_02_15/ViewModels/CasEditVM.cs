using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ispit_2017_02_15.ViewModels
{
    public class CasEditVM
    {
        public int CasID { get; set; }
        public string Nastavnik { get; set; }
        public DateTime Datum { get; set; }
        public string AkademskaPredmet { get; set; }

        public List<Row> odrzaniCasDetalji { get; set; }
        public CasEditVM()
        {
            odrzaniCasDetalji = new List<Row>();
        }
        public class Row
        {
            public int OdrzaniCasDetaljiID { get; set; }
            public string StudentIme { get; set; }
            public int Bodovi { get; set; }
            public bool Prisutan { get; set; }
            public string PrisutanString { get { return Prisutan ? "Prisutan" : "Odsutan"; } }
        }
    }
}
