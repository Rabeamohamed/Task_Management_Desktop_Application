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
    // Task Management Desktop Application --> The Name of Repository
    public partial class CategoryForm : Form
    {
        private readonly TaskManagementContext context = new TaskManagementContext();
        private readonly User loggedInUser; // not used for filtering, but kept for consistency
        private int? selectedCategoryId = null;

        public CategoryForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            //ResetEditor();
        }

        // Load all categories into the grid
        private void LoadCategories()
        {
            var data = context.Categories
                              .Select(c => new { c.Id, c.Name })
                              .OrderBy(c => c.Name)
                              .ToList();

            gridCategories.DataSource = data;

            // Hide Id column but keep it in the data source
            if (gridCategories.Columns.Contains("Id"))
                gridCategories.Columns["Id"].Visible = false;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            AddCategory addForm = new AddCategory(this);
            addForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gridCategories.CurrentRow != null)
            {
                int categoryId = (int)gridCategories.CurrentRow.Cells["Id"].Value;
                UpdateCategory updateForm = new UpdateCategory(categoryId, this);
                updateForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a category to update.");
            }
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            if (gridCategories.CurrentRow != null)
            {
                int categoryId = (int)gridCategories.CurrentRow.Cells["Id"].Value;
                var category = context.Categories.Find(categoryId);

                if (category != null)
                {
                    // prevent deleting categories linked with tasks
                    bool hasTasks = context.TaskItems.Any(t => t.CategoryId == categoryId);
                    if (hasTasks)
                    {
                        MessageBox.Show("This category has tasks and cannot be deleted.");
                        return;
                    }

                    DialogResult result = MessageBox.Show(
                        $"Are you sure you want to delete the category '{category.Name}'?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2 
                   );
                    if (result != DialogResult.Yes)
                        return;

                    context.Categories.Remove(category);
                    context.SaveChanges();
                    MessageBox.Show("Category deleted successfully!");
                    LoadCategories();
                }
            }
            else
            {
                MessageBox.Show("Please select a category to delete.",
                      "Information",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
            }
        }
        public void RefreshCategories()
        {
            LoadCategories();
        }
        private void layoutMain_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
