namespace Task_Management_System
{
    partial class CategoryForm
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
            layoutMain = new TableLayoutPanel();
            panelHeader = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            addbtn = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            gridCategories = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            layoutMain.SuspendLayout();
            panelHeader.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCategories).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // layoutMain
            // 
            layoutMain.ColumnCount = 2;
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.8085823F));
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.19142F));
            layoutMain.Controls.Add(panelHeader, 0, 0);
            layoutMain.Controls.Add(panel1, 0, 1);
            layoutMain.Controls.Add(gridCategories, 1, 1);
            layoutMain.Controls.Add(panel2, 1, 0);
            layoutMain.Dock = DockStyle.Fill;
            layoutMain.Location = new Point(0, 0);
            layoutMain.Name = "layoutMain";
            layoutMain.RowCount = 2;
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutMain.Size = new Size(482, 353);
            layoutMain.TabIndex = 0;
            layoutMain.Paint += layoutMain_Paint;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(14, 165, 167);
            panelHeader.Controls.Add(label2);
            panelHeader.Dock = DockStyle.Fill;
            panelHeader.Location = new Point(3, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(166, 69);
            panelHeader.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(15);
            label2.Size = new Size(138, 68);
            label2.TabIndex = 2;
            label2.Text = "Mange";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(13, 17, 23);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(166, 272);
            panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(addbtn);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(35);
            flowLayoutPanel1.Size = new Size(166, 320);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.FromArgb(14, 165, 167);
            addbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            addbtn.ForeColor = SystemColors.ControlLightLight;
            addbtn.Location = new Point(45, 45);
            addbtn.Margin = new Padding(10);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(88, 35);
            addbtn.TabIndex = 0;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(14, 165, 167);
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(45, 100);
            button3.Margin = new Padding(10);
            button3.Name = "button3";
            button3.Size = new Size(88, 36);
            button3.TabIndex = 3;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(14, 165, 167);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(45, 156);
            button2.Margin = new Padding(10);
            button2.Name = "button2";
            button2.Size = new Size(88, 36);
            button2.TabIndex = 1;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(45, 212);
            button1.Margin = new Padding(10);
            button1.Name = "button1";
            button1.Size = new Size(88, 36);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // gridCategories
            // 
            gridCategories.AllowUserToAddRows = false;
            gridCategories.AllowUserToDeleteRows = false;
            gridCategories.Anchor = AnchorStyles.None;
            gridCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCategories.BackgroundColor = SystemColors.Info;
            gridCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCategories.Location = new Point(175, 78);
            gridCategories.MultiSelect = false;
            gridCategories.Name = "gridCategories";
            gridCategories.ReadOnly = true;
            gridCategories.RowHeadersWidth = 51;
            gridCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridCategories.Size = new Size(304, 272);
            gridCategories.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(14, 165, 167);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(175, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(304, 69);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(15);
            label1.Size = new Size(185, 68);
            label1.TabIndex = 1;
            label1.Text = "Categories";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 353);
            Controls.Add(layoutMain);
            Name = "CategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            layoutMain.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridCategories).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel layoutMain;
        private Panel panelHeader;
        private DataGridView gridCategories;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button addbtn;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Label label2;
        private Label label1;
    }
}