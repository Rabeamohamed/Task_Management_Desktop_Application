namespace Task_Management_System
{
    partial class ReportForm
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label1 = new Label();
            gridReports = new DataGridView();
            panel1 = new Panel();
            lblInProgress = new Label();
            lblPending = new Label();
            lblCompleted = new Label();
            lblTotal = new Label();
            panel2 = new Panel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridReports).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(193, 114);
            label1.Name = "label1";
            label1.Size = new Size(128, 41);
            label1.TabIndex = 1;
            label1.Text = "Reports";
            // 
            // gridReports
            // 
            gridReports.BackgroundColor = SystemColors.Info;
            gridReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridReports.Location = new Point(0, 83);
            gridReports.Name = "gridReports";
            gridReports.RowHeadersWidth = 51;
            gridReports.Size = new Size(797, 218);
            gridReports.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblInProgress);
            panel1.Controls.Add(lblPending);
            panel1.Controls.Add(lblCompleted);
            panel1.Controls.Add(lblTotal);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 307);
            panel1.Name = "panel1";
            panel1.Size = new Size(671, 141);
            panel1.TabIndex = 3;
            // 
            // lblInProgress
            // 
            lblInProgress.AutoSize = true;
            lblInProgress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInProgress.Location = new Point(349, 83);
            lblInProgress.Name = "lblInProgress";
            lblInProgress.Size = new Size(174, 28);
            lblInProgress.TabIndex = 3;
            lblInProgress.Text = "In Progress Tasks:";
            // 
            // lblPending
            // 
            lblPending.AutoSize = true;
            lblPending.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPending.Location = new Point(93, 83);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(146, 28);
            lblPending.TabIndex = 2;
            lblPending.Text = "Pending Tasks:";
            // 
            // lblCompleted
            // 
            lblCompleted.AutoSize = true;
            lblCompleted.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCompleted.Location = new Point(349, 15);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Size = new Size(182, 28);
            lblCompleted.TabIndex = 1;
            lblCompleted.Text = "Compeleted Tasks:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(93, 15);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(114, 28);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total Tasks:";
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(671, 83);
            panel2.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Forte", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(287, 26);
            label6.Name = "label6";
            label6.Size = new Size(135, 37);
            label6.TabIndex = 1;
            label6.Text = "Reports";
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 448);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(gridReports);
            Controls.Add(label1);
            Name = "ReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReportForm";
            Load += ReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)gridReports).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label1;
        private DataGridView gridReports;
        private Panel panel1;
        private Label lblInProgress;
        private Label lblPending;
        private Label lblCompleted;
        private Label lblTotal;
        private Panel panel2;
        private Label label6;
    }
}