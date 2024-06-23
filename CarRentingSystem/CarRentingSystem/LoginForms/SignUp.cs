using CarRentingSystem.LoginForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CarRentingSystem
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FullName_Load(object sender, EventArgs e)
        {

        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            userPass.TogglePasswordVisibility(ShowPass.Checked);
            if (ShowPass.Checked == true)
            {
                ShowPass.Text = "Hide Password";
            }
            else
            {
                ShowPass.Text = "Show Password";
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            //LoginDb login = new LoginDb();
            //login.Show();
            this.Hide();
        }
    }
}
