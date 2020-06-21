using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UslugePrijevoza.Web.Models;

namespace UslugePrijevoza.Web.Areas.Prijevoznik.ViewModels
{
    public class DashboardPrikazVM
    {
        public int PrijevoznikID { get; set; }
        public int Ocjena1 { get; set; } = 0;
        public int Ocjena2 { get; set; } = 0;
        public int Ocjena3 { get; set; } = 0;
        public int Ocjena4 { get; set; } = 0;
        public int Ocjena5 { get; set; } = 0;
        public int BrojacRezervacije { get; set; } = 0;
        public double Cijene { get; set; } = 0.0;
        public int BrojVozila { get; set; } = 0;
        public int UkupnoPrijevoza { get; set; } = 0;

        public List<Row> naziviModela { get; set; }
        public DashboardPrikazVM()
        {
            naziviModela = new List<Row>();

        }
        public class Row
        {
            public string NazivModela { get; set; }
            public int BrojacVozila { get; set; }

            //public List<int> BrojacVozila { get; set; }
            //public Row()
            //{
            //    BrojacVozila = new List<int>();
            //}
        }

    }
}
