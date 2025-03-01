namespace WindowsFormsApp2
{
    partial class appointForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnappoint_check = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbbappoint_courses = new System.Windows.Forms.ComboBox();
            this.txbappoint_phone = new System.Windows.Forms.TextBox();
            this.txbappoint_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "appointform";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(153, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 34;
            this.label12.Text = "預約時間*";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(221, 211);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 22);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(153, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 32;
            this.label8.Text = "消息來源";
            // 
            // btnappoint_check
            // 
            this.btnappoint_check.Location = new System.Drawing.Point(221, 286);
            this.btnappoint_check.Name = "btnappoint_check";
            this.btnappoint_check.Size = new System.Drawing.Size(75, 23);
            this.btnappoint_check.TabIndex = 31;
            this.btnappoint_check.Text = "確定預約";
            this.btnappoint_check.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbbappoint_courses);
            this.groupBox5.Location = new System.Drawing.Point(146, 142);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(243, 47);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "預約試聽課程*";
            // 
            // cbbappoint_courses
            // 
            this.cbbappoint_courses.FormattingEnabled = true;
            this.cbbappoint_courses.Location = new System.Drawing.Point(9, 21);
            this.cbbappoint_courses.Name = "cbbappoint_courses";
            this.cbbappoint_courses.Size = new System.Drawing.Size(234, 20);
            this.cbbappoint_courses.TabIndex = 24;
            this.cbbappoint_courses.Text = "---請選擇---";
            // 
            // txbappoint_phone
            // 
            this.txbappoint_phone.Location = new System.Drawing.Point(155, 112);
            this.txbappoint_phone.Name = "txbappoint_phone";
            this.txbappoint_phone.Size = new System.Drawing.Size(234, 22);
            this.txbappoint_phone.TabIndex = 29;
            // 
            // txbappoint_name
            // 
            this.txbappoint_name.Location = new System.Drawing.Point(155, 65);
            this.txbappoint_name.Name = "txbappoint_name";
            this.txbappoint_name.Size = new System.Drawing.Size(234, 22);
            this.txbappoint_name.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 26;
            this.label6.Text = "學生姓名*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "聯絡電話*";
            // 
            // appointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 346);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnappoint_check);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.txbappoint_phone);
            this.Controls.Add(this.txbappoint_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "appointForm";
            this.Text = "appointForm";
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnappoint_check;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbbappoint_courses;
        private System.Windows.Forms.TextBox txbappoint_phone;
        private System.Windows.Forms.TextBox txbappoint_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}