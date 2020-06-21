using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UslugePrijevoza.Web.Models
{
    public class Grad
    {
        public int GradID { get; set; }
        public string Naziv { get; set; }
        public string PostanskiBroj { get; set; }
        public int DrzavaID { get; set; }
        public Drzava Drzava { get; set; }
        public List<Adresa> Adrese { get; set; }
    }
}
