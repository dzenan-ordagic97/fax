﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UslugePrijevoza.Web.Models
{
    public class DetaljiVozila
    {
        public int DetaljiVozilaID { get; set; }
        public double MaxVisina { get; set; }
        public double MaxTezina { get; set; }
        public double MaxDuzina { get; set; }
        public double MaxSirina { get; set; }
        public double Cijena_km { get; set; }
        public int? Br_EUPaleta { get; set; }
        public string Opis { get; set; }

        public List<SlikaVozilo> Slike { get; set; }

    }
}
