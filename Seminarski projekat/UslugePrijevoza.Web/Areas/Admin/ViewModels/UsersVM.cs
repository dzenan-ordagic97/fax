using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UslugePrijevoza.Web.Areas.Admin.ViewModels
{
    public class UsersVM
    {
        public List<Row> userRow { get; set; }
        public UsersVM()
        {
            userRow = new List<Row>();
        }
        public class Row
        {
            public int UserID { get; set; }
            public string Username { get; set; }
            public string Ime { get; set; }
            public string Prezime { get; set; }
            public string DatumRodjenja { get; set; }
            public string JMBG { get; set; }
            public string Spol { get; set; }
            public string TipUsera { get; set; }
        }
    }
}
