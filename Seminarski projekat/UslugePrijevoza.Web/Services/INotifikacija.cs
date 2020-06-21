using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UslugePrijevoza.Web.Services
{
    public interface INotifikacija
    {
        void posaljiNotifikacijeKlijentu(int to, int from, NotifikacijaVM message);
        void posaljiNotifikacijePrijevozniku(int to,int from, NotifikacijaVM message);
        Task getAllNotifikacije(int br,string connectionID);
    }

    public class NotifikacijaVM
    {
        public string Poruka { get; set; }
        public string Vrijeme { get; set; }
        public string User { get; set; }
        public string Slika { get; set; }
        public bool Otvorena { get;  set; }
        public string Url { get; internal set; }
        public int NotifikacijaId { get; internal set; }
    }
}
