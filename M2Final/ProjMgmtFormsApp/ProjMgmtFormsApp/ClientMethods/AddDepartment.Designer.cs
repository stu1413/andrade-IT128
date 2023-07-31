namespace ProjMgmtFormsApp.ClientMethods
{
    partial class AddDepartment
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
            tboxDepartment = new TextBox();
            lblDepartment = new Label();
            btnSubmit = new Button();
            lblPhone = new Label();
            tboxDescription = new TextBox();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // tboxDepartment
            // 
            tboxDepartment.Location = new Point(315, 136);
            tboxDepartment.Name = "tboxDepartment";
            tboxDepartment.Size = new Size(205, 31);
            tboxDepartment.TabIndex = 29;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(202, 138);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(107, 25);
            lblDepartment.TabIndex = 24;
            lblDepartment.Text = "Department";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(367, 322);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 23;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(207, 185);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(102, 25);
            lblPhone.TabIndex = 25;
            lblPhone.Text = "Description";
            // 
            // tboxDescription
            // 
            tboxDescription.Location = new Point(315, 180);
            tboxDescription.Multiline = true;
            tboxDescription.Name = "tboxDescription";
            tboxDescription.Size = new Size(205, 92);
            tboxDescription.TabIndex = 30;
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
            // AddDepartment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(tboxDescription);
            Controls.Add(tboxDepartment);
            Controls.Add(lblPhone);
            Controls.Add(lblDepartment);
            Controls.Add(btnSubmit);
            Name = "AddDepartment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddDepartment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tboxDepartment;
        private Label lblDepartment;
        private Button btnSubmit;
        private Label lblPhone;
        private TextBox tboxDescription;
        private Button btnCancel;
    }
}