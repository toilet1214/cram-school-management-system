using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace WindowsFormsApp2
{
    public partial class mycourseUserControl : UserControl
    {
        
        public mycourseUserControl()
        {
            InitializeComponent();

            
            LoadStudentCourses();
            showDay(_month, _year, flowLayoutPanel1, new Size(35, 25));
        }


        
        private int _year = DateTime.Now.Year;
        private int _month = DateTime.Now.Month;

        private void iconButton_next_Click_1(object sender, EventArgs e)
        {
            _month += 1;
            if (_month > 12)
            {
                _month = 1;
                _year += 1;
            }
            if (_year > 9999) _year = 9999;            
            if (_year >= 1753 && _year <= 9999)
            {
                showDay(_month, _year, flowLayoutPanel1, new Size(35, 25));
            }
            else
            {
                MessageBox.Show("年份超出 SQL Server 支援的範圍 (1753-9999)");
            }
            
        }

        private void iconButton_prev_Click_1(object sender, EventArgs e)
        {
            _month -= 1;
            if (_month < 1)
            {
                _month = 12;
                _year -= 1;
            }
            if (_year > 9999) _year = 9999;
            if (_year < 1) _year = 1;
            if (_year >= 1753 && _year <= 9999)
            {
                showDay(_month, _year, flowLayoutPanel1, new Size(35, 25));
            }
            else
            {
                MessageBox.Show("年份超出 SQL Server 支援的範圍 (1753-9999)");
            }
            
        }

        private void panel1_DateClicked(DateTime selectedDate)
        {
            
        }


        
        private void showDay(int month, int year, FlowLayoutPanel targetPanel, Size dayControlSize)
        {

            // 清空目標 panel 以新增新控制項
            targetPanel.Controls.Clear();
            _year = year;
            _month = month;

            string monthName = new DateTimeFormatInfo().GetMonthName(month);
            lblMonth.Text = monthName.ToUpper() + " " + year;
            DateTime startOfMonth = new DateTime(year, month, 2);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int firstDayOfWeek = (int)startOfMonth.DayOfWeek;

            // 為對齊目的在月初前添加空白天數
            for (int i = 1; i < firstDayOfWeek; i++)
            {
                dayUserControl blankDayControl = new dayUserControl("");
                blankDayControl.SetControlSize(dayControlSize);
                targetPanel.Controls.Add(blankDayControl);
            }

            // 為每一天添加 day 控制項
            for (int i = 1; i <= daysInMonth; i++)
            {
                DateTime currentDate = new DateTime(year, month, i);
                dayUserControl dayControl = new dayUserControl(i.ToString());

                // 設定大小並加載約會數量
                dayControl.SetControlSize(dayControlSize);
                int appointmentCount = GetAppointmentCountForDate(currentDate);
                dayControl.SetAppointmentCount(appointmentCount);

                // 點擊日期事件處理
                dayControl.DateClicked += panel1_DateClicked;
                targetPanel.Controls.Add(dayControl);
            }

            /*
            //dayUserControl dayControl = new dayUserControl();
            //dayControl.SetControlSize(new Size(35, 35)); // 設定在課程顯示中的大小
            //flowLayoutPanel2.Controls.Add(dayControl);

            //flowLayoutPanel1.Controls.Clear();
            //_year = year;
            //_month = month;

            //string monthName = new DateTimeFormatInfo().GetMonthName(month);
            //lblMonth.Text = monthName.ToUpper() + " " + year;
            //DateTime startodTheMonth = new DateTime(year, month, 1);
            ////int day = DateTime.DaysInMonth(year, month);
            ////int week = Convert.ToInt32(startodTheMonth.DayOfWeek.ToString("d")) + 1;
            //int daysInMonth = DateTime.DaysInMonth(year, month);
            //int firstDayOfWeek = (int)startodTheMonth.DayOfWeek;


            //for (int i = 1; i < firstDayOfWeek; i++)   //(int i = 1; i < week; i++) 
            //{
            //    dayUserControl uc = new dayUserControl("");
            //    flowLayoutPanel1.Controls.Add(uc);
            //}
            //for (int i = 1; i <= daysInMonth; i++)
            //{
            //    DateTime currentDate = new DateTime(year, month, i);
            //    dayUserControl dayControl = new dayUserControl(i.ToString());

            //    int appointmentCount = GetAppointmentCountForDate(currentDate);
            //    dayControl.SetAppointmentCount(appointmentCount);


            //    dayControl.DateClicked += panel1_DateClicked;
            //    flowLayoutPanel1.Controls.Add(dayControl);                
            //}*/

        }










        private void LoadAppointments(DateTime selectedDate)
        {
            //using (SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString))
            //{
            //    string query = "SELECT stu_name, course_name, stu_phone, appoint_date FROM appointments WHERE appoint_date = @date";
            //    SqlCommand cmd = new SqlCommand(query, conn);
            //    cmd.Parameters.AddWithValue("@date", selectedDate);

            //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //    DataTable dataTable = new DataTable();
            //    adapter.Fill(dataTable);


            //    dataGridView1.DataSource = dataTable;  // 或 listView 用於顯示
            //    int totalRecords = dataTable.Rows.Count;
            //    lbl_共幾筆.Text = "共 " + totalRecords + " 筆";
            //}
        }


        private int GetAppointmentCountForDate(DateTime date)
        {


            int count = 0;
            string query = "SELECT COUNT(*) FROM appointments WHERE appoint_date = @date";

            using (SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@date", date.Date);

                conn.Open();

                count = (int)cmd.ExecuteScalar(); // 取得該日期的預約數
            }
            return count;

        }


        




        #region courselistUserControl呈現在flowlayoutlabel2

        private void LoadStudentCourses()
        {
            
            //學校用SQL
            // 設置 SQL 查詢來獲取學生已註冊的課程
            string query = @"
        SELECT c.id, c.course_name, c.course_intro, c.course_fee, c.course_start, c.course_image
        FROM users u
        JOIN stuinfo s ON s.id = u.stu_id
        JOIN registrations r ON r.stu_id = s.id
        JOIN courses c ON c.id = r.course_id
        WHERE u.id = @userId";

            using (SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString))
                {
                   SqlCommand cmd = new SqlCommand(query, conn);
        
                    // 設定使用者ID參數，並顯示當前的使用者ID
                    cmd.Parameters.AddWithValue("@userId", GlobalVar.使用者ID);
                    Console.WriteLine("使用者ID: " + GlobalVar.使用者ID);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    // 檢查是否讀取到了資料
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("未找到符合條件的課程。");
                        return;
                    }

                    courselistUserControl[] courseItem = new courselistUserControl[10];                
                    int i = 0;

                    flowLayoutPanel2.Controls.Clear();
                    flowLayoutPanel2.AutoScroll = true;
        
                    // 建立新的課程控制項並添加至 flowLayoutPanel
                    while (reader.Read() && i < courseItem.Length)
                    {
                        courseItem[i] = new courselistUserControl();
                        courseItem[i].Title = reader["course_name"].ToString();
                        courseItem[i].Intro = reader["course_intro"].ToString();
                        courseItem[i].Fee = $"費用: {reader["course_fee"]}";
                        courseItem[i].Start = $"開課日期: {Convert.ToDateTime(reader["course_start"]).ToString("yyyy-MM-dd")}";
                        flowLayoutPanel1.Controls.Add(courseItem[i]);

                                // 加載圖片
                                if (reader["course_image"] != DBNull.Value)
                        {
                            string imagePath = GlobalVar.image_dir + @"\" + reader["course_image"].ToString();
                
                            try
                            {
                                courseItem[i].Icon = Image.FromFile(imagePath);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"載入圖片失敗: {ex.Message}");
                            }
                        }

                        // 添加到 flowLayoutPanel
                        flowLayoutPanel2.Controls.Add(courseItem[i]);
            
                        Console.WriteLine($"成功添加控制項: {courseItem[i].Title}");
                        i++; // 記得在每次迴圈後遞增 i
                    }
        
                       // MessageBox.Show($"flowLayoutPanel 控制項數量: {flowLayoutPanel2.Controls.Count}");  //測試
                    }





            /*家裡用SQL
            //// 設置 SQL 查詢來獲取學生已註冊的課程
            //string query = "SELECT c.id, c.course_name, c.course_intro, c.course_fee, c.course_start, c.course_image FROM courses c INNER JOIN registrations r ON c.id = r.course_id WHERE r.stu_id = @studentId";
            

            //using (SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString))
            //{
            //    SqlCommand cmd = new SqlCommand(query, conn);
                
            //    cmd.Parameters.AddWithValue("@studentId", GlobalVar.使用者ID);
            //    courselistUserControl[] courseItem = new courselistUserControl[10];                
            //    conn.Open();                
            //    SqlDataReader reader = cmd.ExecuteReader();

            //    int i = 0;

            //    flowLayoutPanel2.Controls.Clear();
            //    flowLayoutPanel2.AutoScroll = true;
            //    // 建立新的課程控制項並添加至 flowLayoutPanel
            //    while (reader.Read() && i < courseItem.Length)
            //    {
            //        courseItem[i] = new courselistUserControl();
            //        courseItem[i].Title = reader["course_name"].ToString();
            //        courseItem[i].Intro = reader["course_intro"].ToString();
            //        courseItem[i].Fee = $"費用: {reader["course_fee"]}";
            //        courseItem[i].Start = $"開課日期: {Convert.ToDateTime(reader["course_start"]).ToString("yyyy-MM-dd")}";

            //        //flowLayoutPanel2.Controls.Add(courseItem[i]);

            //        // 加載圖片
            //        if (reader["course_image"] != DBNull.Value)
            //        {
            //            string imagePath = GlobalVar.image_dir + @"\" + reader["course_image"].ToString();
            //            courseItem[i].Icon = Image.FromFile(imagePath);
            //        }

            //        // 添加到 flowLayoutPanel
            //        flowLayoutPanel2.Controls.Add(courseItem[i]);
            //        i++;

            //    }
            //    MessageBox.Show($"flowLayoutPanel 控制項數量: {flowLayoutPanel2.Controls.Count}");  //測試

            //}*/
        }

        #endregion


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void mycourseUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
