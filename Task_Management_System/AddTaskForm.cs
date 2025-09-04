using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Management_System.Models;
using TaskStatus = Task_Management_System.Models.TaskStatus;

namespace Task_Management_System
{
    public partial class AddTaskForm : Form
    {
        private TaskManagementContext context = new TaskManagementContext();
        private User loggedInUser;
        private TaskManagement manageTasksForm;

        public AddTaskForm(User user, TaskManagement tasksForm)
        {
            InitializeComponent();
            loggedInUser = user;
            manageTasksForm = tasksForm;
        }



        private void savebtn_Click(object sender, EventArgs e)
        {
            string title = titletextBox.Text.Trim();
            string description = descriptiotextBox2.Text.Trim();
            DateTime dueDate = dateTimePicker1.Value;
            var priority = (PriorityLevel)prioritycomboBox.SelectedItem;
            int categoryId = (int)categorycomboBox.SelectedValue;

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            var task = new TaskItem
            {
                Title = title,
                Description = description,
                DueDate = dueDate,
                Priority = priority,
                Status = TaskStatus.Pending,
                UserId = loggedInUser.Id,
                CategoryId = categoryId,
                CreatedDate = DateTime.Now
            };
            context.TaskItems.Add(task);
            context.SaveChanges();

            MessageBox.Show("Task Added Successfully!");

            manageTasksForm.LoadTasks();

            this.Close();
        }



        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AddTaskForm_Load(object sender, EventArgs e)
        {
            prioritycomboBox.DataSource = Enum.GetValues(typeof(PriorityLevel));
            //cmbStatus.DataSource = Enum.GetValues(typeof(TaskStatus));

            categorycomboBox.DataSource = context.Categories.ToList();
            categorycomboBox.DisplayMember = "Name";
            categorycomboBox.ValueMember = "Id";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
