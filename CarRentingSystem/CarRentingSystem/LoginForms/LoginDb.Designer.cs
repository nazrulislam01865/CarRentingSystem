namespace CarRentingSystem
{
    partial class LoginDb
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
            System.Windows.Forms.Label MemberLoginLabel;
            this.LoginText = new System.Windows.Forms.Panel();
            this.ShowPassWord = new System.Windows.Forms.CheckBox();
            this.ForgetPass = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.cusButton1 = new CustomControls.RJControls.CusButton();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBtn = new CustomControls.RJControls.CusButton();
            this.userPass = new CarRentingSystem.CustomTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userName = new CarRentingSystem.CustomTextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            MemberLoginLabel = new System.Windows.Forms.Label();
            this.LoginText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MemberLoginLabel
            // 
            MemberLoginLabel.AutoSize = true;
            MemberLoginLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            MemberLoginLabel.ForeColor = System.Drawing.Color.Black;
            MemberLoginLabel.Location = new System.Drawing.Point(84, 158);
            MemberLoginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            MemberLoginLabel.Name = "MemberLoginLabel";
            MemberLoginLabel.Size = new System.Drawing.Size(203, 40);
            MemberLoginLabel.TabIndex = 5;
            MemberLoginLabel.Text = "Member Login";
            // 
            // LoginText
            // 
            this.LoginText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.LoginText.Controls.Add(this.ShowPassWord);
            this.LoginText.Controls.Add(this.ForgetPass);
            this.LoginText.Controls.Add(this.pictureBox3);
            this.LoginText.Controls.Add(this.pictureBox4);
            this.LoginText.Controls.Add(this.cusButton1);
            this.LoginText.Controls.Add(this.label1);
            this.LoginText.Controls.Add(this.loginBtn);
            this.LoginText.Controls.Add(MemberLoginLabel);
            this.LoginText.Controls.Add(this.userPass);
            this.LoginText.Controls.Add(this.pictureBox1);
            this.LoginText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginText.Location = new System.Drawing.Point(0, 0);
            this.LoginText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(375, 585);
            this.LoginText.TabIndex = 0;
            this.LoginText.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginText_Paint);
            // 
            // ShowPassWord
            // 
            this.ShowPassWord.AutoSize = true;
            this.ShowPassWord.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPassWord.Location = new System.Drawing.Point(202, 368);
            this.ShowPassWord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShowPassWord.Name = "ShowPassWord";
            this.ShowPassWord.Size = new System.Drawing.Size(132, 21);
            this.ShowPassWord.TabIndex = 13;
            this.ShowPassWord.Text = "Show Password";
            this.ShowPassWord.UseVisualStyleBackColor = true;
            this.ShowPassWord.CheckedChanged += new System.EventHandler(this.ShowPassWord_CheckedChanged);
            // 
            // ForgetPass
            // 
            this.ForgetPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.ForgetPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgetPass.FlatAppearance.BorderSize = 0;
            this.ForgetPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ForgetPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.ForgetPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForgetPass.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgetPass.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ForgetPass.Location = new System.Drawing.Point(38, 363);
            this.ForgetPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ForgetPass.Name = "ForgetPass";
            this.ForgetPass.Size = new System.Drawing.Size(138, 35);
            this.ForgetPass.TabIndex = 12;
            this.ForgetPass.Text = "Forget Password?";
            this.ForgetPass.UseVisualStyleBackColor = false;
            this.ForgetPass.Click += new System.EventHandler(this.ForgetPass_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::CarRentingSystem.Properties.Resources.line;
            this.pictureBox3.Location = new System.Drawing.Point(51, 274);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(267, 2);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::CarRentingSystem.Properties.Resources.line;
            this.pictureBox4.Location = new System.Drawing.Point(51, 357);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(267, 2);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // cusButton1
            // 
            this.cusButton1.BackColor = System.Drawing.Color.Transparent;
            this.cusButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.cusButton1.BorderColor = System.Drawing.Color.Transparent;
            this.cusButton1.BorderRadius = 0;
            this.cusButton1.BorderSize = 0;
            this.cusButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cusButton1.FlatAppearance.BorderSize = 0;
            this.cusButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cusButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.cusButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cusButton1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cusButton1.Location = new System.Drawing.Point(110, 515);
            this.cusButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cusButton1.Name = "cusButton1";
            this.cusButton1.Size = new System.Drawing.Size(152, 29);
            this.cusButton1.TabIndex = 8;
            this.cusButton1.Text = "Create account";
            this.cusButton1.TextColor = System.Drawing.SystemColors.MenuHighlight;
            this.cusButton1.UseVisualStyleBackColor = false;
            this.cusButton1.Click += new System.EventHandler(this.cusButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 494);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Don\'t have account?.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.loginBtn.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.loginBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.loginBtn.BorderRadius = 10;
            this.loginBtn.BorderSize = 0;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.Black;
            this.loginBtn.Location = new System.Drawing.Point(120, 443);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(129, 40);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login ->";
            this.loginBtn.TextColor = System.Drawing.Color.Black;
            this.loginBtn.UseVisualStyleBackColor = false;
            // 
            // userPass
            // 
            this.userPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.userPass.customMultiline = false;
            this.userPass.customText = "Password";
            this.userPass.Location = new System.Drawing.Point(38, 300);
            this.userPass.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.userPass.Name = "userPass";
            this.userPass.password = true;
            this.userPass.Size = new System.Drawing.Size(314, 62);
            this.userPass.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRentingSystem.Properties.Resources.key_11263140;
            this.pictureBox1.Location = new System.Drawing.Point(150, 86);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.userName.customMultiline = false;
            this.userName.customText = "Username";
            this.userName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userName.Location = new System.Drawing.Point(38, 215);
            this.userName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.userName.Name = "userName";
            this.userName.password = false;
            this.userName.Size = new System.Drawing.Size(314, 58);
            this.userName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.White;
            this.labelName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.labelName.Location = new System.Drawing.Point(483, 32);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(291, 34);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Car Renting System";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Image = global::CarRentingSystem.Properties.Resources._6310507;
            this.pictureBox2.Location = new System.Drawing.Point(375, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(480, 585);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // LoginDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(855, 585);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LoginText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginDb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginDb";
            this.Load += new System.EventHandler(this.LoginDb_Load);
            this.LoginText.ResumeLayout(false);
            this.LoginText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LoginText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomControls.RJControls.CusButton loginBtn;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.CusButton cusButton1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private CustomTextBox userName;
        private System.Windows.Forms.Button ForgetPass;
        private System.Windows.Forms.CheckBox ShowPassWord;
        private CustomTextBox userPass;
        private System.Windows.Forms.Label labelName;
    }
}