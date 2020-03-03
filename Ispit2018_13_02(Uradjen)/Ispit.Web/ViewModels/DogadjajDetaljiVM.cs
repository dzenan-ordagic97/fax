using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ispit.Web.ViewModels
{
    public class DogadjajDetaljiVM
    {
        public int OznaceniDogadjajID { get; set; }
        public string Nastavnik { get; set; }
        public string DatumDogadjaja { get; set; }
        public string DatumDodavanja { get; set; }
        public string Opis { get; set; }

        public List<RowObaveze> _Obaveze { get; set; }

        public DogadjajDetaljiVM()
        {
            _Obaveze = new List<RowObaveze>();
        }

        public class RowObaveze
        {
            public int StanjeObavezeID { get; set; }
            public bool PonavljajNotiSvakiDan { get; set; }
            public string PonavljajNotiSvakiDanString { get { return PonavljajNotiSvakiDan ? "DA" : "NE"; } }
            public int NotifikacijaUnaprijedDana { get; set; }
            public string Naziv { get; set; }
            public float Procenat { get; set; }

        }

    }
}
