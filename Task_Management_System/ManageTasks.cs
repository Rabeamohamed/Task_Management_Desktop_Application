//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Drawing.Printing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using Task_Management_System.Models;

//namespace Task_Management_System
//{
//    public partial class ManageTasks : Form
//    {

//        private readonly TaskManagementContext context = new TaskManagementContext();
//        private readonly User loggedInUser;

//        private int currentPage = 1;
//        private int pageSize = 5;
//        private int totalPages = 0;

//        public ManageTasks(User user)
//        {
//            InitializeComponent();
//            loggedInUser = user;
//        }

//        private void ManageTasks_Load(object sender, EventArgs e)
//        {
//            LoadTasks();
//            LoadFilters();
//            StyleGrid();
//        }

//        private void StyleGrid()
//        {
//            dataGridTasks.EnableHeadersVisualStyles = false;
//            dataGridTasks.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;
//            dataGridTasks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
//            dataGridTasks.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
//            dataGridTasks.DefaultCellStyle.Font = new Font("Segoe UI", 9);
//            dataGridTasks.RowTemplate.Height = 28;
//            dataGridTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
//            dataGridTasks.MultiSelect = false;
//            dataGridTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
//        }


//        private void gridTasks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
//        {
//            if (dataGridTasks.Columns[e.ColumnIndex].Name == "Priority" && e.Value != null)
//            {
//                string priority = e.Value.ToString();
//                if (priority == "High")
//                    e.CellStyle.BackColor = Color.Red;
//                else if (priority == "Medium")
//                    e.CellStyle.BackColor = Color.Green;
//                else if (priority == "Low")
//                    e.CellStyle.BackColor = Color.Blue;
//            }

//            if (dataGridTasks.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
//            {
//                string status = e.Value.ToString();
//                if (status == "Completed")
//                    e.CellStyle.BackColor = Color.Green;
//                else if (status == "Pending")
//                    e.CellStyle.BackColor = Color.Brown;
//                else if (status == "InProgress")
//                    e.CellStyle.BackColor = Color.Orange;
//            }
//        }


//        private void LoadTasks()
//        {
//            var tasks = context.TaskItems
//               .Include(t => t.Category)
//               .Where(t => t.UserId == loggedInUser.Id)
//               .Select(t => new
//               {
//                   t.Id,
//                   t.Title,
//                   t.Description,
//                   t.DueDate,
//                   t.Priority,
//                   t.Status,
//                   Category = t.Category != null ? t.Category.Name : "No Category"
//               })
//               .ToList();

//            dataGridTasks.DataSource = tasks;

//            if (dataGridTasks.Columns.Contains("Id"))
//                dataGridTasks.Columns["Id"].Visible = false;

//            lblPending.Text = "Pending: " + tasks.Count(t => t.Status.ToString() == "Pending");
//            lblInProgress.Text = "In Progress: " + tasks.Count(t => t.Status.ToString() == "InProgress");
//            lblCompleted.Text = "Completed: " + tasks.Count(t => t.Status.ToString() == "Completed");


//            var query = context.TaskItems
//               .Include(t => t.Category)
//               .Where(t => t.UserId == loggedInUser.Id);

//            int totalRecords = query.Count();
//            dataGridTasks = (int)Math.Ceiling(totalRecords / (double)pageSize);


//            dataGridTasks.DataSource = tasks;

//            if (dataGridTasks.Columns.Contains("Id"))
//                dataGridTasks.Columns["Id"].Visible = false;

//            lblPageInfo.Text = $"Page {currentPage} of {totalPages}";
//        }

//        private void LoadFilters()
//        {
//            cmbSort.Items.Clear();
//            cmbSort.Items.Add("Newest");
//            cmbSort.Items.Add("Oldest");
//            cmbSort.SelectedIndex = 0;

//            cmbStatusFilter.Items.Clear();
//            cmbStatusFilter.Items.AddRange(Enum.GetNames(typeof(Models.TaskStatus)));
//            cmbStatusFilter.SelectedIndex = -1;

//            cmbPriorityFilter.Items.Clear();
//            cmbPriorityFilter.Items.Add("High");
//            cmbPriorityFilter.Items.Add("Medium");
//            cmbPriorityFilter.Items.Add("Low");
//            cmbPriorityFilter.SelectedIndex = -1;

//            cmbCategoryFilter.DataSource = context.Categories.ToList();
//            cmbCategoryFilter.DisplayMember = "Name";
//            cmbCategoryFilter.ValueMember = "Id";
//            cmbCategoryFilter.SelectedIndex = -1;
//        }

