using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UslugePrijevoza.Web.Models;

namespace UslugePrijevoza.Web.Areas.Prijevoznik.ViewModels
{
    public class ModelVozilaVM
    {
        public ModelVozila ModelVozilaForSave { get; set; }
        public List<Vozilo> MojaVozila { get; set; }

        public List<RoW> ModelVozila { get; set; }
        public ModelVozilaVM()
        {
            ModelVozila = new List<RoW>();
            MojaVozila = new List<Vozilo>();
        }
        public class RoW
        {
            public int ModelVozilaID { get; set; }
            public string Naziv { get; set; }
            public bool AllowChanges { get; set; }

        }
    }
}
