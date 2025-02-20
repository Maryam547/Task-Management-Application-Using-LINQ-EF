using System.Threading.Tasks;
using TaskManagement.Models;

namespace TaskManagement
{
    public partial class LoginForm : Form
    {
        TaskManagementContext context = new TaskManagementContext();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {

            string email = EmailtextBox.Text;
            string password = PasswordtextBox.Text;
            //UserRoles userRoles = new UserRoles();
            var selectedRole = (UserRoles)RolecomboBox.SelectedItem;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email and Password are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = context.Users.FirstOrDefault(u => u.Email == email && u.Password == password && u.Roles == selectedRole);
            if (user != null)
            {
                //MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //switch (user.Roles)
                //{
                //    case UserRoles.Admin:
                //        AdminDashboard adminDashboard = new AdminDashboard(user);
                //        adminDashboard.Show();
                //        break;

                //    case UserRoles.Employee:
                //        EmployeeDashboard userDashboard = new EmployeeDashboard(user);
                //        userDashboard.Show();
                //        break;

                //    case UserRoles.Manager:
                //        TaskForm managerDashboard = new TaskForm(user);
                //        managerDashboard.Show();
                //        break;
                //    default:
                //        MessageBox.Show("Invalid role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        return;
                //}
                DashboardForm dashboardForm=new DashboardForm(user);
                dashboardForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            RolecomboBox.DataSource = Enum.GetValues(typeof(UserRoles));
            PasswordtextBox.PasswordChar = '•';

        }

        private void RegisterFirst_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
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
