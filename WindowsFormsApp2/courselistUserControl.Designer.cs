namespace WindowsFormsApp2
{
    partial class courselistUserControl
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
            this.lbl_courseintro = new System.Windows.Forms.Label();
            this.lbl_coursename = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_fee = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_start = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_courseintro
            // 
            this.lbl_courseintro.AutoEllipsis = true;
            this.lbl_courseintro.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_courseintro.Location = new System.Drawing.Point(0, 0);
            this.lbl_courseintro.Name = "lbl_courseintro";
            this.lbl_courseintro.Size = new System.Drawing.Size(295, 14);
            this.lbl_courseintro.TabIndex = 9;
            this.lbl_courseintro.Text = "介紹:";
            // 
            // lbl_coursename
            // 
            this.lbl_coursename.AutoEllipsis = true;
            this.lbl_coursename.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_coursename.Location = new System.Drawing.Point(167, 9);
            this.lbl_coursename.Name = "lbl_coursename";
            this.lbl_coursename.Size = new System.Drawing.Size(392, 23);
            this.lbl_coursename.TabIndex = 8;
            this.lbl_coursename.Text = "課程名稱";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 101);
            this.panel1.TabIndex = 10;
            // 
            // lbl_fee
            // 
            this.lbl_fee.AutoEllipsis = true;
            this.lbl_fee.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_fee.Location = new System.Drawing.Point(0, 20);
            this.lbl_fee.Name = "lbl_fee";
            this.lbl_fee.Size = new System.Drawing.Size(295, 16);
            this.lbl_fee.TabIndex = 12;
            this.lbl_fee.Text = "費用:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_start);
            this.panel3.Controls.Add(this.lbl_fee);
            this.panel3.Controls.Add(this.lbl_courseintro);
            this.panel3.Location = new System.Drawing.Point(164, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 75);
            this.panel3.TabIndex = 13;
            // 
            // lbl_start
            // 
            this.lbl_start.AutoEllipsis = true;
            this.lbl_start.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_start.Location = new System.Drawing.Point(0, 42);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(295, 16);
            this.lbl_start.TabIndex = 13;
            this.lbl_start.Text = "開課:";
            // 
            // courselistUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lbl_coursename);
            this.Controls.Add(this.panel1);
            this.Name = "courselistUserControl";
            this.Size = new System.Drawing.Size(570, 112);
            this.Load += new System.EventHandler(this.courselistUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_courseintro;
        private System.Windows.Forms.Label lbl_coursename;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_fee;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_start;
    }
}
