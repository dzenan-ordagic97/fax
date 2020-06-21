using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UslugePrijevoza.Web.Models
{
    public class SlikaVozilo
    {
        public int SlikaVoziloID { get; set; }
        public int Pozicija { get; set; }

        public int DetaljiVozilaID { get; set; }
        public DetaljiVozila DetaljiVozila { get; set; }

        public int SlikeID { get; set; }
        public Slike Slike { get; set; }
    }
}
