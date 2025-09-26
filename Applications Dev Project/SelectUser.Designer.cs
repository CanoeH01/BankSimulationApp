namespace Applications_Dev_Project
{
    partial class SelectUser
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
            lstUsers = new ListBox();
            btnSelect = new Button();
            SuspendLayout();
            // 
            // lstUsers
            // 
            lstUsers.FormattingEnabled = true;
            lstUsers.ItemHeight = 20;
            lstUsers.Location = new Point(12, 12);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(306, 384);
            lstUsers.TabIndex = 0;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(120, 409);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(94, 29);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // SelectUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 450);
            Controls.Add(btnSelect);
            Controls.Add(lstUsers);
            Name = "SelectUser";
            Text = "SelectUser";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstUsers;
        private Button btnSelect;
    }
}