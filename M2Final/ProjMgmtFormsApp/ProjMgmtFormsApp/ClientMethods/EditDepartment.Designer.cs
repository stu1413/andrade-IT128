namespace ProjMgmtFormsApp.ClientMethods
{
    partial class EditDepartment
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
            tboxDescription = new TextBox();
            tboxDepartment = new TextBox();
            lblPhone = new Label();
            lblDepartment = new Label();
            btnSubmit = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // tboxDescription
            // 
            tboxDescription.Location = new Point(298, 172);
            tboxDescription.Multiline = true;
            tboxDescription.Name = "tboxDescription";
            tboxDescription.Size = new Size(205, 92);
            tboxDescription.TabIndex = 35;
            // 
            // tboxDepartment
            // 
            tboxDepartment.Location = new Point(298, 128);
            tboxDepartment.Name = "tboxDepartment";
            tboxDepartment.Size = new Size(205, 31);
            tboxDepartment.TabIndex = 34;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(190, 177);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(102, 25);
            lblPhone.TabIndex = 33;
            lblPhone.Text = "Description";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(185, 130);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(107, 25);
            lblDepartment.TabIndex = 32;
            lblDepartment.Text = "Department";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(350, 314);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 31;
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
            btnCancel.TabIndex = 75;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // EditDepartment
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
            Name = "EditDepartment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditDepartment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tboxDescription;
        private TextBox tboxDepartment;
        private Label lblPhone;
        private Label lblDepartment;
        private Button btnSubmit;
        private Button btnCancel;
    }
}