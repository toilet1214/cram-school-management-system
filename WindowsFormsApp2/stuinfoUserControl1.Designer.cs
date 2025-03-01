namespace WindowsFormsApp2
{
    partial class stuinfoUserControl1
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
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txb_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(209, 302);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 57;
            this.btn_save.Text = "儲存修改";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(312, 302);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 56;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            this.panel5.Location = new System.Drawing.Point(185, 125);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 3);
            this.panel5.TabIndex = 55;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            this.panel3.Location = new System.Drawing.Point(185, 205);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 3);
            this.panel3.TabIndex = 53;
            // 
            // txb_name
            // 
            this.txb_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_name.Location = new System.Drawing.Point(220, 107);
            this.txb_name.MaxLength = 200;
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(176, 15);
            this.txb_name.TabIndex = 54;
            this.txb_name.TextChanged += new System.EventHandler(this.txb_name_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 52;
            this.label5.Text = "姓名";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            this.panel4.Location = new System.Drawing.Point(185, 165);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 3);
            this.panel4.TabIndex = 51;
            // 
            // txb_address
            // 
            this.txb_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_address.Location = new System.Drawing.Point(220, 187);
            this.txb_address.MaxLength = 200;
            this.txb_address.Name = "txb_address";
            this.txb_address.Size = new System.Drawing.Size(176, 15);
            this.txb_address.TabIndex = 50;
            this.txb_address.TextChanged += new System.EventHandler(this.txb_address_TextChanged);
            // 
            // txb_phone
            // 
            this.txb_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_phone.Location = new System.Drawing.Point(220, 147);
            this.txb_phone.MaxLength = 200;
            this.txb_phone.Name = "txb_phone";
            this.txb_phone.Size = new System.Drawing.Size(176, 15);
            this.txb_phone.TabIndex = 49;
            this.txb_phone.TextChanged += new System.EventHandler(this.txb_phone_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 48;
            this.label3.Text = "地址";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 47;
            this.label4.Text = "電話";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            this.panel2.Location = new System.Drawing.Point(185, 282);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 3);
            this.panel2.TabIndex = 46;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            this.panel1.Location = new System.Drawing.Point(185, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 3);
            this.panel1.TabIndex = 45;
            // 
            // txb_email
            // 
            this.txb_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_email.Location = new System.Drawing.Point(220, 264);
            this.txb_email.MaxLength = 200;
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(176, 15);
            this.txb_email.TabIndex = 44;
            this.txb_email.TextChanged += new System.EventHandler(this.txb_email_TextChanged);
            // 
            // txb_birthday
            // 
            this.txb_birthday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_birthday.Location = new System.Drawing.Point(220, 224);
            this.txb_birthday.MaxLength = 200;
            this.txb_birthday.Name = "txb_birthday";
            this.txb_birthday.Size = new System.Drawing.Size(176, 15);
            this.txb_birthday.TabIndex = 43;
            this.txb_birthday.TextChanged += new System.EventHandler(this.txb_birthday_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 42;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 41;
            this.label1.Text = "生日";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            this.panel6.Location = new System.Drawing.Point(185, 92);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(220, 3);
            this.panel6.TabIndex = 58;
            // 
            // txb_id
            // 
            this.txb_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_id.Location = new System.Drawing.Point(220, 74);
            this.txb_id.MaxLength = 200;
            this.txb_id.Name = "txb_id";
            this.txb_id.ReadOnly = true;
            this.txb_id.Size = new System.Drawing.Size(176, 15);
            this.txb_id.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 56;
            this.label6.Text = "ID";
            // 
            // stuinfoUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txb_id);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_cancel);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "stuinfoUserControl1";
            this.Size = new System.Drawing.Size(600, 385);
            this.Load += new System.EventHandler(this.stuinfoUserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txb_id;
        private System.Windows.Forms.Label label6;
    }
}
