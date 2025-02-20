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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TaskStatus = TaskManagement.Models.TaskStatus;
using TaskUser = TaskManagement.Models.User;

namespace TaskManagement
{
    public partial class ManagerDashboard : Form
    {
        private TaskManagementContext context = new TaskManagementContext();
        private User CurrentUser;
        private int TaskId;



        public ManagerDashboard(User currentUser)
        {
            InitializeComponent();
            CurrentUser = currentUser;
            SetupForm();


        }
        private void SetupForm()
        {
            LoadTasks();
            LoadComboBoxes();
            ClearFields();

            Updatebutton.Enabled = false;
            Deletebutton.Enabled = false;
            CreatedAtdateTimePicker.Enabled = false;
        }
        private void CleanupReminders()
        {
            var expiredReminders = context.Reminders
                .Where(r => r.Task.DueDate < DateTime.Now)
                .ToList();

            if (expiredReminders.Any())
            {
                context.Reminders.RemoveRange(expiredReminders);
                context.SaveChanges();
            }
        }

        private void LoadTasks()
        {
            CleanupReminders();

            var tasks = context.Tasks.Select(t => new
            {
                t.Id,
                t.Title,
                t.Description,
                t.DueDate,
                t.TaskStatus,
                t.CreatedAt,
                AssignedUser = t.User.Name,
                t.Priority,
                t.Complexity,
                Category = t.Category.Name
            }).ToList();
            TaskdataGridView.DataSource = tasks;
        }


        private void LoadComboBoxes()
        {
            AssignedUsercomboBox.DataSource = context.Users
                .Where(u => u.Roles == UserRoles.Employee)
                .ToList();
            AssignedUsercomboBox.DisplayMember = "Name";
            AssignedUsercomboBox.ValueMember = "Id";

            StatuscomboBox.DataSource = Enum.GetValues(typeof(TaskStatus));
            PrioritycomboBox.DataSource = Enum.GetValues(typeof(Priority));
            ComplexitycomboBox.DataSource = Enum.GetValues(typeof(Complexity));

            CategorycomboBox.DataSource = context.Categories.ToList();
            CategorycomboBox.DisplayMember = "Name";
            CategorycomboBox.ValueMember = "Id";
        }

        private void ClearFields()
        {
            TitletextBox.Clear();
            DescriptionrichTextBox.Clear();
            DuedateTimePicker.Value = DateTime.Now;
            CreatedAtdateTimePicker.Value = DateTime.Now;
            StatuscomboBox.SelectedIndex = -1;
            AssignedUsercomboBox.SelectedIndex = -1;
            PrioritycomboBox.SelectedIndex = -1;
            ComplexitycomboBox.SelectedIndex = -1;
            CategorycomboBox.SelectedIndex = -1;
            RemindercheckBox.Checked = false;
            TaskId = 0;

            Updatebutton.Enabled = false;
            Deletebutton.Enabled = false;
        }


