using System;
using System.Windows.Forms;

namespace ABCCollegeLibrary
{
    public partial class ManageBooksForm : Form
    {
        public ManageBooksForm()
        {
            InitializeComponent();
        }

        private void ManageBooksForm_Load(object sender, EventArgs e)
        {
            // Set up DataGridView Columns
            dgvBooks.Columns.Add("BookID", "Book ID");
            dgvBooks.Columns.Add("Title", "Title");
            dgvBooks.Columns.Add("Author", "Author");
            dgvBooks.Columns.Add("Category", "Category");
            dgvBooks.Columns.Add("Year", "Year");

            // Dummy rows
            dgvBooks.Rows.Add("B001", "C# Programming", "John Doe", "Programming", "2020");
            dgvBooks.Rows.Add("B002", "Database Basics", "Jane Smith", "Database", "2019");
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Book clicked!");
        }

        private void BtnEditBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                MessageBox.Show("Edit Book: " + dgvBooks.SelectedRows[0].Cells["Title"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Please select a book to edit!");
            }
        }

        private void BtnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this book?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    dgvBooks.Rows.RemoveAt(dgvBooks.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Please select a book to delete!");
            }
        }
    }
}