using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UslugePrijevoza.Web.Models
{
    public class ModelVozila
    {
        public int ModelVozilaID { get; set; }
        public string Naziv { get; set; }
        public int PrijevoznikID { get; set; }
        public Prijevoznik Prijevoznik { get; set; }
    }
}
