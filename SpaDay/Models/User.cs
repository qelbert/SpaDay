using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Models
{
    public class User
    {
        public String Username { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public User()
        {
        }
        public User(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
        }
    }


}
