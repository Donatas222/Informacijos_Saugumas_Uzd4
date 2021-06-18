using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inf_Saug_Uzd4_Password_Manager
{
    public class User
    {
        protected string username;
        protected string password;

        public User()
        {

        }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string GetUsername()
        {
            return username;
        }

        public void SetUsername(string value)
        {
            username = value;
        }

        public string GetPassword()
        {
            return password;
        }

        public void SetPassword(string value)
        {
            password = value;
        }
    }
}
