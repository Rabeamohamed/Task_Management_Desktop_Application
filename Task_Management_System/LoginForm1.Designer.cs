namespace Task_Management_System
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            logintextBox1 = new TextBox();
            logintextBox2 = new TextBox();
            loginbtn = new Button();
            signupbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MidnightBlue;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(335, 78);
            label1.Name = "label1";
            label1.Size = new Size(92, 39);
            label1.TabIndex = 0;
            label1.Text = "LogIn";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(122, 175);
            label2.Name = "label2";
            label2.Size = new Size(127, 33);
            label2.TabIndex = 1;
            label2.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(122, 270);
            label3.Name = "label3";
            label3.Size = new Size(75, 33);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // logintextBox1
            // 
            logintextBox1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logintextBox1.Location = new Point(266, 175);
            logintextBox1.Multiline = true;
            logintextBox1.Name = "logintextBox1";
            logintextBox1.Size = new Size(391, 44);
            logintextBox1.TabIndex = 3;
            // 
            // logintextBox2
            // 
            logintextBox2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logintextBox2.Location = new Point(266, 270);
            logintextBox2.Multiline = true;
            logintextBox2.Name = "logintextBox2";
            logintextBox2.Size = new Size(391, 43);
            logintextBox2.TabIndex = 4;
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.MidnightBlue;
            loginbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbtn.ForeColor = SystemColors.ButtonHighlight;
            loginbtn.Location = new Point(511, 361);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(115, 42);
            loginbtn.TabIndex = 5;
            loginbtn.Text = "LogIn";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            // 
            // signupbtn
            // 
            signupbtn.BackColor = Color.MidnightBlue;
            signupbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupbtn.ForeColor = SystemColors.ControlLightLight;
            signupbtn.Location = new Point(305, 361);
            signupbtn.Name = "signupbtn";
            signupbtn.Size = new Size(106, 42);
            signupbtn.TabIndex = 6;
            signupbtn.Text = "Sign Up";
            signupbtn.UseVisualStyleBackColor = false;
            signupbtn.Click += signupbtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(signupbtn);
            Controls.Add(loginbtn);
            Controls.Add(logintextBox2);
            Controls.Add(logintextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox logintextBox1;
        private TextBox logintextBox2;
        private Button loginbtn;
        private Button signupbtn;
    }
}
