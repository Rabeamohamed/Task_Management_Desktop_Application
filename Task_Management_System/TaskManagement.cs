using Microsoft.EntityFrameworkCore;
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
    public partial class TaskManagement : Form
    {
        private TaskManagementContext context = new TaskManagementContext();
        private User loggedInUser;

        public TaskManagement(User user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void TaskManagement_Load(object sender, EventArgs e)
        {
            LoadTasks();
            LoadCategories();
            LoadPriorities();
            LoadStatus();
            LoadSortOptions();
        }

        public void LoadTasks()
        {
            var tasks = context.TaskItems
                .Include(t => t.Category)
                .Where(t => t.UserId == loggedInUser.Id)
                .Select(t => new
                {
                    //t.Id,
                    t.Title,
                    t.Description,
                    t.DueDate,
                    t.Priority,
                    t.Status,
                    Category = t.Category.Name
                })
                .ToList();
            if (gridTasks.Columns["Id"] != null)
                gridTasks.Columns["Id"].Visible = false;

            gridTasks.DataSource = tasks;


        }
        private void LoadCategories()
        {
            comboBox2.DataSource = context.Categories.ToList();
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";
            comboBox2.SelectedIndex = -1;
        }

        private void LoadSortOptions()
        {
            comboSort.Items.Add("Newest");
            comboSort.Items.Add("Oldest");
            comboSort.SelectedIndex = -1; // Set default selection
        }
        private void LoadPriorities()
        {
            comboBox1.DataSource = Enum.GetValues(typeof(PriorityLevel));
            comboBox1.SelectedIndex = -1;
        }

        private void LoadStatus()
        {
            cbStatus.DataSource = Enum.GetValues(typeof(TaskStatus));
            cbStatus.SelectedIndex = -1;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AddTaskForm addForm = new AddTaskForm(loggedInUser, this);
            addForm.ShowDialog();
        }

        private void updateTaskbtn_Click(object sender, EventArgs e)
        {
            if (gridTasks.CurrentRow == null)
            {
                MessageBox.Show("Please select a task first!");
                return;
            }

            int taskId = (int)gridTasks.CurrentRow.Cells["Id"].Value;
            UpdateTaskForm updateForm = new UpdateTaskForm(taskId, this);
            updateForm.ShowDialog();
        }

        private void deleteTaskbtn_Click(object sender, EventArgs e)
        {
            if (gridTasks.CurrentRow == null)
            {
                MessageBox.Show("Please select a task to delete.", "Information",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int taskId = (int)gridTasks.CurrentRow.Cells["Id"].Value;

            string taskTitle = gridTasks.CurrentRow.Cells["Title"].Value.ToString();

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete the task: '{taskTitle}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result != DialogResult.Yes)
                return;

            var task = context.TaskItems.Find(taskId);

            if (task != null)
            {
                try
                {
                    context.TaskItems.Remove(task);
                    context.SaveChanges();
                    MessageBox.Show("Task deleted successfully!", "Success",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTasks();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting task: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Task not found!", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void fiterbtn_Click(object sender, EventArgs e)
        {
            var query = context.TaskItems
        .Include(t => t.Category)
        .Where(t => t.UserId == loggedInUser.Id);

            // Filter by Status
            if (cbStatus.SelectedIndex != -1)
            {
                var status = (TaskStatus)cbStatus.SelectedItem;
                query = query.Where(t => t.Status == status);
            }

            // Filter by Priority
            if (comboBox1.SelectedIndex != -1)
            {
                var priority = (PriorityLevel)comboBox1.SelectedItem;
                query = query.Where(t => t.Priority == priority);
            }

            // Filter by Category
            if (comboBox2.SelectedIndex != -1)
            {
                int categoryId = (int)comboBox2.SelectedValue;
                query = query.Where(t => t.CategoryId == categoryId);
            }

            gridTasks.DataSource = query
                .Select(t => new
                {

                    t.Title,
                    t.Description,
                    t.DueDate,
                    t.Priority,
                    t.Status,
                    Category = t.Category.Name
                })
                .ToList();
        }

        private void ClearFilterbtn_Click(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            LoadTasks();
        }


        private void comboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSort.SelectedItem == null)
                return;

            // Query all tasks for the logged-in user
            var tasks = context.TaskItems
                .Include(t => t.Category)
                .Where(t => t.UserId == loggedInUser.Id);

            string selectedSort = comboSort.SelectedItem.ToString();

            // Apply sorting
            if (selectedSort == "Newest")
                tasks = tasks.OrderByDescending(t => t.DueDate);
            else if (selectedSort == "Oldest")
                tasks = tasks.OrderBy(t => t.DueDate);

            // Bind to DataGridView
            gridTasks.DataSource = tasks.Select(t => new
            {
                t.Id,
                t.Title,
                t.Description,
                t.DueDate,
                t.Priority,
                t.Status,
                Category = t.Category.Name
            }).ToList();

            // Hide ID column
            if (gridTasks.Columns.Contains("Id"))
                gridTasks.Columns["Id"].Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            var tasks = context.TaskItems
                .Include(t => t.Category)
                .Where(t => t.UserId == loggedInUser.Id &&
                       (t.Title.ToLower().Contains(keyword) ||
                        t.Description.ToLower().Contains(keyword)))
                .Select(t => new
                {

                    t.Title,
                    t.Description,
                    t.DueDate,
                    t.Priority,
                    t.Status,
                    Category = t.Category.Name
                })
                .ToList();

            gridTasks.DataSource = tasks;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            var completedTasks = context.TaskItems
                .Where(t => t.UserId == loggedInUser.Id && t.Status == Models.TaskStatus.Completed && t.CompletedDate != null)
                .ToList();

            if (completedTasks.Any())
            {
                var avg = completedTasks.Average(t => (t.CompletedDate.Value - t.CreatedDate).TotalHours);
                MessageBox.Show($"Average Completion Time: {avg:F2} hours");
            }
            else
            {
                MessageBox.Show("No completed tasks to calculate average.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(loggedInUser);
            dashboard.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void flowFilters_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
 }

