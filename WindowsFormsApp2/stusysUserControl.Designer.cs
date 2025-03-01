namespace WindowsFormsApp2
{
    partial class stusysUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stusysUserControl));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textFind關鍵字 = new System.Windows.Forms.TextBox();
            this.lbox進階搜尋結果 = new System.Windows.Forms.ListBox();
            this.txb_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_address = new System.Windows.Forms.TextBox();
            this.txb_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.txb_birthday = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbpassword = new System.Windows.Forms.TextBox();
            this.txbaccountnumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn儲存修改 = new System.Windows.Forms.Button();
            this.btn儲存新增 = new System.Windows.Forms.Button();
            this.btn新增資料 = new System.Windows.Forms.Button();
            this.btn刪除資料 = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textFind關鍵字);
            this.groupBox1.Controls.Add(this.lbox進階搜尋結果);
            this.groupBox1.Location = new System.Drawing.Point(5, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(136, 140);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜尋功能";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(103, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // textFind關鍵字
            // 
            this.textFind關鍵字.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textFind關鍵字.Location = new System.Drawing.Point(5, 24);
            this.textFind關鍵字.Margin = new System.Windows.Forms.Padding(4);
            this.textFind關鍵字.Name = "textFind關鍵字";
            this.textFind關鍵字.Size = new System.Drawing.Size(123, 25);
            this.textFind關鍵字.TabIndex = 0;
            this.textFind關鍵字.TextChanged += new System.EventHandler(this.textFind關鍵字_TextChanged);
            this.textFind關鍵字.Enter += new System.EventHandler(this.textFind關鍵字_Enter);
            this.textFind關鍵字.Leave += new System.EventHandler(this.textFind關鍵字_Leave);
            // 
            // lbox進階搜尋結果
            // 
            this.lbox進階搜尋結果.DisplayMember = "姓名";
            this.lbox進階搜尋結果.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox進階搜尋結果.FormattingEnabled = true;
            this.lbox進階搜尋結果.ItemHeight = 17;
            this.lbox進階搜尋結果.Location = new System.Drawing.Point(7, 55);
            this.lbox進階搜尋結果.Margin = new System.Windows.Forms.Padding(4);
            this.lbox進階搜尋結果.Name = "lbox進階搜尋結果";
            this.lbox進階搜尋結果.Size = new System.Drawing.Size(121, 72);
            this.lbox進階搜尋結果.TabIndex = 58;
            this.lbox進階搜尋結果.SelectedIndexChanged += new System.EventHandler(this.lbox進階搜尋結果_SelectedIndexChanged);
            // 
            // txb_id
            // 
            this.txb_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_id.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txb_id.Location = new System.Drawing.Point(182, 20);
            this.txb_id.Margin = new System.Windows.Forms.Padding(4);
            this.txb_id.MaxLength = 200;
            this.txb_id.Name = "txb_id";
            this.txb_id.ReadOnly = true;
            this.txb_id.Size = new System.Drawing.Size(173, 18);
            this.txb_id.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(149, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 17);
            this.label6.TabIndex = 74;
            this.label6.Text = "ID";
            // 
            // txb_name
            // 
            this.txb_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_name.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txb_name.Location = new System.Drawing.Point(182, 54);
            this.txb_name.Margin = new System.Windows.Forms.Padding(4);
            this.txb_name.MaxLength = 200;
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(173, 18);
            this.txb_name.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(149, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 70;
            this.label5.Text = "姓名";
            // 
            // txb_address
            // 
            this.txb_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_address.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txb_address.Location = new System.Drawing.Point(180, 132);
            this.txb_address.Margin = new System.Windows.Forms.Padding(4);
            this.txb_address.MaxLength = 200;
            this.txb_address.Name = "txb_address";
            this.txb_address.Size = new System.Drawing.Size(175, 18);
            this.txb_address.TabIndex = 68;
            // 
            // txb_phone
            // 
            this.txb_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_phone.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txb_phone.Location = new System.Drawing.Point(182, 92);
            this.txb_phone.Margin = new System.Windows.Forms.Padding(4);
            this.txb_phone.MaxLength = 200;
            this.txb_phone.Name = "txb_phone";
            this.txb_phone.Size = new System.Drawing.Size(173, 18);
            this.txb_phone.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(149, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 66;
            this.label3.Text = "地址";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(149, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 65;
            this.label4.Text = "電話";
            // 
            // txb_email
            // 
            this.txb_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_email.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txb_email.Location = new System.Drawing.Point(408, 53);
            this.txb_email.Margin = new System.Windows.Forms.Padding(4);
            this.txb_email.MaxLength = 200;
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(152, 18);
            this.txb_email.TabIndex = 62;
            // 
            // txb_birthday
            // 
            this.txb_birthday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_birthday.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txb_birthday.Location = new System.Drawing.Point(405, 20);
            this.txb_birthday.Margin = new System.Windows.Forms.Padding(4);
            this.txb_birthday.MaxLength = 200;
            this.txb_birthday.Name = "txb_birthday";
            this.txb_birthday.Size = new System.Drawing.Size(152, 18);
            this.txb_birthday.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(367, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 60;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(367, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 59;
            this.label1.Text = "生日";
            // 
            // txbpassword
            // 
            this.txbpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbpassword.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbpassword.Location = new System.Drawing.Point(403, 132);
            this.txbpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txbpassword.Name = "txbpassword";
            this.txbpassword.Size = new System.Drawing.Size(152, 18);
            this.txbpassword.TabIndex = 80;
            // 
            // txbaccountnumber
            // 
            this.txbaccountnumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbaccountnumber.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbaccountnumber.Location = new System.Drawing.Point(402, 92);
            this.txbaccountnumber.Margin = new System.Windows.Forms.Padding(4);
            this.txbaccountnumber.Name = "txbaccountnumber";
            this.txbaccountnumber.Size = new System.Drawing.Size(152, 18);
            this.txbaccountnumber.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(367, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 78;
            this.label7.Text = "密碼";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(367, 93);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 77;
            this.label8.Text = "帳號";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.btn儲存修改);
            this.panel7.Controls.Add(this.btn儲存新增);
            this.panel7.Controls.Add(this.btn新增資料);
            this.panel7.Controls.Add(this.btn刪除資料);
            this.panel7.Controls.Add(this.btn_refresh);
            this.panel7.Location = new System.Drawing.Point(586, 7);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(92, 158);
            this.panel7.TabIndex = 81;
            // 
            // btn儲存修改
            // 
            this.btn儲存修改.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn儲存修改.FlatAppearance.BorderSize = 0;
            this.btn儲存修改.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn儲存修改.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn儲存修改.ForeColor = System.Drawing.Color.Green;
            this.btn儲存修改.Location = new System.Drawing.Point(0, 74);
            this.btn儲存修改.Name = "btn儲存修改";
            this.btn儲存修改.Size = new System.Drawing.Size(92, 28);
            this.btn儲存修改.TabIndex = 15;
            this.btn儲存修改.Text = "儲存修改";
            this.btn儲存修改.UseVisualStyleBackColor = true;
            this.btn儲存修改.Click += new System.EventHandler(this.btn儲存修改_Click);
            // 
            // btn儲存新增
            // 
            this.btn儲存新增.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn儲存新增.FlatAppearance.BorderSize = 0;
            this.btn儲存新增.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn儲存新增.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn儲存新增.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(92)))), ((int)(((byte)(30)))));
            this.btn儲存新增.Location = new System.Drawing.Point(0, 28);
            this.btn儲存新增.Name = "btn儲存新增";
            this.btn儲存新增.Size = new System.Drawing.Size(92, 28);
            this.btn儲存新增.TabIndex = 19;
            this.btn儲存新增.Text = "儲存新增";
            this.btn儲存新增.UseVisualStyleBackColor = true;
            this.btn儲存新增.Click += new System.EventHandler(this.btn儲存新增_Click);
            // 
            // btn新增資料
            // 
            this.btn新增資料.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn新增資料.FlatAppearance.BorderSize = 0;
            this.btn新增資料.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn新增資料.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增資料.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(92)))), ((int)(((byte)(30)))));
            this.btn新增資料.Location = new System.Drawing.Point(0, 0);
            this.btn新增資料.Name = "btn新增資料";
            this.btn新增資料.Size = new System.Drawing.Size(92, 28);
            this.btn新增資料.TabIndex = 12;
            this.btn新增資料.Text = "新增資料";
            this.btn新增資料.UseVisualStyleBackColor = true;
            this.btn新增資料.Click += new System.EventHandler(this.btn新增資料_Click);
            // 
            // btn刪除資料
            // 
            this.btn刪除資料.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn刪除資料.FlatAppearance.BorderSize = 0;
            this.btn刪除資料.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn刪除資料.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除資料.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn刪除資料.Location = new System.Drawing.Point(0, 102);
            this.btn刪除資料.Name = "btn刪除資料";
            this.btn刪除資料.Size = new System.Drawing.Size(92, 28);
            this.btn刪除資料.TabIndex = 17;
            this.btn刪除資料.Text = "刪除資料";
            this.btn刪除資料.UseVisualStyleBackColor = true;
            this.btn刪除資料.Click += new System.EventHandler(this.btn刪除資料_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(92)))), ((int)(((byte)(30)))));
            this.btn_refresh.Location = new System.Drawing.Point(0, 130);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(92, 28);
            this.btn_refresh.TabIndex = 18;
            this.btn_refresh.Text = "重新整理";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // stusysUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txbpassword);
            this.Controls.Add(this.txbaccountnumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txb_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_address);
            this.Controls.Add(this.txb_phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_email);
            this.Controls.Add(this.txb_birthday);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "stusysUserControl";
            this.Size = new System.Drawing.Size(700, 513);
            this.Load += new System.EventHandler(this.stusysUserControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textFind關鍵字;
        private System.Windows.Forms.ListBox lbox進階搜尋結果;
        private System.Windows.Forms.TextBox txb_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_address;
        private System.Windows.Forms.TextBox txb_phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.TextBox txb_birthday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbpassword;
        private System.Windows.Forms.TextBox txbaccountnumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn刪除資料;
        private System.Windows.Forms.Button btn儲存修改;
        private System.Windows.Forms.Button btn新增資料;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn儲存新增;
    }
}
