using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UslugePrijevoza.Web.Areas.Identity.ViewModels
{
    public class FormaPrijevoznikVM
    {
        [Required]
        [Display(Name = "Naziv Prijevoznika")]
        public string NazivPrijevoznika { get; set; }
        [Required]
        public string Telefon { get; set; }
        [Display(Name = "Kontakt Email")]
        public string KontaktEmail { get; set; }
        public int DrzavaID { get; set; }

        public List<SelectListItem> Drzave { get; set; }

        public int GradID { get; set; }

        public List<SelectListItem> Gradovi { get; set; }

        public string Adresa { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string JMBG { get; set; }
        public string Spol { get; set; }
        public string[] Spolovi = new[] { "Male", "Female" };
    }
}
