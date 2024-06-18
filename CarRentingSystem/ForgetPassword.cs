using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
           NewPassword.Visible = true;
            ConfirmPassbtn.Visible = true;
        }
    }
}
