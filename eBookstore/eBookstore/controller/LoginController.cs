using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using eBookstore.data;
using eBookstore.model;

namespace eBookstore.controller
{
    public static class LoginController
    {

        public static User UserLogin(string username, string password, UserList userList)
        {
            foreach (var user in userList.GetUserDataList())
            {
                if (user.Username.ToLower().Equals(username.ToLower()) && user.Password.Equals(password))
                {
                    return user;
                }
            }

            return null;
        }
    }

}
