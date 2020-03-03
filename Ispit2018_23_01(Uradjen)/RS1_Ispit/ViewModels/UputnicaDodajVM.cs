using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class UputnicaDodajVM
    {
        public int LjekarID { get; set; }
        public List<SelectListItem> Ljekari { get; set; }
        public DateTime Datum { get; set; }
        public int PacijentID { get; set; }
        public List<SelectListItem> Pacijenti { get; set; }
        public int VrstaPretrageID { get; set; }
        public List<SelectListItem> VrstaPretraga { get; set; }
    }
}
