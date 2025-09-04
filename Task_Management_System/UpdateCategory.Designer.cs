namespace Task_Management_System
{
    partial class UpdateCategory
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
            label1 = new Label();
            panel3 = new Panel();
            CategoryNameLabel = new Label();
            button2 = new Button();
            button1 = new Button();
            categoryNametxt = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Forte", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(94, 24);
            label1.Name = "label1";
            label1.Size = new Size(299, 41);
            label1.TabIndex = 0;
            label1.Text = "Update Category";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(CategoryNameLabel);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(categoryNametxt);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 90);
            panel3.Name = "panel3";
            panel3.Size = new Size(482, 263);
            panel3.TabIndex = 4;
            // 
            // CategoryNameLabel
            // 
            CategoryNameLabel.AutoSize = true;
            CategoryNameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryNameLabel.ForeColor = SystemColors.ActiveCaptionText;
            CategoryNameLabel.Location = new Point(84, 32);
            CategoryNameLabel.Name = "CategoryNameLabel";
            CategoryNameLabel.Size = new Size(94, 28);
            CategoryNameLabel.TabIndex = 5;
            CategoryNameLabel.Text = "Category";
            CategoryNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(293, 176);
            button2.Name = "button2";
            button2.Size = new Size(100, 39);
            button2.TabIndex = 4;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(84, 176);
            button1.Name = "button1";
            button1.Size = new Size(105, 39);
            button1.TabIndex = 3;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // categoryNametxt
            // 
            categoryNametxt.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoryNametxt.Location = new Point(202, 88);
            categoryNametxt.Multiline = true;
            categoryNametxt.Name = "categoryNametxt";
            categoryNametxt.Size = new Size(253, 50);
            categoryNametxt.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(36, 99);
            label2.Name = "label2";
            label2.Size = new Size(154, 28);
            label2.TabIndex = 1;
            label2.Text = "Category Name";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 90);
            panel1.TabIndex = 3;
            // 
            // UpdateCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 353);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "UpdateCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateCategory";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel3;
        private Button button2;
        private Button button1;
        private TextBox categoryNametxt;
        private Label label2;
        private Panel panel1;
        private Label CategoryNameLabel;
    }
}