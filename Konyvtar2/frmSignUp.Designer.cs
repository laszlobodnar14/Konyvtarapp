namespace Konyvtar2
{
    partial class frmSignUp
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
            this.Signup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.txtConfPasswd = new System.Windows.Forms.TextBox();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.chkConfShowPasswd = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Signup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Signup
            // 
            this.Signup.Controls.Add(this.txtID);
            this.Signup.Controls.Add(this.chkConfShowPasswd);
            this.Signup.Controls.Add(this.button2);
            this.Signup.Controls.Add(this.chkShowPassword);
            this.Signup.Controls.Add(this.cmbDesignation);
            this.Signup.Controls.Add(this.cmbUserType);
            this.Signup.Controls.Add(this.txtConfPasswd);
            this.Signup.Controls.Add(this.txtPasswd);
            this.Signup.Controls.Add(this.txtFullName);
            this.Signup.Controls.Add(this.txtUserName);
            this.Signup.Controls.Add(this.label6);
            this.Signup.Controls.Add(this.label5);
            this.Signup.Controls.Add(this.label4);
            this.Signup.Controls.Add(this.label3);
            this.Signup.Controls.Add(this.label2);
            this.Signup.Controls.Add(this.label1);
            this.Signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup.Location = new System.Drawing.Point(21, 12);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(753, 426);
            this.Signup.TabIndex = 0;
            this.Signup.TabStop = false;
            this.Signup.Text = "Signup";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Designation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = " Confirm Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(134, 46);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(344, 26);
            this.txtUserName.TabIndex = 6;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(125, 97);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(344, 26);
            this.txtFullName.TabIndex = 7;
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(119, 263);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(344, 26);
            this.txtPasswd.TabIndex = 10;
            this.txtPasswd.UseSystemPasswordChar = true;
            // 
            // txtConfPasswd
            // 
            this.txtConfPasswd.Location = new System.Drawing.Point(182, 309);
            this.txtConfPasswd.Name = "txtConfPasswd";
            this.txtConfPasswd.Size = new System.Drawing.Size(344, 26);
            this.txtConfPasswd.TabIndex = 11;
            this.txtConfPasswd.UseSystemPasswordChar = true;
            // 
            // cmbUserType
            // 
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Items.AddRange(new object[] {
            "Admin",
            "Staff Member"});
            this.cmbUserType.Location = new System.Drawing.Point(126, 150);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(334, 28);
            this.cmbUserType.TabIndex = 12;
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Items.AddRange(new object[] {
            "kiraj",
            "Manager",
            "Supervisior",
            "Lib_Cr",
            "BookKeeper"});
            this.cmbDesignation.Location = new System.Drawing.Point(135, 204);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(334, 28);
            this.cmbDesignation.TabIndex = 13;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(470, 265);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(140, 24);
            this.chkShowPassword.TabIndex = 14;
            this.chkShowPassword.Text = "Show password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // chkConfShowPasswd
            // 
            this.chkConfShowPasswd.AutoSize = true;
            this.chkConfShowPasswd.Location = new System.Drawing.Point(532, 309);
            this.chkConfShowPasswd.Name = "chkConfShowPasswd";
            this.chkConfShowPasswd.Size = new System.Drawing.Size(140, 24);
            this.chkConfShowPasswd.TabIndex = 15;
            this.chkConfShowPasswd.Text = "Show password";
            this.chkConfShowPasswd.UseVisualStyleBackColor = true;
            this.chkConfShowPasswd.CheckedChanged += new System.EventHandler(this.chkConfShowPasswd_CheckedChanged);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.DarkCyan;
            this.button2.Location = new System.Drawing.Point(286, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 48);
            this.button2.TabIndex = 17;
            this.button2.Text = "SignUp";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogin.Location = new System.Drawing.Point(307, 444);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(156, 48);
            this.btnLogin.TabIndex = 16;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(622, 46);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(99, 26);
            this.txtID.TabIndex = 18;
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.Signup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Signup.ResumeLayout(false);
            this.Signup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Signup;
        private System.Windows.Forms.CheckBox chkConfShowPasswd;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.TextBox txtConfPasswd;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtID;
    }
}