namespace ProjMgmtFormsApp.ClientMethods
{
    partial class AddAssignment
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
            btnSubmit = new Button();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            lblStartDate = new Label();
            lblEndDate = new Label();
            cmbDepartment = new ComboBox();
            lblDepartment = new Label();
            lblEmployee = new Label();
            cmbEmployee = new ComboBox();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(343, 333);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(291, 109);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(300, 31);
            dtpStartDate.TabIndex = 3;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(291, 153);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(300, 31);
            dtpEndDate.TabIndex = 4;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(195, 113);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(90, 25);
            lblStartDate.TabIndex = 5;
            lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(201, 157);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(84, 25);
            lblEndDate.TabIndex = 6;
            lblEndDate.Text = "End Date";
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(291, 248);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(205, 33);
            cmbDepartment.TabIndex = 7;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(178, 251);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(107, 25);
            lblDepartment.TabIndex = 8;
            lblDepartment.Text = "Department";
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Location = new Point(195, 202);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(90, 25);
            lblEmployee.TabIndex = 10;
            lblEmployee.Text = "Employee";
            // 
            // cmbEmployee
            // 
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(291, 199);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(205, 33);
            cmbEmployee.TabIndex = 9;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnCancel.Location = new Point(676, 404);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddAssignment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(lblEmployee);
            Controls.Add(cmbEmployee);
            Controls.Add(lblDepartment);
            Controls.Add(cmbDepartment);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(btnSubmit);
            Name = "AddAssignment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddAssignment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSubmit;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label lblStartDate;
        private Label lblEndDate;
        private ComboBox cmbDepartment;
        private Label lblDepartment;
        private Label lblEmployee;
        private ComboBox cmbEmployee;
        private Button btnCancel;
    }
}