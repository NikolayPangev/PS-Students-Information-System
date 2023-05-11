using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WelcomeExtended.Helpers;
using WelcomeExtended.Loggers;
using WelcomeExtended.Others;
using Welcome.Model;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;
using static WelcomeExtended.Others.Delegates;
using WelcomeExtended.Data;

namespace WelcomeExtended
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DatabaseContext())
            {
                context.Database.EnsureCreated();
                context.Add<DatabaseUser>(new DatabaseUser()
                {
                    Name = "user",
                    Password = "password",
                    Expires = DateTime.Now,
                    Role = UserRolesEnum.STUDENT
                });
                context.SaveChanges();
                var users = context.Users.ToList();
                Console.ReadKey();
            }

        }
    }
}
