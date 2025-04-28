using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ABCCollegeLibrary
{
    public partial class UserManagementForm : Form
    {
        private readonly List<User> users = new List<User>();

        public UserManagementForm()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void LoadUserData()
        {
            // Sample users for testing
            users.Add(new User("admin", "admin123", "Admin"));
            users.Add(new User("librarian", "lib123", "Librarian"));
            users.Add(new User("member", "member123", "Member"));

            // Refresh the DataGridView
            UpdateUserGrid();
        }

        private void UpdateUserGrid()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = users;
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            // Create a new user and add it to the list
            User newUser = new User(username, password, role);
            users.Add(newUser);

            // Refresh the grid
            UpdateUserGrid();

            // Clear the input fields
            txtUsername.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = -1;
        }

        private void BtnUpdateUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            // Find the user in the list
            User userToUpdate = users.FirstOrDefault(u => u.Username == username);
            if (userToUpdate != null)
            {
                userToUpdate.Password = password;
                userToUpdate.Role = role;

                // Refresh the grid
                UpdateUserGrid();
            }
            else
            {
                MessageBox.Show("User not found.");
            }
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            // Find and remove the user from the list
            User userToDelete = users.FirstOrDefault(u => u.Username == username);
            if (userToDelete != null)
            {
                users.Remove(userToDelete);

                // Refresh the grid
                UpdateUserGrid();

                // Clear input fields
                txtUsername.Clear();
                txtPassword.Clear();
                cmbRole.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("User not found.");
            }
        }

        private void BgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // When a row is selected, fill the textboxes with user data
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
                cmbRole.SelectedItem = row.Cells["Role"].Value.ToString();
            }
        }
    }
}
