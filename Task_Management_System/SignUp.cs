using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Management_System.Models;

namespace Task_Management_System
{
    public partial class SignUp : Form
    {

        private LoginForm loginForm;

        TaskManagementContext context = new TaskManagementContext();
        public SignUp(LoginForm form)
        {
            InitializeComponent();
            loginForm = form;
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            string name = sginupnametxt.Text.Trim();
            string email = signupemailtxt.Text.Trim();

            if (!new EmailAddressAttribute().IsValid(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email)) // Check  if User enter the name & email or not
            {
                MessageBox.Show("Please Enter Both You UserName and Email");
                return;
            }
            // check if the user already registerd in the system
            var existexistingUser = context.Users.FirstOrDefault(U => U.Email == email);

            if (existexistingUser != null)
            {
                MessageBox.Show("This email is already registered. Please login.");
                return;
            }
            var newUser = new User
            {
                Name = name,
                Email = email

            };
            context.Users.Add(newUser);
            context.SaveChanges();

            MessageBox.Show("Registration Done Successfully!, You can now login.");
            this.Close();
            loginForm.Show();

        }
    }
}


