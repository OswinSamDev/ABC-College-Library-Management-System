using System;
using System.Windows.Forms;

namespace ABCCollegeLibrary
{
    public partial class BorrowReturnForm : Form
    {
        public BorrowReturnForm()
        {
            InitializeComponent();
        }

        private void BtnBorrow_Click(object sender, EventArgs e)
        {
            string memberName = txtMemberName.Text.Trim();
            string bookTitle = txtBookTitle.Text.Trim();
            string borrowDate = dtpBorrowDate.Value.ToShortDateString();
            string returnDate = dtpReturnDate.Value.ToShortDateString();

            if (string.IsNullOrEmpty(memberName) || string.IsNullOrEmpty(bookTitle))
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string entry = $"Member: {memberName}, Book: {bookTitle}, Borrow: {borrowDate}, Return: {returnDate}";
            lstBorrowedBooks.Items.Add(entry);

            // Clear fields
            txtMemberName.Clear();
            txtBookTitle.Clear();
            dtpBorrowDate.Value = DateTime.Now;
            dtpReturnDate.Value = DateTime.Now.AddDays(14); // Default 2 weeks
        }
    }
}
