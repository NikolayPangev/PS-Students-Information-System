using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Others;
using Welcome.ViewModel;

namespace Welcome.View
{
    public class UserView
    {
        private UserViewModel _viewModel;
        public UserView(UserViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        public void Display(String user, UserRolesEnum role)

        {
            Console.WriteLine("Welcome");
            Console.Write("User: "); Console.WriteLine(user);
            Console.Write("Role: "); Console.WriteLine(role);
        }

        public void DisplayError()
        {
            throw new NotImplementedException();
        }
    }
}