//        private void ApplyFilters()
//        {
//            var query = context.TaskItems.Include(t => t.Category)
//                .Where(t => t.UserId == loggedInUser.Id);

//            if (!string.IsNullOrWhiteSpace(textSearch.Text))
//                query = query.Where(t => t.Title.Contains(textSearch.Text) || t.Description.Contains(textSearch.Text));

//            if (cmbStatusFilter.SelectedIndex != -1)
//                query = query.Where(t => t.Status.ToString() == cmbStatusFilter.SelectedItem.ToString());

//            if (cmbPriorityFilter.SelectedIndex != -1)
//                query = query.Where(t => t.Priority.ToString() == cmbPriorityFilter.SelectedItem.ToString());

//            if (cmbCategoryFilter.SelectedIndex != -1)
//                query = query.Where(t => t.CategoryId == (int)cmbCategoryFilter.SelectedValue);

//            if (cmbSort.SelectedItem?.ToString() == "Newest")
//                query = query.OrderByDescending(t => t.DueDate);
//            else if (cmbSort.SelectedItem?.ToString() == "Oldest")
//                query = query.OrderBy(t => t.DueDate);

//            var tasks = query.Select(t => new
//            {
//                t.Id,
//                t.Title,
//                t.Description,
//                t.DueDate,
//                t.Priority,
//                t.Status,
//                Category = t.Category != null ? t.Category.Name : "No Category"
//            }).ToList();

//            dataGridTasks.DataSource = tasks;

//            if (dataGridTasks.Columns.Contains("Id"))
//                dataGridTasks.Columns["Id"].Visible = false;

//            lblPending.Text = "Pending: " + tasks.Count(t => t.Status.ToString() == "Pending");
//            lblInProgress.Text = "In Progress: " + tasks.Count(t => t.Status.ToString() == "InProgress");
//            lblCompleted.Text = "Completed: " + tasks.Count(t => t.Status.ToString() == "Completed");
//        }

//        private void btnSearch_Click(object sender, EventArgs e) => ApplyFilters();
//        private void btnClearSearch_Click(object sender, EventArgs e) { textSearch.Clear(); ApplyFilters(); }
//        private void btnFilter_Click(object sender, EventArgs e) => ApplyFilters();
//        private void btnClearFilter_Click(object sender, EventArgs e)
//        {
//            cmbStatusFilter.SelectedIndex = -1;
//            cmbPriorityFilter.SelectedIndex = -1;
//            cmbCategoryFilter.SelectedIndex = -1;
//            ApplyFilters();
//        }
//        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();

//        private void btnAddTask_Click(object sender, EventArgs e)
//        {
//            MessageBox.Show("Open AddTaskForm here");
//        }

//        private void btnUpdateTask_Click(object sender, EventArgs e)
//        {
//            if (dataGridTasks.CurrentRow != null)
//                MessageBox.Show("Open UpdateTaskForm for TaskId: " +
//                    dataGridTasks.CurrentRow.Cells["Id"].Value);

//        }

//        private void btnDeleteTask_Click(object sender, EventArgs e)
//        {
//            if (dataGridTasks.CurrentRow != null)
//            {
//                int taskId = (int)dataGridTasks.CurrentRow.Cells["Id"].Value;
//                var task = context.TaskItems.Find(taskId);

//                if (task != null)
//                {
//                    context.TaskItems.Remove(task);
//                    context.SaveChanges();
//                    MessageBox.Show("Task deleted successfully!");
//                    ApplyFilters();
//                }
//            }
//        }

//        private void btnReport_Click(object sender, EventArgs e)
//        {
//            ReportForm reportForm = new ReportForm(loggedInUser);
//            reportForm.ShowDialog();
//            MessageBox.Show("Open ReportForm here");
//        }

//        private void btnPrevPage_Click(object sender, EventArgs e)
//        {
//            if (currentPage > 1)
//            {
//                currentPage--;
//                LoadTasks();
//            }
//        }

//        private void btnNextPage_Click(object sender, EventArgs e)
//        {
//            if (currentPage < totalPages)
//            {
//                currentPage++;
//                LoadTasks();
//            }
//        }

//        private void lblPageInfo_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}




using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Management_System.Models;

namespace Task_Management_System
{
    public partial class ManageTasks : Form
    {
        private readonly TaskManagementContext context = new TaskManagementContext();
        private readonly User loggedInUser;

        private int currentPage = 1;
        private int pageSize = 5;
        private int totalPages = 0;

        private Label lblPending;
        private Label lblInProgress;
        private Label lblCompleted;

        public ManageTasks(User user)
        {
            InitializeComponent();
            loggedInUser = user;

            InitializeStatusLabels();
        }

