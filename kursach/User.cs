using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach
{
    class User
    {
        private int GroupId { get; }
        private string UserLogin { get; }
        private string UserId { get; }


        public User(int groupId, string userLogin, string userId)
        {
            GroupId = groupId;
            UserLogin = userLogin;
            UserId = userId;
        }

        public void SetUser()
        {
            
        }
    }
}