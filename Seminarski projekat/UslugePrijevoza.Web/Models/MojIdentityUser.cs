using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using UslugePrijevoza.Web.Models;

namespace UslugePrijevoza.Web.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the MojIdentityUser class
    public class MojIdentityUser : IdentityUser<int>
    {
        [Required(ErrorMessage = "Ime je obavezno polje")]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[A-Ža-ž\s]+$")]
        public string Ime { get; set; }
        [Required(ErrorMessage = "Ime je obavezno polje")]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[A-Ža-ž\s]+$")]
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string JMBG { get; set; }
        public string Spol { get; set; }
        public string Slika { get; set; }
        public int? AdresaID { get; set; }
        public Adresa Adresa { get; set; }
        public string SignalRToken { get; set; }
    }
}