        private void InitializeStatusLabels()
        {
            lblPending = new Label();
            lblInProgress = new Label();
            lblCompleted = new Label();

            lblPending.Location = new Point(49, 430);
            lblInProgress.Location = new Point(49, 450);
            lblCompleted.Location = new Point(49, 470);

            lblPending.AutoSize = true;
            lblInProgress.AutoSize = true;
            lblCompleted.AutoSize = true;

            this.Controls.Add(lblPending);
            this.Controls.Add(lblInProgress);
            this.Controls.Add(lblCompleted);
        }

        private void ManageTasks_Load(object sender, EventArgs e)
        {
            LoadTasks();
            LoadFilters();
            StyleGrid();
        }

        private void StyleGrid()
        {
            dataGridTasks.EnableHeadersVisualStyles = false;
            dataGridTasks.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;
            dataGridTasks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridTasks.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridTasks.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dataGridTasks.RowTemplate.Height = 28;
            dataGridTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridTasks.MultiSelect = false;
            dataGridTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // ربط حدث التنسيق
            dataGridTasks.CellFormatting += gridTasks_CellFormatting;
        }

        private void gridTasks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dataGridTasks.Columns[e.ColumnIndex].Name == "Priority" && e.Value != null)
            {
                string priority = e.Value.ToString();
                if (priority == "High")
                    e.CellStyle.BackColor = Color.LightCoral;
                else if (priority == "Medium")
                    e.CellStyle.BackColor = Color.Aquamarine;
                else if (priority == "Low")
                    e.CellStyle.BackColor = Color.LightBlue;
            }

