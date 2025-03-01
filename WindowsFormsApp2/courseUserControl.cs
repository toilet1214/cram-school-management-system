using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace WindowsFormsApp2
{
    public partial class courseUserControl : UserControl
    {
        //SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        //List<string> list課程名稱 = new List<string>(); //value
        //List<int> list課程價格 = new List<int>();       //value
        //List<string>list課程介紹 = new List<string>();  //value
        //List<DateTime> list課程開始時間 = new List<DateTime>(); // 課程開始
        //List<DateTime> list課程結束時間 = new List<DateTime>(); // 課程結束
        //List<string> list課程部門 = new List<string>();  //value
        //List<int> listId = new List<int>();             //key
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        List<string> list課程名稱 = new List<string>(); //value
        List<string> list課程介紹 = new List<string>(); //value
        List<int> list課程Id = new List<int>();        //key

        private void courseUserControl_Load(object sender, EventArgs e)
        {
            courseslist();
            LoadDepartmentData();
            LoadSubjectData();


            #region
            //scsb.DataSource = @".";
            //scsb.InitialCatalog = "mydb";
            //scsb.IntegratedSecurity = true;
            //GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();
            //讀取課程資料庫();

            //Console.WriteLine("Form Load!!");

            ////顯示ListView列表模式();
            //顯示ListView圖片模式();
            #endregion
        }

        public courseUserControl()
        {
            InitializeComponent();
        }


        public void courseslist()
        {
            string connectionString = @".";
            string query = "SELECT TOP 200 course_name, course_intro, course_fee, course_start, course_image FROM courses"; ;

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


        private void cbb_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 確保當有選擇才進行過濾
            string selectedDepartment = cbb_department.SelectedItem?.ToString();
            string selectedSubject = cbb_subject.SelectedItem?.ToString();

            // 如果都沒有選擇，顯示所有課程
            if (selectedDepartment == "---請選擇---" && selectedSubject == "---請選擇---")
            {
                LoadCourses();
            }
            else
            {
                LoadFilteredCourses(selectedDepartment, selectedSubject);
            }
        }
        
        private void cbb_subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDepartment = cbb_department.SelectedItem?.ToString();
            string selectedSubject = cbb_subject.SelectedItem?.ToString();

            // 如果都沒有選擇，顯示所有課程
            if (selectedDepartment == "---請選擇---" && selectedSubject == "---請選擇---")
            {
                LoadCourses();
            }
            else
            {
                LoadFilteredCourses(selectedDepartment, selectedSubject);
            }
        }

        private void LoadCourses()
        {
            string query = "SELECT course_name, course_intro, course_fee, course_start, course_image FROM courses";

            using (SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    flowLayoutPanel1.Controls.Clear();  // 清空之前的結果

                    while (reader.Read())
                    {
                        var courseControl = CreateCourseControl(reader);
                        flowLayoutPanel1.Controls.Add(courseControl);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("資料載入失敗：" + ex.Message);
                }
            }
        }
        private void LoadFilteredCourses(string department, string subject)
        {
            string query = "SELECT course_name, course_intro, course_fee, course_start, course_image " +
                           "FROM courses WHERE 1=1";

            // 進行條件過濾，依照部門和科目
            if (!string.IsNullOrEmpty(department) && department != "---請選擇---")
            {
                query += " AND course_department = @department";
            }

            if (!string.IsNullOrEmpty(subject) && subject != "---請選擇---")
            {
                query += " AND course_subject = @subject";
            }

            using (SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                // 添加參數
                if (!string.IsNullOrEmpty(department) && department != "---請選擇---")
                {
                    cmd.Parameters.AddWithValue("@department", department);
                }

                if (!string.IsNullOrEmpty(subject) && subject != "---請選擇---")
                {
                    cmd.Parameters.AddWithValue("@subject", subject);
                }

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    flowLayoutPanel1.Controls.Clear();  // 清空之前的結果

                    while (reader.Read())
                    {
                        var courseControl = CreateCourseControl(reader);
                        flowLayoutPanel1.Controls.Add(courseControl);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("資料載入失敗：" + ex.Message);
                }
            }
        }
        private courselistUserControl CreateCourseControl(SqlDataReader reader)
        {   // 根據讀取的資料創建課程控制項
            var courseControl = new courselistUserControl
            {
                Title = reader["course_name"].ToString(),
                Intro = reader["course_intro"].ToString(),
                Fee = reader["course_fee"].ToString(),
                Start = reader["course_start"].ToString()
            };

            // 加載圖片（如果有）
            if (reader["course_image"] != DBNull.Value)
            {
                string imagePath = GlobalVar.image_dir + @"\" + reader["course_image"].ToString();
                try
                {
                    using (FileStream fs = File.OpenRead(imagePath))
                    {
                        courseControl.Icon = Image.FromStream(fs);
                    }
                }
                catch
                {
                    courseControl.Icon = Properties.Resources.pencil;  // 設定預設圖片
                }
            }

            return courseControl;
        }


        private void LoadDepartmentData()
        {
            string query = "SELECT DISTINCT course_department FROM courses";

            using (SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    // 清空 ComboBox 的項目
                    cbb_department.Items.Clear();
                    cbb_department.Items.Add("---請選擇---");

                    // 檢查是否有資料並將其加入 ComboBox
                    while (reader.Read())
                    {
                        string department = reader["course_department"].ToString();
                        cbb_department.Items.Add(department);
                    }

                    // 如果需要，可以選擇預設選中某個項目
                    if (cbb_department.Items.Count > 0)
                    {
                        cbb_department.SelectedIndex = 0;  // 預設選擇第一個項目
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("資料載入失敗：" + ex.Message);
                }
            }
        }

        private void LoadSubjectData()
        {
            string query = "SELECT DISTINCT course_subject FROM courses";

            using (SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    // 清空 ComboBox 的項目
                    cbb_subject.Items.Clear();
                    cbb_subject.Items.Add("---請選擇---");

                    // 檢查是否有資料並將其加入 ComboBox
                    while (reader.Read())
                    {
                        string subject = reader["course_subject"].ToString();
                        cbb_subject.Items.Add(subject);
                    }

                    // 如果需要，可以選擇預設選中某個項目
                    if (cbb_subject.Items.Count > 0)
                    {
                        cbb_subject.SelectedIndex = 0;  // 預設選擇第一個項目
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("資料載入失敗：" + ex.Message);
                }
            }
        }




        void 讀取課程資料庫()
        {
            //SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            //con.Open();
            //string strSQL = "select top 200 * from courses;";
            //SqlCommand sqlCommand = new SqlCommand(strSQL, con);
            //SqlDataReader reader = sqlCommand.ExecuteReader();

            //int count = 0;
            //while (reader.Read())
            //{
            //    listId.Add((int)reader["id"]);
            //    list課程名稱.Add((string)reader["course_name"]);
            //    list課程價格.Add((int)reader["course_fee"]);
            //    list課程介紹.Add((string)reader["course_intro"]);
            //    list課程部門.Add((string)reader["course_department"]);

            //    // 確保 course_start 和 course_end 這些欄位不為 null
            //    if (!reader.IsDBNull(reader.GetOrdinal("course_start")))
            //    {
            //        list課程開始時間.Add((DateTime)reader["course_start"]);
            //    }
            //    else
            //    {
            //        list課程開始時間.Add(DateTime.MinValue);  // 或者使用其他預設值
            //    }

            //    if (!reader.IsDBNull(reader.GetOrdinal("course_end")))
            //    {
            //        list課程結束時間.Add((DateTime)reader["course_end"]);
            //    }
            //    else
            //    {
            //        list課程結束時間.Add(DateTime.MinValue);  // 或者使用其他預設值
            //    }

            //    string image_name = (string)reader["course_image"];
            //    string 完整圖檔路徑 = GlobalVar.image_dir + @"\" + image_name;
            //    Console.WriteLine(完整圖檔路徑);
            //    System.IO.FileStream fs = System.IO.File.OpenRead(完整圖檔路徑); //命名空間system.IO 可以把完整圖案路徑存在Filestrem
            //    Image img商品圖檔 = Image.FromStream(fs);  //存成圖檔格式  //如果當掉有時是圖檔相容性問題
            //    image課程圖檔.Images.Add(img商品圖檔);//加入圖檔

            //    fs.Close();


            //    count++;
            //}
            //Console.WriteLine($"共有{count}筆資料");
            //reader.Close();
            //con.Close();
        }

                
        void 顯示ListView列表模式()
        {
            //listView_course.Clear();
            //listView_course.LargeImageList = null;
            //listView_course.SmallImageList = null; //刪除快取
            //listView_course.View = View.Details;
            //listView_course.Columns.Add("id", 30);
            //listView_course.Columns.Add("課程名稱", 80); //( , 欄位寬度)
            //listView_course.Columns.Add("上課時間", 200);
            //listView_course.Columns.Add("課程費用", 90);
            //listView_course.Columns.Add("開課時間", 100);
            //listView_course.Columns.Add("結束時間", 100);
            //listView_course.GridLines = true; //是否有分隔線

            //for (int idx = 0; idx < listId.Count; idx += 1)
            //{
            //    ListViewItem item = new ListViewItem();
            //    item.Font = new Font("微軟正黑體", 10, FontStyle.Bold);
            //    item.Tag = listId[idx];
            //    item.Text = listId[idx].ToString(); //第一欄
            //    item.SubItems.Add(list課程名稱[idx]); //第二欄
            //    item.SubItems.Add(list課程介紹[idx].ToString());
            //    item.SubItems.Add(list課程價格[idx].ToString());
            //    item.SubItems.Add(list課程開始時間[idx].ToString("yyyy-MM-dd "));
            //    item.SubItems.Add(list課程結束時間[idx].ToString("yyyy-MM-dd "));
            //    item.ForeColor = System.Drawing.Color.DarkBlue; //字體顏色
            //    listView_course.Items.Add(item);
            //}
        }

        void 顯示ListView圖片模式()
        {
            ////listview和listbox都會自動產生捲軸
            //listView_course.Clear();
            //listView_course.View = View.LargeIcon; //列舉 (LargeIcon. Tile. List. SmallIcon) 圖片顯示
            //image課程圖檔.ImageSize = new Size(120, 120);//圖檔大小，form有設訂256，但這邊可以再變化
            //listView_course.LargeImageList = image課程圖檔;//LargeIcon, Tile//圖檔來源
            
            //listView_course.SmallImageList = image課程圖檔;//SmallIcon, List

            //for (int idx = 0; idx < listId.Count; idx += 1)
            //{
            //    ListViewItem item = new ListViewItem();
            //    //item.ImageIndex = idx;
            //    //item.Text = $"{list課程名稱[idx]} {list課程價格[idx]}元 \n{list課程介紹[idx]} \n{list課程開始時間[idx]}";
            //    //item.SubItems.Add($"{list課程價格[idx]} 元");
            //    //item.SubItems.Add($"{list課程介紹[idx]}");
            //    //item.SubItems.Add($"{list課程開始時間[idx]}");

            //    item.Font = new Font("微軟正黑體", 10, FontStyle.Bold); //Bold粗體字
            //    item.Tag = listId[idx]; //把ID藏在tag
            //    listView_course.Items.Add(item);
            //}
        }        

        private void listView_course_DrawItem_1(object sender, DrawListViewItemEventArgs e)
        {
            //int idx = e.ItemIndex;            
                        
            

            //// 設定圖片位置
            //int imageX = e.Bounds.Left + 10;  // 圖片的 X 坐標 (左邊邊界 + 10)
            //int imageY = e.Bounds.Top + 10;   // 圖片的 Y 坐標 (上邊邊界 + 10)
            //int imageWidth = 120;             // 圖片寬度
            //int imageHeight = 120;            // 圖片高度

            //// 繪製背景（確保不會擋住下一個項目）
            //e.Graphics.FillRectangle(System.Drawing.Brushes.White, e.Bounds);

            //// 繪製圖片
            //Image img = image課程圖檔.Images[idx];  // 根據圖片索引取得圖片
            //e.Graphics.DrawImage(img, imageX, imageY, imageWidth, imageHeight);  // 繪製圖片

            //// 設定文字顯示的位置
            //int textX = imageX + imageWidth + 10;  // 文字顯示的 X 坐標，在圖片右邊並保留10像素間距
            //int textY = imageY;         // 文字顯示的 Y 坐標，與圖片對齊


            //// 繪製每一項文字，您可以使用多行的方式顯示
            //string text = $"{list課程名稱[e.ItemIndex]} {list課程價格[e.ItemIndex]}元 \n{list課程介紹[e.ItemIndex]}"; //{list課程開始時間[e.ItemIndex]}            

            //// 計算文字的最大寬度，防止文字超出顯示範圍
            //int maxTextWidth = e.Bounds.Width - imageX - imageWidth - 20; // 項目的寬度減去圖片區域的寬度

            //// 根據最大寬度繪製文字，這樣文字會自動換行
            //StringFormat stringFormat = new StringFormat();
            //stringFormat.FormatFlags = StringFormatFlags.LineLimit;
            //e.Graphics.DrawString(text, new Font("微軟正黑體", 14, FontStyle.Bold), System.Drawing.Brushes.Black, textX, textY);

            //// 如果有需要的話，繪製邊框
            //e.DrawDefault = true;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void courselistUserControl1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
