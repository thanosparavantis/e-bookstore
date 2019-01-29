using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBookstore.model
{
    public class User
    {
        private string _username;

        private string _password;

        private string _role;

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public User(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Role = role;
        }

        public string Username { get => _username; set => _username = value; }

        public string Password { get => _password; set => _password = value; }

        public string Role { get => _role; set => _role = value; }
    }
}
