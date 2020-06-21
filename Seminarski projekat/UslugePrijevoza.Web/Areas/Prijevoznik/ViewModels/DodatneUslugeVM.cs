using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UslugePrijevoza.Web.Models;

namespace UslugePrijevoza.Web.Areas.Prijevoznik.ViewModels
{
    public class DodatneUslugeVM
    {
        public DodatneUsluge DodatneUslugeForSave { get; set; }
        public List<DodatneUsluge_Teret> DodatneUsluge_Teret { get; set; }
        public List<Row> DodatneUsluge { get; set; }

        public DodatneUslugeVM()
        {
            DodatneUsluge = new List<Row>();
            DodatneUsluge_Teret = new List<DodatneUsluge_Teret>();
        }
        public class Row {
            public int DodatneUslugeID { get; set; }
            public string Naziv { get; set; }
            public double Cijena { get; set; }
            public string Opis { get; set; }
            public bool AllowChanges { get; set; }
        }
    }
}
