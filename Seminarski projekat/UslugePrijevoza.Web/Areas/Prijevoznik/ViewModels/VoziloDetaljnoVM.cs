using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UslugePrijevoza.Web.Models;

namespace UslugePrijevoza.Web.Areas.Prijevoznik.ViewModels
{
    public class VoziloDetaljnoVM
    {
        

        public int VoziloID { get; set; }
        public string ModelVozila { get; set; }
        public string TipVozila { get; set; }
        public string GodinaProizvodnje { get; set; }
        public string RegistracijskaOznaka { get; set; }
        public int BrojMjesta { get; set; }
        public string Zapremina { get; set; }
        public float MaxVisina { get; set; }
        public float MaxTezina { get; set; }
        public float MaxDuzina { get; set; }
        public float MaxSirina { get; set; }
        public float Cijena_km { get; set; }
        public int Br_EU_Paleta { get; set; }
        public string Opis { get; set; }
        public Slike Slika { get; set; }
    }
}
