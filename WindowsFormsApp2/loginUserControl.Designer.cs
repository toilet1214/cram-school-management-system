namespace WindowsFormsApp2
{
    partial class loginUserControl
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabelforgetpass = new System.Windows.Forms.LinkLabel();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txbpassword = new System.Windows.Forms.TextBox();
            this.txbaccountnumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbTeacher = new System.Windows.Forms.RadioButton();
            this.rdbStudent = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            this.panel2.Location = new System.Drawing.Point(190, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 3);
            this.panel2.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 34;
            this.label3.Text = "身份";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            this.panel1.Location = new System.Drawing.Point(190, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 3);
            this.panel1.TabIndex = 32;
            // 
            // linkLabelforgetpass
            // 
            this.linkLabelforgetpass.AutoSize = true;
            this.linkLabelforgetpass.Location = new System.Drawing.Point(259, 352);
            this.linkLabelforgetpass.Name = "linkLabelforgetpass";
            this.linkLabelforgetpass.Size = new System.Drawing.Size(65, 12);
            this.linkLabelforgetpass.TabIndex = 30;
            this.linkLabelforgetpass.TabStop = true;
            this.linkLabelforgetpass.Text = "忘記密碼？";
            // 
            // btnlogin
            // 
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Location = new System.Drawing.Point(261, 248);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 29;
            this.btnlogin.Text = "登入";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txbpassword
            // 
            this.txbpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbpassword.Location = new System.Drawing.Point(225, 193);
            this.txbpassword.Name = "txbpassword";
            this.txbpassword.PasswordChar = '*';
            this.txbpassword.Size = new System.Drawing.Size(176, 15);
            this.txbpassword.TabIndex = 28;
            // 
            // txbaccountnumber
            // 
            this.txbaccountnumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbaccountnumber.Location = new System.Drawing.Point(225, 153);
            this.txbaccountnumber.Name = "txbaccountnumber";
            this.txbaccountnumber.Size = new System.Drawing.Size(176, 15);
            this.txbaccountnumber.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "密碼";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "帳號";
            // 
            // rdbTeacher
            // 
            this.rdbTeacher.AutoSize = true;
            this.rdbTeacher.BackColor = System.Drawing.Color.Transparent;
            this.rdbTeacher.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.rdbTeacher.Location = new System.Drawing.Point(330, 114);
            this.rdbTeacher.Name = "rdbTeacher";
            this.rdbTeacher.Size = new System.Drawing.Size(47, 16);
            this.rdbTeacher.TabIndex = 24;
            this.rdbTeacher.TabStop = true;
            this.rdbTeacher.Text = "老師";
            this.rdbTeacher.UseVisualStyleBackColor = false;
            // 
            // rdbStudent
            // 
            this.rdbStudent.AutoSize = true;
            this.rdbStudent.Location = new System.Drawing.Point(252, 116);
            this.rdbStudent.Name = "rdbStudent";
            this.rdbStudent.Size = new System.Drawing.Size(47, 16);
            this.rdbStudent.TabIndex = 23;
            this.rdbStudent.TabStop = true;
            this.rdbStudent.Text = "學生";
            this.rdbStudent.UseVisualStyleBackColor = true;
            // 
            // loginUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabelforgetpass);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txbpassword);
            this.Controls.Add(this.txbaccountnumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbTeacher);
            this.Controls.Add(this.rdbStudent);
            this.Name = "loginUserControl";
            this.Size = new System.Drawing.Size(600, 385);
            this.Load += new System.EventHandler(this.loginUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabelforgetpass;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txbpassword;
        private System.Windows.Forms.TextBox txbaccountnumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbTeacher;
        private System.Windows.Forms.RadioButton rdbStudent;
    }
}
