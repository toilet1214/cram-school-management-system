using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class btn_儲存新增 : UserControl
    {

        public static int _year, _month;
        public btn_儲存新增()
        {
            InitializeComponent();
        }


        #region 加載預約資料到datagridview
        private void panel1_DateClicked(DateTime selectedDate)
        {
            LoadAppointments(selectedDate);
        }        
        private void LoadAppointments(DateTime selectedDate)
        {
            using (SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString))
            {
                string query = "SELECT stu_name, course_name, stu_phone, appoint_date FROM appointments WHERE appoint_date = @date";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@date", selectedDate);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                
                dataGridView1.DataSource = dataTable;  // 或 listView 用於顯示
                int totalRecords = dataTable.Rows.Count;
                lbl_共幾筆.Text = "共 " + totalRecords + " 筆";
            }            
        }
        #endregion

        //...
        #region 設日曆
        private void calanderUserControl_Load(object sender, EventArgs e)
        {
            showDay(DateTime.Now.Month, DateTime.Now.Year);

            Console.WriteLine("TableLayoutPanel Position: " + flowLayoutPanel1.Location);
            Console.WriteLine("TableLayoutPanel Size: " + flowLayoutPanel1.Size);

            dataGridView1.CellClick += dataGridView1_CellClick;

            
            
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(250, 231, 176); //行的底色
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //選取整行
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(254, 184, 59); //被選取行的底色
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.FromArgb(134, 92, 30);
        }

        private void iconButton_next_Click(object sender, EventArgs e)
        {
            _month += 1;
            if (_month >12)
            { 
                _month = 1;
                _year += 1;
            }
            showDay(_month, _year);
        }


        private void iconButton_prev_Click(object sender, EventArgs e)
        {
            _month -= 1;
            if (_month < 1)
            {
                _month = 12 ;
                _year -= 1;
            }
            showDay(_month, _year);
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



        private void showDay(int month, int year)
        {
            flowLayoutPanel1.Controls.Clear();
            _year = year;
            _month = month;

            string monthName = new DateTimeFormatInfo().GetMonthName(month);
            lblMonth.Text = monthName.ToUpper() + " " + year;
            DateTime startodTheMonth = new DateTime(year, month, 1);
            //int day = DateTime.DaysInMonth(year, month);
            //int week = Convert.ToInt32(startodTheMonth.DayOfWeek.ToString("d")) + 1;
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int firstDayOfWeek = (int)startodTheMonth.DayOfWeek;


            for (int i = 1; i < firstDayOfWeek; i++)   //(int i = 1; i < week; i++) 
            {
                dayUserControl uc = new dayUserControl("");                
                flowLayoutPanel1.Controls.Add(uc);
            }
            for (int i = 1; i <= daysInMonth; i++)
            {
                DateTime currentDate = new DateTime(year, month, i);
                dayUserControl dayControl = new dayUserControl(i.ToString());

                int appointmentCount = GetAppointmentCountForDate(currentDate);
                dayControl.SetAppointmentCount(appointmentCount);


                dayControl.DateClicked += panel1_DateClicked;
                flowLayoutPanel1.Controls.Add(dayControl);

                //dayUserControl uc = new dayUserControl(i + "");
                //uc.DateClicked += dayUserControl_DateClicked;
                //flowLayoutPanel1.Controls.Add(uc);
            }

        }

        private void txb_name_TextChanged(object sender, EventArgs e)
        {

        }


        #endregion
        //...


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 確保選中的行不是標題行或無效行
            if (e.RowIndex >= 0)
            {
                // 獲取選中的行
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // 將選中行的每個欄位值顯示在對應的文字框中
                txb_name.Text = row.Cells["stu_name"].Value?.ToString();
                txb_course.Text = row.Cells["course_name"].Value?.ToString();
                txb_date.Text = row.Cells["appoint_date"].Value != null
                                ? Convert.ToDateTime(row.Cells["appoint_date"].Value).ToString("yyyy-MM-dd")
                                : "";
                txb_phone.Text = row.Cells["stu_phone"].Value?.ToString();

                
            }
        }

        private void btn_新增資料_Click(object sender, EventArgs e)
        {
            txb_name.Text = "";
            txb_phone.Text = "";
            txb_course.Text = "";
            txb_date.Text = "";
        }

        
        private void btn_儲存新增正式_Click(object sender, EventArgs e)
        {
            // 取得 TextBox 中的資料
            string stuName = txb_name.Text;
            string stuPhone = txb_phone.Text;
            string courseName = txb_course.Text;
            DateTime appointDate = DateTime.Parse(txb_date.Text);
            DateTime createdAt = DateTime.Now;

            string connectionString = GlobalVar.strDBConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction(); // 使用交易確保資料一致性
                try
                {
                    // 1. 插入或取得 stu_id
                    int stuId;
                    string getStudentQuery = "SELECT id FROM stuinfo WHERE stu_name = @stuName AND stu_phone = @stuPhone";
                    using (SqlCommand cmd = new SqlCommand(getStudentQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@stuName", stuName);
                        cmd.Parameters.AddWithValue("@stuPhone", stuPhone);
                        var result = cmd.ExecuteScalar();

                        if (result == null) // 若學生不存在，則新增
                        {
                            string insertStudentQuery = "INSERT INTO stuinfo (stu_name, stu_phone) OUTPUT INSERTED.id VALUES (@stuName, @stuPhone)";
                            using (SqlCommand insertCmd = new SqlCommand(insertStudentQuery, conn, transaction))
                            {
                                insertCmd.Parameters.AddWithValue("@stuName", stuName);
                                insertCmd.Parameters.AddWithValue("@stuPhone", stuPhone);
                                stuId = (int)insertCmd.ExecuteScalar(); // 取得插入後的 stu_id
                                MessageBox.Show("新增學生成功，id：" + stuId); // 提示成功新增學生
                            }
                        }
                        else
                        {
                            stuId = (int)result;
                            MessageBox.Show("找到已存在學生，id：" + stuId); // 提示找到已存在學生
                        }
                    }

                    // 2. 取得 course_id
                    int courseId;
                    string getCourseIdQuery = "SELECT id FROM courses WHERE course_name = @courseName";
                    using (SqlCommand cmd = new SqlCommand(getCourseIdQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@courseName", courseName);
                        var courseIdResult = cmd.ExecuteScalar();

                        if (courseIdResult == null)
                        {
                            MessageBox.Show("找不到指定的課程名稱，請檢查後重試", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        courseId = (int)courseIdResult;
                        MessageBox.Show("找到課程，id：" + courseId); // 提示課程ID
                    }

                    // 3. 插入約會資料
                    string insertAppointmentQuery = @"
                INSERT INTO appointments (stu_id, stu_name, stu_phone, course_id, course_name, created_at, appoint_date) 
                VALUES (@stuId, @stuName, @stuPhone, @courseId, @courseName, @createdAt, @appointDate)";

                    using (SqlCommand cmd = new SqlCommand(insertAppointmentQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@stuId", stuId);
                        cmd.Parameters.AddWithValue("@stuName", stuName);
                        cmd.Parameters.AddWithValue("@stuPhone", stuPhone);
                        cmd.Parameters.AddWithValue("@courseId", courseId);
                        cmd.Parameters.AddWithValue("@courseName", courseName);
                        cmd.Parameters.AddWithValue("@createdAt", createdAt);
                        cmd.Parameters.AddWithValue("@appointDate", appointDate);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("預約資料已成功儲存！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("預約資料儲存失敗！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    transaction.Commit(); // 提交交易
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // 若出錯則回滾交易
                    MessageBox.Show("發生錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_儲存修改_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
