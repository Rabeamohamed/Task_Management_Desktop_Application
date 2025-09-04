namespace Task_Management_System
{
    partial class AddTaskForm
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
            panelMain = new Panel();
            button1 = new Button();
            savebtn = new Button();
            categorycomboBox = new ComboBox();
            label6 = new Label();
            prioritycomboBox = new ComboBox();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            descriptiotextBox2 = new TextBox();
            label2 = new Label();
            titletextBox = new TextBox();
            label1 = new Label();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.None;
            panelMain.BorderStyle = BorderStyle.FixedSingle;
            panelMain.Controls.Add(button1);
            panelMain.Controls.Add(savebtn);
            panelMain.Controls.Add(categorycomboBox);
            panelMain.Controls.Add(label6);
            panelMain.Controls.Add(prioritycomboBox);
            panelMain.Controls.Add(label7);
            panelMain.Controls.Add(dateTimePicker1);
            panelMain.Controls.Add(label3);
            panelMain.Controls.Add(descriptiotextBox2);
            panelMain.Controls.Add(label2);
            panelMain.Controls.Add(titletextBox);
            panelMain.Controls.Add(label1);
            panelMain.Location = new Point(68, 67);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(440, 518);
            panelMain.TabIndex = 0;
            panelMain.Paint += panelMain_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(47, 452);
            button1.Name = "button1";
            button1.Size = new Size(130, 40);
            button1.TabIndex = 13;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // savebtn
            // 
            savebtn.BackColor = Color.FromArgb(0, 192, 0);
            savebtn.FlatStyle = FlatStyle.Flat;
            savebtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            savebtn.ForeColor = SystemColors.ButtonHighlight;
            savebtn.Location = new Point(242, 452);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(130, 40);
            savebtn.TabIndex = 12;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = false;
            savebtn.Click += savebtn_Click;
            // 
            // categorycomboBox
            // 
            categorycomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categorycomboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categorycomboBox.FormattingEnabled = true;
            categorycomboBox.Location = new Point(153, 289);
            categorycomboBox.Name = "categorycomboBox";
            categorycomboBox.Size = new Size(249, 36);
            categorycomboBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 293);
            label6.Name = "label6";
            label6.Size = new Size(98, 28);
            label6.TabIndex = 10;
            label6.Text = "Category";
            // 
            // prioritycomboBox
            // 
            prioritycomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            prioritycomboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prioritycomboBox.FormattingEnabled = true;
            prioritycomboBox.Items.AddRange(new object[] { "Low", "Medium", " High" });
            prioritycomboBox.Location = new Point(153, 371);
            prioritycomboBox.Name = "prioritycomboBox";
            prioritycomboBox.Size = new Size(249, 36);
            prioritycomboBox.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(21, 375);
            label7.Name = "label7";
            label7.Size = new Size(83, 28);
            label7.TabIndex = 6;
            label7.Text = "Priority";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(154, 200);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(248, 34);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 205);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 4;
            label3.Text = "Due Date";
            // 
            // descriptiotextBox2
            // 
            descriptiotextBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptiotextBox2.Location = new Point(153, 122);
            descriptiotextBox2.Multiline = true;
            descriptiotextBox2.Name = "descriptiotextBox2";
            descriptiotextBox2.ScrollBars = ScrollBars.Vertical;
            descriptiotextBox2.Size = new Size(248, 37);
            descriptiotextBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 121);
            label2.Name = "label2";
            label2.Size = new Size(121, 28);
            label2.TabIndex = 2;
            label2.Text = "Description";
            // 
            // titletextBox
            // 
            titletextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titletextBox.Location = new Point(153, 42);
            titletextBox.Name = "titletextBox";
            titletextBox.Size = new Size(249, 34);
            titletextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 42);
            label1.Name = "label1";
            label1.Size = new Size(55, 28);
            label1.TabIndex = 0;
            label1.Text = "Title";
            label1.Click += label1_Click;
            // 
            // AddTaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 653);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddTaskForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddTaskForm";
            Load += AddTaskForm_Load;
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);


            // testing 



        }

        #endregion

        private Panel panelMain;
        private TextBox descriptiotextBox2;
        private Label label2;
        private TextBox titletextBox;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private ComboBox categorycomboBox;
        private Label label6;
        private ComboBox prioritycomboBox;
        private Label label7;
        private Button savebtn;
        private Button button1;
    }
}