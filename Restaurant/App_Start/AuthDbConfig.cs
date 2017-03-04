using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Restaurant.Data;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurant.App_Start
{
    public class AuthDbConfig
    {
        public static void RegisterAdmin()
        {
            using (var context = new CmsContext())
            using (var userStore = new UserStore<User>(context))
            using (var userManager = new UserManager<User>(userStore))
            {
                var user = userStore.FindByNameAsync("admin").Result;

                if (user == null)
                {
                    var adminUser = new User
                    {
                        UserName = "admin",
                        Email = "admin@makara.com",
                        DisplayName = "MakaraAdministrator"
                    };

                    userManager.Create(adminUser, "12345678");
                }
            }
        }
    }
}