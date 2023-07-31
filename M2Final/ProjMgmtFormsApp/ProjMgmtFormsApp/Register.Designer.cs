namespace ProjMgmtFormsApp
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
            tboxFirstname = new TextBox();
            tboxLastname = new TextBox();
            tboxEmail = new TextBox();
            tboxPhone = new TextBox();
            tboxPassword = new TextBox();
            cmbDepartment = new ComboBox();
            cmbRegion = new ComboBox();
            cmbRole = new ComboBox();
            lblFirstname = new Label();
            lblEmail = new Label();
            lblLastname = new Label();
            lblDepartment = new Label();
            lblRegion = new Label();
            lblRole = new Label();
            lblPhone = new Label();
            lblPassword = new Label();
            btnRegister = new Button();
            lblCredentials = new Label();
            lblPersonals = new Label();
            lblClassifications = new Label();
            btnLogin = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tboxFirstname
            // 
            tboxFirstname.Location = new Point(315, 99);
            tboxFirstname.Name = "tboxFirstname";
            tboxFirstname.Size = new Size(182, 31);
            tboxFirstname.TabIndex = 0;
            // 
            // tboxLastname
            // 
            tboxLastname.Location = new Point(315, 161);
            tboxLastname.Name = "tboxLastname";
            tboxLastname.Size = new Size(182, 31);
            tboxLastname.TabIndex = 1;
            // 
            // tboxEmail
            // 
            tboxEmail.Location = new Point(83, 99);
            tboxEmail.Name = "tboxEmail";
            tboxEmail.Size = new Size(182, 31);
            tboxEmail.TabIndex = 2;
            // 
            // tboxPhone
            // 
            tboxPhone.Location = new Point(315, 223);
            tboxPhone.Name = "tboxPhone";
            tboxPhone.Size = new Size(182, 31);
            tboxPhone.TabIndex = 3;
            // 
            // tboxPassword
            // 
            tboxPassword.Location = new Point(83, 161);
            tboxPassword.Name = "tboxPassword";
            tboxPassword.Size = new Size(182, 31);
            tboxPassword.TabIndex = 4;
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(83, 301);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(182, 33);
            cmbDepartment.TabIndex = 6;
            cmbDepartment.Click += cmbDepartment_Click;
            // 
            // cmbRegion
            // 
            cmbRegion.FormattingEnabled = true;
            cmbRegion.Location = new Point(315, 301);
            cmbRegion.Name = "cmbRegion";
            cmbRegion.Size = new Size(182, 33);
            cmbRegion.TabIndex = 7;
            cmbRegion.Click += cmbRegion_Click;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(83, 372);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(182, 33);
            cmbRole.TabIndex = 8;
            cmbRole.Click += cmbRole_Click;
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Location = new Point(315, 133);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(89, 25);
            lblFirstname.TabIndex = 9;
            lblFirstname.Text = "Firstname";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(83, 133);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.Location = new Point(315, 195);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(87, 25);
            lblLastname.TabIndex = 11;
            lblLastname.Text = "Lastname";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(83, 337);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(107, 25);
            lblDepartment.TabIndex = 12;
            lblDepartment.Text = "Department";
            // 
            // lblRegion
            // 
            lblRegion.AutoSize = true;
            lblRegion.Location = new Point(315, 337);
            lblRegion.Name = "lblRegion";
            lblRegion.Size = new Size(67, 25);
            lblRegion.TabIndex = 13;
            lblRegion.Text = "Region";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(83, 408);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(46, 25);
            lblRole.TabIndex = 14;
            lblRole.Text = "Role";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(315, 257);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(62, 25);
            lblPhone.TabIndex = 15;
            lblPhone.Text = "Phone";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(83, 195);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 16;
            lblPassword.Text = "Password";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.Location = new Point(347, 408);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(150, 58);
            btnRegister.TabIndex = 17;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegistersubmit_Click;
            // 
            // lblCredentials
            // 
            lblCredentials.AutoSize = true;
            lblCredentials.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCredentials.Location = new Point(78, 54);
            lblCredentials.Name = "lblCredentials";
            lblCredentials.Size = new Size(112, 25);
            lblCredentials.TabIndex = 18;
            lblCredentials.Text = "Credentials:";
            // 
            // lblPersonals
            // 
            lblPersonals.AutoSize = true;
            lblPersonals.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPersonals.Location = new Point(305, 54);
            lblPersonals.Name = "lblPersonals";
            lblPersonals.Size = new Size(97, 25);
            lblPersonals.TabIndex = 19;
            lblPersonals.Text = "Personals:";
            // 
            // lblClassifications
            // 
            lblClassifications.AutoSize = true;
            lblClassifications.FlatStyle = FlatStyle.Flat;
            lblClassifications.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblClassifications.Location = new Point(78, 257);
            lblClassifications.Name = "lblClassifications";
            lblClassifications.Size = new Size(137, 25);
            lblClassifications.TabIndex = 20;
            lblClassifications.Text = "Classifications:";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnLogin.Location = new Point(12, 465);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 39);
            btnLogin.TabIndex = 21;
            btnLogin.Text = "back to login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(524, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(552, 516);
            dataGridView1.TabIndex = 22;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 516);
            Controls.Add(dataGridView1);
            Controls.Add(btnLogin);
            Controls.Add(lblClassifications);
            Controls.Add(lblPersonals);
            Controls.Add(lblCredentials);
            Controls.Add(btnRegister);
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
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Project Management - Register";
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tboxFirstname;
        private TextBox tboxLastname;
        private TextBox tboxEmail;
        private TextBox tboxPhone;
        private TextBox tboxPassword;
        private ComboBox cmbDepartment;
        private ComboBox cmbRegion;
        private ComboBox cmbRole;
        private Label lblFirstname;
        private Label lblEmail;
        private Label lblLastname;
        private Label lblDepartment;
        private Label lblRegion;
        private Label lblRole;
        private Label lblPhone;
        private Label lblPassword;
        private Button btnRegister;
        private Label lblCredentials;
        private Label lblPersonals;
        private Label lblClassifications;
        private Button btnLogin;
        private DataGridView dataGridView1;
    }
}