using System;
using System.Windows.Forms;

namespace ABCCollegeLibrary
{
    public partial class ReservationsForm : Form
    {
        public ReservationsForm()
        {
            InitializeComponent();
        }

        private void ReservationsForm_Load(object sender, EventArgs e)
        {
            // Preload some sample reservation data
            dgvReservations.Rows.Add("R001", "M001", "The Great Gatsby", "2025-05-01");
            dgvReservations.Rows.Add("R002", "M002", "To Kill a Mockingbird", "2025-05-02");
        }

        private void DgvReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
