using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UslugePrijevoza.Web.Models;

namespace UslugePrijevoza.Web.Areas.Prijevoznik.ViewModels
{
    public class DashboardVM
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Grad { get; set; }
        public string NazivPrijevoznika { get; set; }
        public string EmailPrijevoznika { get; set; }
        public string PhoneNumber { get; set; }
        public Slike Slika { get; set; }
        int SlikaID { get; set; } = 0;

        public int BrojacRezervacije { get; set; } = 0;
        public double? Cijene { get; set; } = 0.0;
        public int? BrojVozila { get; set; } = 0;
        public int? UkupnoPrijevoza { get; set; } = 0;
    }
}
