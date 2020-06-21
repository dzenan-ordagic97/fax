using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UslugePrijevoza.Web.Models;

namespace UslugePrijevoza.Web.Areas.Admin.ViewModels
{
    public class DrzavaVM
    {
        public Drzava DrzavaForSave { get; set; }
        public List<RoW> DrzavaRow { get; set; }
        public DrzavaVM()
        {
            DrzavaRow = new List<RoW>();
        }
        public class RoW
        {
            public int DrzavaID { get; set; }
            public string Naziv { get; set; }

        }
    }
}
