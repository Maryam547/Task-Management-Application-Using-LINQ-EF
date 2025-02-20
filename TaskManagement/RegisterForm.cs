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

namespace TaskManagement
{
    public partial class RegisterForm : Form
    {
        TaskManagementContext context = new TaskManagementContext();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Registerbutton_Click(object sender, EventArgs e)
        {
            var userName = UserNametextBox.Text;
            var email = EmailtextBox.Text;
            var password = PasswordtextBox.Text;

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!email.Contains("@"))
            {
                MessageBox.Show("Invalid email address. It must contain '@'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (RolecomboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selectedRole = (UserRoles)RolecomboBox.SelectedItem;

            var user = context.Users.FirstOrDefault(u => u.Name == userName || u.Email == email);
            if (user != null)
            {
                MessageBox.Show("User already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);


            var newUser = new User { Name = userName, Email = email, Password = password, Roles = selectedRole };

            context.Users.Add(newUser);
            context.SaveChanges();
            MessageBox.Show("Registration Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            RolecomboBox.DataSource = Enum.GetValues(typeof(UserRoles));
            PasswordtextBox.PasswordChar = '•';
        }

        private void LoginFirst_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                PasswordtextBox.PasswordChar = '\0'; 
            }
            else
            {
                PasswordtextBox.PasswordChar = '•'; 
            }
        }
    }
}
