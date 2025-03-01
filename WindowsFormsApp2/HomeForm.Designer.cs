namespace WindowsFormsApp2
{
    partial class HomeForm
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_管理權限 = new System.Windows.Forms.Button();
            this.btn_預約管理 = new System.Windows.Forms.Button();
            this.btn_課程管理 = new System.Windows.Forms.Button();
            this.btn_學生管理 = new System.Windows.Forms.Button();
            this.btn_設定管理 = new System.Windows.Forms.Button();
            this.btn_課程一覽2改 = new System.Windows.Forms.Button();
            this.btn_registration = new System.Windows.Forms.Button();
            this.btn_appointForm = new System.Windows.Forms.Button();
            this.btn_coursesform = new System.Windows.Forms.Button();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton_login = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconButton_logout = new FontAwesome.Sharp.IconButton();
            this.iconButton_mycourse = new FontAwesome.Sharp.IconButton();
            this.iconButton_stuinfo = new FontAwesome.Sharp.IconButton();
            this.iconButton_signup = new FontAwesome.Sharp.IconButton();
            this.panelform = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelform.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(183)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 120);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(70)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 3);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(109)))));
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.btn_設定管理);
            this.panel2.Controls.Add(this.btn_課程一覽2改);
            this.panel2.Controls.Add(this.btn_registration);
            this.panel2.Controls.Add(this.btn_appointForm);
            this.panel2.Controls.Add(this.btn_coursesform);
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 425);
            this.panel2.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_管理權限);
            this.panel6.Controls.Add(this.btn_預約管理);
            this.panel6.Controls.Add(this.btn_課程管理);
            this.panel6.Controls.Add(this.btn_學生管理);
            this.panel6.Location = new System.Drawing.Point(0, 240);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(100, 158);
            this.panel6.TabIndex = 18;
            // 
            // btn_管理權限
            // 
            this.btn_管理權限.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(205)))), ((int)(((byte)(153)))));
            this.btn_管理權限.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_管理權限.FlatAppearance.BorderSize = 0;
            this.btn_管理權限.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_管理權限.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_管理權限.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(92)))), ((int)(((byte)(30)))));
            this.btn_管理權限.Location = new System.Drawing.Point(0, 120);
            this.btn_管理權限.Name = "btn_管理權限";
            this.btn_管理權限.Size = new System.Drawing.Size(100, 40);
            this.btn_管理權限.TabIndex = 20;
            this.btn_管理權限.Text = "管理權限";
            this.btn_管理權限.UseVisualStyleBackColor = false;
            this.btn_管理權限.Click += new System.EventHandler(this.btn_管理權限_Click);
            // 
            // btn_預約管理
            // 
            this.btn_預約管理.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(205)))), ((int)(((byte)(153)))));
            this.btn_預約管理.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_預約管理.FlatAppearance.BorderSize = 0;
            this.btn_預約管理.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_預約管理.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_預約管理.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(92)))), ((int)(((byte)(30)))));
            this.btn_預約管理.Location = new System.Drawing.Point(0, 80);
            this.btn_預約管理.Name = "btn_預約管理";
            this.btn_預約管理.Size = new System.Drawing.Size(100, 40);
            this.btn_預約管理.TabIndex = 19;
            this.btn_預約管理.Text = "預約管理";
            this.btn_預約管理.UseVisualStyleBackColor = false;
            this.btn_預約管理.Click += new System.EventHandler(this.btn_預約管理_Click);
            // 
            // btn_課程管理
            // 
            this.btn_課程管理.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(205)))), ((int)(((byte)(153)))));
            this.btn_課程管理.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_課程管理.FlatAppearance.BorderSize = 0;
            this.btn_課程管理.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_課程管理.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_課程管理.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(92)))), ((int)(((byte)(30)))));
            this.btn_課程管理.Location = new System.Drawing.Point(0, 40);
            this.btn_課程管理.Name = "btn_課程管理";
            this.btn_課程管理.Size = new System.Drawing.Size(100, 40);
            this.btn_課程管理.TabIndex = 18;
            this.btn_課程管理.Text = "課程管理";
            this.btn_課程管理.UseVisualStyleBackColor = false;
            this.btn_課程管理.Click += new System.EventHandler(this.btn_課程管理_Click);
            // 
            // btn_學生管理
            // 
            this.btn_學生管理.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(205)))), ((int)(((byte)(153)))));
            this.btn_學生管理.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_學生管理.FlatAppearance.BorderSize = 0;
            this.btn_學生管理.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_學生管理.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_學生管理.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(92)))), ((int)(((byte)(30)))));
            this.btn_學生管理.Location = new System.Drawing.Point(0, 0);
            this.btn_學生管理.Name = "btn_學生管理";
            this.btn_學生管理.Size = new System.Drawing.Size(100, 40);
            this.btn_學生管理.TabIndex = 17;
            this.btn_學生管理.Text = "學生管理";
            this.btn_學生管理.UseVisualStyleBackColor = false;
            this.btn_學生管理.Click += new System.EventHandler(this.btn_學生管理_Click);
            // 
            // btn_設定管理
            // 
            this.btn_設定管理.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_設定管理.FlatAppearance.BorderSize = 0;
            this.btn_設定管理.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_設定管理.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_設定管理.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(92)))), ((int)(((byte)(30)))));
            this.btn_設定管理.Location = new System.Drawing.Point(0, 200);
            this.btn_設定管理.Name = "btn_設定管理";
            this.btn_設定管理.Size = new System.Drawing.Size(100, 40);
            this.btn_設定管理.TabIndex = 17;
            this.btn_設定管理.Text = "設定管理";
            this.btn_設定管理.UseVisualStyleBackColor = true;
            this.btn_設定管理.Click += new System.EventHandler(this.btn_設定管理_Click);
            // 
            // btn_課程一覽2改
            // 
            this.btn_課程一覽2改.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_課程一覽2改.FlatAppearance.BorderSize = 0;
            this.btn_課程一覽2改.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_課程一覽2改.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_課程一覽2改.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(92)))), ((int)(((byte)(30)))));
            this.btn_課程一覽2改.Location = new System.Drawing.Point(0, 160);
            this.btn_課程一覽2改.Name = "btn_課程一覽2改";
            this.btn_課程一覽2改.Size = new System.Drawing.Size(100, 40);
            this.btn_課程一覽2改.TabIndex = 15;
            this.btn_課程一覽2改.Text = "課程一覽";
            this.btn_課程一覽2改.UseVisualStyleBackColor = true;
            this.btn_課程一覽2改.Click += new System.EventHandler(this.btn_課程一覽2改_Click);
            // 
            // btn_registration
            // 
            this.btn_registration.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_registration.FlatAppearance.BorderSize = 0;
            this.btn_registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registration.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_registration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(92)))), ((int)(((byte)(30)))));
            this.btn_registration.Location = new System.Drawing.Point(0, 120);
            this.btn_registration.Name = "btn_registration";
            this.btn_registration.Size = new System.Drawing.Size(100, 40);
            this.btn_registration.TabIndex = 14;
            this.btn_registration.Text = "我要報名";
            this.btn_registration.UseVisualStyleBackColor = true;
            this.btn_registration.Click += new System.EventHandler(this.btn_registration_Click);
            // 
            // btn_appointForm
            // 
            this.btn_appointForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_appointForm.FlatAppearance.BorderSize = 0;
            this.btn_appointForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_appointForm.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_appointForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(92)))), ((int)(((byte)(30)))));
            this.btn_appointForm.Location = new System.Drawing.Point(0, 80);
            this.btn_appointForm.Name = "btn_appointForm";
            this.btn_appointForm.Size = new System.Drawing.Size(100, 40);
            this.btn_appointForm.TabIndex = 13;
            this.btn_appointForm.Text = "我要預約";
            this.btn_appointForm.UseVisualStyleBackColor = true;
            this.btn_appointForm.Click += new System.EventHandler(this.btn_appointForm_Click);
            // 
            // btn_coursesform
            // 
            this.btn_coursesform.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_coursesform.FlatAppearance.BorderSize = 0;
            this.btn_coursesform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_coursesform.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_coursesform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(92)))), ((int)(((byte)(30)))));
            this.btn_coursesform.Location = new System.Drawing.Point(0, 40);
            this.btn_coursesform.Name = "btn_coursesform";
            this.btn_coursesform.Size = new System.Drawing.Size(100, 40);
            this.btn_coursesform.TabIndex = 12;
            this.btn_coursesform.Text = "課程一覽";
            this.btn_coursesform.UseVisualStyleBackColor = true;
            this.btn_coursesform.Click += new System.EventHandler(this.btn_coursesform_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(92)))), ((int)(((byte)(30)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(92)))), ((int)(((byte)(30)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 40;
            this.iconButton2.Location = new System.Drawing.Point(0, 0);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(100, 40);
            this.iconButton2.TabIndex = 5;
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton_login
            // 
            this.iconButton_login.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton_login.FlatAppearance.BorderSize = 0;
            this.iconButton_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_login.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.iconButton_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(92)))), ((int)(((byte)(30)))));
            this.iconButton_login.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconButton_login.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(92)))), ((int)(((byte)(30)))));
            this.iconButton_login.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_login.IconSize = 25;
            this.iconButton_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_login.Location = new System.Drawing.Point(600, 0);
            this.iconButton_login.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton_login.Name = "iconButton_login";
            this.iconButton_login.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.iconButton_login.Size = new System.Drawing.Size(100, 40);
            this.iconButton_login.TabIndex = 0;
            this.iconButton_login.Text = "登入";
            this.iconButton_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_login.UseVisualStyleBackColor = true;
            this.iconButton_login.Click += new System.EventHandler(this.iconButton_login_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(109)))));
            this.panel4.Controls.Add(this.iconButton_login);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(100, 123);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(700, 40);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.iconButton_logout);
            this.panel5.Controls.Add(this.iconButton_mycourse);
            this.panel5.Controls.Add(this.iconButton_stuinfo);
            this.panel5.Controls.Add(this.iconButton_signup);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(700, 163);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 385);
            this.panel5.TabIndex = 8;
            // 
            // iconButton_logout
            // 
            this.iconButton_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(205)))), ((int)(((byte)(153)))));
            this.iconButton_logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_logout.FlatAppearance.BorderSize = 0;
            this.iconButton_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_logout.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.iconButton_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(92)))), ((int)(((byte)(30)))));
            this.iconButton_logout.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.iconButton_logout.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(92)))), ((int)(((byte)(30)))));
            this.iconButton_logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_logout.IconSize = 20;
            this.iconButton_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_logout.Location = new System.Drawing.Point(0, 90);
            this.iconButton_logout.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton_logout.Name = "iconButton_logout";
            this.iconButton_logout.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButton_logout.Size = new System.Drawing.Size(100, 30);
            this.iconButton_logout.TabIndex = 4;
            this.iconButton_logout.Text = "登出";
            this.iconButton_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_logout.UseVisualStyleBackColor = false;
            this.iconButton_logout.Click += new System.EventHandler(this.iconButton_logout_Click);
            // 
            // iconButton_mycourse
            // 
            this.iconButton_mycourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(205)))), ((int)(((byte)(153)))));
            this.iconButton_mycourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_mycourse.FlatAppearance.BorderSize = 0;
            this.iconButton_mycourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_mycourse.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.iconButton_mycourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(92)))), ((int)(((byte)(30)))));
            this.iconButton_mycourse.IconChar = FontAwesome.Sharp.IconChar.CalendarWeek;
            this.iconButton_mycourse.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(92)))), ((int)(((byte)(30)))));
            this.iconButton_mycourse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_mycourse.IconSize = 20;
            this.iconButton_mycourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_mycourse.Location = new System.Drawing.Point(0, 60);
            this.iconButton_mycourse.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton_mycourse.Name = "iconButton_mycourse";
            this.iconButton_mycourse.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.iconButton_mycourse.Size = new System.Drawing.Size(100, 30);
            this.iconButton_mycourse.TabIndex = 3;
            this.iconButton_mycourse.Text = "我的課程";
            this.iconButton_mycourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_mycourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_mycourse.UseVisualStyleBackColor = false;
            this.iconButton_mycourse.Click += new System.EventHandler(this.iconButton_mycourse_Click);
            // 
            // iconButton_stuinfo
            // 
            this.iconButton_stuinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(205)))), ((int)(((byte)(153)))));
            this.iconButton_stuinfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_stuinfo.FlatAppearance.BorderSize = 0;
            this.iconButton_stuinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_stuinfo.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.iconButton_stuinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(92)))), ((int)(((byte)(30)))));
            this.iconButton_stuinfo.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.iconButton_stuinfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(92)))), ((int)(((byte)(30)))));
            this.iconButton_stuinfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_stuinfo.IconSize = 20;
            this.iconButton_stuinfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_stuinfo.Location = new System.Drawing.Point(0, 30);
            this.iconButton_stuinfo.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton_stuinfo.Name = "iconButton_stuinfo";
            this.iconButton_stuinfo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButton_stuinfo.Size = new System.Drawing.Size(100, 30);
            this.iconButton_stuinfo.TabIndex = 2;
            this.iconButton_stuinfo.Text = "基本資料";
            this.iconButton_stuinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_stuinfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_stuinfo.UseVisualStyleBackColor = false;
            this.iconButton_stuinfo.Click += new System.EventHandler(this.iconButton_stuinfo_Click);
            // 
            // iconButton_signup
            // 
            this.iconButton_signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(109)))));
            this.iconButton_signup.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton_signup.FlatAppearance.BorderSize = 0;
            this.iconButton_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_signup.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.iconButton_signup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(92)))), ((int)(((byte)(30)))));
            this.iconButton_signup.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButton_signup.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(92)))), ((int)(((byte)(30)))));
            this.iconButton_signup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_signup.IconSize = 20;
            this.iconButton_signup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_signup.Location = new System.Drawing.Point(0, 0);
            this.iconButton_signup.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton_signup.Name = "iconButton_signup";
            this.iconButton_signup.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButton_signup.Size = new System.Drawing.Size(100, 30);
            this.iconButton_signup.TabIndex = 9;
            this.iconButton_signup.Text = "建新帳號";
            this.iconButton_signup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_signup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_signup.UseVisualStyleBackColor = false;
            this.iconButton_signup.Click += new System.EventHandler(this.iconButton_signup_Click);
            // 
            // panelform
            // 
            this.panelform.AutoScroll = true;
            this.panelform.AutoSize = true;
            this.panelform.Controls.Add(this.flowLayoutPanel1);
            this.panelform.Controls.Add(this.label1);
            this.panelform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelform.Location = new System.Drawing.Point(100, 163);
            this.panelform.Name = "panelform";
            this.panelform.Size = new System.Drawing.Size(600, 385);
            this.panelform.TabIndex = 9;
            this.panelform.Paint += new System.Windows.Forms.PaintEventHandler(this.panelform_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(588, 364);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "homeformpanel";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.panelform);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Home_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Home_MouseMove);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panelform.ResumeLayout(false);
            this.panelform.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_課程一覽2改;
        private System.Windows.Forms.Button btn_registration;
        private System.Windows.Forms.Button btn_appointForm;
        private System.Windows.Forms.Button btn_coursesform;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton_login;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton iconButton_mycourse;
        private FontAwesome.Sharp.IconButton iconButton_logout;
        private System.Windows.Forms.Panel panelform;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_管理權限;
        private System.Windows.Forms.Button btn_預約管理;
        private System.Windows.Forms.Button btn_課程管理;
        private System.Windows.Forms.Button btn_學生管理;
        private System.Windows.Forms.Button btn_設定管理;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton_signup;
        private FontAwesome.Sharp.IconButton iconButton_stuinfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}

