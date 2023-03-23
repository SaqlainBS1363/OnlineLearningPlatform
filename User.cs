using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningPlatform
{
    public class User
    {
        private string userId = "", userName = "", password = "", email = "";

        User(string userId, string userName, string password, string email) { 
            this.userId = userId;
            this.userName = userName;
            this.password = password;
            this.email = email;     
        }

        public string UserId { get { return userId; } }         
        public string UserName { get { return userName; } }
        public string Password { get { return password; } }
        public string Email { get { return email; } }
    }
}
