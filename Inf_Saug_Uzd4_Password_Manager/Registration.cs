using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inf_Saug_Uzd4_Password_Manager
{
    public class Registration : User
    {
        public bool CheckPassword(string pass1, string pass2)
        {
            if (pass1 == pass2)
            {
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Slaptažodis pakartotas neteisingai");
                return false;
            }
        }

        public bool CheckFieldsNotEmpty(string username, string pass, string pass2)
        {
            username = username.Replace(" ", "");
            pass = pass.Replace(" ", "");
            pass2 = pass2.Replace(" ", "");


            if (username != "" && pass != "" && pass2 != "")
            {
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Negali būti tuščių laukų");
                return false;
            }
        }

        public bool CheckUsernameUnique(string un)
        {
            UserList ul = new UserList();
            if (ul.GetUsers().Where(i => i.GetUsername() == un).FirstOrDefault() == null)
                return true;
            else
            {
                System.Windows.Forms.MessageBox.Show("Toks naudotojo vardas jau užimtas");
                return false;
            }
        }
    }
}
