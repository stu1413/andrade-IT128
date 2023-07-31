namespace ProjMgmtFormsApp
{
    partial class Login
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
            tboxPassword = new TextBox();
            lblEmail = new Label();
            lblPassword = new Label();
            btnRegister = new Button();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tboxEmail
            // 
            tboxEmail.Location = new Point(402, 86);
            tboxEmail.Name = "tboxEmail";
            tboxEmail.Size = new Size(268, 31);
            tboxEmail.TabIndex = 1;
            // 
            // tboxPassword
            // 
            tboxPassword.Location = new Point(402, 148);
            tboxPassword.Name = "tboxPassword";
            tboxPassword.Size = new Size(268, 31);
            tboxPassword.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(402, 120);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(402, 182);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnRegister.Location = new Point(558, 329);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(112, 34);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(402, 225);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(146, 34);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(40, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 320);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 393);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(tboxPassword);
            Controls.Add(tboxEmail);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Project Management - Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tboxEmail;
        private TextBox tboxPassword;
        private Label lblEmail;
        private Label lblPassword;
        private Button btnRegister;
        private Button btnLogin;
        private PictureBox pictureBox1;
    }
}