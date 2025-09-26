namespace Applications_Dev_Project
{
    partial class Register
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
            txtRegisterFirstName = new TextBox();
            txtRegisterUsername = new TextBox();
            txtRegisterPassword = new TextBox();
            label2 = new Label();
            txtRegisterPasswordConfirm = new TextBox();
            btnRegister = new Button();
            txtRegisterLastName = new TextBox();
            SuspendLayout();
            // 
            // txtRegisterFirstName
            // 
            txtRegisterFirstName.Location = new Point(14, 83);
            txtRegisterFirstName.Margin = new Padding(3, 4, 3, 4);
            txtRegisterFirstName.Name = "txtRegisterFirstName";
            txtRegisterFirstName.PlaceholderText = "First Name";
            txtRegisterFirstName.Size = new Size(215, 27);
            txtRegisterFirstName.TabIndex = 1;
            // 
            // txtRegisterUsername
            // 
            txtRegisterUsername.Location = new Point(14, 179);
            txtRegisterUsername.Margin = new Padding(3, 4, 3, 4);
            txtRegisterUsername.Name = "txtRegisterUsername";
            txtRegisterUsername.PlaceholderText = "Username";
            txtRegisterUsername.Size = new Size(215, 27);
            txtRegisterUsername.TabIndex = 2;
            // 
            // txtRegisterPassword
            // 
            txtRegisterPassword.Location = new Point(14, 233);
            txtRegisterPassword.Margin = new Padding(3, 4, 3, 4);
            txtRegisterPassword.Name = "txtRegisterPassword";
            txtRegisterPassword.PlaceholderText = "Password";
            txtRegisterPassword.Size = new Size(215, 27);
            txtRegisterPassword.TabIndex = 4;
            txtRegisterPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 31);
            label2.Name = "label2";
            label2.Size = new Size(215, 20);
            label2.TabIndex = 6;
            label2.Text = "Please enter your details below";
            // 
            // txtRegisterPasswordConfirm
            // 
            txtRegisterPasswordConfirm.Location = new Point(14, 286);
            txtRegisterPasswordConfirm.Margin = new Padding(3, 4, 3, 4);
            txtRegisterPasswordConfirm.Name = "txtRegisterPasswordConfirm";
            txtRegisterPasswordConfirm.PlaceholderText = "Confirm Password";
            txtRegisterPasswordConfirm.Size = new Size(215, 27);
            txtRegisterPasswordConfirm.TabIndex = 7;
            txtRegisterPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(79, 332);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(86, 31);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtRegisterLastName
            // 
            txtRegisterLastName.Location = new Point(14, 131);
            txtRegisterLastName.Margin = new Padding(3, 4, 3, 4);
            txtRegisterLastName.Name = "txtRegisterLastName";
            txtRegisterLastName.PlaceholderText = "Last Name";
            txtRegisterLastName.Size = new Size(215, 27);
            txtRegisterLastName.TabIndex = 9;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 388);
            Controls.Add(txtRegisterLastName);
            Controls.Add(btnRegister);
            Controls.Add(txtRegisterPasswordConfirm);
            Controls.Add(label2);
            Controls.Add(txtRegisterPassword);
            Controls.Add(txtRegisterUsername);
            Controls.Add(txtRegisterFirstName);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtRegisterFirstName;
        private TextBox txtRegisterUsername;
        private TextBox txtRegisterPassword;
        private Label label2;
        private TextBox txtRegisterPasswordConfirm;
        private Button btnRegister;
        private TextBox txtRegisterLastName;
    }
}