using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ispit.Web.ViewModels
{
    public class DogadjajiVM
    {

        public List<RowOznaceni> _OznaceniDog { get; set; }
        public List<RowNeOznaceni> _NeOznaceniDog { get; set; }

        public DogadjajiVM()
        {
            _NeOznaceniDog = new List<RowNeOznaceni>();
            _OznaceniDog = new List<RowOznaceni>();

        }
        public class RowOznaceni {
            public int OznaceniDogadjajID { get; set; }
            public string DatumDogadjaja { get; set; }
            public string Nastavnik { get; set; }
            public string Opis { get; set; }
            public float RealizovanoObaveza { get; set; }
            public int NeOznaceniDogadjajID { get; set; }


        }
        public class RowNeOznaceni
        {
     
    
            public int NeOznaceniDogadjajID { get; set; }
            public string DatumDogadjaja { get; set; }
            public string Nastavnik { get; set; }
            public string Opis { get; set; }
            public int BrojObaveza { get; set; }

        }

    }
}
