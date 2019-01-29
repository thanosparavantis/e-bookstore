using System.Collections;
using System.Collections.Generic;
using eBookstore.model;

namespace eBookstore.data
{
    public class UserList
    {
        private List<User> _userDataList = new List<User>();

        public UserList()
        {
            _userDataList.Add(new User("admin", "123456", "administrator"));
            _userDataList.Add(new User("johndoe", "123456", "customer"));
        }

        public List<User> GetUserDataList()
        {
            return _userDataList;
        }
    }
}