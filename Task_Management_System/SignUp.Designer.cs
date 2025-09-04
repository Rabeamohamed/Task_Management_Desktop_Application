namespace Task_Management_System
{
    partial class SignUp
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
            label2 = new Label();
            label3 = new Label();
            sginupnametxt = new TextBox();
            signupemailtxt = new TextBox();
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
            label1.Location = new Point(313, 83);
            label1.Name = "label1";
            label1.Size = new Size(209, 39);
            label1.TabIndex = 7;
            label1.Text = "Add New User";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(133, 178);
            label2.Name = "label2";
            label2.Size = new Size(127, 33);
            label2.TabIndex = 8;
            label2.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(135, 260);
            label3.Name = "label3";
            label3.Size = new Size(75, 33);
            label3.TabIndex = 9;
            label3.Text = "Email";
            // 
            // sginupnametxt
            // 
            sginupnametxt.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sginupnametxt.Location = new Point(277, 173);
            sginupnametxt.Multiline = true;
            sginupnametxt.Name = "sginupnametxt";
            sginupnametxt.Size = new Size(391, 44);
            sginupnametxt.TabIndex = 10;
            // 
            // signupemailtxt
            // 
            signupemailtxt.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupemailtxt.Location = new Point(277, 255);
            signupemailtxt.Multiline = true;
            signupemailtxt.Name = "signupemailtxt";
            signupemailtxt.Size = new Size(391, 43);
            signupemailtxt.TabIndex = 11;
            // 
            // signupbtn
            // 
            signupbtn.BackColor = Color.MidnightBlue;
            signupbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupbtn.ForeColor = SystemColors.ControlLightLight;
            signupbtn.Location = new Point(398, 344);
            signupbtn.Name = "signupbtn";
            signupbtn.Size = new Size(106, 42);
            signupbtn.TabIndex = 13;
            signupbtn.Text = "Sign Up";
            signupbtn.UseVisualStyleBackColor = false;
            signupbtn.Click += signupbtn_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(signupbtn);
            Controls.Add(signupemailtxt);
            Controls.Add(sginupnametxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SignUp";
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox sginupnametxt;
        private TextBox signupemailtxt;
        private Button signupbtn;
    }
}