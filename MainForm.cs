using System;
using System.Windows.Forms;

namespace ABCCollegeLibrary
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Optional: Form Load actions if needed
        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            ManageBooksForm manageBooksForm = new ManageBooksForm();
            manageBooksForm.ShowDialog();
        }

        private void btnManageMembers_Click(object sender, EventArgs e)
        {
            ManageMembersForm manageMembersForm = new ManageMembersForm();
            manageMembersForm.ShowDialog();
        }

        private void btnBorrowReturnBooks_Click(object sender, EventArgs e)
        {
            BorrowReturnForm borrowReturnForm = new BorrowReturnForm();
            borrowReturnForm.ShowDialog();
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            ReservationsForm reservationsForm = new ReservationsForm();
            reservationsForm.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.ShowDialog();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagementForm = new UserManagementForm();
            userManagementForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
