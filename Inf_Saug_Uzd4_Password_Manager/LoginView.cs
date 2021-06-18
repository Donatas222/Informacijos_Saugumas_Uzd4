using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inf_Saug_Uzd4_Password_Manager
{
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            if (login.CheckFieldsNotEmpty(usernameTextBox.Text, passwordTextBox.Text)
                && login.CheckPassword(usernameTextBox.Text, passwordTextBox.Text))
            {
                Startform.currentUser = usernameTextBox.Text;
                foreach (TextBox tb in this.Controls.OfType<TextBox>())
                    tb.Text = string.Empty;

                MessageBox.Show("Prisijungimas sekmingas");
                Startform st = new Startform();
                st.Show();
                st.LoginButton.Visible = false;
                st.RegisterButton.Visible = false;
                st.NewPassButton.Visible = true;
                st.UpdatePassButton.Visible = true;
                st.FindPassButton.Visible = true;
                st.DeletePassButton.Visible = true;
                st.ExitButton.Visible = true;
                Manager mn = new Manager();
                mn.Decrypt();
            }
        }
    }
}
