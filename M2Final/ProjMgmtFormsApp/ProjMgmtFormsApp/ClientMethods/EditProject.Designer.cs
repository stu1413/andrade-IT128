namespace ProjMgmtFormsApp.ClientMethods
{
    partial class EditProject
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
            lblTitle = new Label();
            lblBudget = new Label();
            tboxDescription = new TextBox();
            tboxTitle = new TextBox();
            btnSubmit = new Button();
            nupBudget = new NumericUpDown();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)nupBudget).BeginInit();
            SuspendLayout();
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(211, 158);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(102, 25);
            lblDescription.TabIndex = 71;
            lblDescription.Text = "Description";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(269, 121);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(44, 25);
            lblTitle.TabIndex = 68;
            lblTitle.Text = "Title";
            // 
            // lblBudget
            // 
            lblBudget.AutoSize = true;
            lblBudget.Location = new Point(244, 245);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(69, 25);
            lblBudget.TabIndex = 67;
            lblBudget.Text = "Budget";
            // 
            // tboxDescription
            // 
            tboxDescription.Location = new Point(319, 155);
            tboxDescription.Multiline = true;
            tboxDescription.Name = "tboxDescription";
            tboxDescription.Size = new Size(182, 81);
            tboxDescription.TabIndex = 64;
            // 
            // tboxTitle
            // 
            tboxTitle.Location = new Point(319, 118);
            tboxTitle.Name = "tboxTitle";
            tboxTitle.Size = new Size(182, 31);
            tboxTitle.TabIndex = 63;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(371, 328);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 61;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // nupBudget
            // 
            nupBudget.Location = new Point(321, 243);
            nupBudget.Name = "nupBudget";
            nupBudget.Size = new Size(180, 31);
            nupBudget.TabIndex = 72;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnCancel.Location = new Point(676, 404);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 73;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // EditProject
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(nupBudget);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(lblBudget);
            Controls.Add(tboxDescription);
            Controls.Add(tboxTitle);
            Controls.Add(btnSubmit);
            Name = "EditProject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditProject";
            ((System.ComponentModel.ISupportInitialize)nupBudget).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblDescription;
        private Label lblTitle;
        private Label lblBudget;
        private TextBox tboxDescription;
        private TextBox tboxTitle;
        private Button btnSubmit;
        private NumericUpDown nupBudget;
        private Button btnCancel;
    }
}