using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Inf_Saug_Uzd4_Password_Manager
{
    public partial class NewPassView : UserControl
    {
        public NewPassView()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text != "" && passwordTextBox.Text != "" && URLTextBox.Text != "")
            {
                AES aa = new AES();
                string pass = aa.CipherCBC(passwordTextBox.Text);
                string file = @"C:\Users\superuser\Desktop\PwManager\" + Startform.currentUser + ".txt";
                using (StreamWriter sw = File.AppendText(file))
                {
                    sw.WriteLine(loginTextBox.Text + " " + pass + " " + URLTextBox.Text + " ");
                    //sw.WriteLine(loginTextBox.Text + " " + passwordTextBox.Text + " " + URLTextBox.Text + " ");

                    loginTextBox.Text = "";
                    passwordTextBox.Text = "";
                    URLTextBox.Text = "";
                    MessageBox.Show("Slaptažodis pridėtas.");
                }
            }
            else
            {
                MessageBox.Show("Negali būti tuščių laukų");
            }
        }
    }
}
