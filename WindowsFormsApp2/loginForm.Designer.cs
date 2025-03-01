using System.Drawing;

namespace WindowsFormsApp2
{
    partial class loginForm
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
            this.linkLabelsignup = new System.Windows.Forms.LinkLabel();
            this.linkLabelforgetpass = new System.Windows.Forms.LinkLabel();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txbpassword = new System.Windows.Forms.TextBox();
            this.txbaccountnumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbTeacher = new System.Windows.Forms.RadioButton();
            this.rdbStudent = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // linkLabelsignup
            // 
            this.linkLabelsignup.AutoSize = true;
            this.linkLabelsignup.Location = new System.Drawing.Point(307, 335);
            this.linkLabelsignup.Name = "linkLabelsignup";
            this.linkLabelsignup.Size = new System.Drawing.Size(53, 12);
            this.linkLabelsignup.TabIndex = 19;
            this.linkLabelsignup.TabStop = true;
            this.linkLabelsignup.Text = "創新帳戶";
            this.linkLabelsignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelsignup_LinkClicked);
            // 
            // linkLabelforgetpass
            // 
            this.linkLabelforgetpass.AutoSize = true;
            this.linkLabelforgetpass.Location = new System.Drawing.Point(236, 335);
            this.linkLabelforgetpass.Name = "linkLabelforgetpass";
            this.linkLabelforgetpass.Size = new System.Drawing.Size(65, 12);
            this.linkLabelforgetpass.TabIndex = 18;
            this.linkLabelforgetpass.TabStop = true;
            this.linkLabelforgetpass.Text = "忘記密碼？";
            // 
            // btnlogin
            // 
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Location = new System.Drawing.Point(263, 231);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 17;
            this.btnlogin.Text = "登入";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txbpassword
            // 
            this.txbpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbpassword.Location = new System.Drawing.Point(227, 176);
            this.txbpassword.Name = "txbpassword";
            this.txbpassword.PasswordChar = '*';
            this.txbpassword.Size = new System.Drawing.Size(176, 15);
            this.txbpassword.TabIndex = 16;
            this.txbpassword.TextChanged += new System.EventHandler(this.txbpassword_TextChanged);
            // 
            // txbaccountnumber
            // 
            this.txbaccountnumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbaccountnumber.Location = new System.Drawing.Point(227, 136);
            this.txbaccountnumber.Name = "txbaccountnumber";
            this.txbaccountnumber.Size = new System.Drawing.Size(176, 15);
            this.txbaccountnumber.TabIndex = 15;
            this.txbaccountnumber.TextChanged += new System.EventHandler(this.txbaccountnumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "密碼";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "帳號";
            // 
            // rdbTeacher
            // 
            this.rdbTeacher.AutoSize = true;
            this.rdbTeacher.BackColor = System.Drawing.Color.Transparent;
            this.rdbTeacher.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.rdbTeacher.Location = new System.Drawing.Point(332, 97);
            this.rdbTeacher.Name = "rdbTeacher";
            this.rdbTeacher.Size = new System.Drawing.Size(47, 16);
            this.rdbTeacher.TabIndex = 11;
            this.rdbTeacher.TabStop = true;
            this.rdbTeacher.Text = "老師";
            this.rdbTeacher.UseVisualStyleBackColor = false;
            this.rdbTeacher.CheckedChanged += new System.EventHandler(this.rdbTeacher_CheckedChanged);
            // 
            // rdbStudent
            // 
            this.rdbStudent.AutoSize = true;
            this.rdbStudent.Location = new System.Drawing.Point(254, 99);
            this.rdbStudent.Name = "rdbStudent";
            this.rdbStudent.Size = new System.Drawing.Size(47, 16);
            this.rdbStudent.TabIndex = 10;
            this.rdbStudent.TabStop = true;
            this.rdbStudent.Text = "學生";
            this.rdbStudent.UseVisualStyleBackColor = true;
            this.rdbStudent.CheckedChanged += new System.EventHandler(this.rdbStudent_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            this.panel1.Location = new System.Drawing.Point(192, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 3);
            this.panel1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "身份";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            this.panel2.Location = new System.Drawing.Point(192, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 3);
            this.panel2.TabIndex = 22;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 356);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabelsignup);
            this.Controls.Add(this.linkLabelforgetpass);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txbpassword);
            this.Controls.Add(this.txbaccountnumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbTeacher);
            this.Controls.Add(this.rdbStudent);
            this.Name = "loginForm";
            this.Text = "logintForm";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelsignup;
        private System.Windows.Forms.LinkLabel linkLabelforgetpass;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txbpassword;
        private System.Windows.Forms.TextBox txbaccountnumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbTeacher;
        private System.Windows.Forms.RadioButton rdbStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
    }
}