namespace ProjMgmtFormsApp.ClientMethods
{
    partial class AddClient
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
            lblEmail = new Label();
            lblRegion = new Label();
            cmbRegion = new ComboBox();
            lblPhone = new Label();
            lblName = new Label();
            btnSubmit = new Button();
            tboxName = new TextBox();
            tboxPhone = new TextBox();
            tboxEmail = new TextBox();
            btnCancel = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(247, 189);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 19;
            lblEmail.Text = "Email";
            // 
            // lblRegion
            // 
            lblRegion.AutoSize = true;
            lblRegion.Location = new Point(234, 238);
            lblRegion.Name = "lblRegion";
            lblRegion.Size = new Size(67, 25);
            lblRegion.TabIndex = 17;
            lblRegion.Text = "Region";
            // 
            // cmbRegion
            // 
            cmbRegion.FormattingEnabled = true;
            cmbRegion.Location = new Point(307, 235);
            cmbRegion.Name = "cmbRegion";
            cmbRegion.Size = new Size(205, 33);
            cmbRegion.TabIndex = 16;
            cmbRegion.Click += cmbRegion_Click;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(239, 144);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(62, 25);
            lblPhone.TabIndex = 15;
            lblPhone.Text = "Phone";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(242, 97);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 14;
            lblName.Text = "Name";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(359, 320);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // tboxName
            // 
            tboxName.Location = new Point(307, 97);
            tboxName.Name = "tboxName";
            tboxName.Size = new Size(205, 31);
            tboxName.TabIndex = 20;
            // 
            // tboxPhone
            // 
            tboxPhone.Location = new Point(307, 141);
            tboxPhone.Name = "tboxPhone";
            tboxPhone.Size = new Size(205, 31);
            tboxPhone.TabIndex = 21;
            // 
            // tboxEmail
            // 
            tboxEmail.Location = new Point(307, 186);
            tboxEmail.Name = "tboxEmail";
            tboxEmail.Size = new Size(205, 31);
            tboxEmail.TabIndex = 22;
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
            dataGridView1.Location = new Point(0, 459);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(800, 260);
            dataGridView1.TabIndex = 77;
            // 
            // AddClient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 719);
            Controls.Add(dataGridView1);
            Controls.Add(btnCancel);
            Controls.Add(tboxEmail);
            Controls.Add(tboxPhone);
            Controls.Add(tboxName);
            Controls.Add(lblEmail);
            Controls.Add(lblRegion);
            Controls.Add(cmbRegion);
            Controls.Add(lblPhone);
            Controls.Add(lblName);
            Controls.Add(btnSubmit);
            Name = "AddClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddClient";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private Label lblRegion;
        private ComboBox cmbRegion;
        private Label lblPhone;
        private Label lblName;
        private Button btnSubmit;
        private TextBox tboxName;
        private TextBox tboxPhone;
        private TextBox tboxEmail;
        private Button btnCancel;
        private DataGridView dataGridView1;
    }
}