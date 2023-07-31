namespace ProjMgmtFormsApp.ClientMethods
{
    partial class AddProject
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
            lblDescription = new Label();
            lblEmployee = new Label();
            lblClient = new Label();
            lblTitle = new Label();
            lblBudget = new Label();
            cmbEmployee = new ComboBox();
            cmbClient = new ComboBox();
            tboxDescription = new TextBox();
            tboxTitle = new TextBox();
            btnSubmit = new Button();
            lblEndDate = new Label();
            lblStartDate = new Label();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            nupBudget = new NumericUpDown();
            btnCancel = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nupBudget).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(90, 147);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(102, 25);
            lblDescription.TabIndex = 56;
            lblDescription.Text = "Description";
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Location = new Point(401, 147);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(90, 25);
            lblEmployee.TabIndex = 54;
            lblEmployee.Text = "Employee";
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.Location = new Point(136, 187);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(56, 25);
            lblClient.TabIndex = 52;
            lblClient.Text = "Client";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(148, 107);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(44, 25);
            lblTitle.TabIndex = 50;
            lblTitle.Text = "Title";
            // 
            // lblBudget
            // 
            lblBudget.AutoSize = true;
            lblBudget.Location = new Point(422, 110);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(69, 25);
            lblBudget.TabIndex = 49;
            lblBudget.Text = "Budget";
            // 
            // cmbEmployee
            // 
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(497, 144);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(182, 33);
            cmbEmployee.TabIndex = 48;
            cmbEmployee.Click += cmbEmployee_Click;
            // 
            // cmbClient
            // 
            cmbClient.FormattingEnabled = true;
            cmbClient.Location = new Point(198, 184);
            cmbClient.Name = "cmbClient";
            cmbClient.Size = new Size(182, 33);
            cmbClient.TabIndex = 46;
            cmbClient.Click += cmbClient_Click;
            // 
            // tboxDescription
            // 
            tboxDescription.Location = new Point(198, 144);
            tboxDescription.Name = "tboxDescription";
            tboxDescription.Size = new Size(182, 31);
            tboxDescription.TabIndex = 45;
            // 
            // tboxTitle
            // 
            tboxTitle.Location = new Point(198, 104);
            tboxTitle.Name = "tboxTitle";
            tboxTitle.Size = new Size(182, 31);
            tboxTitle.TabIndex = 43;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(355, 344);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 40;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(194, 282);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(84, 25);
            lblEndDate.TabIndex = 60;
            lblEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(188, 245);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(90, 25);
            lblStartDate.TabIndex = 59;
            lblStartDate.Text = "Start Date";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(284, 281);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(303, 31);
            dtpEndDate.TabIndex = 58;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(284, 239);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(303, 31);
            dtpStartDate.TabIndex = 57;
            // 
            // nupBudget
            // 
            nupBudget.Location = new Point(499, 107);
            nupBudget.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nupBudget.Name = "nupBudget";
            nupBudget.Size = new Size(180, 31);
            nupBudget.TabIndex = 61;
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
            dataGridView1.Location = new Point(0, 458);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(800, 263);
            dataGridView1.TabIndex = 78;
            // 
            // AddProject
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 719);
            Controls.Add(dataGridView1);
            Controls.Add(btnCancel);
            Controls.Add(nupBudget);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(lblDescription);
            Controls.Add(lblEmployee);
            Controls.Add(lblClient);
            Controls.Add(lblTitle);
            Controls.Add(lblBudget);
            Controls.Add(cmbEmployee);
            Controls.Add(cmbClient);
            Controls.Add(tboxDescription);
            Controls.Add(tboxTitle);
            Controls.Add(btnSubmit);
            Name = "AddProject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProject";
            ((System.ComponentModel.ISupportInitialize)nupBudget).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDescription;
        private Label lblEmployee;
        private Label lblClient;
        private Label lblTitle;
        private Label lblBudget;
        private ComboBox cmbEmployee;
        private ComboBox cmbClient;
        private TextBox tboxDescription;
        private TextBox tboxTitle;
        private Button btnSubmit;
        private Label lblEndDate;
        private Label lblStartDate;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private NumericUpDown nupBudget;
        private Button btnCancel;
        private DataGridView dataGridView1;
    }
}