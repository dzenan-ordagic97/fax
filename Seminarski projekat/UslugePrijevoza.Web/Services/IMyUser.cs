using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using UslugePrijevoza.Web.Areas.Identity.Data;

namespace UslugePrijevoza.Web.Services
{
    public interface IMyUser
    {
        Task<MojIdentityUser> getUser(ClaimsPrincipal claims);
        Task<MojIdentityUser> getUserById(string id);
        Task<bool> updateUser(string id, string token);
    }
}
