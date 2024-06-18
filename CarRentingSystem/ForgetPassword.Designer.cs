namespace CarRentingSystem
{
    partial class ForgetPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Email = new CarRentingSystem.CustomTextBox();
            this.userName = new CarRentingSystem.CustomTextBox();
            this.ForgetBtn = new CustomControls.RJControls.CusButton();
            this.NewPassword = new CarRentingSystem.CustomTextBox();
            this.ConfirmPassbtn = new CarRentingSystem.CustomTextBox();
            this.SuspendLayout();
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.Email.customMultiline = false;
            this.Email.customText = "Email";
            this.Email.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(142, 204);
            this.Email.Name = "Email";
            this.Email.password = false;
            this.Email.Size = new System.Drawing.Size(168, 43);
            this.Email.TabIndex = 0;
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.userName.customMultiline = false;
            this.userName.customText = "Username";
            this.userName.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(142, 256);
            this.userName.Name = "userName";
            this.userName.password = false;
            this.userName.Size = new System.Drawing.Size(168, 43);
            this.userName.TabIndex = 1;
            // 
            // ForgetBtn
            // 
            this.ForgetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(116)))), ((int)(((byte)(192)))));
            this.ForgetBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(116)))), ((int)(((byte)(192)))));
            this.ForgetBtn.BorderColor = System.Drawing.Color.LavenderBlush;
            this.ForgetBtn.BorderRadius = 8;
            this.ForgetBtn.BorderSize = 0;
            this.ForgetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgetBtn.FlatAppearance.BorderSize = 0;
            this.ForgetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForgetBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgetBtn.ForeColor = System.Drawing.Color.Black;
            this.ForgetBtn.Location = new System.Drawing.Point(174, 307);
            this.ForgetBtn.Name = "ForgetBtn";
            this.ForgetBtn.Size = new System.Drawing.Size(105, 27);
            this.ForgetBtn.TabIndex = 2;
            this.ForgetBtn.Text = "Continue";
            this.ForgetBtn.TextColor = System.Drawing.Color.Black;
            this.ForgetBtn.UseVisualStyleBackColor = false;
            this.ForgetBtn.Click += new System.EventHandler(this.ForgetBtn_Click);
            // 
            // NewPassword
            // 
            this.NewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.NewPassword.customMultiline = false;
            this.NewPassword.customText = "New Password";
            this.NewPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPassword.Location = new System.Drawing.Point(142, 204);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.password = true;
            this.NewPassword.Size = new System.Drawing.Size(168, 43);
            this.NewPassword.TabIndex = 3;
            this.NewPassword.Visible = false;
            // 
            // ConfirmPassbtn
            // 
            this.ConfirmPassbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.ConfirmPassbtn.customMultiline = false;
            this.ConfirmPassbtn.customText = "Confirm Password";
            this.ConfirmPassbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassbtn.Location = new System.Drawing.Point(142, 256);
            this.ConfirmPassbtn.Name = "ConfirmPassbtn";
            this.ConfirmPassbtn.password = true;
            this.ConfirmPassbtn.Size = new System.Drawing.Size(168, 43);
            this.ConfirmPassbtn.TabIndex = 4;
            this.ConfirmPassbtn.Visible = false;
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarRentingSystem.Properties.Resources.ForgetPass;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.ConfirmPassbtn);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.ForgetBtn);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.Email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPassword";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomTextBox Email;
        private CustomTextBox userName;
        private CustomControls.RJControls.CusButton ForgetBtn;
        private CustomTextBox NewPassword;
        private CustomTextBox ConfirmPassbtn;
    }
}