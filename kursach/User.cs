namespace kursach
{
    public class User
    {
        public int GroupId { get; set; }
        public string UserLogin { get; set; }
        public int UserId { get; set; }
        public string UserPassword { get; set; }


        public User(int groupId, string userLogin, int userId, string userPassword)
        {
            GroupId = groupId;
            UserLogin = userLogin;
            UserId = userId;
            UserPassword = userPassword;
        }

        public User(int groupId, string userLogin, int userId)
        {
            GroupId = groupId;
            UserLogin = userLogin;
            UserPassword = "";
            UserId = userId;
        }

        public User(string userLogin, string userPassword)
        {
            GroupId = 2;
            UserLogin = userLogin;
            UserPassword = userPassword;
            UserId = 0;
        }

        public User()
        {
            GroupId = 0;
            UserLogin = "";
            UserPassword = "";
            UserId = 0;
        }
    }
}