        private void Updatebutton_Click(object sender, EventArgs e)
        {
            var task = context.Tasks.Find(TaskId);
            if (task != null)
            {
                task.Title = TitletextBox.Text;
                task.Description = DescriptionrichTextBox.Text;
                task.DueDate = DuedateTimePicker.Value;
                //task.CreatedAt = CreatedAtdateTimePicker.Value;
                task.TaskStatus = (TaskStatus)StatuscomboBox.SelectedItem;
                task.UserId = ((User)AssignedUsercomboBox.SelectedItem).Id;
                task.Priority = (Priority)PrioritycomboBox.SelectedItem;
                task.Complexity = (Complexity)ComplexitycomboBox.SelectedItem;
                task.CategoryId = ((Category)CategorycomboBox.SelectedItem).Id;

                context.SaveChanges();
                MessageBox.Show("Task updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTasks();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Task not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            var task = context.Tasks.Find(TaskId);
            if (task != null)
            {
                var confirm = MessageBox.Show("Are you sure to delete this task?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    context.Tasks.Remove(task);
                    context.SaveChanges();
                    MessageBox.Show("Task deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTasks();
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Task not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TitletextBox.Text))
            {
                MessageBox.Show("Task Title is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TaskManagement.Models.Task task = new TaskManagement.Models.Task
            {
                Title = TitletextBox.Text,
                Description = DescriptionrichTextBox.Text,
                DueDate = DuedateTimePicker.Value,
                CreatedAt = DateTime.Now,
                TaskStatus = (TaskStatus)StatuscomboBox.SelectedItem,
                UserId = ((User)AssignedUsercomboBox.SelectedItem).Id,
                Priority = (Priority)PrioritycomboBox.SelectedItem,
                Complexity = (Complexity)ComplexitycomboBox.SelectedItem,
                CategoryId = ((Category)CategorycomboBox.SelectedItem).Id
            };

            context.Tasks.Add(task);
            context.SaveChanges();
            MessageBox.Show("Task saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadTasks();
            ClearFields();

        }

        private void OpenRemindersbutton_Click(object sender, EventArgs e)
        {
            ReminderFormForManager reminderFormForManager = new ReminderFormForManager(CurrentUser.Id);
            reminderFormForManager.Show();
            this.Hide();
        }



        private void TaskdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TaskId = Convert.ToInt32(TaskdataGridView.Rows[e.RowIndex].Cells["Id"].Value);
                var task = context.Tasks.Find(TaskId);
                if (task != null)
                {
                    TitletextBox.Text = task.Title;
                    DescriptionrichTextBox.Text = task.Description;
                    DuedateTimePicker.Value = task.DueDate;
                    CreatedAtdateTimePicker.Value = task.CreatedAt;
                    StatuscomboBox.SelectedItem = task.TaskStatus;
                    if (AssignedUsercomboBox.Items.Cast<User>().Any(u => u.Id == task.UserId))
                    {
                        AssignedUsercomboBox.SelectedValue = task.UserId;
                    }
                    else
                    {
                        AssignedUsercomboBox.SelectedIndex = -1;
                    }
                    PrioritycomboBox.SelectedItem = task.Priority;
                    ComplexitycomboBox.SelectedItem = task.Complexity;
                    CategorycomboBox.SelectedValue = task.CategoryId;
                    RemindercheckBox.Checked = context.Reminders.Any(r => r.TaskId == TaskId);

                    Updatebutton.Enabled = true;
                    Deletebutton.Enabled = true;

                    RemindercheckBox.Checked = context.Reminders.Any(r => r.TaskId == TaskId);

                }
            }
        }

        private void RemindercheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TaskId == 0)
            {
                MessageBox.Show("Please select a task first.");
                RemindercheckBox.Checked = false;
                return;
            }

            var task = context.Tasks.Find(TaskId);
            var reminder = context.Reminders.FirstOrDefault(r => r.TaskId == TaskId);

            if (CurrentUser.Roles == UserRoles.Employee)
            {
                RemindercheckBox.Checked = reminder != null;
                MessageBox.Show("Only managers can set reminders.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (task != null && task.DueDate < DateTime.Now)
            {
                if (reminder != null)
                {
                    context.Reminders.Remove(reminder);
                    context.SaveChanges();
                    MessageBox.Show("Reminder removed because task due date has passed!");
                    RemindercheckBox.Checked = false;
                }
                return;
            }

            if (RemindercheckBox.Checked)
            {
                if (reminder == null)
                {
                    context.Reminders.Add(new Reminder { ReminderDate = DateTime.Now.AddDays(1), TaskId = TaskId });
                    context.SaveChanges();
                    MessageBox.Show("Reminder added successfully!");
                }

            }
            else
            {
                if (reminder != null)
                {
                    context.Reminders.Remove(reminder);
                    context.SaveChanges();
                    MessageBox.Show("Reminder removed successfully!");
                }
            }

        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
