using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UslugePrijevoza.Web.Models
{
    public class Drzava
    {
        public int  DrzavaID { get; set; }
        public string Naziv { get; set; }
        public string Skracenica { get; set; }
        public List<Grad> Gradovi { get; set; }//treba
    }
}
