//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Task_Management_System
//{
//    public partial class ViewTaskForm : Form
//    {
//        public ViewTaskForm()
//        {
//            InitializeComponent();
//        }

//        private void ViewTaskForm_Load(object sender, EventArgs e)
//        {

//        }
//    }
//}


using System;
using System.Windows.Forms;
using Task_Management_System.Models;

namespace Task_Management_System
{
    public partial class ViewTaskForm : Form
    {
        private readonly TaskManagementContext context = new TaskManagementContext();
        private readonly User loggedInUser;
        private readonly ManageTasks manageTasksForm;
        private TaskItem task;

        public ViewTaskForm(int taskId, User user, ManageTasks manageTasksForm)
        {
            InitializeComponent();
            loggedInUser = user;
            this.manageTasksForm = manageTasksForm;

            task = context.TaskItems
                          .Where(t => t.Id == taskId && t.UserId == loggedInUser.Id)
                          .FirstOrDefault();

            if (task == null)
            {
                MessageBox.Show("Task not found.");
                this.Close();
            }
        }

        private void ViewTaskForm_Load(object sender, EventArgs e)
        {
            if (task != null)
            {
                lblTitle.Text = $"Title: {task.Title}";
                lblDescription.Text = $"Description: {task.Description}";
                lblDueDate.Text = $"Due Date: {task.DueDate.ToShortDateString()}";
                lblPriority.Text = $"Priority: {task.Priority}";
                lblStatus.Text = $"Status: {task.Status}";
                lblCategory.Text = $"Category: {task.Category?.Name ?? "N/A"}";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

