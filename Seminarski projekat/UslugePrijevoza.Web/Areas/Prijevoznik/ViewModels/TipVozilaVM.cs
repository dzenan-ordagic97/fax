using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UslugePrijevoza.Web.Models;

namespace UslugePrijevoza.Web.Areas.Prijevoznik.ViewModels
{
    public class TipVozilaVM
    {
        public TipVozila TipVozilaForSave { get; set; }
        public List<RoW> TipoviVozila { get; set; }
        public List<Vozilo> MojaVozila { get; set; }
        public TipVozilaVM()
        {
            TipoviVozila = new List<RoW>();
            MojaVozila = new List<Vozilo>();
        }
        public class RoW
        {
            public int TipVozilaID { get; set; }
            public string Naziv { get; set; }
            public bool AllowChanges { get; set; }

        }
    }
}
