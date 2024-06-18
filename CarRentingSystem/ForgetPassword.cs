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
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void ForgetBtn_Click(object sender, EventArgs e)
        {
           Email.Visible = false;
           userName.Visible = false;
           showPass.Visible = true;
           NewPassword.Visible = true;
           ConfirmPassbtn.Visible = true;
           ForgetBtn.Visible = false;
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            NewPassword.TogglePasswordVisibility(showPass.Checked);
         
        }

    }
}
