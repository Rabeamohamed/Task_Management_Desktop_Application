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
        private TaskManagementContext context = new TaskManagementContext();
        private User loggedInUser;

        public ReportForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
        }
        private void ReportForm_Load(object sender, EventArgs e)
        {

        }
    }
}
