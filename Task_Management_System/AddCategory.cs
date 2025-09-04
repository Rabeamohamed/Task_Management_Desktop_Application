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
    public partial class AddCategory : Form
    {
        private readonly TaskManagementContext context = new TaskManagementContext();
        private readonly CategoryForm parentForm;

        public AddCategory(CategoryForm parent)
        {
            InitializeComponent();
            parentForm = parent;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string name = categoryNametxt.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a category name.");
                return;
            }

            // check if category already exists
            if (context.Categories.Any(c => c.Name == name))
            {
                MessageBox.Show("Category already exists.");
                return;
            }

            var category = new Category { Name = name };
            context.Categories.Add(category);
            context.SaveChanges();

            MessageBox.Show("Category added successfully!");
            parentForm.RefreshCategories();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
