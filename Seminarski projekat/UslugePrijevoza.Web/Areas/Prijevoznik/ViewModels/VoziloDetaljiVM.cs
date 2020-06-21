using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UslugePrijevoza.Web.Models;

namespace UslugePrijevoza.Web.Areas.Prijevoznik.ViewModels
{
    public class VoziloDetaljiVM
    {
        public int VoziloID { get; set; }
        public string ModelVozila { get; set; }
        public string TipVozila { get; set; }
        public string GodinaProizvodnje { get; set; }
        public string RegistracijskaOznaka { get; set; }
        public int BrojMjesta { get; set; }
        public string Zapremina { get; set; }
        public List<SlikaVozilo> Slike { get; set; }


        public DetaljiVozilaDodajVM DetaljiVozila { get; set; }
    }
}
