using System;
using System.Windows.Forms;

namespace ABCCollegeLibrary
{
    public partial class ManageMembersForm : Form
    {
        public ManageMembersForm()
        {
            InitializeComponent();
        }

        private void ManageMembersForm_Load(object sender, EventArgs e)
        {
            // Preload with some dummy member data
            dgvMembers.Rows.Add("M001", "John Doe", "john@example.com", "0771234567");
            dgvMembers.Rows.Add("M002", "Jane Smith", "jane@example.com", "0787654321");
            dgvMembers.Rows.Add("M003", "Alan Walker", "alan@example.com", "0763456789");
        }
    }
}
