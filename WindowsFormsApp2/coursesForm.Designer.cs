namespace WindowsFormsApp2
{
    partial class coursesForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_deletecourse = new System.Windows.Forms.Button();
            this.btn_editcourse = new System.Windows.Forms.Button();
            this.btn_addcourse = new System.Windows.Forms.Button();
            this.listView_course = new System.Windows.Forms.ListView();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(183)))), ((int)(((byte)(130)))));
            this.panel2.Controls.Add(this.btn_refresh);
            this.panel2.Controls.Add(this.btn_deletecourse);
            this.panel2.Controls.Add(this.btn_editcourse);
            this.panel2.Controls.Add(this.btn_addcourse);
            this.panel2.Location = new System.Drawing.Point(461, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 177);
            this.panel2.TabIndex = 9;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(92)))), ((int)(((byte)(30)))));
            this.btn_refresh.Location = new System.Drawing.Point(0, 120);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(100, 40);
            this.btn_refresh.TabIndex = 18;
            this.btn_refresh.Text = "重新整理";
            this.btn_refresh.UseVisualStyleBackColor = true;
            // 
            // btn_deletecourse
            // 
            this.btn_deletecourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_deletecourse.FlatAppearance.BorderSize = 0;
            this.btn_deletecourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletecourse.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_deletecourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_deletecourse.Location = new System.Drawing.Point(0, 80);
            this.btn_deletecourse.Name = "btn_deletecourse";
            this.btn_deletecourse.Size = new System.Drawing.Size(100, 40);
            this.btn_deletecourse.TabIndex = 17;
            this.btn_deletecourse.Text = "刪除課程";
            this.btn_deletecourse.UseVisualStyleBackColor = true;
            // 
            // btn_editcourse
            // 
            this.btn_editcourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_editcourse.FlatAppearance.BorderSize = 0;
            this.btn_editcourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editcourse.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_editcourse.ForeColor = System.Drawing.Color.Green;
            this.btn_editcourse.Location = new System.Drawing.Point(0, 40);
            this.btn_editcourse.Name = "btn_editcourse";
            this.btn_editcourse.Size = new System.Drawing.Size(100, 40);
            this.btn_editcourse.TabIndex = 15;
            this.btn_editcourse.Text = "修改課程";
            this.btn_editcourse.UseVisualStyleBackColor = true;
            // 
            // btn_addcourse
            // 
            this.btn_addcourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_addcourse.FlatAppearance.BorderSize = 0;
            this.btn_addcourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addcourse.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_addcourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(92)))), ((int)(((byte)(30)))));
            this.btn_addcourse.Location = new System.Drawing.Point(0, 0);
            this.btn_addcourse.Name = "btn_addcourse";
            this.btn_addcourse.Size = new System.Drawing.Size(100, 40);
            this.btn_addcourse.TabIndex = 12;
            this.btn_addcourse.Text = "新增課程";
            this.btn_addcourse.UseVisualStyleBackColor = true;
            // 
            // listView_course
            // 
            this.listView_course.HideSelection = false;
            this.listView_course.Location = new System.Drawing.Point(28, 34);
            this.listView_course.Name = "listView_course";
            this.listView_course.Size = new System.Drawing.Size(383, 337);
            this.listView_course.TabIndex = 8;
            this.listView_course.UseCompatibleStateImageBehavior = false;
            this.listView_course.SelectedIndexChanged += new System.EventHandler(this.listView_course_SelectedIndexChanged);
            // 
            // coursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 356);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listView_course);
            this.Name = "coursesForm";
            this.Text = "coursesForm";
            this.Load += new System.EventHandler(this.coursesForm_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_deletecourse;
        private System.Windows.Forms.Button btn_editcourse;
        private System.Windows.Forms.Button btn_addcourse;
        private System.Windows.Forms.ListView listView_course;
    }
}