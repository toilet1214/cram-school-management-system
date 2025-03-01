using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class appointUserContro1 : UserControl
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        List<string> list課程名稱 = new List<string>(); //value
        List<string> list課程介紹 = new List<string>(); //value
        List<int> list課程Id = new List<int>();        //key

        public appointUserContro1()
        {
            InitializeComponent();
        }

        private void appointUserContro1_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private int CheckExistingStudent(string name, string phone)
        {
            int studentId = 0;
            string query = "SELECT id FROM stuinfo WHERE stu_name = @name AND stu_phone = @phone";

            using (SqlConnection connection = new SqlConnection(GlobalVar.strDBConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@phone", phone);
                connection.Open();

                object result = command.ExecuteScalar(); // 獲取學生 ID（如果存在）
                if (result != null)
                {
                    studentId = Convert.ToInt32(result); // 存在的學生 ID
                }
            }
            return studentId;
        }
        private int Insertstuinfo(string name, string phone)
        {
            //首先檢查是否已存在相同的學生資料
            int existingStudenId = CheckExistingStudent(name, phone);
            if (existingStudenId > 0)
            {
                return existingStudenId; //如存存在，返回已有的學生ID
            }

            //如果不存在，插入新的學生資料
            int studentId = 0;
            string query = "INSERT INTO stuinfo (stu_name, stu_phone) OUTPUT INSERTED.id VALUES (@name, @phone)";

            using (SqlConnection connection = new SqlConnection(GlobalVar.strDBConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);    //SQL 查詢中的參數名稱, 用戶輸入（文本框）中獲取的實際值
                command.Parameters.AddWithValue("@phone", phone);
                connection.Open();
                studentId = (int)command.ExecuteScalar(); // 獲取自增的學生 ID
            }

            return studentId;
        }
        private bool CheckExistingAppointment(string name, string phone, int courseId, string tableName)
        {
            string query = $"SELECT COUNT(*) FROM  {tableName} WHERE stu_name = @name AND stu_phone = @phone AND course_id = @courseId";

            using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString))
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@courseId", courseId);
                con.Open();

                int count = (int)command.ExecuteScalar(); // 獲取符合條件的預約數量
                return count > 0; // 如果數量大於0，表示已經預約過
            }
        }
        private void ShowDuplicateMessage(string tableName)
        {
            string message = tableName == "appointments" ? "您已經預約過此課程" : "您已經報名過此課程";
            MessageBox.Show(message, "預約重複", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void RegisterForCourse(string tableName, int stuId, string stuName, string stuPhone, int courseId, string courseName, string appointSource, DateTime appointDate)
        {
            //檢查是否已經有預約/報名過此課程
            if (CheckExistingAppointment(stuName, stuPhone, courseId, tableName))
            {
                ShowDuplicateMessage(tableName);
                return;
            }

            string query = $"insert into {tableName} (stu_id, stu_name, stu_phone, course_id, course_name, created_at, appoint_sources, appoint_date) values (@stuId, @stuName, @stuPhone, @courseId, @courseName, @createdAt, @appoint_source, @appoint_date)";

            using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@stuId", stuId);
                com.Parameters.AddWithValue("@stuName", stuName);
                com.Parameters.AddWithValue("@stuPhone", stuPhone);
                com.Parameters.AddWithValue("@courseId", courseId);
                com.Parameters.AddWithValue("@courseName", courseName);
                com.Parameters.AddWithValue("@createdAt", DateTime.Now);
                com.Parameters.AddWithValue("@appoint_source", appointSource);
                com.Parameters.AddWithValue("@appoint_date", appointDate);

                con.Open();
                com.ExecuteNonQuery(); // 執行插入操作
            }

        }
        private string GetSelectedAppointmentSource()
        {
            // 根據選中的 RadioButton 返回對應的消息來源
            if (rdb_臉書.Checked)
                return "臉書";
            else if (rdb_ig.Checked)
                return "IG";
            else if (rdb_親友.Checked)
                return "親友";
            else if (rdb_文宣.Checked)
                return "文宣";
            else if (rdb_其他.Checked)
                return "其他";
            else
                return "其他";  // 預設為 '其他'
        }
        public void btnappoint_check_Click(object sender, EventArgs e)
        {
            //檢查資料是否有效，獲取用戶輸入的資料
            string appointName = txbappoint_name.Text.Trim();
            string appointPhone = txbappoint_phone.Text.Trim();
            string selectedCourseName = cbbappoint_courses.SelectedItem?.ToString(); // 獲取選擇的課程名稱
            string appointSource = GetSelectedAppointmentSource();
            DateTime appointDate = dtp_appointment.Value;

            // 檢查是否已經選擇了課程，並且獲取課程 ID
            if (cbbappoint_courses.SelectedIndex < 0 || cbbappoint_courses.SelectedIndex >= list課程Id.Count)
            {
                MessageBox.Show("請選擇課程", "課程選擇錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // 如果未選擇課程，則返回
            }
            int selectedCourseId = list課程Id[cbbappoint_courses.SelectedIndex]; // 獲取選擇的課程 ID


            // 檢查是否已經預約過此課程
            if (CheckExistingAppointment(appointName, appointPhone, selectedCourseId, "appointments"))
            {
                ShowDuplicateMessage("appointments");
                return;
            }

            //檢查是否空白
            if (string.IsNullOrWhiteSpace(appointName) || string.IsNullOrWhiteSpace(appointPhone) || string.IsNullOrEmpty(selectedCourseName))
            {
                MessageBox.Show("請填寫完整姓名,電話並選擇課程", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 顯示確認報名的 MessageBox，帶有確定和取消按鈕
            DialogResult result = MessageBox.Show($"確認報名 {selectedCourseName}課程 ?", "確認報名", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 用戶選擇了確定，插入資料到資料庫
                int stuId = Insertstuinfo(appointName, appointPhone);
                RegisterForCourse("appointments", stuId, appointName, appointPhone, selectedCourseId, selectedCourseName , appointSource, appointDate);

                // 顯示成功消息
                MessageBox.Show($"預約 {selectedCourseName}課程 成功", "成功", MessageBoxButtons.OK);
            }
            else
            {
                // 用戶選擇了取消，不做任何操作
                MessageBox.Show("預約已取消", "取消", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
        public void LoadComboBox()  //通用的 combox加載課程  //(ComboBox comboBox)
        {
            string query = "SELECT course_name, id FROM courses";

            using (SqlConnection connection = new SqlConnection(GlobalVar.strDBConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // 清空 ComboBox 以避免重複項目
                cbbappoint_courses.Items.Clear();  //comboBox
                list課程名稱.Clear(); // 清空名稱列表
                list課程Id.Clear();    // 清空 ID 列表

                while (reader.Read())
                {
                    list課程名稱.Add(reader["course_name"].ToString());
                    list課程Id.Add(Convert.ToInt32(reader["id"])); // 假設 course_id 是 int 類型
                }

                // 將課程名稱添加到 ComboBox
                foreach (var courseName in list課程名稱)
                {
                    cbbappoint_courses.Items.Add(courseName);//comboBox
                }

            }
        }

    }
}
