using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using UslugePrijevoza.Web.Models;
using UslugePrijevoza.Web.ViewModels;

namespace UslugePrijevoza.Web.Services
{
    public class LoggedUserService : ILoggedUser
    {
        private MojDBContext _db;

        public LoggedUserService(MojDBContext db)
        {
            _db = db;
        }
        public LoggedUserVM getLoggedUser(int id)
        {
            LoggedUserVM model = _db.Users.Where(x => x.Id == id).Select(x => new LoggedUserVM()
            {
                Ime = x.Ime,
                Prezime = x.Prezime
            }).FirstOrDefault();
            return model;
        }
        public LoggedUserSlikaVM getLoggedUserSlika(int id)
        {
            LoggedUserSlikaVM model = new LoggedUserSlikaVM();
            int _UserID = _db.Prijevoznik.Where(x => x.UserID == id).Select(x => x.PrijevoznikID).FirstOrDefault();
            string UserID = _UserID.ToString();

            List<Slike> _slike = _db.Slike.ToList();
            for (int y = 0; y < _slike.Count(); y++)
            {
                char temp = '0';
                temp = _slike[y].Naziv.LastOrDefault();
                if (temp.ToString() == UserID)
                {
                    int tempID = _slike[y].SlikeID;
                    model = _db.Slike.Where(s=>s.SlikeID==tempID).Select(x => new LoggedUserSlikaVM()
                    {
                        Naziv = x.Naziv,
                        URL = x.URL,
                        SlikaID=x.SlikeID
                    }).FirstOrDefault();
                }
            }
            return model;
        }
    }
}
