using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {
        public String Name { get; set; }
        public String Password { get; set; }
        public UserRolesEnum Role { get; set; }
        public int Id { get; set; }
        public String Date { get; set; }
        public DateTime Expires { get; set; }
    }
}
