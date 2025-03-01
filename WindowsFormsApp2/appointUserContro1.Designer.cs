namespace WindowsFormsApp2
{
    partial class appointUserContro1
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
            this.label12 = new System.Windows.Forms.Label();
            this.dtp_appointment = new System.Windows.Forms.DateTimePicker();
            this.btnappoint_check = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbbappoint_courses = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbappoint_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbappoint_phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_其他 = new System.Windows.Forms.RadioButton();
            this.rdb_親友 = new System.Windows.Forms.RadioButton();
            this.rdb_文宣 = new System.Windows.Forms.RadioButton();
            this.rdb_ig = new System.Windows.Forms.RadioButton();
            this.rdb_臉書 = new System.Windows.Forms.RadioButton();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(175, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 43;
            this.label12.Text = "預約時間*";
            // 
            // dtp_appointment
            // 
            this.dtp_appointment.Location = new System.Drawing.Point(243, 195);
            this.dtp_appointment.Name = "dtp_appointment";
            this.dtp_appointment.Size = new System.Drawing.Size(152, 22);
            this.dtp_appointment.TabIndex = 42;
            // 
            // btnappoint_check
            // 
            this.btnappoint_check.FlatAppearance.BorderSize = 0;
            this.btnappoint_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnappoint_check.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnappoint_check.Location = new System.Drawing.Point(243, 284);
            this.btnappoint_check.Name = "btnappoint_check";
            this.btnappoint_check.Size = new System.Drawing.Size(75, 23);
            this.btnappoint_check.TabIndex = 40;
            this.btnappoint_check.Text = "確定預約";
            this.btnappoint_check.UseVisualStyleBackColor = true;
            this.btnappoint_check.Click += new System.EventHandler(this.btnappoint_check_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbbappoint_courses);
            this.groupBox5.Location = new System.Drawing.Point(168, 140);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(227, 47);
            this.groupBox5.TabIndex = 39;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "預約試聽課程*";
            // 
            // cbbappoint_courses
            // 
            this.cbbappoint_courses.FormattingEnabled = true;
            this.cbbappoint_courses.Location = new System.Drawing.Point(9, 21);
            this.cbbappoint_courses.Name = "cbbappoint_courses";
            this.cbbappoint_courses.Size = new System.Drawing.Size(218, 20);
            this.cbbappoint_courses.TabIndex = 24;
            this.cbbappoint_courses.Text = "---請選擇---";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            this.panel5.Location = new System.Drawing.Point(175, 82);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 3);
            this.panel5.TabIndex = 61;
            // 
            // txbappoint_name
            // 
            this.txbappoint_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbappoint_name.Location = new System.Drawing.Point(241, 64);
            this.txbappoint_name.MaxLength = 200;
            this.txbappoint_name.Name = "txbappoint_name";
            this.txbappoint_name.Size = new System.Drawing.Size(176, 15);
            this.txbappoint_name.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 59;
            this.label5.Text = "姓　　名*";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            this.panel4.Location = new System.Drawing.Point(175, 123);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 3);
            this.panel4.TabIndex = 58;
            // 
            // txbappoint_phone
            // 
            this.txbappoint_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbappoint_phone.Location = new System.Drawing.Point(235, 104);
            this.txbappoint_phone.MaxLength = 200;
            this.txbappoint_phone.Name = "txbappoint_phone";
            this.txbappoint_phone.Size = new System.Drawing.Size(176, 15);
            this.txbappoint_phone.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 56;
            this.label4.Text = "聯絡電話*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_其他);
            this.groupBox1.Controls.Add(this.rdb_親友);
            this.groupBox1.Controls.Add(this.rdb_文宣);
            this.groupBox1.Controls.Add(this.rdb_ig);
            this.groupBox1.Controls.Add(this.rdb_臉書);
            this.groupBox1.Location = new System.Drawing.Point(168, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 54);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "消息來源";
            // 
            // rdb_其他
            // 
            this.rdb_其他.AutoSize = true;
            this.rdb_其他.Location = new System.Drawing.Point(73, 32);
            this.rdb_其他.Name = "rdb_其他";
            this.rdb_其他.Size = new System.Drawing.Size(47, 16);
            this.rdb_其他.TabIndex = 4;
            this.rdb_其他.TabStop = true;
            this.rdb_其他.Text = "其他";
            this.rdb_其他.UseVisualStyleBackColor = true;
            // 
            // rdb_親友
            // 
            this.rdb_親友.AutoSize = true;
            this.rdb_親友.Location = new System.Drawing.Point(156, 14);
            this.rdb_親友.Name = "rdb_親友";
            this.rdb_親友.Size = new System.Drawing.Size(71, 16);
            this.rdb_親友.TabIndex = 3;
            this.rdb_親友.TabStop = true;
            this.rdb_親友.Text = "親朋好友";
            this.rdb_親友.UseVisualStyleBackColor = true;
            // 
            // rdb_文宣
            // 
            this.rdb_文宣.AutoSize = true;
            this.rdb_文宣.Location = new System.Drawing.Point(6, 32);
            this.rdb_文宣.Name = "rdb_文宣";
            this.rdb_文宣.Size = new System.Drawing.Size(47, 16);
            this.rdb_文宣.TabIndex = 2;
            this.rdb_文宣.TabStop = true;
            this.rdb_文宣.Text = "文宣";
            this.rdb_文宣.UseVisualStyleBackColor = true;
            // 
            // rdb_ig
            // 
            this.rdb_ig.AutoSize = true;
            this.rdb_ig.Location = new System.Drawing.Point(73, 14);
            this.rdb_ig.Name = "rdb_ig";
            this.rdb_ig.Size = new System.Drawing.Size(69, 16);
            this.rdb_ig.TabIndex = 1;
            this.rdb_ig.TabStop = true;
            this.rdb_ig.Text = "Instagram";
            this.rdb_ig.UseVisualStyleBackColor = true;
            // 
            // rdb_臉書
            // 
            this.rdb_臉書.AutoSize = true;
            this.rdb_臉書.Location = new System.Drawing.Point(7, 14);
            this.rdb_臉書.Name = "rdb_臉書";
            this.rdb_臉書.Size = new System.Drawing.Size(47, 16);
            this.rdb_臉書.TabIndex = 0;
            this.rdb_臉書.TabStop = true;
            this.rdb_臉書.Text = "臉書";
            this.rdb_臉書.UseVisualStyleBackColor = true;
            // 
            // appointUserContro1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txbappoint_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txbappoint_phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtp_appointment);
            this.Controls.Add(this.btnappoint_check);
            this.Controls.Add(this.groupBox5);
            this.Name = "appointUserContro1";
            this.Size = new System.Drawing.Size(600, 385);
            this.Load += new System.EventHandler(this.appointUserContro1_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtp_appointment;
        private System.Windows.Forms.Button btnappoint_check;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbbappoint_courses;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbappoint_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbappoint_phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_ig;
        private System.Windows.Forms.RadioButton rdb_臉書;
        private System.Windows.Forms.RadioButton rdb_其他;
        private System.Windows.Forms.RadioButton rdb_親友;
        private System.Windows.Forms.RadioButton rdb_文宣;
    }
}
