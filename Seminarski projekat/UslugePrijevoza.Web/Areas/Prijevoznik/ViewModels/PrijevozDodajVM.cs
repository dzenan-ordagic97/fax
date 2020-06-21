using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UslugePrijevoza.Web.Models;

namespace UslugePrijevoza.Web.Areas.Prijevoznik.ViewModels
{
    public class PrijevozDodajVM
    {
        public int TeretRezervacijaID { get; set; }
        public int PrijevoznikID { get; set; }
        public DateTime DatumPotvrde { get; set; }
        public DateTime DatumPrijevoza { get; set; }
        public double Cijena { get; set; }
        public double Kilometraza { get; set; }
        public string TipPrijevoza { get; set; }
        public int VoziloID { get; set; }
        public int BrojacVozila { get; set; }
        public List<SelectListItem> Vozila { get; set; }
        public PrijevozDodajVM()
        {
            Vozila = new List<SelectListItem>();
            Vozila.Add(new SelectListItem()
            {
                Text = "Odaberite vozilo",
                Value = null,
                Disabled = true,
                Selected = true
            });
        }
    }
}
