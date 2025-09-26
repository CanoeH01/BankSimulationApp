namespace Applications_Dev_Project
{
    partial class ManagePocket
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
            lblName = new Label();
            txtName = new TextBox();
            numSavingsGoal = new NumericUpDown();
            lblSavingsGoal = new Label();
            mthDeadline = new MonthCalendar();
            lblDeadline = new Label();
            btnConfirm = new Button();
            ((System.ComponentModel.ISupportInitialize)numSavingsGoal).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(31, 39);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(152, 32);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 1;
            // 
            // numSavingsGoal
            // 
            numSavingsGoal.BorderStyle = BorderStyle.FixedSingle;
            numSavingsGoal.DecimalPlaces = 2;
            numSavingsGoal.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            numSavingsGoal.Location = new Point(152, 92);
            numSavingsGoal.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numSavingsGoal.Name = "numSavingsGoal";
            numSavingsGoal.Size = new Size(125, 27);
            numSavingsGoal.TabIndex = 2;
            // 
            // lblSavingsGoal
            // 
            lblSavingsGoal.AutoSize = true;
            lblSavingsGoal.Location = new Point(31, 94);
            lblSavingsGoal.Name = "lblSavingsGoal";
            lblSavingsGoal.Size = new Size(94, 20);
            lblSavingsGoal.TabIndex = 3;
            lblSavingsGoal.Text = "Savings Goal";
            // 
            // mthDeadline
            // 
            mthDeadline.Location = new Point(31, 157);
            mthDeadline.MaxSelectionCount = 1;
            mthDeadline.Name = "mthDeadline";
            mthDeadline.TabIndex = 4;
            // 
            // lblDeadline
            // 
            lblDeadline.AutoSize = true;
            lblDeadline.Location = new Point(31, 137);
            lblDeadline.Name = "lblDeadline";
            lblDeadline.Size = new Size(69, 20);
            lblDeadline.TabIndex = 5;
            lblDeadline.Text = "Deadline";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(118, 376);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 29);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // ManagePocket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 424);
            Controls.Add(btnConfirm);
            Controls.Add(lblDeadline);
            Controls.Add(mthDeadline);
            Controls.Add(lblSavingsGoal);
            Controls.Add(numSavingsGoal);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "ManagePocket";
            Text = "Manage Pocket";
            ((System.ComponentModel.ISupportInitialize)numSavingsGoal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private NumericUpDown numSavingsGoal;
        private Label lblSavingsGoal;
        private MonthCalendar mthDeadline;
        private Label lblDeadline;
        private Button btnConfirm;
    }
}