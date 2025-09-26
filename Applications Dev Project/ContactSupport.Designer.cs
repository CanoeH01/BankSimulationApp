namespace Applications_Dev_Project
{
    partial class ContactSupport
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
            txtQuery = new RichTextBox();
            txtSubject = new TextBox();
            btnSubmitQuery = new Button();
            lblSubject = new Label();
            btnDeleteMessage = new Button();
            lblMessageFrom = new Label();
            txtMessageFrom = new TextBox();
            btnResolve = new Button();
            SuspendLayout();
            // 
            // txtQuery
            // 
            txtQuery.Location = new Point(19, 56);
            txtQuery.Margin = new Padding(2);
            txtQuery.Name = "txtQuery";
            txtQuery.Size = new Size(586, 180);
            txtQuery.TabIndex = 0;
            txtQuery.Text = "";
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(94, 11);
            txtSubject.Margin = new Padding(2);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(243, 27);
            txtSubject.TabIndex = 1;
            // 
            // btnSubmitQuery
            // 
            btnSubmitQuery.Location = new Point(19, 260);
            btnSubmitQuery.Margin = new Padding(2);
            btnSubmitQuery.Name = "btnSubmitQuery";
            btnSubmitQuery.Size = new Size(108, 27);
            btnSubmitQuery.TabIndex = 2;
            btnSubmitQuery.Text = "Submit Query";
            btnSubmitQuery.UseVisualStyleBackColor = true;
            btnSubmitQuery.Click += btnSubmitQuery_Click;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(19, 14);
            lblSubject.Margin = new Padding(2, 0, 2, 0);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(58, 20);
            lblSubject.TabIndex = 3;
            lblSubject.Text = "Subject";
            // 
            // btnDeleteMessage
            // 
            btnDeleteMessage.Location = new Point(485, 260);
            btnDeleteMessage.Margin = new Padding(2);
            btnDeleteMessage.Name = "btnDeleteMessage";
            btnDeleteMessage.Size = new Size(120, 27);
            btnDeleteMessage.TabIndex = 6;
            btnDeleteMessage.Text = "Delete Message";
            btnDeleteMessage.UseVisualStyleBackColor = true;
            btnDeleteMessage.Click += btnDeleteMessage_Click;
            // 
            // lblMessageFrom
            // 
            lblMessageFrom.AutoSize = true;
            lblMessageFrom.Location = new Point(354, 14);
            lblMessageFrom.Margin = new Padding(2, 0, 2, 0);
            lblMessageFrom.Name = "lblMessageFrom";
            lblMessageFrom.Size = new Size(105, 20);
            lblMessageFrom.TabIndex = 4;
            lblMessageFrom.Text = "Message From";
            // 
            // txtMessageFrom
            // 
            txtMessageFrom.Location = new Point(485, 14);
            txtMessageFrom.Margin = new Padding(2);
            txtMessageFrom.Name = "txtMessageFrom";
            txtMessageFrom.Size = new Size(121, 27);
            txtMessageFrom.TabIndex = 5;
            // 
            // btnResolve
            // 
            btnResolve.Location = new Point(331, 260);
            btnResolve.Name = "btnResolve";
            btnResolve.Size = new Size(149, 28);
            btnResolve.TabIndex = 7;
            btnResolve.Text = "Mark As Resolved";
            btnResolve.UseVisualStyleBackColor = true;
            btnResolve.Click += btnResolve_Click;
            // 
            // ContactSupport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 300);
            Controls.Add(btnResolve);
            Controls.Add(btnDeleteMessage);
            Controls.Add(txtMessageFrom);
            Controls.Add(lblMessageFrom);
            Controls.Add(lblSubject);
            Controls.Add(btnSubmitQuery);
            Controls.Add(txtSubject);
            Controls.Add(txtQuery);
            Margin = new Padding(2);
            Name = "ContactSupport";
            Text = "ContactSupport";
            Load += ContactSupport_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtQuery;
        private TextBox txtSubject;
        private Button btnSubmitQuery;
        private Label lblSubject;
        private Button btnDeleteMessage;
        private Label lblMessageFrom;
        private TextBox txtMessageFrom;
        private Button btnResolve;
    }
}