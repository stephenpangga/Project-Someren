namespace SomerenUI
{
    partial class LoginForm
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
            this.pnl_Login = new System.Windows.Forms.Panel();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.pnl_registration = new System.Windows.Forms.Panel();
            this.lbl_registrationtitle = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.txtBn_4thkey = new System.Windows.Forms.TextBox();
            this.txtBn_3rdkey = new System.Windows.Forms.TextBox();
            this.txtBn_2ndkey = new System.Windows.Forms.TextBox();
            this.txtBn_1stkey = new System.Windows.Forms.TextBox();
            this.txtBn_RePassword = new System.Windows.Forms.TextBox();
            this.txtBn_Password = new System.Windows.Forms.TextBox();
            this.txtBn_Email = new System.Windows.Forms.TextBox();
            this.txtBn_name = new System.Windows.Forms.TextBox();
            this.lbl_license = new System.Windows.Forms.Label();
            this.lbl_rePass = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.button_Forgot = new System.Windows.Forms.Button();
            this.pnl_Login.SuspendLayout();
            this.pnl_registration.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Login
            // 
            this.pnl_Login.Controls.Add(this.button_Forgot);
            this.pnl_Login.Controls.Add(this.btn_SignUp);
            this.pnl_Login.Controls.Add(this.Login);
            this.pnl_Login.Controls.Add(this.PasswordBox);
            this.pnl_Login.Controls.Add(this.UsernameBox);
            this.pnl_Login.Controls.Add(this.Password);
            this.pnl_Login.Controls.Add(this.Username);
            this.pnl_Login.Location = new System.Drawing.Point(1, 20);
            this.pnl_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(795, 416);
            this.pnl_Login.TabIndex = 6;
            this.pnl_Login.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Login_Paint);
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Location = new System.Drawing.Point(480, 267);
            this.btn_SignUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(156, 34);
            this.btn_SignUp.TabIndex = 11;
            this.btn_SignUp.Text = "Sign Up!";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(148, 266);
            this.Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(154, 34);
            this.Login.TabIndex = 10;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(228, 188);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(409, 22);
            this.PasswordBox.TabIndex = 9;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(228, 117);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(409, 22);
            this.UsernameBox.TabIndex = 8;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(144, 188);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(69, 17);
            this.Password.TabIndex = 7;
            this.Password.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(144, 122);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(73, 17);
            this.Username.TabIndex = 6;
            this.Username.Text = "Username";
            // 
            // pnl_registration
            // 
            this.pnl_registration.Controls.Add(this.lbl_registrationtitle);
            this.pnl_registration.Controls.Add(this.btn_return);
            this.pnl_registration.Controls.Add(this.btn_register);
            this.pnl_registration.Controls.Add(this.txtBn_4thkey);
            this.pnl_registration.Controls.Add(this.txtBn_3rdkey);
            this.pnl_registration.Controls.Add(this.txtBn_2ndkey);
            this.pnl_registration.Controls.Add(this.txtBn_1stkey);
            this.pnl_registration.Controls.Add(this.txtBn_RePassword);
            this.pnl_registration.Controls.Add(this.txtBn_Password);
            this.pnl_registration.Controls.Add(this.txtBn_Email);
            this.pnl_registration.Controls.Add(this.txtBn_name);
            this.pnl_registration.Controls.Add(this.lbl_license);
            this.pnl_registration.Controls.Add(this.lbl_rePass);
            this.pnl_registration.Controls.Add(this.lbl_password);
            this.pnl_registration.Controls.Add(this.lbl_email);
            this.pnl_registration.Controls.Add(this.lbl_name);
            this.pnl_registration.Location = new System.Drawing.Point(1, 16);
            this.pnl_registration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_registration.Name = "pnl_registration";
            this.pnl_registration.Size = new System.Drawing.Size(795, 420);
            this.pnl_registration.TabIndex = 7;
            // 
            // lbl_registrationtitle
            // 
            this.lbl_registrationtitle.AutoSize = true;
            this.lbl_registrationtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registrationtitle.Location = new System.Drawing.Point(15, 16);
            this.lbl_registrationtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_registrationtitle.Name = "lbl_registrationtitle";
            this.lbl_registrationtitle.Size = new System.Drawing.Size(248, 33);
            this.lbl_registrationtitle.TabIndex = 16;
            this.lbl_registrationtitle.Text = "Registration Form";
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(261, 311);
            this.btn_return.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(181, 44);
            this.btn_return.TabIndex = 15;
            this.btn_return.Text = "Cancel";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(452, 311);
            this.btn_register.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(185, 44);
            this.btn_register.TabIndex = 13;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // txtBn_4thkey
            // 
            this.txtBn_4thkey.Location = new System.Drawing.Point(548, 239);
            this.txtBn_4thkey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBn_4thkey.Name = "txtBn_4thkey";
            this.txtBn_4thkey.Size = new System.Drawing.Size(85, 22);
            this.txtBn_4thkey.TabIndex = 12;
            // 
            // txtBn_3rdkey
            // 
            this.txtBn_3rdkey.Location = new System.Drawing.Point(453, 239);
            this.txtBn_3rdkey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBn_3rdkey.Name = "txtBn_3rdkey";
            this.txtBn_3rdkey.Size = new System.Drawing.Size(85, 22);
            this.txtBn_3rdkey.TabIndex = 11;
            // 
            // txtBn_2ndkey
            // 
            this.txtBn_2ndkey.Location = new System.Drawing.Point(356, 239);
            this.txtBn_2ndkey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBn_2ndkey.Name = "txtBn_2ndkey";
            this.txtBn_2ndkey.Size = new System.Drawing.Size(85, 22);
            this.txtBn_2ndkey.TabIndex = 10;
            // 
            // txtBn_1stkey
            // 
            this.txtBn_1stkey.Location = new System.Drawing.Point(261, 239);
            this.txtBn_1stkey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBn_1stkey.Name = "txtBn_1stkey";
            this.txtBn_1stkey.Size = new System.Drawing.Size(85, 22);
            this.txtBn_1stkey.TabIndex = 9;
            // 
            // txtBn_RePassword
            // 
            this.txtBn_RePassword.Location = new System.Drawing.Point(261, 186);
            this.txtBn_RePassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBn_RePassword.Name = "txtBn_RePassword";
            this.txtBn_RePassword.Size = new System.Drawing.Size(375, 22);
            this.txtBn_RePassword.TabIndex = 8;
            // 
            // txtBn_Password
            // 
            this.txtBn_Password.Location = new System.Drawing.Point(261, 153);
            this.txtBn_Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBn_Password.Name = "txtBn_Password";
            this.txtBn_Password.Size = new System.Drawing.Size(375, 22);
            this.txtBn_Password.TabIndex = 7;
            // 
            // txtBn_Email
            // 
            this.txtBn_Email.Location = new System.Drawing.Point(261, 121);
            this.txtBn_Email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBn_Email.Name = "txtBn_Email";
            this.txtBn_Email.Size = new System.Drawing.Size(375, 22);
            this.txtBn_Email.TabIndex = 6;
            // 
            // txtBn_name
            // 
            this.txtBn_name.Location = new System.Drawing.Point(261, 86);
            this.txtBn_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBn_name.Name = "txtBn_name";
            this.txtBn_name.Size = new System.Drawing.Size(375, 22);
            this.txtBn_name.TabIndex = 5;
            // 
            // lbl_license
            // 
            this.lbl_license.AutoSize = true;
            this.lbl_license.Location = new System.Drawing.Point(91, 247);
            this.lbl_license.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_license.Name = "lbl_license";
            this.lbl_license.Size = new System.Drawing.Size(85, 17);
            this.lbl_license.TabIndex = 4;
            this.lbl_license.Text = "License Key";
            // 
            // lbl_rePass
            // 
            this.lbl_rePass.AutoSize = true;
            this.lbl_rePass.Location = new System.Drawing.Point(91, 192);
            this.lbl_rePass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_rePass.Name = "lbl_rePass";
            this.lbl_rePass.Size = new System.Drawing.Size(123, 17);
            this.lbl_rePass.TabIndex = 3;
            this.lbl_rePass.Text = "Re-type Password";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(91, 156);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(69, 17);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "Password";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(91, 124);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(98, 17);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "Email Address";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(91, 90);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(45, 17);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // button_Forgot
            // 
            this.button_Forgot.Location = new System.Drawing.Point(307, 266);
            this.button_Forgot.Margin = new System.Windows.Forms.Padding(2);
            this.button_Forgot.Name = "button_Forgot";
            this.button_Forgot.Size = new System.Drawing.Size(157, 35);
            this.button_Forgot.TabIndex = 13;
            this.button_Forgot.Text = "Forgot Password";
            this.button_Forgot.UseVisualStyleBackColor = true;
            this.button_Forgot.Click += new System.EventHandler(this.button_Forgot_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_Login);
            this.Controls.Add(this.pnl_registration);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.pnl_Login.ResumeLayout(false);
            this.pnl_Login.PerformLayout();
            this.pnl_registration.ResumeLayout(false);
            this.pnl_registration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Login;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Panel pnl_registration;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.TextBox txtBn_4thkey;
        private System.Windows.Forms.TextBox txtBn_3rdkey;
        private System.Windows.Forms.TextBox txtBn_2ndkey;
        private System.Windows.Forms.TextBox txtBn_1stkey;
        private System.Windows.Forms.TextBox txtBn_RePassword;
        private System.Windows.Forms.TextBox txtBn_Password;
        private System.Windows.Forms.TextBox txtBn_Email;
        private System.Windows.Forms.TextBox txtBn_name;
        private System.Windows.Forms.Label lbl_license;
        private System.Windows.Forms.Label lbl_rePass;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Label lbl_registrationtitle;
        private System.Windows.Forms.Button button_Forgot;
    }
}