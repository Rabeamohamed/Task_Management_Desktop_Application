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
    public partial class ReportForm : Form
    {
        
        private void ReportForm_Load(object sender, EventArgs e)
        {
            LoadReportData();
        }

        private readonly TaskManagementContext context = new TaskManagementContext();
        private readonly User loggedInUser;

        public ReportForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

       

        private void LoadReportData()
        {
            // Get all tasks for this user
            var tasks = context.TaskItems
                .Where(t => t.UserId == loggedInUser.Id)
                .Select(t => new
                {
                    t.Title,
                    t.Status,
                    t.Priority,
                    t.DueDate,
                    Category = t.Category.Name
                })
                .ToList();

            // Fill DataGridView
            gridReports.DataSource = tasks;

            // Summary
            int total = tasks.Count;
            int completed = tasks.Count(t => t.Status == Models.TaskStatus.Completed);
            int pending = tasks.Count(t => t.Status == Models.TaskStatus.Pending);
            int inProgress = tasks.Count(t => t.Status == Models.TaskStatus.In_Progress);

            lblTotal.Text = $"Total Tasks: {total}";
            lblCompleted.Text = $"Completed Tasks: {completed}";
            lblPending.Text = $"Pending Tasks: {pending}";
            lblInProgress.Text = $"In Progress Tasks: {inProgress}";
        }
    }
}
