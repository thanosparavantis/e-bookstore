using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using eBookstore.model;

namespace eBookstore.data
{
    public sealed class UserList
    {
        private List<User> _userDataList = new List<User>();

        public UserList()
        {
            _userDataList.Add(new User("admin", "123456", "admin@ebookstore.gr", "Piraeus", "18534", "Karaoli & Dimitriou 80", "21 0414 2000", "administrator"));
            _userDataList.Add(new User("johndoe", "123456", "johndoe@gmail.gr", "Athens", "16001", "Filis", "21 0414 2000", "customer"));
        }

        public List<User> GetUserDataList()
        {
            return _userDataList;
        }

        public void addNewUser(string username, string password, string email, string city, string zip, string address, string phone)
        {
            _userDataList.Add(new User(username, password, email, city, zip, address, phone, "customer"));
        }

        public void replaceUserList(List<User> newUserList)
        {
            _userDataList = newUserList;
        }
    }
}