namespace ProjMgmtFormsApp
{
    partial class Client
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
            btnProjects = new Button();
            btnClients = new Button();
            btnRegions = new Button();
            btnEmpInventory = new Button();
            btnEmpDepartments = new Button();
            btnEmpRoles = new Button();
            btnEmployees = new Button();
            btnSignout = new Button();
            pictureBox1 = new PictureBox();
            btnEditprofile = new Button();
            tboxFullname = new TextBox();
            tboxEmail = new TextBox();
            tboxPassword = new TextBox();
            tboxDepartment = new TextBox();
            tboxPhone = new TextBox();
            dataGridView1 = new DataGridView();
            btnEditprofilesubmit = new Button();
            btnEditprofilecancel = new Button();
            btnAddRole = new Button();
            btnAddProject = new Button();
            btnAddDepartment = new Button();
            button4 = new Button();
            btnAddEmployee = new Button();
            btnAddRegion = new Button();
            btnAddClient = new Button();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnProjects
            // 
            btnProjects.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnProjects.Location = new Point(84, 280);
            btnProjects.Name = "btnProjects";
            btnProjects.Size = new Size(345, 94);
            btnProjects.TabIndex = 12;
            btnProjects.Text = "Projects";
            btnProjects.UseVisualStyleBackColor = true;
            btnProjects.Click += btnProjects_Click;
            // 
            // btnClients
            // 
            btnClients.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClients.Location = new Point(84, 718);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(345, 94);
            btnClients.TabIndex = 13;
            btnClients.Text = "Clients";
            btnClients.UseVisualStyleBackColor = true;
            btnClients.Click += btnClients_Click;
            // 
            // btnRegions
            // 
            btnRegions.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegions.Location = new Point(84, 613);
            btnRegions.Name = "btnRegions";
            btnRegions.Size = new Size(345, 94);
            btnRegions.TabIndex = 14;
            btnRegions.Text = "Regions";
            btnRegions.UseVisualStyleBackColor = true;
            btnRegions.Click += btnRegions_Click;
            // 
            // btnEmpInventory
            // 
            btnEmpInventory.Location = new Point(148, 567);
            btnEmpInventory.Name = "btnEmpInventory";
            btnEmpInventory.Size = new Size(281, 35);
            btnEmpInventory.TabIndex = 15;
            btnEmpInventory.Text = "Inventory";
            btnEmpInventory.UseVisualStyleBackColor = true;
            btnEmpInventory.Click += btnEmpInventory_Click;
            // 
            // btnEmpDepartments
            // 
            btnEmpDepartments.Location = new Point(148, 526);
            btnEmpDepartments.Name = "btnEmpDepartments";
            btnEmpDepartments.Size = new Size(281, 35);
            btnEmpDepartments.TabIndex = 16;
            btnEmpDepartments.Text = "Departments";
            btnEmpDepartments.UseVisualStyleBackColor = true;
            btnEmpDepartments.Click += btnEmpDepartments_Click;
            // 
            // btnEmpRoles
            // 
            btnEmpRoles.Location = new Point(148, 485);
            btnEmpRoles.Name = "btnEmpRoles";
            btnEmpRoles.Size = new Size(281, 35);
            btnEmpRoles.TabIndex = 17;
            btnEmpRoles.Text = "Roles";
            btnEmpRoles.UseVisualStyleBackColor = true;
            btnEmpRoles.Click += btnEmpRoles_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployees.Location = new Point(84, 385);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(345, 94);
            btnEmployees.TabIndex = 18;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnSignout
            // 
            btnSignout.Anchor = AnchorStyles.Bottom;
            btnSignout.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnSignout.Location = new Point(12, 977);
            btnSignout.Name = "btnSignout";
            btnSignout.Size = new Size(197, 37);
            btnSignout.TabIndex = 19;
            btnSignout.Text = "Sign Out";
            btnSignout.UseVisualStyleBackColor = true;
            btnSignout.Click += btnSignout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.profile_placeholder;
            pictureBox1.Location = new Point(18, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // btnEditprofile
            // 
            btnEditprofile.BackgroundImage = Properties.Resources.settings;
            btnEditprofile.BackgroundImageLayout = ImageLayout.Zoom;
            btnEditprofile.Location = new Point(399, 173);
            btnEditprofile.Name = "btnEditprofile";
            btnEditprofile.Size = new Size(30, 30);
            btnEditprofile.TabIndex = 23;
            btnEditprofile.UseVisualStyleBackColor = true;
            btnEditprofile.Click += btnEditprofile_Click;
            // 
            // tboxFullname
            // 
            tboxFullname.Enabled = false;
            tboxFullname.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            tboxFullname.Location = new Point(145, 53);
            tboxFullname.Name = "tboxFullname";
            tboxFullname.Size = new Size(284, 45);
            tboxFullname.TabIndex = 27;
            tboxFullname.Text = "Fullname";
            // 
            // tboxEmail
            // 
            tboxEmail.Enabled = false;
            tboxEmail.Location = new Point(162, 19);
            tboxEmail.Name = "tboxEmail";
            tboxEmail.Size = new Size(267, 31);
            tboxEmail.TabIndex = 28;
            tboxEmail.Text = "Email";
            // 
            // tboxPassword
            // 
            tboxPassword.Enabled = false;
            tboxPassword.Location = new Point(162, 173);
            tboxPassword.Name = "tboxPassword";
            tboxPassword.PlaceholderText = "New Password";
            tboxPassword.Size = new Size(231, 31);
            tboxPassword.TabIndex = 29;
            tboxPassword.Visible = false;
            // 
            // tboxDepartment
            // 
            tboxDepartment.Enabled = false;
            tboxDepartment.Location = new Point(162, 136);
            tboxDepartment.Name = "tboxDepartment";
            tboxDepartment.Size = new Size(267, 31);
            tboxDepartment.TabIndex = 30;
            tboxDepartment.Text = "Department";
            // 
            // tboxPhone
            // 
            tboxPhone.Enabled = false;
            tboxPhone.Location = new Point(162, 102);
            tboxPhone.Name = "tboxPhone";
            tboxPhone.Size = new Size(267, 31);
            tboxPhone.TabIndex = 31;
            tboxPhone.Text = "Phone";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Location = new Point(440, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1423, 1026);
            dataGridView1.TabIndex = 32;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnEditprofilesubmit
            // 
            btnEditprofilesubmit.BackgroundImage = Properties.Resources.confirm;
            btnEditprofilesubmit.BackgroundImageLayout = ImageLayout.Zoom;
            btnEditprofilesubmit.Location = new Point(327, 210);
            btnEditprofilesubmit.Name = "btnEditprofilesubmit";
            btnEditprofilesubmit.Size = new Size(30, 30);
            btnEditprofilesubmit.TabIndex = 33;
            btnEditprofilesubmit.UseVisualStyleBackColor = true;
            btnEditprofilesubmit.Visible = false;
            btnEditprofilesubmit.Click += btnEditprofilesubmit_Click;
            // 
            // btnEditprofilecancel
            // 
            btnEditprofilecancel.BackgroundImage = Properties.Resources.cancel;
            btnEditprofilecancel.BackgroundImageLayout = ImageLayout.Zoom;
            btnEditprofilecancel.Location = new Point(363, 210);
            btnEditprofilecancel.Name = "btnEditprofilecancel";
            btnEditprofilecancel.Size = new Size(30, 30);
            btnEditprofilecancel.TabIndex = 34;
            btnEditprofilecancel.UseVisualStyleBackColor = true;
            btnEditprofilecancel.Visible = false;
            btnEditprofilecancel.Click += btnEditprofilecancel_Click;
            // 
            // btnAddRole
            // 
            btnAddRole.BackgroundImage = Properties.Resources.add;
            btnAddRole.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddRole.Location = new Point(117, 490);
            btnAddRole.Name = "btnAddRole";
            btnAddRole.Size = new Size(25, 25);
            btnAddRole.TabIndex = 35;
            btnAddRole.UseVisualStyleBackColor = true;
            btnAddRole.Click += btnAddRole_Click;
            // 
            // btnAddProject
            // 
            btnAddProject.BackgroundImage = Properties.Resources.add;
            btnAddProject.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddProject.Location = new Point(48, 312);
            btnAddProject.Name = "btnAddProject";
            btnAddProject.Size = new Size(30, 30);
            btnAddProject.TabIndex = 36;
            btnAddProject.UseVisualStyleBackColor = true;
            btnAddProject.Click += btnAddProject_Click;
            // 
            // btnAddDepartment
            // 
            btnAddDepartment.BackgroundImage = Properties.Resources.add;
            btnAddDepartment.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddDepartment.Location = new Point(117, 531);
            btnAddDepartment.Name = "btnAddDepartment";
            btnAddDepartment.Size = new Size(25, 25);
            btnAddDepartment.TabIndex = 37;
            btnAddDepartment.UseVisualStyleBackColor = true;
            btnAddDepartment.Click += btnAddDepartment_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.add;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Location = new Point(117, 572);
            button4.Name = "button4";
            button4.Size = new Size(25, 25);
            button4.TabIndex = 38;
            button4.UseVisualStyleBackColor = true;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackgroundImage = Properties.Resources.add;
            btnAddEmployee.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddEmployee.Location = new Point(48, 417);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(30, 30);
            btnAddEmployee.TabIndex = 39;
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // btnAddRegion
            // 
            btnAddRegion.BackgroundImage = Properties.Resources.add;
            btnAddRegion.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddRegion.Location = new Point(48, 645);
            btnAddRegion.Name = "btnAddRegion";
            btnAddRegion.Size = new Size(30, 30);
            btnAddRegion.TabIndex = 40;
            btnAddRegion.UseVisualStyleBackColor = true;
            btnAddRegion.Click += btnAddRegion_Click;
            // 
            // btnAddClient
            // 
            btnAddClient.BackgroundImage = Properties.Resources.add;
            btnAddClient.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddClient.Location = new Point(48, 750);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(30, 30);
            btnAddClient.TabIndex = 41;
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 8;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Resizable = DataGridViewTriState.False;
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 75;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Resizable = DataGridViewTriState.False;
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 75;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1863, 1026);
            Controls.Add(btnAddClient);
            Controls.Add(btnAddRegion);
            Controls.Add(btnAddEmployee);
            Controls.Add(button4);
            Controls.Add(btnAddDepartment);
            Controls.Add(btnAddProject);
            Controls.Add(btnAddRole);
            Controls.Add(btnEditprofilecancel);
            Controls.Add(btnEditprofilesubmit);
            Controls.Add(dataGridView1);
            Controls.Add(tboxPhone);
            Controls.Add(tboxDepartment);
            Controls.Add(tboxPassword);
            Controls.Add(tboxEmail);
            Controls.Add(tboxFullname);
            Controls.Add(btnEditprofile);
            Controls.Add(pictureBox1);
            Controls.Add(btnSignout);
            Controls.Add(btnEmployees);
            Controls.Add(btnEmpRoles);
            Controls.Add(btnEmpDepartments);
            Controls.Add(btnEmpInventory);
            Controls.Add(btnRegions);
            Controls.Add(btnClients);
            Controls.Add(btnProjects);
            Name = "Client";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Project Management - Client";
            Load += Client_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnProjects;
        private Button btnClients;
        private Button btnRegions;
        private Button btnEmpInventory;
        private Button btnEmpDepartments;
        private Button btnEmpRoles;
        private Button btnEmployees;
        private Button btnSignout;
        private PictureBox pictureBox1;
        private Button btnEditprofile;
        private TextBox tboxFullname;
        private TextBox tboxEmail;
        private TextBox tboxPassword;
        private TextBox tboxDepartment;
        private TextBox tboxPhone;
        private DataGridView dataGridView1;
        private Button btnEditprofilesubmit;
        private Button btnEditprofilecancel;
        private Button btnAddRole;
        private Button btnAddProject;
        private Button btnAddDepartment;
        private Button button4;
        private Button btnAddEmployee;
        private Button btnAddRegion;
        private Button btnAddClient;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}