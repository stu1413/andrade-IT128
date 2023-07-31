namespace ProjMgmtFormsApp.ClientMethods
{
    partial class AddRegion
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
            tboxRegion = new TextBox();
            lblRegion = new Label();
            btnSubmit = new Button();
            lblCode = new Label();
            tboxCode = new TextBox();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // tboxRegion
            // 
            tboxRegion.Location = new Point(306, 156);
            tboxRegion.Name = "tboxRegion";
            tboxRegion.Size = new Size(205, 31);
            tboxRegion.TabIndex = 30;
            // 
            // lblRegion
            // 
            lblRegion.AutoSize = true;
            lblRegion.Location = new Point(233, 159);
            lblRegion.Name = "lblRegion";
            lblRegion.Size = new Size(67, 25);
            lblRegion.TabIndex = 25;
            lblRegion.Text = "Region";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(358, 335);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 23;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(246, 204);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(54, 25);
            lblCode.TabIndex = 28;
            lblCode.Text = "Code";
            // 
            // tboxCode
            // 
            tboxCode.Location = new Point(306, 201);
            tboxCode.Name = "tboxCode";
            tboxCode.Size = new Size(205, 31);
            tboxCode.TabIndex = 31;
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
            // AddRegion
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
            Name = "AddRegion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddRegion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tboxRegion;
        private Label lblRegion;
        private Button btnSubmit;
        private Label lblCode;
        private TextBox tboxCode;
        private Button btnCancel;
    }
}