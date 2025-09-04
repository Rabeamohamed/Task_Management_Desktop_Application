//namespace Task_Management_System
//{
//    partial class ViewTaskForm
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            SuspendLayout();
//            // 
//            // ViewTaskForm
//            // 
//            AutoScaleDimensions = new SizeF(8F, 20F);
//            AutoScaleMode = AutoScaleMode.Font;
//            ClientSize = new Size(800, 450);
//            Name = "ViewTaskForm";
//            Text = "ViewTaskForm";
//            Load += ViewTaskForm_Load;
//            ResumeLayout(false);
//        }

//        #endregion
//    }
//}




namespace Task_Management_System
{
    partial class ViewTaskForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCategory;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblDescription = new Label();
            lblDueDate = new Label();
            lblPriority = new Label();
            lblStatus = new Label();
            lblCategory = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(30, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(63, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Task";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12F);
            lblDescription.Location = new Point(30, 80);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(112, 28);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Description";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Font = new Font("Segoe UI", 12F);
            lblDueDate.Location = new Point(30, 130);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(88, 28);
            lblDueDate.TabIndex = 2;
            lblDueDate.Text = "DueDate";
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Font = new Font("Segoe UI", 12F);
            lblPriority.Location = new Point(30, 180);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(76, 28);
            lblPriority.TabIndex = 3;
            lblPriority.Text = "Priority";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F);
            lblStatus.Location = new Point(30, 230);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(65, 28);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 12F);
            lblCategory.Location = new Point(30, 280);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(92, 28);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Category";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(256, 307);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ViewTaskForm
            // 
            ClientSize = new Size(500, 350);
            Controls.Add(btnClose);
            Controls.Add(lblCategory);
            Controls.Add(lblStatus);
            Controls.Add(lblPriority);
            Controls.Add(lblDueDate);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Name = "ViewTaskForm";
            Text = "Task Details";
            Load += ViewTaskForm_Load;
            Click += ViewTaskForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private Button btnClose;
    }
}
