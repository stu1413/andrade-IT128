namespace ProjMgmtFormsApp.ClientMethods
{
    partial class EditEmployee
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
            lblPassword = new Label();
            lblPhone = new Label();
            tboxPassword = new TextBox();
            tboxPhone = new TextBox();
            btnSubmit = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(225, 172);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 56;
            lblPassword.Text = "Password";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(250, 221);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(62, 25);
            lblPhone.TabIndex = 55;
            lblPhone.Text = "Phone";
            // 
            // tboxPassword
            // 
            tboxPassword.Location = new Point(318, 169);
            tboxPassword.Name = "tboxPassword";
            tboxPassword.Size = new Size(182, 31);
            tboxPassword.TabIndex = 45;
            // 
            // tboxPhone
            // 
            tboxPhone.Location = new Point(318, 218);
            tboxPhone.Name = "tboxPhone";
            tboxPhone.Size = new Size(182, 31);
            tboxPhone.TabIndex = 44;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(350, 328);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 40;
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
            btnCancel.TabIndex = 74;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // EditEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(lblPassword);
            Controls.Add(lblPhone);
            Controls.Add(tboxPassword);
            Controls.Add(tboxPhone);
            Controls.Add(btnSubmit);
            Name = "EditEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPassword;
        private Label lblPhone;
        private TextBox tboxPassword;
        private TextBox tboxPhone;
        private Button btnSubmit;
        private Button btnCancel;
    }
}