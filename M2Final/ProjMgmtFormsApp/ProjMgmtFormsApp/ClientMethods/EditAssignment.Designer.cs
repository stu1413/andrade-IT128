namespace ProjMgmtFormsApp.ClientMethods
{
    partial class EditAssignment
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
            lblEmployee = new Label();
            cmbEmployee = new ComboBox();
            lblEndDate = new Label();
            lblStartDate = new Label();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            btnSubmit = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Location = new Point(188, 228);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(90, 25);
            lblEmployee.TabIndex = 19;
            lblEmployee.Text = "Employee";
            // 
            // cmbEmployee
            // 
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(284, 225);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(205, 33);
            cmbEmployee.TabIndex = 18;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(194, 183);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(84, 25);
            lblEndDate.TabIndex = 15;
            lblEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(188, 139);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(90, 25);
            lblStartDate.TabIndex = 14;
            lblStartDate.Text = "Start Date";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(284, 179);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(300, 31);
            dtpEndDate.TabIndex = 13;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(284, 135);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(300, 31);
            dtpStartDate.TabIndex = 12;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(336, 335);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnCancel.Location = new Point(676, 404);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 76;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // EditAssignment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(lblEmployee);
            Controls.Add(cmbEmployee);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(btnSubmit);
            Name = "EditAssignment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditAssignment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmployee;
        private ComboBox cmbEmployee;
        private Label lblEndDate;
        private Label lblStartDate;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private Button btnSubmit;
        private Button btnCancel;
    }
}