using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentingSystem.LoginForms
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void cusButton1_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide();
        }

        private void ForgetPass_Click(object sender, EventArgs e)
        {
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.Show();
            this.Hide();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            LoginDb loginDb = new LoginDb();
            loginDb.Show();
            this.Hide();
        }
    }
}
