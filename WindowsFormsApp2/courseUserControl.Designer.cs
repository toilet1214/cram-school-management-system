namespace WindowsFormsApp2
{
    partial class courseUserControl
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
            this.components = new System.ComponentModel.Container();
            this.image課程圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbb_subject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_department = new System.Windows.Forms.ComboBox();
            this.courselistUserControl1 = new WindowsFormsApp2.courselistUserControl();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // image課程圖檔
            // 
            this.image課程圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.image課程圖檔.ImageSize = new System.Drawing.Size(16, 16);
            this.image課程圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.courselistUserControl1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 32);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(594, 350);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbb_subject);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbb_department);
            this.panel1.Location = new System.Drawing.Point(6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 30);
            this.panel1.TabIndex = 1;
            // 
            // cbb_subject
            // 
            this.cbb_subject.FormattingEnabled = true;
            this.cbb_subject.Location = new System.Drawing.Point(210, 3);
            this.cbb_subject.Name = "cbb_subject";
            this.cbb_subject.Size = new System.Drawing.Size(107, 20);
            this.cbb_subject.TabIndex = 4;
            this.cbb_subject.Text = "---請選擇---";
            this.cbb_subject.SelectedIndexChanged += new System.EventHandler(this.cbb_subject_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "年級";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "科目";
            // 
            // cbb_department
            // 
            this.cbb_department.FormattingEnabled = true;
            this.cbb_department.Location = new System.Drawing.Point(48, 3);
            this.cbb_department.Name = "cbb_department";
            this.cbb_department.Size = new System.Drawing.Size(107, 20);
            this.cbb_department.TabIndex = 0;
            this.cbb_department.Text = "---請選擇---";
            this.cbb_department.SelectedIndexChanged += new System.EventHandler(this.cbb_department_SelectedIndexChanged);
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
            this.courselistUserControl1.Size = new System.Drawing.Size(590, 116);
            this.courselistUserControl1.Start = null;
            this.courselistUserControl1.TabIndex = 0;
            this.courselistUserControl1.Title = null;
            this.courselistUserControl1.Load += new System.EventHandler(this.courselistUserControl1_Load);
            // 
            // courseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "courseUserControl";
            this.Size = new System.Drawing.Size(600, 385);
            this.Load += new System.EventHandler(this.courseUserControl_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList image課程圖檔;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_department;
        private courselistUserControl courselistUserControl1;
        private System.Windows.Forms.ComboBox cbb_subject;
    }
}
