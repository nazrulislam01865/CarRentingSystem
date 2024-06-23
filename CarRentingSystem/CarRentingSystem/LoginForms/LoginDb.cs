using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CarRentingSystem
{
    public partial class LoginDb : Form
    {
        public LoginDb()
        {
            InitializeComponent();
        }

        private void LoginDb_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        bool isFocused = false;
        private void TextBoxPanel_Paint(object sender, PaintEventArgs e)
        {
 
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
           MessageBox.Show(userName.TextBox);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginText_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowPassWord_CheckedChanged(object sender, EventArgs e)
        {
            userPass.TogglePasswordVisibility(ShowPassWord.Checked);
            if(ShowPassWord.Checked == true){
                ShowPassWord.Text = "Hide Password";
            }
            else
            {
                ShowPassWord.Text = "Show Password";
            }
        }

        private void userPass_Load(object sender, EventArgs e)
        {

        }

        private void userPass_MouseHover(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

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
    }
}
