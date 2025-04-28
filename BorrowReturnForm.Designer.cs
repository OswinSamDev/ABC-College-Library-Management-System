namespace ABCCollegeLibrary
{
    partial class BorrowReturnForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblBorrowDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.ListBox lstBorrowedBooks;

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
            this.lblMemberName = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.lstBorrowedBooks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblMemberName
            // 
            this.lblMemberName.Location = new System.Drawing.Point(30, 30);
            this.lblMemberName.Size = new System.Drawing.Size(100, 20);
            this.lblMemberName.Text = "Member Name:";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.Location = new System.Drawing.Point(30, 70);
            this.lblBookTitle.Size = new System.Drawing.Size(100, 20);
            this.lblBookTitle.Text = "Book Title:";
            // 
            // lblBorrowDate
            // 
            this.lblBorrowDate.Location = new System.Drawing.Point(30, 110);
            this.lblBorrowDate.Size = new System.Drawing.Size(100, 20);
            this.lblBorrowDate.Text = "Borrow Date:";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.Location = new System.Drawing.Point(30, 150);
            this.lblReturnDate.Size = new System.Drawing.Size(100, 20);
            this.lblReturnDate.Text = "Return Date:";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(140, 30);
            this.txtMemberName.Size = new System.Drawing.Size(180, 20);
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(140, 70);
            this.txtBookTitle.Size = new System.Drawing.Size(180, 20);
            // 
            // dtpBorrowDate
            // 
            this.dtpBorrowDate.Location = new System.Drawing.Point(140, 110);
            this.dtpBorrowDate.Size = new System.Drawing.Size(180, 20);
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Location = new System.Drawing.Point(140, 150);
            this.dtpReturnDate.Size = new System.Drawing.Size(180, 20);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(140, 190);
            this.btnBorrow.Size = new System.Drawing.Size(100, 30);
            this.btnBorrow.Text = "Borrow Book";
            this.btnBorrow.Click += new System.EventHandler(this.BtnBorrow_Click);
            // 
            // lstBorrowedBooks
            // 
            this.lstBorrowedBooks.Location = new System.Drawing.Point(30, 240);
            this.lstBorrowedBooks.Size = new System.Drawing.Size(400, 150);
            // 
            // BorrowReturnForm
            // 
            this.ClientSize = new System.Drawing.Size(480, 420);
            this.Controls.Add(this.lblMemberName);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.lblBorrowDate);
            this.Controls.Add(this.lblReturnDate);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtBookTitle);
            this.Controls.Add(this.dtpBorrowDate);
            this.Controls.Add(this.dtpReturnDate);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.lstBorrowedBooks);
            this.Name = "BorrowReturnForm";
            this.Text = "Borrow/Return Books";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
