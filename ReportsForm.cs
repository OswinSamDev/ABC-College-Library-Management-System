using System;
using System.Windows.Forms;

namespace ABCCollegeLibrary
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            // Preload sample reports
            lstReports.Items.Add("Total Books in Library: 1200");
            lstReports.Items.Add("Books Borrowed This Month: 150");
            lstReports.Items.Add("Active Members: 300");
            lstReports.Items.Add("Overdue Books: 15");
        }
    }
}
