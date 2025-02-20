using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.Models;

namespace TaskManagement
{
    public partial class DashboardForm : Form
    {
        private User CurrentUser;
        public DashboardForm(User currentUser)
        {
            InitializeComponent();
            CurrentUser = currentUser;
            SetupDashboard();
        }
        private void SetupDashboard()
        {
            Welcomelabel.Text = $"Welcome, {CurrentUser.Name} ";

            if (CurrentUser.Roles == UserRoles.Admin)
            {
                ManageUserbutton.Enabled = true;
                ManageTasksbutton.Enabled = false;
                ViewTasksbutton.Enabled = false;
            }
            else if (CurrentUser.Roles == UserRoles.Manager)
            {
                ManageUserbutton.Enabled = false;
                ManageTasksbutton.Enabled = true;
                ViewTasksbutton.Enabled = false;
            }
            else if (CurrentUser.Roles == UserRoles.Employee)
            {
                ManageUserbutton.Enabled = false;
                ManageTasksbutton.Enabled = false;
                ViewTasksbutton.Enabled = true;
            }
        }
        private void ManageUserbutton_Click(object sender, EventArgs e)
        {
            AdminDashboard userManagementForm = new AdminDashboard(CurrentUser);
            userManagementForm.Show();
            this.Hide();
        }

        private void ManageTasksbutton_Click(object sender, EventArgs e)
        {
            ManagerDashboard managerDashboard = new ManagerDashboard(CurrentUser);
            managerDashboard.Show();
            this.Hide();
        }

        private void ViewTasksbutton_Click(object sender, EventArgs e)
        {
            EmployeeDashboard employeeTasksForm = new EmployeeDashboard(CurrentUser);
            employeeTasksForm.Show();
            this.Hide();
        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
