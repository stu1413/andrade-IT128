namespace ProjMgmtFormsApp.ClientMethods
{
    partial class AddEmployee
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
            lblPassword = new Label();
            lblPhone = new Label();
            lblRole = new Label();
            lblRegion = new Label();
            lblDepartment = new Label();
            lblLastname = new Label();
            lblEmail = new Label();
            lblFirstname = new Label();
            cmbRole = new ComboBox();
            cmbRegion = new ComboBox();
            cmbDepartment = new ComboBox();
            tboxPassword = new TextBox();
            tboxPhone = new TextBox();
            tboxEmail = new TextBox();
            tboxLastname = new TextBox();
            tboxFirstname = new TextBox();
            btnCancel = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(344, 330);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 23;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(99, 133);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 39;
            lblPassword.Text = "Password";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(423, 173);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(62, 25);
            lblPhone.TabIndex = 38;
            lblPhone.Text = "Phone";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(140, 215);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(46, 25);
            lblRole.TabIndex = 37;
            lblRole.Text = "Role";
            // 
            // lblRegion
            // 
            lblRegion.AutoSize = true;
            lblRegion.Location = new Point(119, 257);
            lblRegion.Name = "lblRegion";
            lblRegion.Size = new Size(67, 25);
            lblRegion.TabIndex = 36;
            lblRegion.Text = "Region";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(79, 173);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(107, 25);
            lblDepartment.TabIndex = 35;
            lblDepartment.Text = "Department";
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.Location = new Point(398, 133);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(87, 25);
            lblLastname.TabIndex = 34;
            lblLastname.Text = "Lastname";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(132, 93);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 33;
            lblEmail.Text = "Email";
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Location = new Point(396, 93);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(89, 25);
            lblFirstname.TabIndex = 32;
            lblFirstname.Text = "Firstname";
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(192, 212);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(182, 33);
            cmbRole.TabIndex = 31;
            cmbRole.Click += cmbRole_Click;
            // 
            // cmbRegion
            // 
            cmbRegion.FormattingEnabled = true;
            cmbRegion.Location = new Point(192, 254);
            cmbRegion.Name = "cmbRegion";
            cmbRegion.Size = new Size(182, 33);
            cmbRegion.TabIndex = 30;
            cmbRegion.Click += cmbRegion_Click;
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(192, 170);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(182, 33);
            cmbDepartment.TabIndex = 29;
            cmbDepartment.Click += cmbDepartment_Click;
            // 
            // tboxPassword
            // 
            tboxPassword.Location = new Point(192, 130);
            tboxPassword.Name = "tboxPassword";
            tboxPassword.Size = new Size(182, 31);
            tboxPassword.TabIndex = 28;
            // 
            // tboxPhone
            // 
            tboxPhone.Location = new Point(491, 170);
            tboxPhone.Name = "tboxPhone";
            tboxPhone.Size = new Size(182, 31);
            tboxPhone.TabIndex = 27;
            // 
            // tboxEmail
            // 
            tboxEmail.Location = new Point(192, 90);
            tboxEmail.Name = "tboxEmail";
            tboxEmail.Size = new Size(182, 31);
            tboxEmail.TabIndex = 26;
            // 
            // tboxLastname
            // 
            tboxLastname.Location = new Point(491, 130);
            tboxLastname.Name = "tboxLastname";
            tboxLastname.Size = new Size(182, 31);
            tboxLastname.TabIndex = 25;
            // 
            // tboxFirstname
            // 
            tboxFirstname.Location = new Point(491, 90);
            tboxFirstname.Name = "tboxFirstname";
            tboxFirstname.Size = new Size(182, 31);
            tboxFirstname.TabIndex = 24;
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 456);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(800, 263);
            dataGridView1.TabIndex = 78;
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 719);
            Controls.Add(dataGridView1);
            Controls.Add(btnCancel);
            Controls.Add(lblPassword);
            Controls.Add(lblPhone);
            Controls.Add(lblRole);
            Controls.Add(lblRegion);
            Controls.Add(lblDepartment);
            Controls.Add(lblLastname);
            Controls.Add(lblEmail);
            Controls.Add(lblFirstname);
            Controls.Add(cmbRole);
            Controls.Add(cmbRegion);
            Controls.Add(cmbDepartment);
            Controls.Add(tboxPassword);
            Controls.Add(tboxPhone);
            Controls.Add(tboxEmail);
            Controls.Add(tboxLastname);
            Controls.Add(tboxFirstname);
            Controls.Add(btnSubmit);
            Name = "AddEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEmployee";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSubmit;
        private Label lblPassword;
        private Label lblPhone;
        private Label lblRole;
        private Label lblRegion;
        private Label lblDepartment;
        private Label lblLastname;
        private Label lblEmail;
        private Label lblFirstname;
        private ComboBox cmbRole;
        private ComboBox cmbRegion;
        private ComboBox cmbDepartment;
        private TextBox tboxPassword;
        private TextBox tboxPhone;
        private TextBox tboxEmail;
        private TextBox tboxLastname;
        private TextBox tboxFirstname;
        private Button btnCancel;
        private DataGridView dataGridView1;
    }
}