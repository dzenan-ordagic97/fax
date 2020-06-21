using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UslugePrijevoza.Web.ViewModels;

namespace UslugePrijevoza.Web.Services
{
    public interface ILoggedUser
    {
        public LoggedUserVM getLoggedUser(int id);
        public LoggedUserSlikaVM getLoggedUserSlika(int id);
    }
}
