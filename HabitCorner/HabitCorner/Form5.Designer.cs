namespace HabitCorner
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btnSaveUsername = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBirthDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your name :";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(39, 33);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(177, 23);
            this.tbUsername.TabIndex = 1;
            // 
            // btnSaveUsername
            // 
            this.btnSaveUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveUsername.BackColor = System.Drawing.Color.Indigo;
            this.btnSaveUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveUsername.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveUsername.Location = new System.Drawing.Point(83, 134);
            this.btnSaveUsername.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveUsername.Name = "btnSaveUsername";
            this.btnSaveUsername.Size = new System.Drawing.Size(96, 34);
            this.btnSaveUsername.TabIndex = 46;
            this.btnSaveUsername.Text = "Save";
            this.btnSaveUsername.UseVisualStyleBackColor = false;
            this.btnSaveUsername.Click += new System.EventHandler(this.btnSaveUsername_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 47;
            this.label2.Text = "Enter your birthday :";
            // 
            // tbBirthDate
            // 
            this.tbBirthDate.Location = new System.Drawing.Point(39, 93);
            this.tbBirthDate.Name = "tbBirthDate";
            this.tbBirthDate.Size = new System.Drawing.Size(177, 23);
            this.tbBirthDate.TabIndex = 48;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 190);
            this.Controls.Add(this.tbBirthDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveUsername);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btnSaveUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBirthDate;
    }
}