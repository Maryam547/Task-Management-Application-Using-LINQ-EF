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
    public partial class EmployeeDashboard : Form
    {
        TaskManagementContext context = new TaskManagementContext();

        private User CurrentUser;

        public EmployeeDashboard(User user)
        {
            InitializeComponent();
            CurrentUser = user;
        }
        private void LoadTasks()
        {
            var tasks = context.Tasks
                .Where(t => t.UserId == CurrentUser.Id)
                .Select(t => new
                {

                    t.Title,
                    t.Description,
                    t.CreatedAt,
                    t.DueDate,
                    t.Complexity,
                    t.Priority,
                    t.TaskStatus,

                })
                .ToList();

            TasksdataGridView.DataSource = tasks;
            TasksdataGridView.Refresh();
        }

        private void EmployeeDashboard_Load(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void Reminderbutton_Click(object sender, EventArgs e)
        {
            ReminderFormForEmployee reminderFormForEmployee = new ReminderFormForEmployee(CurrentUser.Id);
            reminderFormForEmployee.Show();
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
