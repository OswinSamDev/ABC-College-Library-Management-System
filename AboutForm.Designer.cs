namespace ABCCollegeLibrary
{
    partial class AboutForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblAbout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblAbout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAbout.Location = new System.Drawing.Point(30, 30);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(326, 46);
            this.lblAbout.TabIndex = 0;
            this.lblAbout.Text = "ABC College Library Management System\nVersion 1.0 - Developed in 2025";
            // 
            // AboutForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.lblAbout);
            this.Name = "AboutForm";
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
