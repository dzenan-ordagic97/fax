using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using UslugePrijevoza.Web.Areas.Identity.Data;

namespace UslugePrijevoza.Web.Services
{
    public class MyUser : IMyUser
    {
        private readonly UserManager<MojIdentityUser> _userManager;

        public MyUser(UserManager<MojIdentityUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<MojIdentityUser> getUser(ClaimsPrincipal claims)
        {
            MojIdentityUser user = await _userManager.GetUserAsync(claims);
            return user;
        }
        public async Task<MojIdentityUser> getUserById(string id)
        {
            MojIdentityUser appUser = await _userManager.FindByIdAsync(id);
            return appUser;
        }
        public async Task<bool> updateUser(string id, string token)
        {
            try
            {
                MojIdentityUser appUser = await _userManager.FindByIdAsync(id);
                appUser.SignalRToken = token;
                var x = await _userManager.UpdateAsync(appUser);
                if (x.Succeeded)
                {
                    return true;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;

            }


            return false;
        }
    }
}

