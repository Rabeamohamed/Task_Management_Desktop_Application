using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel.DataAnnotations;
using Task_Management_System.Models;

namespace Task_Management_System
{
    public partial class LoginForm : Form
    {
        TaskManagementContext context = new TaskManagementContext();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string name = logintextBox1.Text.Trim();
            string email = logintextBox2.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email)) // Check  if User enter the name & email or not
            {
                MessageBox.Show("Please Enter Both You UserName and Email");
                return;
            }

            if (!new EmailAddressAttribute().IsValid(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            var User = context.Users.FirstOrDefault(U => U.Email == email && U.Name == name);

            if (User == null)
            {
                MessageBox.Show("Invalid Name or Email. Please Try Again or sign up.");
                return;
            }
            MessageBox.Show($"Welcomback {User.Name}");

            Dashboard dashboard = new Dashboard(User);
            dashboard.Show();
            this.Hide();

        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp(this);
            signUp.Show();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}



