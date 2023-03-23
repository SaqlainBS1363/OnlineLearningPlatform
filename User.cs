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

        /*User(string userId, string userName, string password, string email) { 
            this.userId = userId;
            this.userName = userName;
            this.password = password;
            this.email = email;     
        }*/

        public void setuserId(string userId) { this.userId = userId; }
        public string getuserId() {  return userId; }

        public void setuserName(string  userName) { this.userName = userName; }
        public string getuserName() { return userName; }

        public void setpassword(string password) {  this.password = password; }
        public string getpassword() { return password; }    

        public void setemail(string email) { this.email = email; }
        public string getemail() { return email; } 
    }
}
