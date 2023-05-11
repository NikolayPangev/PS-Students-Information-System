using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;

namespace Welcome
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(UserRolesEnum.ADMIN);
            //Console.ReadKey();
            User user1 = new User
            {
                Name = "Ivan",
                Password = "password",
                Role = UserRolesEnum.STUDENT
            };

            UserViewModel userViewModel1 = new UserViewModel(user1);
            UserView userView1 = new UserView(userViewModel1);
            userView1.Display(user1.Name, user1.Role);
            Console.ReadKey();
        }
    }
}