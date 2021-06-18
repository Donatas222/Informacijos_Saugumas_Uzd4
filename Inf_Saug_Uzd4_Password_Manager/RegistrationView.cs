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
    public partial class RegistrationView : UserControl
    {
        public RegistrationView()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();

            if (registration.CheckFieldsNotEmpty(usernameTextBox.Text, passwordTextBox.Text, passwordConfirmTextBox.Text)
                && registration.CheckUsernameUnique(usernameTextBox.Text)
                && registration.CheckPassword(passwordTextBox.Text, passwordConfirmTextBox.Text))
            {
                UserList u = new UserList();
                u.AddUser(usernameTextBox.Text, passwordTextBox.Text);

                Startform.currentUser = usernameTextBox.Text;

                Manager mn = new Manager();
                mn.CreateFile(Startform.currentUser);

                foreach (TextBox tb in this.Controls.OfType<TextBox>())
                    tb.Text = string.Empty;

                MessageBox.Show("Registracija sekminga");
                Startform st = new Startform();
                st.Show();
                st.LoginButton.Visible = false;
                st.RegisterButton.Visible = false;
                st.NewPassButton.Visible = true;
                st.UpdatePassButton.Visible = true;
                st.FindPassButton.Visible = true;
                st.DeletePassButton.Visible = true;
                st.ExitButton.Visible = true;
            }
        }
    }
}
