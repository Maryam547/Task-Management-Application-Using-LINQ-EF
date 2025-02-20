using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Models;

namespace TaskManagement
{
    public partial class AdminDashboard : Form
    {
        private TaskManagementContext context = new TaskManagementContext();
        private int selectedUserId;

        //private string placeholderText = "Search here...";
        //private Color placeholderColor = Color.Gray;
        //private Color textColor = Color.Black;


        public AdminDashboard(User currentUser)
        {
            InitializeComponent();
            LoadUsers();

        }
        private void ResetFields()
        {
            NametextBox.Text = "";
            EmailtextBox.Text = "";
            RolecomboBox.SelectedIndex = -1;

            NametextBox.ReadOnly = true;
            EmailtextBox.ReadOnly = true;
            RolecomboBox.Enabled = false;

            Updatebutton.Enabled = false;
            Deletebutton.Enabled = false;

            selectedUserId = 0;
        }
        private void SetPlaceholder()
        {
            //if (string.IsNullOrWhiteSpace(SearchUsertextBox.Text))
            //{
            //    SearchUsertextBox.Text = placeholderText;
            //    SearchUsertextBox.ForeColor = placeholderColor;
            //}
        }
        private void LoadUsers()
        {
            var users = context.Users.Select(u => new
            {
                u.Id,
                u.Name,
                u.Email,
                u.Password,
                u.Roles,
            }).ToList();

            //UserdataGridView.Columns["Id"].Visible = false;

            UserdataGridView.DataSource = users;
            UserdataGridView.Refresh();

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            RolecomboBox.DataSource = Enum.GetValues(typeof(UserRoles));

            Updatebutton.Enabled = false;
            Deletebutton.Enabled = false;

            NametextBox.ReadOnly = true;
            EmailtextBox.ReadOnly = true;
            RolecomboBox.Enabled = false;

            SetPlaceholder();
        }

        private void UserdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedUserId = Convert.ToInt32(UserdataGridView.Rows[e.RowIndex].Cells["Id"].Value);
                var user = context.Users.Find(selectedUserId);
                if (user != null)
                {
                    NametextBox.Text = user.Name;
                    EmailtextBox.Text = user.Email;
                    RolecomboBox.SelectedItem = user.Roles;

                    NametextBox.ReadOnly = false;
                    EmailtextBox.ReadOnly = false;
                    RolecomboBox.Enabled = true;

                    Updatebutton.Enabled = true;
                    Deletebutton.Enabled = true;
                }
            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            var user = context.Users.Find(selectedUserId);
            if (user != null)
            {
                user.Name = NametextBox.Text;
                user.Email = EmailtextBox.Text;
                user.Roles = (UserRoles)Enum.Parse(typeof(UserRoles), RolecomboBox.SelectedItem.ToString());
                context.SaveChanges();
                MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
                ResetFields();
            }
            else
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            var user = context.Users.Find(selectedUserId);
            if (user != null)
            {
                var confirm = MessageBox.Show("Are you sure to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    var tasksToDelete = context.Tasks.Where(t => t.UserId == selectedUserId);
                    context.Tasks.RemoveRange(tasksToDelete);

                    context.Users.Remove(user);
                    context.SaveChanges();
                    MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                    ResetFields();
                }
            }
            else
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchUsertextBox_TextChanged(object sender, EventArgs e)
        {
            string query = SearchUsertextBox.Text.Trim().ToLower().Replace(" ", "");
            var filteredUsers = context.Users
                .Where(u => u.Name.Replace(" ", "").ToLower().StartsWith(query))
                .Select(u => new { u.Id, u.Name, u.Email, u.Roles })
                .ToList();
            UserdataGridView.DataSource = filteredUsers;
        }



        private void UserdataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (UserdataGridView.Columns[e.ColumnIndex].Name == "Password")
            {
                e.Value = "••••••••";
                e.FormattingApplied = true;
            }
        }

        private void SearchUsertextBox_Enter(object sender, EventArgs e)
        {
            //if (SearchUsertextBox.Text == placeholderText)
            //{
            //    SearchUsertextBox.Text = "";
            //    SearchUsertextBox.ForeColor = textColor;
            //}
        }

        private void SearchUsertextBox_Leave(object sender, EventArgs e)
        {

        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
