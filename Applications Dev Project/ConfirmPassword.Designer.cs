namespace Applications_Dev_Project
{
    partial class ConfirmPassword
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
            lblPrompt = new Label();
            txtPassword = new TextBox();
            btnVerify = new Button();
            SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new Point(35, 27);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(270, 20);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "Please verify your password to continue";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(82, 67);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(178, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnVerify
            // 
            btnVerify.Location = new Point(125, 117);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(94, 29);
            btnVerify.TabIndex = 2;
            btnVerify.Text = "Verify";
            btnVerify.UseVisualStyleBackColor = true;
            btnVerify.Click += btnVerify_Click;
            // 
            // ConfirmPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 158);
            Controls.Add(btnVerify);
            Controls.Add(txtPassword);
            Controls.Add(lblPrompt);
            Name = "ConfirmPassword";
            Text = "ConfirmPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrompt;
        private TextBox txtPassword;
        private Button btnVerify;
    }
}