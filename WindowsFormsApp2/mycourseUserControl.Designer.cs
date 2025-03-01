namespace WindowsFormsApp2
{
    partial class mycourseUserControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton_next = new FontAwesome.Sharp.IconButton();
            this.iconButton_prev = new FontAwesome.Sharp.IconButton();
            this.lblMonth = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.courselistUserControl1 = new WindowsFormsApp2.courselistUserControl();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Monday";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(328, 42);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(269, 144);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(402, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tuesday";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(434, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Wednesday";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(478, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Thuresday";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(519, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Friday";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tw Cen MT", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(549, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Saturday";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(318, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sunday";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // iconButton_next
            // 
            this.iconButton_next.AutoSize = true;
            this.iconButton_next.FlatAppearance.BorderSize = 0;
            this.iconButton_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_next.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.iconButton_next.IconColor = System.Drawing.Color.Chocolate;
            this.iconButton_next.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_next.IconSize = 15;
            this.iconButton_next.Location = new System.Drawing.Point(340, 5);
            this.iconButton_next.Name = "iconButton_next";
            this.iconButton_next.Size = new System.Drawing.Size(25, 25);
            this.iconButton_next.TabIndex = 30;
            this.iconButton_next.UseVisualStyleBackColor = true;
            this.iconButton_next.Click += new System.EventHandler(this.iconButton_next_Click_1);
            // 
            // iconButton_prev
            // 
            this.iconButton_prev.AutoSize = true;
            this.iconButton_prev.FlatAppearance.BorderSize = 0;
            this.iconButton_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_prev.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.iconButton_prev.IconColor = System.Drawing.Color.Chocolate;
            this.iconButton_prev.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_prev.IconSize = 15;
            this.iconButton_prev.Location = new System.Drawing.Point(323, 5);
            this.iconButton_prev.Name = "iconButton_prev";
            this.iconButton_prev.Size = new System.Drawing.Size(25, 25);
            this.iconButton_prev.TabIndex = 29;
            this.iconButton_prev.UseVisualStyleBackColor = true;
            this.iconButton_prev.Click += new System.EventHandler(this.iconButton_prev_Click_1);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMonth.Location = new System.Drawing.Point(362, 8);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(55, 16);
            this.lblMonth.TabIndex = 28;
            this.lblMonth.Text = "MONTH";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Controls.Add(this.courselistUserControl1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 20);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(319, 352);
            this.flowLayoutPanel2.TabIndex = 31;
            // 
            // courselistUserControl1
            // 
            this.courselistUserControl1.BackColor = System.Drawing.Color.White;
            this.courselistUserControl1.Fee = null;
            this.courselistUserControl1.Icon = null;
            this.courselistUserControl1.IconPath = null;
            this.courselistUserControl1.Intro = null;
            this.courselistUserControl1.Location = new System.Drawing.Point(3, 3);
            this.courselistUserControl1.Name = "courselistUserControl1";
            this.courselistUserControl1.Size = new System.Drawing.Size(311, 113);
            this.courselistUserControl1.Start = null;
            this.courselistUserControl1.TabIndex = 0;
            this.courselistUserControl1.Title = null;
            // 
            // mycourseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.iconButton_next);
            this.Controls.Add(this.iconButton_prev);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "mycourseUserControl";
            this.Size = new System.Drawing.Size(600, 385);
            this.Load += new System.EventHandler(this.mycourseUserControl_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton_next;
        private FontAwesome.Sharp.IconButton iconButton_prev;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private courselistUserControl courselistUserControl1;
    }
}
