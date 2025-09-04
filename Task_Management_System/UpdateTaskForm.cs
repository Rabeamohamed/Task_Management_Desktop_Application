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


namespace Task_Management_System
{
    public partial class UpdateTaskForm : Form
    {


        private TaskManagementContext context = new TaskManagementContext();
        private ManageTasks manageTasksForm;
        private TaskItem currentTask;

        public UpdateTaskForm(int taskId, ManageTasks tasksForm)
        {
            InitializeComponent();
            manageTasksForm = tasksForm;
            currentTask = context.TaskItems.Find(taskId);
        }
        private void UpdateTaskForm_Load(object sender, EventArgs e)
        {

            prioritycomboBox.DataSource = Enum.GetValues(typeof(PriorityLevel));
            statuscomboBox.DataSource = Enum.GetValues(typeof(Models.TaskStatus));

            categorycomboBox.DataSource = context.Categories.ToList();
            categorycomboBox.DisplayMember = "Name";
            categorycomboBox.ValueMember = "Id";

            if (currentTask != null)
            {
                titletextBox.Text = currentTask.Title;
                descriptiotextBox2.Text = currentTask.Description;
                dateTimePicker1.Value = currentTask.DueDate;
                prioritycomboBox.SelectedItem = currentTask.Priority;
                statuscomboBox.SelectedItem = currentTask.Status;
                categorycomboBox.SelectedValue = currentTask.CategoryId;
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (currentTask != null)
            {
                currentTask.Title = titletextBox.Text.Trim();
                currentTask.Description = descriptiotextBox2.Text.Trim();
                currentTask.DueDate = dateTimePicker1.Value;
                currentTask.Priority = (PriorityLevel)prioritycomboBox.SelectedItem;
                currentTask.Status = (Models.TaskStatus)statuscomboBox.SelectedItem;
                currentTask.CategoryId = (int)categorycomboBox.SelectedValue;

                if (currentTask.Status == Models.TaskStatus.Completed)
                    currentTask.CompletedDate = DateTime.Now;

                context.SaveChanges();
                MessageBox.Show("Task updated successfully!");
                manageTasksForm.LoadTasks();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
