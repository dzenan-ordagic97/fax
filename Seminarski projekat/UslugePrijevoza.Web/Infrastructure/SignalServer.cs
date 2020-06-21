using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UslugePrijevoza.Web.Areas.Identity.Data;
using UslugePrijevoza.Web.Models;
using UslugePrijevoza.Web.Services;

namespace UslugePrijevoza.Web.Infrastructure
{
    [Authorize]
    public class SignalServer : Hub
    {
        private readonly IMyUser _user;
        private readonly MojDBContext  _db;
        private readonly INotifikacija _notifikacijaService;
        private readonly UserManager<MojIdentityUser> _userManager;

        public SignalServer(IMyUser user, UserManager<MojIdentityUser> userManager, MojDBContext db,INotifikacija notifikacija)
        {
            _notifikacijaService = notifikacija;
            _userManager = userManager;
            _user = user;
            _db = db;
        }

        
        public  Task getNotification(int brNoti)
        {
           return  _notifikacijaService.getAllNotifikacije(brNoti, Context.ConnectionId);
        } 
        
        public  void deselectNotification(int id)
        {
            var n = _db.Notifikacija.Where(x => x.NotifikacijaID == id).FirstOrDefault();
            if (n!=null)
            {
                n.Otvorena = true;
                _db.SaveChanges();
            }
        }

        public override Task OnConnectedAsync()
        {
            var Userid = Context.UserIdentifier;
            //var y = Context.User;
            var ConnectionId = Context.ConnectionId;

            var x = _user.updateUser(Userid, ConnectionId).Result;

            if (x == true)
            {
                return base.OnConnectedAsync();

            }
            return null;
        }

    }
}
