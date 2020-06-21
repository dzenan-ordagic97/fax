using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UslugePrijevoza.Web.Models;

namespace UslugePrijevoza.Web.Areas.Prijevoznik.ViewModels
{
    public class VoziloDodajVM
    {
        public VoziloDodajVM()
        {
            ModelVozila = new List<SelectListItem>();
            TipVozila = new List<SelectListItem>();
        }
        public string RegistracijskaOznaka { get; set; }
        public DateTime GodinaProizvodnje { get; set; }
        public int BrojMjesta { get; set; }
        public double ZapreminaPrtljaznika { get; set; }

        public int TipVozilaID { get; set; }
        public List<SelectListItem> TipVozila { get; set; }

        public int ModelVozilaID { get; set; }
        public List<SelectListItem> ModelVozila { get; set; }

        public DetaljiVozilaDodajVM DetaljiVozila { get; set; }
        public IFormFile[] Photos { get; set; }
    }
}
