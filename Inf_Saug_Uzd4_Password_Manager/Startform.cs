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
    public partial class Startform : Form
    {
        public Startform()
        {
            InitializeComponent();
        }
        public static byte[] IV;
        public static string currentUser;
        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginButton.Visible = false;
            RegisterButton.Visible = false;
            MainFieldPanel.Controls.Clear();
            LoginView lg = new LoginView();
            MainFieldPanel.Controls.Add(lg);
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            LoginButton.Visible = false;
            RegisterButton.Visible = false;
            MainFieldPanel.Controls.Clear();
            RegistrationView rg = new RegistrationView();
            MainFieldPanel.Controls.Add(rg);
        }

        private void Startform_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Manager mn = new Manager();
            mn.Encrypt();
            currentUser = null;
        }

        private void NewPassButton_Click(object sender, EventArgs e)
        {
            MainFieldPanel.Controls.Clear();
            NewPassView npv = new NewPassView();
            MainFieldPanel.Controls.Add(npv);
        }

        private void UpdatePassButton_Click(object sender, EventArgs e)
        {
            MainFieldPanel.Controls.Clear();
            UpdatePassView upv = new UpdatePassView();
            MainFieldPanel.Controls.Add(upv);
        }

        private void FindPassButton_Click(object sender, EventArgs e)
        {
            MainFieldPanel.Controls.Clear();
            FindPassView fpv = new FindPassView();
            MainFieldPanel.Controls.Add(fpv);
        }

        private void DeletePassButton_Click(object sender, EventArgs e)
        {
            MainFieldPanel.Controls.Clear();
            DeletePassView dpv = new DeletePassView();
            MainFieldPanel.Controls.Add(dpv);
        }

        private void MainFieldPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
