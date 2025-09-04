
namespace Task_Management_System
{
    partial class ManageTasks
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            textSearch = new TextBox();
            btnSearch = new Button();
            btnClearSearch = new Button();
            cmbStatusFilter = new ComboBox();
            cmbPriorityFilter = new ComboBox();
            cmbCategoryFilter = new ComboBox();
            cmbSort = new ComboBox();
            btnFilter = new Button();
            btnClearFilter = new Button();
            dataGridTasks = new DataGridView();
            btnPrevPage = new Button();
            btnNextPage = new Button();
            lblPageInfo = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnView = new Button();
            btnReport = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridTasks).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(200, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Task Management System";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(80, 60);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(200, 27);
            textSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Teal;
            btnSearch.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(309, 56);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 33);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClearSearch
            // 
            btnClearSearch.BackColor = Color.Gray;
            btnClearSearch.ForeColor = Color.White;
            btnClearSearch.Location = new Point(404, 57);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(75, 29);
            btnClearSearch.TabIndex = 3;
            btnClearSearch.Text = "Clear";
            btnClearSearch.UseVisualStyleBackColor = false;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.Location = new Point(80, 100);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(120, 28);
            cmbStatusFilter.TabIndex = 4;
            // 
            // cmbPriorityFilter
            // 
            cmbPriorityFilter.Location = new Point(280, 99);
            cmbPriorityFilter.Name = "cmbPriorityFilter";
            cmbPriorityFilter.Size = new Size(120, 28);
            cmbPriorityFilter.TabIndex = 5;
            // 
            // cmbCategoryFilter
            // 
            cmbCategoryFilter.Location = new Point(457, 99);
            cmbCategoryFilter.Name = "cmbCategoryFilter";
            cmbCategoryFilter.Size = new Size(120, 28);
            cmbCategoryFilter.TabIndex = 6;
            // 
            // cmbSort
            // 
            cmbSort.Location = new Point(635, 58);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(120, 28);
            cmbSort.TabIndex = 7;
            cmbSort.SelectedIndexChanged += cmbSort_SelectedIndexChanged;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.Teal;
            btnFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilter.ForeColor = SystemColors.ControlLightLight;
            btnFilter.Location = new Point(600, 100);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(80, 35);
            btnFilter.TabIndex = 8;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnClearFilter
            // 
            btnClearFilter.Location = new Point(680, 100);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(75, 25);
            btnClearFilter.TabIndex = 9;
            btnClearFilter.Text = "Clear";
            btnClearFilter.Click += btnClearFilter_Click;
            // 
            // dataGridTasks
            // 
            dataGridTasks.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridTasks.ColumnHeadersHeight = 29;
            dataGridTasks.Location = new Point(173, 140);
            dataGridTasks.Name = "dataGridTasks";
            dataGridTasks.ReadOnly = true;
            dataGridTasks.RowHeadersWidth = 51;
            dataGridTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridTasks.Size = new Size(570, 280);
            dataGridTasks.TabIndex = 10;
            // 
            // btnPrevPage
            // 
            btnPrevPage.BackColor = SystemColors.ActiveCaption;
            btnPrevPage.Location = new Point(39, 513);
            btnPrevPage.Name = "btnPrevPage";
            btnPrevPage.Size = new Size(110, 33);
            btnPrevPage.TabIndex = 11;
            btnPrevPage.Text = "← Previous";
            btnPrevPage.UseVisualStyleBackColor = false;
            btnPrevPage.Click += btnPrevPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.BackColor = SystemColors.ActiveCaption;
            btnNextPage.Location = new Point(644, 513);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(110, 36);
            btnNextPage.TabIndex = 12;
            btnNextPage.Text = "Next →";
            btnNextPage.UseVisualStyleBackColor = false;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // lblPageInfo
            // 
            lblPageInfo.BackColor = Color.LavenderBlush;
            lblPageInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageInfo.ForeColor = Color.Navy;
            lblPageInfo.Location = new Point(347, 435);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(174, 46);
            lblPageInfo.TabIndex = 13;
            lblPageInfo.Text = "Page 1 of 1";
            lblPageInfo.TextAlign = ContentAlignment.MiddleCenter;
            lblPageInfo.Click += lblPageInfo_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(31, 148);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(128, 45);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "+ Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAddTask_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SteelBlue;
            btnUpdate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(31, 288);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(128, 45);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "✎ Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdateTask_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(31, 360);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(128, 45);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "🗑 Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDeleteTask_Click;
            // 
            // btnView
            // 
            btnView.BackColor = Color.Purple;
            btnView.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnView.ForeColor = Color.White;
            btnView.Location = new Point(31, 220);
            btnView.Name = "btnView";
            btnView.Size = new Size(128, 45);
            btnView.TabIndex = 17;
            btnView.Text = "👁 View";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click_1;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.MidnightBlue;
            btnReport.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnReport.ForeColor = Color.White;
            btnReport.Location = new Point(31, 430);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(128, 45);
            btnReport.TabIndex = 18;
            btnReport.Text = "📊 Report";
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(570, 56);
            label1.Name = "label1";
            label1.Size = new Size(49, 28);
            label1.TabIndex = 19;
            label1.Text = "Sort";
            // 
            // ManageTasks
            // 
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(784, 561);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(textSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnClearSearch);
            Controls.Add(cmbStatusFilter);
            Controls.Add(cmbPriorityFilter);
            Controls.Add(cmbCategoryFilter);
            Controls.Add(cmbSort);
            Controls.Add(btnFilter);
            Controls.Add(btnClearFilter);
            Controls.Add(dataGridTasks);
            Controls.Add(btnPrevPage);
            Controls.Add(btnNextPage);
            Controls.Add(lblPageInfo);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnView);
            Controls.Add(btnReport);
            Name = "ManageTasks";
            Text = "Manage Tasks";
            Load += ManageTasks_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.ComboBox cmbPriorityFilter;
        private System.Windows.Forms.ComboBox cmbCategoryFilter;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.DataGridView dataGridTasks;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Label lblPageInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnReport;
        private Label label1;
    }
}

