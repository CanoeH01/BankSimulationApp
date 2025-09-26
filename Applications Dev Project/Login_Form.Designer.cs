namespace Applications_Dev_Project
{
    partial class Form_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            btnLogin = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(129, 34);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(178, 27);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(129, 78);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(178, 27);
            txtPassword.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(39, 37);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(39, 81);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            lblPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(182, 130);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(90, 27);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            btnLogin.Enter += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(53, 130);
            btnRegister.Margin = new Padding(2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(90, 27);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register New Account";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // Form_Login
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 177);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Margin = new Padding(2);
            Name = "Form_Login";
            Text = "Login";
            Enter += btnLogin_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblUsername;
        private Label lblPassword;
        private Button btnLogin;
        private Button btnRegister;
    }
}