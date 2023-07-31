namespace ProjMgmtFormsApp.ClientMethods
{
    partial class EditClient
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
            tboxEmail = new TextBox();
            tboxPhone = new TextBox();
            lblEmail = new Label();
            lblPhone = new Label();
            btnSubmit = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // tboxEmail
            // 
            tboxEmail.Location = new Point(302, 218);
            tboxEmail.Name = "tboxEmail";
            tboxEmail.Size = new Size(205, 31);
            tboxEmail.TabIndex = 31;
            // 
            // tboxPhone
            // 
            tboxPhone.Location = new Point(302, 173);
            tboxPhone.Name = "tboxPhone";
            tboxPhone.Size = new Size(205, 31);
            tboxPhone.TabIndex = 30;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(242, 221);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 28;
            lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(234, 176);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(62, 25);
            lblPhone.TabIndex = 25;
            lblPhone.Text = "Phone";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(354, 352);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 23;
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
            // EditClient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(tboxEmail);
            Controls.Add(tboxPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(btnSubmit);
            Name = "EditClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tboxEmail;
        private TextBox tboxPhone;
        private Label lblEmail;
        private Label lblPhone;
        private Button btnSubmit;
        private Button btnCancel;
    }
}