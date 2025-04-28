namespace ABCCollegeLibrary
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstReports;

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
            this.lstReports = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstReports
            // 
            this.lstReports.FormattingEnabled = true;
            this.lstReports.ItemHeight = 15;
            this.lstReports.Location = new System.Drawing.Point(20, 20);
            this.lstReports.Name = "lstReports";
            this.lstReports.Size = new System.Drawing.Size(400, 200);
            this.lstReports.TabIndex = 0;
            // 
            // ReportsForm
            // 
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.lstReports);
            this.Name = "ReportsForm";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.ResumeLayout(false);
        }
    }
}
