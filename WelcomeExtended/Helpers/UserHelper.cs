using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using WelcomeExtended.Data;

namespace WelcomeExtended.Helpers
{
    internal static class UserHelper
    {
        public static void MyString(this User user)
        {
            Console.WriteLine($"{user.Name} - {user.Role}");
        }

        public static bool ValidateCredentials(this UserData _users, string name, string password)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Username can't be empty.");
            }
            if (string.IsNullOrEmpty(password))
            {
                throw new Exception("Password can't be empty.");
            }
            return _users.ValidateUser(name, password);
        }

        public static User GetUser(this UserData _users, string name, string password)
        {
            return _users.GetUser(name, password);
        }
    }
}
