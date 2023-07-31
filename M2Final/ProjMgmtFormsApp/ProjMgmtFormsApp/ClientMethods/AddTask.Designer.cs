namespace ProjMgmtFormsApp.ClientMethods
{
    partial class AddTask
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
            tboxDescription = new TextBox();
            btnSubmit = new Button();
            lblDueDate = new Label();
            lblBeginDate = new Label();
            dtpDueDate = new DateTimePicker();
            dtpBeginDate = new DateTimePicker();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(181, 110);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(102, 25);
            lblDescription.TabIndex = 44;
            lblDescription.Text = "Description";
            // 
            // tboxDescription
            // 
            tboxDescription.Location = new Point(289, 107);
            tboxDescription.Multiline = true;
            tboxDescription.Name = "tboxDescription";
            tboxDescription.Size = new Size(218, 79);
            tboxDescription.TabIndex = 41;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(325, 324);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 40;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(197, 254);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(86, 25);
            lblDueDate.TabIndex = 50;
            lblDueDate.Text = "Due Date";
            // 
            // lblBeginDate
            // 
            lblBeginDate.AutoSize = true;
            lblBeginDate.Location = new Point(185, 210);
            lblBeginDate.Name = "lblBeginDate";
            lblBeginDate.Size = new Size(98, 25);
            lblBeginDate.TabIndex = 49;
            lblBeginDate.Text = "Begin Date";
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(289, 252);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(300, 31);
            dtpDueDate.TabIndex = 48;
            // 
            // dtpBeginDate
            // 
            dtpBeginDate.Location = new Point(289, 208);
            dtpBeginDate.Name = "dtpBeginDate";
            dtpBeginDate.Size = new Size(300, 31);
            dtpBeginDate.TabIndex = 47;
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
            // AddTask
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(lblDueDate);
            Controls.Add(lblBeginDate);
            Controls.Add(dtpDueDate);
            Controls.Add(dtpBeginDate);
            Controls.Add(lblDescription);
            Controls.Add(tboxDescription);
            Controls.Add(btnSubmit);
            Name = "AddTask";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddTask";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblDescription;
        private TextBox tboxDescription;
        private Button btnSubmit;
        private Label lblDueDate;
        private Label lblBeginDate;
        private DateTimePicker dtpDueDate;
        private DateTimePicker dtpBeginDate;
        private Button btnCancel;
    }
}