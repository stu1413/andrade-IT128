namespace ProjMgmtFormsApp.ClientMethods
{
    partial class EditRole
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
            tboxRole = new TextBox();
            lblRole = new Label();
            btnSubmit = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // tboxRole
            // 
            tboxRole.Location = new Point(295, 183);
            tboxRole.Name = "tboxRole";
            tboxRole.Size = new Size(205, 31);
            tboxRole.TabIndex = 38;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(243, 186);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(46, 25);
            lblRole.TabIndex = 37;
            lblRole.Text = "Role";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(338, 320);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 36;
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
            btnCancel.TabIndex = 55;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // EditRole
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(tboxRole);
            Controls.Add(lblRole);
            Controls.Add(btnSubmit);
            Name = "EditRole";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditRole";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tboxRole;
        private Label lblRole;
        private Button btnSubmit;
        private Button btnCancel;
    }
}