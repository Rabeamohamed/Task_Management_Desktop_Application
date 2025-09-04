namespace Task_Management_System
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            label1 = new Label();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button4 = new Button();
            imageList1 = new ImageList(components);
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DarkSlateGray;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(846, 80);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.FromArgb(30, 58, 138);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(846, 80);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button4, 1, 1);
            tableLayoutPanel1.Controls.Add(button3, 0, 1);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 80);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(846, 586);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(64, 0, 0);
            button4.Cursor = Cursors.Hand;
            button4.Dock = DockStyle.Fill;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.ImageKey = "logput.png";
            button4.ImageList = imageList1;
            button4.Location = new Point(426, 296);
            button4.Name = "button4";
            button4.Size = new Size(397, 267);
            button4.TabIndex = 3;
            button4.Text = "Logout";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.TextImageRelation = TextImageRelation.ImageAboveText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Cat2.png");
            imageList1.Images.SetKeyName(1, "Categor.png");
            imageList1.Images.SetKeyName(2, "Categories.png");
            imageList1.Images.SetKeyName(3, "Categoryyy.png");
            imageList1.Images.SetKeyName(4, "logon.png");
            imageList1.Images.SetKeyName(5, "logput.png");
            imageList1.Images.SetKeyName(6, "Reporrt.png");
            imageList1.Images.SetKeyName(7, "Report.png");
            imageList1.Images.SetKeyName(8, "shopping.png");
            imageList1.Images.SetKeyName(9, "task-list.png");
            imageList1.Images.SetKeyName(10, "Taskss.png");
            imageList1.Images.SetKeyName(11, "time-management.png");
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.Cursor = Cursors.Hand;
            button3.Dock = DockStyle.Fill;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.ImageKey = "Report.png";
            button3.ImageList = imageList1;
            button3.Location = new Point(23, 296);
            button3.Name = "button3";
            button3.Size = new Size(397, 267);
            button3.TabIndex = 2;
            button3.Text = "Reports";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.ImageKey = "Categories.png";
            button2.ImageList = imageList1;
            button2.Location = new Point(426, 23);
            button2.Name = "button2";
            button2.Size = new Size(397, 267);
            button2.TabIndex = 1;
            button2.Text = "Categories";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 0, 0);
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.ImageKey = "time-management.png";
            button1.ImageList = imageList1;
            button1.Location = new Point(23, 23);
            button1.Name = "button1";
            button1.Size = new Size(397, 267);
            button1.TabIndex = 0;
            button1.Text = "Manage Tasks";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(846, 666);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private ImageList imageList1;
    }
}