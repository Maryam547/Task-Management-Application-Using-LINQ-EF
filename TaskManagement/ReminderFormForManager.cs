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
using Microsoft.VisualBasic.ApplicationServices;
using TaskManagement.Models;

namespace TaskManagement
{
    public partial class ReminderFormForManager : Form
    {
        TaskManagementContext context = new TaskManagementContext();
        private int CurrentUserId;
        public ReminderFormForManager(int userId)
        {
            InitializeComponent();
            CurrentUserId = userId;

        }

        public void LoadReminders()
        {
            var reminders = context.Reminders
                .Include(r => r.Task).ThenInclude(t => t.User)
                .Select(r => new
        {
            r.TaskId,
            TaskTitle = r.Task.Title,
            UserName = r.Task.User.Name, 
            r.IsRead
        })
        .ToList();

            ReminderGridView.DataSource = reminders;
            ReminderGridView.Refresh();
        }
        private void AddAutomaticReminders()
        {
            DateTime tomorrow = DateTime.Now.Date.AddDays(1);

            var tasksDueTomorrow = context.Tasks
                .Where(t => t.DueDate.Date == tomorrow)
                .ToList();

            foreach (var task in tasksDueTomorrow)
            {
                bool reminderExists = context.Reminders.Any(r => r.TaskId == task.Id);
                if (!reminderExists)
                {
                    context.Reminders.Add(new Reminder
                    {
                        TaskId = task.Id,
                        ReminderDate = DateTime.Now,
                        IsRead = false
                    });
                }
            }

            context.SaveChanges();
        }

        private void ReminderForm_Load(object sender, EventArgs e)
        {
            AddAutomaticReminders(); 
            LoadReminders();
        }

        

        private void Backbutton_Click(object sender, EventArgs e)
        {
            var user = context.Users.FirstOrDefault(u => u.Id == CurrentUserId);
            if (user != null)
            {
                ManagerDashboard taskForm = new ManagerDashboard(user);
                taskForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
