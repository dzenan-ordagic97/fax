using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UslugePrijevoza.Web.Models;

namespace UslugePrijevoza.Web.Areas.Prijevoznik.ViewModels
{
    public class VoziloVM
    {
        public List<RoW> Vozila { get; set; }
        public VoziloVM()
        {
            Vozila = new List<RoW>();
        }
        public class RoW
        {
            public int VoziloID { get; set; }
            public string RegistracijskaOznaka { get; set; }
            public string GodinaProizvodnje { get; set; }
            public string BrojMjesta { get; set; }
            public string Zapremina { get; set; }
            public string TipVozila { get; set; }
            public string ModelVozila { get; set; }
            public Slike Slika { get; set; }
        }
    }
}
