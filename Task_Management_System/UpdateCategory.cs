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
    public partial class UpdateCategory : Form
    {

        private readonly TaskManagementContext context = new TaskManagementContext();
        private readonly int categoryId;
        private readonly CategoryForm parentForm;
        private string oldCategoryName;

        public UpdateCategory(int id, CategoryForm parent)
        {
            InitializeComponent();
            categoryId = id;
            parentForm = parent;
        }

        private void UpdateCategory_Load(object sender, EventArgs e)
        {
            var category = context.Categories.FirstOrDefault(c => c.Id == categoryId);
            if (category != null)
            {
                categoryNametxt.Text = category.Name;
                oldCategoryName = category.Name;

                CategoryNameLabel.Text = $"Current Category Name: {oldCategoryName}";

                CategoryNameLabel.Refresh();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {

            string newName = categoryNametxt.Text.Trim();
            //string name = categoryNametxt.Text.Trim();
            if (string.IsNullOrEmpty(newName))
            {
                MessageBox.Show("Please enter a category name.");
                return;
            }

            if (newName == oldCategoryName)
            {
                MessageBox.Show("No changes were made.");
                this.Close();
                return;
            }

            var category = context.Categories.FirstOrDefault(c => c.Id == categoryId);
            if (category != null)
            {
                category.Name = newName;
                context.SaveChanges();

                MessageBox.Show($"Category updated successfully!\n\n\nNew Name: {newName}");
                CategoryNameLabel.Text = $"Category Name : {newName}";
                parentForm.RefreshCategories();
                //this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
