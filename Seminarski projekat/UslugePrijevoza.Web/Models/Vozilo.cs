using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UslugePrijevoza.Web.Models
{
    public class Vozilo
    {
        public int VoziloID { get; set; }
        public string RegistracijskaOznaka { get; set; }
        public DateTime GodinaProizvodnje { get; set; }
        public int BrojMjesta { get; set; }
        public double ZapreminaPrtljaznika { get; set; }

        public int PrijevoznikID { get; set; }
        public Prijevoznik Prijevoznik { get; set; }

        public int TipVozilaID { get; set; }
        public TipVozila TipVozila { get; set; }

        public int ModelVozilaID { get; set; }
        public ModelVozila ModelVozila { get; set; }

        public int? DetaljiVozilaID { get; set; }
        public DetaljiVozila DetaljiVozila { get; set; }

        public List<Prijevoz> Prijevoz { get; set; }
    }
}