            if (dataGridTasks.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString();
                if (status == "Completed")
                    e.CellStyle.BackColor = Color.LightGreen;
                else if (status == "Pending")
                    e.CellStyle.BackColor = Color.LightYellow;
                else if (status == "In_Progress")
                    e.CellStyle.BackColor = Color.LightGoldenrodYellow;
            }
        }

        public void LoadTasks()
        {
            try
            {
                var query = context.TaskItems
                   .Include(t => t.Category)
                   .Where(t => t.UserId == loggedInUser.Id);

                int totalRecords = query.Count();
                totalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);
                if (totalPages == 0) totalPages = 1;

                var tasks = query
                    .OrderBy(t => t.Id)
                    .Skip((currentPage - 1) * pageSize)
                    .Take(pageSize)
                    .Select(t => new
                    {
                        t.Id,
                        t.Title,
                        t.Description,
                        t.DueDate,
                        t.Priority,
                        t.Status,
                        Category = t.Category != null ? t.Category.Name : "No Category"
                    })
                    .ToList();

                dataGridTasks.DataSource = tasks;

                if (dataGridTasks.Columns.Contains("Id"))
                    dataGridTasks.Columns["Id"].Visible = false;

                lblPending.Text = "Pending: " + tasks.Count(t => t.Status.ToString() == "Pending");
                lblInProgress.Text = "In Progress: " + tasks.Count(t => t.Status.ToString() == "In_Progress");
                lblCompleted.Text = "Completed: " + tasks.Count(t => t.Status.ToString() == "Completed");

                lblPageInfo.Text = $"Page {currentPage} of {totalPages}";

                UpdatePaginationButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading tasks: {ex.Message}");
            }
        }

        private void UpdatePaginationButtons()
        {
            btnPrevPage.Enabled = (currentPage > 1);
            btnNextPage.Enabled = (currentPage < totalPages);
        }

        private void LoadFilters()
        {
            cmbSort.Items.Clear();
            cmbSort.Items.Add("Newest");
            cmbSort.Items.Add("Oldest");
            cmbSort.Items.Add("Priority (High to Low)");
            cmbSort.Items.Add("Priority (Low to High)");
            cmbSort.SelectedIndex = 0;

            cmbStatusFilter.Items.Clear();
            cmbStatusFilter.Items.AddRange(Enum.GetNames(typeof(Models.TaskStatus)));
            cmbStatusFilter.SelectedIndex = -1;

            cmbPriorityFilter.Items.Clear();
            cmbPriorityFilter.Items.AddRange(Enum.GetNames(typeof(PriorityLevel)));
            cmbPriorityFilter.SelectedIndex = -1;

            cmbCategoryFilter.DataSource = context.Categories.ToList();
            cmbCategoryFilter.DisplayMember = "Name";
            cmbCategoryFilter.ValueMember = "Id";
            cmbCategoryFilter.SelectedIndex = -1;
        }

        private void ApplyFilters()
        {
            try
            {
                var query = context.TaskItems.Include(t => t.Category)
                    .Where(t => t.UserId == loggedInUser.Id);

                if (!string.IsNullOrWhiteSpace(textSearch.Text))
                    query = query.Where(t => t.Title.Contains(textSearch.Text) || t.Description.Contains(textSearch.Text));

                if (cmbStatusFilter.SelectedIndex != -1)
                    query = query.Where(t => t.Status.ToString() == cmbStatusFilter.SelectedItem.ToString());

                if (cmbPriorityFilter.SelectedIndex != -1)
                    query = query.Where(t => t.Priority.ToString() == cmbPriorityFilter.SelectedItem.ToString());

                if (cmbCategoryFilter.SelectedIndex != -1)
                    query = query.Where(t => t.CategoryId == (int)cmbCategoryFilter.SelectedValue);

                switch (cmbSort.SelectedItem?.ToString())
                {
                    case "Newest":
                        query = query.OrderByDescending(t => t.DueDate);
                        break;
                    case "Oldest":
                        query = query.OrderBy(t => t.DueDate);
                        break;
                    case "Priority (High to Low)":
                        query = query.OrderByDescending(t => t.Priority);
                        break;
                    case "Priority (Low to High)":
                        query = query.OrderBy(t => t.Priority);
                        break;
                    default:
                        query = query.OrderBy(t => t.Id);
                        break;
                }

                int totalRecords = query.Count();
                totalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);
                if (totalPages == 0) totalPages = 1;

                var tasks = query
                    .Skip((currentPage - 1) * pageSize)
                    .Take(pageSize)
                    .Select(t => new
                    {
                        t.Id,
                        t.Title,
                        t.Description,
                        t.DueDate,
                        t.Priority,
                        t.Status,
                        Category = t.Category != null ? t.Category.Name : "No Category"
                    }).ToList();

                dataGridTasks.DataSource = tasks;

                if (dataGridTasks.Columns.Contains("Id"))
                    dataGridTasks.Columns["Id"].Visible = false;

                // تحديث إحصائيات الحالة
                lblPending.Text = "Pending: " + tasks.Count(t => t.Status.ToString() == "Pending");
                lblInProgress.Text = "In Progress: " + tasks.Count(t => t.Status.ToString() == "In_Progress");
                lblCompleted.Text = "Completed: " + tasks.Count(t => t.Status.ToString() == "Completed");

                lblPageInfo.Text = $"Page {currentPage} of {totalPages}";
                UpdatePaginationButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying filters: {ex.Message}");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) => ApplyFilters();
        private void btnClearSearch_Click(object sender, EventArgs e) { textSearch.Clear(); ApplyFilters(); }
        private void btnFilter_Click(object sender, EventArgs e) => ApplyFilters();
        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            cmbStatusFilter.SelectedIndex = -1;
            cmbPriorityFilter.SelectedIndex = -1;
            cmbCategoryFilter.SelectedIndex = -1;
            ApplyFilters();
        }
        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            var addForm = new AddTaskForm(loggedInUser, this);
            addForm.FormClosed += (s, a) => { currentPage = 1; LoadTasks(); };
            addForm.ShowDialog();
        }

        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
            if (dataGridTasks.CurrentRow == null || dataGridTasks.CurrentRow.Cells["Id"].Value == null)
            {
                MessageBox.Show("Please select a task to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int taskId = (int)dataGridTasks.CurrentRow.Cells["Id"].Value;
            var updateForm = new UpdateTaskForm(taskId, this);
            updateForm.FormClosed += (s, a) => { LoadTasks(); };
            updateForm.ShowDialog();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (dataGridTasks.CurrentRow != null && dataGridTasks.CurrentRow.Cells["Id"].Value != null)
            {
                int taskId = (int)dataGridTasks.CurrentRow.Cells["Id"].Value;

                var confirmResult = MessageBox.Show("Are you sure you want to delete this task?",
                                                  "Confirm Delete",
                                                  MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var task = context.TaskItems.Find(taskId);
                    if (task != null)
                    {
                        context.TaskItems.Remove(task);
                        context.SaveChanges();
                        MessageBox.Show("Task deleted successfully!");
                        LoadTasks();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a task to delete.");
            }
        }

       

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm(loggedInUser);
            reportForm.ShowDialog();
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadTasks();
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadTasks();
            }
        }

        private void lblPageInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click_1(object sender, EventArgs e)
        {
            if (dataGridTasks.CurrentRow != null && dataGridTasks.CurrentRow.Cells["Id"].Value != null)
            {

                int taskId = (int)dataGridTasks.CurrentRow.Cells["Id"].Value;
                ViewTaskForm detailsForm = new ViewTaskForm(taskId, loggedInUser, this);
                detailsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a task to view.");
            }
        }
    }
}


