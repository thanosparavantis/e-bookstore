using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace eBookstore.model
{
    public class User
    {
        private string _username;

        private string _password;

        private string _email;

        private string _city;

        private string _zip;

        private string _address;

        private string _phone;

        private string _role;

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public User(string username, string password, string email, string city, string zip, string address, string phone)
        {
            Username = username;
            Password = password;
            Email = email;
            City = city;
            Zip = zip;
            Address = address;
            Phone = phone;
        }

        public User(string username, string password, string email, string city, string zip, string address, string phone, string role)
        {
            Username = username;
            Password = password;
            Email = email;
            City = city;
            Zip = zip;
            Address = address;
            Phone = phone;
            Role = role;
        }

        public string Username { get => _username; set => _username = value; }

        public string Password { get => _password; set => _password = value; }

        public string Email { get => _email; set => _email = value; }

        public string City { get => _city; set => _city = value; }

        public string Zip { get => _zip; set => _zip = value; }

        public string Address { get => _address; set => _address = value; }

        public string Phone { get => _phone; set => _phone = value; }

        public string Role { get => _role; set => _role = value; }
    }
}
