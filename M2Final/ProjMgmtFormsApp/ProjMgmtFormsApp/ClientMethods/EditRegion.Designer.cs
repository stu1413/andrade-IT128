namespace ProjMgmtFormsApp.ClientMethods
{
    partial class EditRegion
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
            tboxCode = new TextBox();
            tboxRegion = new TextBox();
            lblCode = new Label();
            lblRegion = new Label();
            btnSubmit = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // tboxCode
            // 
            tboxCode.Location = new Point(308, 197);
            tboxCode.Name = "tboxCode";
            tboxCode.Size = new Size(205, 31);
            tboxCode.TabIndex = 36;
            // 
            // tboxRegion
            // 
            tboxRegion.Location = new Point(308, 152);
            tboxRegion.Name = "tboxRegion";
            tboxRegion.Size = new Size(205, 31);
            tboxRegion.TabIndex = 35;
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(248, 200);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(54, 25);
            lblCode.TabIndex = 34;
            lblCode.Text = "Code";
            // 
            // lblRegion
            // 
            lblRegion.AutoSize = true;
            lblRegion.Location = new Point(235, 155);
            lblRegion.Name = "lblRegion";
            lblRegion.Size = new Size(67, 25);
            lblRegion.TabIndex = 33;
            lblRegion.Text = "Region";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(360, 331);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 32;
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
            btnCancel.TabIndex = 56;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // EditRegion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(tboxCode);
            Controls.Add(tboxRegion);
            Controls.Add(lblCode);
            Controls.Add(lblRegion);
            Controls.Add(btnSubmit);
            Name = "EditRegion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditRegion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tboxCode;
        private TextBox tboxRegion;
        private Label lblCode;
        private Label lblRegion;
        private Button btnSubmit;
        private Button btnCancel;
    }
}