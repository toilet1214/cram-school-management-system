namespace WindowsFormsApp2
{
    partial class signupUserControl
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
            this.rdbStudent = new System.Windows.Forms.RadioButton();
            this.btn_signup = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txb_address = new System.Windows.Forms.TextBox();
            this.txb_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.txb_birthday = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txbpassword = new System.Windows.Forms.TextBox();
            this.txbaccountnumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdbStudent
            // 
            this.rdbStudent.AutoSize = true;
            this.rdbStudent.Checked = true;
            this.rdbStudent.Location = new System.Drawing.Point(161, 46);
            this.rdbStudent.Name = "rdbStudent";
            this.rdbStudent.Size = new System.Drawing.Size(47, 16);
            this.rdbStudent.TabIndex = 22;
            this.rdbStudent.TabStop = true;
            this.rdbStudent.Text = "學生";
            this.rdbStudent.UseVisualStyleBackColor = true;
            // 
            // btn_signup
            // 
            this.btn_signup.FlatAppearance.BorderSize = 0;
            this.btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signup.Location = new System.Drawing.Point(231, 341);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(75, 23);
            this.btn_signup.TabIndex = 57;
            this.btn_signup.Text = "註冊";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            this.panel5.Location = new System.Drawing.Point(161, 86);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 3);
            this.panel5.TabIndex = 55;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            this.panel3.Location = new System.Drawing.Point(161, 166);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 3);
            this.panel3.TabIndex = 53;
            // 
            // txb_name
            // 
            this.txb_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_name.Location = new System.Drawing.Point(209, 70);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(176, 15);
            this.txb_name.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 52;
            this.label5.Text = "姓名*";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            this.panel4.Location = new System.Drawing.Point(161, 126);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 3);
            this.panel4.TabIndex = 51;
            // 
            // txb_address
            // 
            this.txb_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_address.Location = new System.Drawing.Point(209, 151);
            this.txb_address.Name = "txb_address";
            this.txb_address.Size = new System.Drawing.Size(176, 15);
            this.txb_address.TabIndex = 50;
            // 
            // txb_phone
            // 
            this.txb_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_phone.Location = new System.Drawing.Point(209, 111);
            this.txb_phone.Name = "txb_phone";
            this.txb_phone.Size = new System.Drawing.Size(176, 15);
            this.txb_phone.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 48;
            this.label3.Text = "地址*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 47;
            this.label4.Text = "電話*";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            this.panel2.Location = new System.Drawing.Point(161, 243);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 3);
            this.panel2.TabIndex = 46;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            this.panel1.Location = new System.Drawing.Point(161, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 3);
            this.panel1.TabIndex = 45;
            // 
            // txb_email
            // 
            this.txb_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_email.Location = new System.Drawing.Point(209, 228);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(176, 15);
            this.txb_email.TabIndex = 44;
            // 
            // txb_birthday
            // 
            this.txb_birthday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_birthday.Location = new System.Drawing.Point(209, 188);
            this.txb_birthday.Name = "txb_birthday";
            this.txb_birthday.Size = new System.Drawing.Size(176, 15);
            this.txb_birthday.TabIndex = 43;
            this.txb_birthday.Text = "---   請輸入 例: 1900-12-31";
            this.txb_birthday.Enter += new System.EventHandler(this.txb_birthday_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 12);
            this.label6.TabIndex = 42;
            this.label6.Text = "Email*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 41;
            this.label7.Text = "生日*";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            this.panel6.Location = new System.Drawing.Point(161, 319);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(220, 3);
            this.panel6.TabIndex = 63;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            this.panel7.Location = new System.Drawing.Point(161, 279);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(220, 3);
            this.panel7.TabIndex = 62;
            // 
            // txbpassword
            // 
            this.txbpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbpassword.Location = new System.Drawing.Point(209, 304);
            this.txbpassword.Name = "txbpassword";
            this.txbpassword.PasswordChar = '*';
            this.txbpassword.Size = new System.Drawing.Size(176, 15);
            this.txbpassword.TabIndex = 61;
            // 
            // txbaccountnumber
            // 
            this.txbaccountnumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbaccountnumber.Location = new System.Drawing.Point(209, 264);
            this.txbaccountnumber.Name = "txbaccountnumber";
            this.txbaccountnumber.Size = new System.Drawing.Size(176, 15);
            this.txbaccountnumber.TabIndex = 60;
            this.txbaccountnumber.TextChanged += new System.EventHandler(this.txbaccountnumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 59;
            this.label2.Text = "密碼*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 58;
            this.label1.Text = "帳號*";
            // 
            // signupUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txbpassword);
            this.Controls.Add(this.txbaccountnumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txb_address);
            this.Controls.Add(this.txb_phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txb_email);
            this.Controls.Add(this.txb_birthday);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rdbStudent);
            this.Name = "signupUserControl";
            this.Size = new System.Drawing.Size(600, 385);
            this.Load += new System.EventHandler(this.signupUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbStudent;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txb_address;
        private System.Windows.Forms.TextBox txb_phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.TextBox txb_birthday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txbpassword;
        private System.Windows.Forms.TextBox txbaccountnumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
