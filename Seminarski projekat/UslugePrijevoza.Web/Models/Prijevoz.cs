using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UslugePrijevoza.Web.Models
{
    public class Prijevoz
    {
        public int PrijevozID { get; set; }
        public DateTime? DatumPotvrde { get; set; }
        public DateTime? DatumPrijevoza { get; set; }
        public double? Cijena { get; set; }
        public double? Kilometraza { get; set; }
        public string? TipPrijevoza { get; set; }
        public bool? Zavrseno { get; set; }

        public int PrijevoznikID { get; set; }
        public Prijevoznik Prijevoznik { get; set; }

        public int? VoziloID { get; set; }
        public Vozilo Vozilo { get; set; }

        public List<KomentarOcjena> komentarOcjena { get; set; }
                                           //  public int BrojVozaca { get; set; }

    }
}
