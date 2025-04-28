using System;
using System.Windows.Forms;

namespace ABCCollegeLibrary
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnManageBooks = new System.Windows.Forms.Button();
            this.btnManageMembers = new System.Windows.Forms.Button();
            this.btnBorrowReturnBooks = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageBooks
            // 
            this.btnManageBooks.Location = new System.Drawing.Point(50, 30);
            this.btnManageBooks.Name = "btnManageBooks";
            this.btnManageBooks.Size = new System.Drawing.Size(200, 50);
            this.btnManageBooks.TabIndex = 0;
            this.btnManageBooks.Text = "Manage Books";
            this.btnManageBooks.UseVisualStyleBackColor = true;
            this.btnManageBooks.Click += new System.EventHandler(this.btnManageBooks_Click);
            // 
            // btnManageMembers
            // 
            this.btnManageMembers.Location = new System.Drawing.Point(50, 100);
            this.btnManageMembers.Name = "btnManageMembers";
            this.btnManageMembers.Size = new System.Drawing.Size(200, 50);
            this.btnManageMembers.TabIndex = 1;
            this.btnManageMembers.Text = "Manage Members";
            this.btnManageMembers.UseVisualStyleBackColor = true;
            this.btnManageMembers.Click += new System.EventHandler(this.btnManageMembers_Click);
            // 
            // btnBorrowReturnBooks
            // 
            this.btnBorrowReturnBooks.Location = new System.Drawing.Point(50, 170);
            this.btnBorrowReturnBooks.Name = "btnBorrowReturnBooks";
            this.btnBorrowReturnBooks.Size = new System.Drawing.Size(200, 50);
            this.btnBorrowReturnBooks.TabIndex = 2;
            this.btnBorrowReturnBooks.Text = "Borrow/Return Books";
            this.btnBorrowReturnBooks.UseVisualStyleBackColor = true;
            this.btnBorrowReturnBooks.Click += new System.EventHandler(this.btnBorrowReturnBooks_Click);
            // 
            // btnReservations
            // 
            this.btnReservations.Location = new System.Drawing.Point(50, 240);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(200, 50);
            this.btnReservations.TabIndex = 3;
            this.btnReservations.Text = "Reservations";
            this.btnReservations.UseVisualStyleBackColor = true;
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(50, 310);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(200, 50);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Location = new System.Drawing.Point(50, 380);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(200, 50);
            this.btnUserManagement.TabIndex = 5;
            this.btnUserManagement.Text = "Manage Users";
            this.btnUserManagement.UseVisualStyleBackColor = true;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(50, 450);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 50);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 550);
            this.Controls.Add(this.btnManageBooks);
            this.Controls.Add(this.btnManageMembers);
            this.Controls.Add(this.btnBorrowReturnBooks);
            this.Controls.Add(this.btnReservations);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnUserManagement);
            this.Controls.Add(this.btnLogout);
            this.Name = "MainForm";
            this.Text = "ABC College Library Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnManageBooks;
        private Button btnManageMembers;
        private Button btnBorrowReturnBooks;
        private Button btnReservations;
        private Button btnReports;
        private Button btnLogout;
        private Button btnUserManagement;
    }
}
