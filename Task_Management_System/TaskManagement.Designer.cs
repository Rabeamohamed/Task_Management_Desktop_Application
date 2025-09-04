namespace Task_Management_System
{
    partial class TaskManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskManagement));
            panelHeader = new Panel();
            label1 = new Label();
            picLogo = new PictureBox();
            panelSearch = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtSearch = new TextBox();
            btnSearch = new Button();
            label5 = new Label();
            comboSort = new ComboBox();
            panel1 = new Panel();
            flowFilters = new FlowLayoutPanel();
            panel2 = new Panel();
            label2 = new Label();
            cbStatus = new ComboBox();
            fiterbtn = new Button();
            panel4 = new Panel();
            label3 = new Label();
            comboBox1 = new ComboBox();
            panel3 = new Panel();
            label4 = new Label();
            comboBox2 = new ComboBox();
            ClearFilterbtn = new Button();
            tableMainContent = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            updateTaskbtn = new Button();
            deleteTaskbtn = new Button();
            button2 = new Button();
            panelGrid = new Panel();
            gridTasks = new DataGridView();
            button4 = new Button();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelSearch.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            flowFilters.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            tableMainContent.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridTasks).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(30, 58, 138);
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(picLogo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1182, 70);
            panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(483, 14);
            label1.Name = "label1";
            label1.Size = new Size(214, 41);
            label1.TabIndex = 1;
            label1.Text = "Manage Tasks";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            picLogo.ErrorImage = null;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(12, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(50, 50);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.FromArgb(243, 244, 246);
            panelSearch.Controls.Add(tableLayoutPanel1);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(0, 70);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(1182, 56);
            panelSearch.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.7283363F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.2833729F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.9882908F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 299F));
            tableLayoutPanel1.Controls.Add(txtSearch, 0, 0);
            tableLayoutPanel1.Controls.Add(btnSearch, 1, 0);
            tableLayoutPanel1.Controls.Add(label5, 2, 0);
            tableLayoutPanel1.Controls.Add(comboSort, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1182, 56);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.None;
            txtSearch.BackColor = SystemColors.GradientActiveCaption;
            txtSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(80, 6);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search title or description";
            txtSearch.Size = new Size(349, 43);
            txtSearch.TabIndex = 2;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.None;
            btnSearch.AutoSize = true;
            btnSearch.BackColor = Color.FromArgb(0, 0, 64);
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.ControlLightLight;
            btnSearch.Location = new Point(560, 9);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(137, 38);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(789, 14);
            label5.Name = "label5";
            label5.Size = new Size(52, 28);
            label5.TabIndex = 4;
            label5.Text = "Sort";
            // 
            // comboSort
            // 
            comboSort.Anchor = AnchorStyles.None;
            comboSort.BackColor = Color.SteelBlue;
            comboSort.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboSort.ForeColor = SystemColors.Window;
            comboSort.FormattingEnabled = true;
            comboSort.Location = new Point(946, 12);
            comboSort.Name = "comboSort";
            comboSort.Size = new Size(170, 31);
            comboSort.TabIndex = 3;
            comboSort.SelectedIndexChanged += comboSort_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(flowFilters);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 56);
            panel1.TabIndex = 2;
            // 
            // flowFilters
            // 
            flowFilters.Controls.Add(panel2);
            flowFilters.Controls.Add(panel4);
            flowFilters.Controls.Add(panel3);
            flowFilters.Controls.Add(ClearFilterbtn);
            flowFilters.Dock = DockStyle.Fill;
            flowFilters.Location = new Point(0, 0);
            flowFilters.Name = "flowFilters";
            flowFilters.Padding = new Padding(10);
            flowFilters.Size = new Size(1182, 56);
            flowFilters.TabIndex = 0;
            flowFilters.WrapContents = false;
            flowFilters.Paint += flowFilters_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cbStatus);
            panel2.Controls.Add(fiterbtn);
            panel2.Location = new Point(13, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(385, 37);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(131, 3);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 0;
            label2.Text = "Status";
            label2.Click += label2_Click_1;
            // 
            // cbStatus
            // 
            cbStatus.Anchor = AnchorStyles.None;
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(207, 6);
            cbStatus.Margin = new Padding(8);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(151, 28);
            cbStatus.TabIndex = 1;
            // 
            // fiterbtn
            // 
            fiterbtn.Anchor = AnchorStyles.None;
            fiterbtn.AutoSize = true;
            fiterbtn.BackColor = Color.FromArgb(0, 0, 64);
            fiterbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fiterbtn.ForeColor = SystemColors.ControlLightLight;
            fiterbtn.Location = new Point(24, -1);
            fiterbtn.Name = "fiterbtn";
            fiterbtn.Size = new Size(94, 38);
            fiterbtn.TabIndex = 2;
            fiterbtn.Text = "Filter";
            fiterbtn.UseVisualStyleBackColor = false;
            fiterbtn.Click += fiterbtn_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Controls.Add(comboBox1);
            panel4.Location = new Point(404, 13);
            panel4.Name = "panel4";
            panel4.Size = new Size(304, 37);
            panel4.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 4);
            label3.Name = "label3";
            label3.Size = new Size(83, 28);
            label3.TabIndex = 2;
            label3.Text = "Priority";
            label3.Click += label3_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(134, 4);
            comboBox1.Margin = new Padding(8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(comboBox2);
            panel3.Location = new Point(714, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(314, 36);
            panel3.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 3);
            label4.Name = "label4";
            label4.Size = new Size(98, 28);
            label4.TabIndex = 4;
            label4.Text = "Category";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(138, 4);
            comboBox2.Margin = new Padding(8);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 5;
            // 
            // ClearFilterbtn
            // 
            ClearFilterbtn.Anchor = AnchorStyles.None;
            ClearFilterbtn.AutoSize = true;
            ClearFilterbtn.BackColor = Color.FromArgb(0, 0, 64);
            ClearFilterbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearFilterbtn.ForeColor = SystemColors.ControlLightLight;
            ClearFilterbtn.Location = new Point(1034, 13);
            ClearFilterbtn.Name = "ClearFilterbtn";
            ClearFilterbtn.Size = new Size(128, 40);
            ClearFilterbtn.TabIndex = 6;
            ClearFilterbtn.Text = "Clear Filter";
            ClearFilterbtn.UseVisualStyleBackColor = false;
            ClearFilterbtn.Click += ClearFilterbtn_Click;
            // 
            // tableMainContent
            // 
            tableMainContent.BackColor = SystemColors.ActiveCaption;
            tableMainContent.ColumnCount = 3;
            tableMainContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.22636F));
            tableMainContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.7736359F));
            tableMainContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 134F));
            tableMainContent.Controls.Add(tableLayoutPanel2, 0, 0);
            tableMainContent.Controls.Add(panelGrid, 1, 0);
            tableMainContent.Controls.Add(button4, 0, 1);
            tableMainContent.Dock = DockStyle.Fill;
            tableMainContent.Location = new Point(0, 182);
            tableMainContent.Name = "tableMainContent";
            tableMainContent.RowCount = 2;
            tableMainContent.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableMainContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableMainContent.Size = new Size(1182, 571);
            tableMainContent.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.22807F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 83.77193F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.Size = new Size(300, 492);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(updateTaskbtn);
            flowLayoutPanel1.Controls.Add(deleteTaskbtn);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 77);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(294, 376);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(59, 130, 246);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(51, 40);
            button1.Margin = new Padding(50, 40, 13, 13);
            button1.Name = "button1";
            button1.Padding = new Padding(5);
            button1.Size = new Size(178, 53);
            button1.TabIndex = 0;
            button1.Text = "Add Task";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // updateTaskbtn
            // 
            updateTaskbtn.Anchor = AnchorStyles.None;
            updateTaskbtn.AutoSize = true;
            updateTaskbtn.BackColor = Color.FromArgb(0, 0, 64);
            updateTaskbtn.FlatStyle = FlatStyle.Flat;
            updateTaskbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateTaskbtn.ForeColor = Color.White;
            updateTaskbtn.Location = new Point(52, 119);
            updateTaskbtn.Margin = new Padding(50, 13, 13, 13);
            updateTaskbtn.Name = "updateTaskbtn";
            updateTaskbtn.Padding = new Padding(5);
            updateTaskbtn.Size = new Size(177, 53);
            updateTaskbtn.TabIndex = 1;
            updateTaskbtn.Text = "Update Task";
            updateTaskbtn.UseVisualStyleBackColor = false;
            updateTaskbtn.Click += updateTaskbtn_Click;
            // 
            // deleteTaskbtn
            // 
            deleteTaskbtn.Anchor = AnchorStyles.None;
            deleteTaskbtn.AutoSize = true;
            deleteTaskbtn.BackColor = Color.FromArgb(192, 0, 0);
            deleteTaskbtn.FlatStyle = FlatStyle.Flat;
            deleteTaskbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteTaskbtn.ForeColor = Color.White;
            deleteTaskbtn.Location = new Point(53, 198);
            deleteTaskbtn.Margin = new Padding(50, 13, 13, 13);
            deleteTaskbtn.Name = "deleteTaskbtn";
            deleteTaskbtn.Padding = new Padding(5);
            deleteTaskbtn.Size = new Size(174, 53);
            deleteTaskbtn.TabIndex = 2;
            deleteTaskbtn.Text = "Delete Task";
            deleteTaskbtn.UseVisualStyleBackColor = false;
            deleteTaskbtn.Click += deleteTaskbtn_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(0, 0, 64);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(50, 277);
            button2.Margin = new Padding(50, 13, 13, 13);
            button2.Name = "button2";
            button2.Padding = new Padding(5);
            button2.Size = new Size(181, 53);
            button2.TabIndex = 4;
            button2.Text = "Average Time";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(gridTasks);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(309, 3);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(735, 492);
            panelGrid.TabIndex = 1;
            // 
            // gridTasks
            // 
            gridTasks.AllowUserToAddRows = false;
            gridTasks.AllowUserToDeleteRows = false;
            gridTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridTasks.BackgroundColor = Color.Honeydew;
            gridTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTasks.Dock = DockStyle.Fill;
            gridTasks.Location = new Point(0, 0);
            gridTasks.MultiSelect = false;
            gridTasks.Name = "gridTasks";
            gridTasks.ReadOnly = true;
            gridTasks.RowHeadersWidth = 51;
            gridTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridTasks.Size = new Size(735, 492);
            gridTasks.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.Navy;
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(25, 523);
            button4.Margin = new Padding(25, 25, 15, 10);
            button4.Name = "button4";
            button4.Size = new Size(112, 38);
            button4.TabIndex = 3;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // TaskManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(tableMainContent);
            Controls.Add(panel1);
            Controls.Add(panelSearch);
            Controls.Add(panelHeader);
            Name = "TaskManagement";
            Text = "TaskManagement";
            Load += TaskManagement_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelSearch.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            flowFilters.ResumeLayout(false);
            flowFilters.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableMainContent.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridTasks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private PictureBox picLogo;
        private Label label1;
        private Panel panelSearch;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSearch;
        private TextBox txtSearch;
        private ComboBox comboSort;
        private Panel panel1;
        private FlowLayoutPanel flowFilters;
        private Label label2;
        private ComboBox cbStatus;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private ComboBox comboBox2;
        private Button ClearFilterbtn;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TableLayoutPanel tableMainContent;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button updateTaskbtn;
        private Button deleteTaskbtn;
        private Button button2;
        private Panel panelGrid;
        private DataGridView gridTasks;
        private Button fiterbtn;
        private Label label5;
        private Button button4;
    }
}