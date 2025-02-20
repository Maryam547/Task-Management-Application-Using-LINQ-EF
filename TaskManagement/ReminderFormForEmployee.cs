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
    public partial class ReminderFormForEmployee : Form
    {
        TaskManagementContext context = new TaskManagementContext();
        private int CurrentUserId;
        public ReminderFormForEmployee(int userId)
        {
            InitializeComponent();
            CurrentUserId = userId;
        }
        public void LoadReminders()
        {
            var reminders = context.Reminders
                .Include(r => r.Task)
                .ThenInclude(t => t.User)
                .Where(r => r.Task.UserId == CurrentUserId) 
                .Select(r => new
                {
                    r.TaskId,
                    TaskTitle = r.Task.Title,
                    r.IsRead
                })
                .ToList();

            ReminderGridView.DataSource = reminders;
            ReminderGridView.Refresh();
        }


        private void GenerateAutomaticReminders()
        {
            DateTime tomorrow = DateTime.Now.Date.AddDays(1);

            var tasksDueTomorrow = context.Tasks
                .Where(t => t.UserId == CurrentUserId && t.DueDate.Date == tomorrow)
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

        private void ReminderFormForEmployee_Load(object sender, EventArgs e)
        {
            GenerateAutomaticReminders();
            LoadReminders();

        }

        private void Markbutton_Click(object sender, EventArgs e)
        {
            if (ReminderGridView.SelectedRows.Count > 0)
            {
                int taskId = Convert.ToInt32(ReminderGridView.SelectedRows[0].Cells["TaskId"].Value);

                var reminder = context.Reminders
                    .Include(r => r.Task)
                    .FirstOrDefault(r => r.TaskId == taskId && r.Task.UserId == CurrentUserId); 

                if (reminder != null)
                {
                    reminder.IsRead = true;
                    context.SaveChanges();
                    MessageBox.Show("Reminder marked as read.");
                    LoadReminders();  
                }
                else
                {
                    MessageBox.Show("This reminder does not belong to you.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a reminder.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void ReminderGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (ReminderGridView.Columns[e.ColumnIndex].Name == "IsRead")
            {
                bool isRead = (bool)ReminderGridView.Rows[e.RowIndex].Cells["IsRead"].Value;
                ReminderGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = isRead ? Color.AliceBlue : Color.White;
            }
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            var user = context.Users.FirstOrDefault(u => u.Id == CurrentUserId);
            if (user != null)
            {
                EmployeeDashboard employeeDashboard = new EmployeeDashboard(user);
                employeeDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
