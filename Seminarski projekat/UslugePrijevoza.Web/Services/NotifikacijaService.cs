using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UslugePrijevoza.Web.Infrastructure;
using UslugePrijevoza.Web.Models;

namespace UslugePrijevoza.Web.Services
{
    public class NotifikacijaService : INotifikacija
    {
        private readonly MojDBContext _db;
        private readonly IHubContext<SignalServer> _Hub;
        private readonly IMyUser _user;

        public NotifikacijaService(MojDBContext db, IHubContext<SignalServer> hub, IMyUser myUser)
        {
            _db = db;
            _Hub = hub;
            _user = myUser;
        }


        public void posaljiNotifikacijePrijevozniku(int to,int from, NotifikacijaVM message)
        {

            var prijevoznik = _db.Prijevoznik.Where(x => x.PrijevoznikID == to).Select(x => x.User).FirstOrDefault();
            var user =  _user.getUserById(from.ToString()).Result;

            var vrijeme = DateTime.Now;
            message.Slika = user.Slika;
            message.User = user.Ime + " " + user.Prezime;
            message.Otvorena = false;
            message.Vrijeme = vrijeme.ToString("hh:mm:ss");
            var temp = new Notifikacija()
            {
                Otvorena = message.Otvorena,
                Poruka = message.Poruka,
                URL = message.Url,
                UserFromID = from,
                UserToID = prijevoznik.Id,
                Vrijeme = vrijeme
            };
            _db.Notifikacija.Add(temp);
            
            _db.SaveChanges();

            message.NotifikacijaId = temp.NotifikacijaID;
            _Hub.Clients.Clients(prijevoznik.SignalRToken).SendAsync("GetNotification",  message);

        }

        public void posaljiNotifikacijeKlijentu(int to,int from, NotifikacijaVM message)
        {
            var Klijent= _user.getUserById(to.ToString()).Result;
            var Prijevoznik = _db.Prijevoznik.Where(x => x.PrijevoznikID == from).Select(x => x.User).FirstOrDefault();
            var vrijeme = DateTime.Now;

            message.Slika = Prijevoznik.Slika;
            message.User = Prijevoznik.Ime + " " + Prijevoznik.Prezime;
            message.Otvorena = false;
            message.Vrijeme = vrijeme.ToString("hh:mm:ss");

           var temp = new Notifikacija()
            {
                Otvorena = message.Otvorena,
                Poruka = message.Poruka,
                URL = message.Url,
                UserFromID = from,
                UserToID = to,
                Vrijeme = DateTime.Now
            };


            _db.Notifikacija.Add(temp);
            _db.SaveChanges();
            message.NotifikacijaId = temp.NotifikacijaID;
            _Hub.Clients.Clients(Klijent.SignalRToken).SendAsync("GetNotification", message);
        }

        public  Task getAllNotifikacije(int br,string connectionId)
        {
            List<NotifikacijaVM> notifikacije = _db.Notifikacija.OrderBy(x=>x.Vrijeme).Where(x => x.UserTo.SignalRToken == connectionId).Select(x => new NotifikacijaVM()
            {
                NotifikacijaId = x.NotifikacijaID,
                Poruka = x.Poruka,
                Slika  =x.UserFrom.Slika,
                User = x.UserFrom.Ime+" "+x.UserFrom.Prezime,
                Vrijeme = x.Vrijeme.ToString("hh:mm"),
                Otvorena = x.Otvorena,
                Url = x.URL
            }).Take(br).ToList();
             return _Hub.Clients.Client(connectionId).SendAsync("getAllNotifikacije", notifikacije);
        }
    }
}
