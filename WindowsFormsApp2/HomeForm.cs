using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;  //icon命名
//using System.Runtime.InteropServices;  //設定表單無邊框和標題欄 命名
using System.Collections;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class HomeForm : Form
    {

        public HomeForm()
        {
            InitializeComponent();



            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();

            


            customizeDesing();  //右panel可視            
            UpdateLoginButtonVisibility(); // 檢查登入狀態並更新按鈕狀態
            courseslist();

            // 設定表單無邊框和標題欄
            //this.FormBorderStyle = FormBorderStyle.None;
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

            //MostrarLogo();  //右上叉叉
            
        }

        // 用來設置新的控制項到 panelform 中的方法
        public void SetPanelControl(Control control)
        {
            panelform.Controls.Clear(); // 清空現有控制項
            panelform.Controls.Add(control); // 加入新的控制項
            control.Dock = DockStyle.Fill; // 讓控制項填滿 panelform
        }

        private void UpdateLoginButtonVisibility()
        {
            #region 右iconbutton登入/未登入顯示
            if (GlobalVar.is登入成功)
            {
                // 判斷使用者權限
                if (GlobalVar.使用者權限 == "老師")
                {
                    MessageBox.Show("老師登入");
                    // 老師登入後顯示這些控件
                    btn_設定管理.Visible = true;  // 顯示設定管理按鈕
                    iconButton_signup.Visible = false;  // 隱藏註冊按鈕
                    iconButton_stuinfo.Visible = false;  // 隱藏學生資料按鈕
                    iconButton_mycourse.Visible = false;  // 隱藏我的課程按鈕
                    iconButton_logout.Visible = true;  // 顯示登出按鈕
                }
                else if (GlobalVar.使用者權限 == "學生")
                {
                    // 學生登入後顯示這些控件
                    btn_設定管理.Visible = false;  // 隱藏設定管理按鈕
                    iconButton_signup.Visible = false;  // 隱藏註冊按鈕
                    iconButton_stuinfo.Visible = true;  // 顯示學生資料按鈕
                    iconButton_mycourse.Visible = true;  // 顯示我的課程按鈕
                    iconButton_logout.Visible = true;  // 顯示登出按鈕
                }
            }
            else
            {
                // 如果未登入，顯示註冊按鈕，隱藏其他控件
                btn_設定管理.Visible = true;  // 隱藏設定管理按鈕
                iconButton_signup.Visible = true;  // 顯示註冊按鈕
                iconButton_stuinfo.Visible = false;  // 隱藏學生資料按鈕
                iconButton_mycourse.Visible = false;  // 隱藏我的課程按鈕
                iconButton_logout.Visible = false;  // 隱藏登出按鈕
            }
            #endregion  
        }

        #region  mutiform in panel
        // me todo para abrir formularios dentro del panel
        private void AbrirFormulario<Miform>() where Miform : Form, new()
        {
            Form formulario = panelform.Controls.OfType<Form>().FirstOrDefault(f => f is Miform); //busca en la colection el formulario在集合搜尋form
            //si el formulario/instanc ia no existe  如果form不存在
            if (formulario == null)
            { 
                formulario = new Miform();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelform.Controls.Add(formulario);
                panelform.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }            
            else
            {
                // 如果窗體已經存在，將其帶到前面
                formulario.BringToFront();
            }
        }
        //multi forms 子窗體
        private void AbrirFormInPanel(object formHijo)
        {
            if (this.panelform.Controls.Count > 0)
            { 
            this.panelform.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill; 
            this.panelform.Controls.Add(fh);
            this.panelform.Tag = fh;
            fh.Show();
        }


        private void AbreFormulario(Type formType)
        {
            //Selocaliza el formulario buscandolo entre los forms abiertos通過搜尋已開啟的表單來定位該表單
            Form formulario = this.MdiChildren.FirstOrDefault(x => x.GetType() == formType);

            if (formulario != null)
            {
                //Si la instancia esta minimizada la dejamos en su estado normal
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }
                //si la instancia existe la pongo en primer plano
                formulario.BringToFront();
                return;
            }
            //Se abre el form
            formulario = (Form)Activator.CreateInstance(formType);
            formulario.MdiParent = this;
            formulario.Show();
        }
        #endregion

        #region  表單無邊框和標題欄
        /*
        //右上叉叉
        private void MostrarLogoAICerrarForms(object sender, FormClosedEventArgs e)
        {
            MostrarLogo();
            MessageBox.Show("Cerrando instancia");
        }

        //剪貼
        //Constructor
        public FormMenuPrincipal()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }       


        // 引入 Windows API 來移動表單
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0x00A1; // Windows 訊息: 非客戶區左鍵按下
        private const int HT_CAPTION = 0x0002; // 標題區域 (caption) 的區域代碼
        */

        // 監聽表單的 MouseDown 事件來實現拖曳
        private void Home_MouseMove(object sender, MouseEventArgs e)
        {

        }
        // 在表單加載時，將 Home_MouseMove 事件與方法綁定
        protected override void OnLoad(EventArgs e)
        {
            //base.OnLoad(e);
            //this.MouseDown += new MouseEventHandler(Home_MouseDown);
        }
        private void Home_MouseDown(object sender, MouseEventArgs e)
        {
            //ReleaseCapture(); // 釋放鼠標捕獲
            //SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); // 模擬標題欄的左鍵按下事件，實現拖曳
        }


        #endregion


        public void courseslist()
        {
            string connectionString = @".";
            string query = "SELECT TOP 200 course_name, course_intro, course_fee, course_start, course_image FROM courses"; 

            SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString);
            courselistUserControl[] listItems = new courselistUserControl[10];
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);            
            SqlDataReader reader = cmd.ExecuteReader();
            
            int i = 0;
            // 清除現有的控制項
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.AutoScroll = true;
            // 從資料庫讀取資料
            while (reader.Read() && i < listItems.Length)
            {
                // 建立新的控制項並設置其屬性
                listItems[i] = new courselistUserControl();
                listItems[i].Title = reader["course_name"].ToString();
                listItems[i].Intro = reader["course_intro"].ToString();
                listItems[i].Fee = reader["course_fee"].ToString();
                listItems[i].Start = reader["course_start"].ToString();
                flowLayoutPanel1.Controls.Add(listItems[i]);

                if (reader["course_image"] != DBNull.Value)
                {
                    string imagePath = GlobalVar.image_dir + @"\" + reader["course_image"].ToString();

                    try
                    {
                        using (System.IO.FileStream fs = System.IO.File.OpenRead(imagePath))
                        {
                            Image img商品圖檔 = Image.FromStream(fs);  // 將 FileStream 轉為 Image
                            listItems[i].Icon = img商品圖檔;  // 設置圖片到控制項的 Icon 屬性
                        }
                    }
                    catch (Exception)
                    {
                        // 若圖片載入失敗，可以在這裡設置預設圖片或顯示錯誤
                        listItems[i].Icon = Properties.Resources.pencil; // 設定預設圖片
                    }

                }

                // 將控制項添加到 FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(listItems[i]);
                i++;

                #region youtube
                ////courseslist it here
                //courselistUserControl[] listItems = new courselistUserControl[10];
                ////loop through each item
                //for (int i = 0; i < listItems.Length; i++)
                //{
                //    listItems[i] = new courselistUserControl();
                //    listItems[i].Title = "Get Data Some Here";
                //    listItems[i].Intro = "any data souce";
                //    //add to flowlayout
                //    if (flowLayoutPanel1.Controls.Count > 0)
                //    {
                //        flowLayoutPanel1.Controls.Clear() ;
                //    }
                //    else 
                //    {
                //        flowLayoutPanel1 .Controls.Add(listItems[i]);
                //    }
                #endregion

            }
            reader.Close();
            conn.Close();
        }
        private void btn_coursesform_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<coursesForm>();

            courseUserControl courseControl = new courseUserControl();
            panelform.Controls.Clear();            
            panelform.Controls.Add(courseControl);            
            courseControl.Dock = DockStyle.Fill;

        }        

        public void btn_appointForm_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<appointForm>();
            

            if (string.IsNullOrEmpty(GlobalVar.strDBConnectionString))
            {
                MessageBox.Show("資料庫連接字串尚未設置！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 嘗試建立資料庫連線
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            try
            {
                con.Open();

                
                appointUserContro1 appointControl = new appointUserContro1();                
                panelform.Controls.Clear();
                panelform.Controls.Add(appointControl);
                appointControl.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                // 當資料庫連接失敗時顯示錯誤訊息
                MessageBox.Show("資料庫連接錯誤: " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();  // 關閉連接
            }
        }

        private void btn_課程一覽2改_Click(object sender, EventArgs e)
        {
            courseUserControl courseControl = new courseUserControl();
            panelform.Controls.Clear();
            panelform.Controls.Add(courseControl);
            courseControl.Dock = DockStyle.Fill;
        }

        private void btn_registration_Click(object sender, EventArgs e)
        {
            appointUserContro1 appointControl = new appointUserContro1();
            panelform.Controls.Clear();
            panelform.Controls.Add(appointControl);
            appointControl.Dock = DockStyle.Fill;
        }



        private void customizeDesing()
        { 
            panel5.Visible = false;
            panel6.Visible = false;
            //..
        }

        private void hideSubMenu() //下拉按鍵可視
        {
            if (panel5.Visible == true)
                panel5.Visible = false;
            if (panel6.Visible == true)
                panel6.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            { 
                subMenu.Visible = false;
            }
        }

       
        public void iconButton_login_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<loginForm>();
            loginUserControl loginControl = new loginUserControl();
            panelform.Controls.Clear();
            panelform.Controls.Add(loginControl);
            loginControl.Dock = DockStyle.Fill;


            showSubMenu(panel5);
            
        }

        public void SetUserName(string username)
        {           
            if (iconButton_login.InvokeRequired)
            {
                // 如果不是在 UI 執行緒上，使用 Invoke 方法回到 UI 執行緒
                iconButton_login.Invoke(new Action<string>(SetUserName), username);
            }
            else
            {
                // 在 UI 執行緒上更新控件
                iconButton_login.Text = $"嗨！ {username}";
            }            
        }
                

        #region 登入後下方鍵顯示
        private void iconButton_stuinfo_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<stuinfoForm>();
            stuinfoUserControl1 stuinfoControl = new stuinfoUserControl1();
            panelform.Controls.Clear();
            panelform.Controls.Add(stuinfoControl);
            stuinfoControl.Dock = DockStyle.Fill;

            if (!GlobalVar.is登入成功)
            {
                MessageBox.Show("請先登入", "未登入", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // 未登入，返回
            }

            
            #region 登入後連SQLstuinfo至 stuinfoUserControl1 至panelfrom呈現txt
            // 打开 stuinfoForm 并显示用户的学生信息
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();

            // 假设 GlobalVar.使用者名稱 存储的是学生的名字
            string query = @"SELECT u.stu_id, s.id, s.stu_name, s.stu_phone, s.stu_address, s.stu_birthday, s.stu_email
                            FROM users u
                            LEFT JOIN stuinfo s ON u.stu_id = s.id
                            WHERE u.id = @stuId";
            SqlCommand cmd = new SqlCommand(query, con);
            //cmd.Parameters.AddWithValue("@stuId", GlobalVar.使用者ID);
            cmd.Parameters.AddWithValue("@stuId", Convert.ToInt32(GlobalVar.使用者ID)); // 強制轉換為 int
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                // 创建 stuinfoForm 并将学生信息传递给它
                stuinfoUserControl1 stuInfoControl = new stuinfoUserControl1();
                
                stuInfoControl.SetStudentInfo(
                    reader["id"].ToString(),
                    reader["stu_name"].ToString(),
                    reader["stu_phone"].ToString(),
                    reader["stu_address"].ToString(),
                    Convert.ToDateTime(reader["stu_birthday"]).ToString("yyyy-MM-dd"),
                    reader["stu_email"].ToString()
                );
                //stuInfoControl.Show();

                panelform.Controls.Clear(); // 清除 Panel 中的现有控件
                panelform.Controls.Add(stuInfoControl); // 将新的控件添加到 Panel 中
            }
            else
            {
                MessageBox.Show("沒有找到基本資料", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion

            reader.Close();
            con.Close();
            

            
            hideSubMenu();
        }

        private void iconButton_mycourse_Click(object sender, EventArgs e)
        {
            mycourseUserControl mycourseControl = new mycourseUserControl();
            panelform.Controls.Clear();
            panelform.Controls.Add(mycourseControl);
            mycourseControl.Dock = DockStyle.Fill;

            //..
            //your cases
            //..
            hideSubMenu();
        }


        
        private void iconButton_logout_Click(object sender, EventArgs e)
        {
            GlobalVar.is登入成功 = false; // 登出後設置為未登入
            MessageBox.Show("登出成功", "已登出", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateLoginButtonVisibility();
            iconButton_login.Text = "登入"; // 設置為登入文本

            string connectionString = GlobalVar.strDBConnectionString; // 獲取連接字串

            

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string updateSQL = "UPDATE users SET user_status = 0 WHERE id = @UserId;";
                SqlCommand updateCmd = new SqlCommand(updateSQL, con);
                updateCmd.Parameters.AddWithValue("@UserId", GlobalVar.使用者ID);
                updateCmd.ExecuteNonQuery(); // 執行更新命令
            }
            //MessageBox.Show("已成功登出");

            loginUserControl loginForm = new loginUserControl();
            // 隱藏 HomeForm 中的其他控件
            panelform.Controls.Clear(); // 清空 Panel
            // 創建並顯示 LoginForm 進入 Panel 中  
            panelform.Controls.Add(loginForm);  //??

            //this.Hide();
            hideSubMenu();
        }


        #endregion




        private void btn_設定管理_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<settingForm>();
            showSubMenu(panel6);
        }
        #region  老師登入後，管理下方顯示
        private void btn_學生管理_Click(object sender, EventArgs e)
        {
            stusysUserControl stusysControl = new stusysUserControl();
            panelform.Controls.Clear();
            panelform.Controls.Add(stusysControl);
            stusysControl.Dock = DockStyle.Fill;


            //..
            //your cases
            //..
            hideSubMenu();
        }

        private void btn_課程管理_Click(object sender, EventArgs e)
        {
            courseUserControl courseControl = new courseUserControl();
            panelform.Controls.Clear();
            panelform.Controls.Add(courseControl);
            courseControl.Dock = DockStyle.Fill;
            
            //..
            //your cases
            //..
            hideSubMenu();
        }

        private void btn_預約管理_Click(object sender, EventArgs e)
        {
            btn_儲存新增 calanderControl = new btn_儲存新增();
            panelform.Controls.Clear();
            panelform.Controls.Add(calanderControl);
            calanderControl.Dock = DockStyle.Fill;

            //..
            //your cases
            //..
            hideSubMenu();
        }

        private void btn_管理權限_Click(object sender, EventArgs e)
        {
            //..
            //your cases
            //..
            hideSubMenu();
        }

        private void panelform_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton_signup_Click(object sender, EventArgs e)
        {
            signupUserControl signupControl = new signupUserControl();
            panelform.Controls.Clear();
            panelform.Controls.Add(signupControl);
            signupControl.Dock = DockStyle.Fill;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }





        #endregion








        //秀多個表單 (?)
        //private Form activeForm = null; //
        //private void openshowForm()
        //{ 
        //    if(activeForm != null)
        //    activeForm.Close();
        //    activeForm = coursesForm();
        //    coursesForm.TopLevel = false;
        //    coursesForm.ForBorderStyle = FormBorderStyle.None;
        //    coursesForm.Dock = DockStyle.Fill;
        //    panel_showForm.Controls.Add(coursesForm);
        //    panel_showForm.Tag = coursesForm;
        //    coursesForm.BringToFront();
        //    coursesForm.Show();
        //}








    }
}
