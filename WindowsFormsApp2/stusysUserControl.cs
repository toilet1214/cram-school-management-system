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
using System.Windows.Input;

namespace WindowsFormsApp2
{
    public partial class stusysUserControl : UserControl
    {


        private DataGridView dataGridView1 = new DataGridView();
        public stusysUserControl()
        {
            InitializeComponent();


            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Height = 210;            
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(250, 231, 176); //行的底色
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //選取整行
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(254, 184, 59); //被選取行的底色
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.FromArgb(134, 92, 30);

            this.Controls.Add(dataGridView1);
            LoadStudentFirstList();
            //LoadStudentData();
            //dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void stusysUserControl_Load(object sender, EventArgs e)
        {

            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString; // 設置全局變數

        }

       /* private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // 檢查是否有選取的行
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // 取得選取的第一行
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // 將選取行的各欄位值顯示到對應的 TextBox
                txb_id.Text = selectedRow.Cells["id"].Value?.ToString();
                txb_name.Text = selectedRow.Cells["stu_name"].Value?.ToString();
                txb_phone.Text = selectedRow.Cells["stu_phone"].Value?.ToString();
                txb_address.Text = selectedRow.Cells["stu_address"].Value?.ToString();

                if (selectedRow.Cells["stu_birthday"].Value != null && selectedRow.Cells["stu_birthday"].Value != DBNull.Value)
                {
                    DateTime birthday = Convert.ToDateTime(selectedRow.Cells["stu_birthday"].Value);
                    txb_birthday.Text = birthday.ToString("yyyy-MM-dd"); // 顯示為 "年-月-日"
                }
                else
                {
                    txb_birthday.Text = string.Empty;
                }

                txb_email.Text = selectedRow.Cells["stu_email"].Value?.ToString();
                txbaccountnumber.Text = selectedRow.Cells["user_account"].Value?.ToString();
                txbpassword.Text = selectedRow.Cells["user_password"].Value?.ToString();
            }
        }
       */



        private void LoadStudentData(int studentId) //連SQL資料到datagridview
        {
            string query = @"SELECT c.course_name, c.course_fee, c.course_start, c.course_end
                            FROM courses c
                            JOIN registrations r ON c.id = r.course_id
                            WHERE r.stu_id = @studentId";
                        
            using (SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.Add(new SqlParameter("@studentId", SqlDbType.Int) { Value = studentId });

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                try
                {
                    conn.Open();
                    adapter.Fill(dataTable);

                    // 將資料顯示在 DataGridView 上
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("資料載入失敗：" + ex.Message);
                }
            }
        }

        private void LoadStudentDetails(int studentId)  // 查詢並顯示學生詳細資料
        {
            string selectQuery = @"SELECT s.id, s.stu_name, s.stu_phone, s.stu_address, s.stu_birthday, 
                                   u.user_account, u.user_password
                                   FROM stuinfo s
                                   LEFT JOIN users u ON u.user_name = s.stu_name
                                   WHERE s.id = @StudentId";

            using (SqlConnection connection = new SqlConnection(GlobalVar.strDBConnectionString))
            {
                connection.Open();
                using (SqlCommand selectCmd = new SqlCommand(selectQuery, connection))
                {
                    selectCmd.Parameters.AddWithValue("@StudentId", studentId);
                    using (SqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // 填充資料到相應的 TextBox 和 DateTimePicker
                            txb_id.Text = reader["id"].ToString();
                            txb_name.Text = reader["stu_name"].ToString();
                            txb_phone.Text = reader["stu_phone"].ToString();
                            // 如果 stu_address 是 DBNull，則給空字符串 (if...else簡寫)
                            txb_address.Text = reader["stu_address"] == DBNull.Value ? "" : reader["stu_address"].ToString();

                            txb_birthday.Text = reader["stu_birthday"] == DBNull.Value
                            ? string.Empty
                            : Convert.ToDateTime(reader["stu_birthday"]).ToShortDateString();
                            //dpt_birthday.Value = reader["stu_birthday"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(reader["stu_birthday"]);

                            txbaccountnumber.Text = reader["user_account"] == DBNull.Value ? "" : reader["user_account"].ToString();
                            txbpassword.Text = reader["user_password"] == DBNull.Value ? "" : reader["user_password"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("找不到該學生的資料。", "資料錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void LoadStudentFirstList()
        {
            string query = @"SELECT id, stu_name FROM stuinfo"; // 查詢所有學生資料

            using (SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader;

                try
                {
                    conn.Open();
                    reader = cmd.ExecuteReader();

                    // 清空現有的項目
                    lbox進階搜尋結果.Items.Clear();

                    while (reader.Read())
                    {
                        string studentId = reader["id"].ToString();
                        string studentName = reader["stu_name"].ToString();

                        // 把學生ID和姓名加到ListView
                        string displayText = $"{studentId} - {studentName}";
                        lbox進階搜尋結果.Items.Add(displayText);
                    }

                    // 預設選擇第一個學生（若有資料）
                    if (lbox進階搜尋結果.Items.Count > 0)
                    {
                        lbox進階搜尋結果.SelectedIndex = 0;  // 選擇第一個項目
                        string firstStudentIdString = lbox進階搜尋結果.SelectedItem.ToString().Split('-')[0].Trim();
                        if (int.TryParse(firstStudentIdString, out int firstStudentId))
                        {
                            // 根據第一個學生ID載入資料
                            LoadStudentData(firstStudentId);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("資料載入失敗：" + ex.Message);
                }
            }
        }

        private void textFind關鍵字_TextChanged(object sender, EventArgs e)
        {
            string keyword = textFind關鍵字.Text.Trim();

            // 呼叫搜尋函數，傳遞輸入的關鍵字
            SearchStudents(keyword);
        }
        private void SearchStudents(string keyword)
        {
            // 清空 ListBox
            lbox進階搜尋結果.Items.Clear();

            string query;
            if (string.IsNullOrEmpty(keyword))
            {
                // 若沒輸入關鍵字，顯示所有學生
                query = "SELECT id, stu_name FROM stuinfo";
            }
            else
            {
                // 否則，根據關鍵字搜尋學生
                query = "SELECT id, stu_name FROM stuinfo WHERE stu_name LIKE @Keyword OR stu_phone LIKE @Keyword";
            }

            // 建立資料庫連線
            using (SqlConnection connection = new SqlConnection(GlobalVar.strDBConnectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // 如果有關鍵字，加入參數
                        if (!string.IsNullOrEmpty(keyword))
                        {
                            command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                        }

                        // 執行查詢並讀取結果
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string displayText = $"{reader["id"]} - {reader["stu_name"]}";
                                lbox進階搜尋結果.Items.Add(displayText);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"搜尋過程中發生錯誤: {ex.Message}");
                }
            }
        }

        private void lbox進階搜尋結果_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbox進階搜尋結果.SelectedIndex >= 0)
            {
                // 獲取選中項目的文本
                string selectedItem = lbox進階搜尋結果.SelectedItem.ToString();

                // 假設項目的格式是 "ID - 姓名"，我們用空格分割來獲取學生的 ID
                string studentIdString = selectedItem.Split('-')[0].Trim();

                // 將學生ID轉換為整數型
                if (int.TryParse(studentIdString, out int studentId))
                {
                    // 呼叫已經存在的 LoadStudentDetails 方法，並傳遞選中的學生 ID
                    LoadStudentDetails(studentId);
                    LoadStudentData(studentId);
                }
                else
                {
                    MessageBox.Show("選擇的項目無效，無法加載詳細資料。", "資料錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void textFind關鍵字_Enter(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void textFind關鍵字_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textFind關鍵字.Text))
            {
                pictureBox1.Visible = true;
            }
        }

        private void btn新增資料_Click(object sender, EventArgs e)
        {
            清空資料();
        }

        private void 清空資料()
        {
            txb_id.Text = "";
            txb_name.Text = "";
            txb_phone.Text = "";
            txb_address.Text = "";
            txbaccountnumber.Text = "";
            txbpassword.Text = "";
            txb_birthday.Text = "";
            //dtp生日.Value = DateTime.Now;
            //chb婚姻狀態.Checked = false;
        }

        private void btn儲存新增_Click(object sender, EventArgs e)
        {
            // 获取用户输入的数据
            string name = txb_name.Text;
            string phone = txb_phone.Text;
            string address = txb_address.Text;
            string birthday = txb_birthday.Text;
            //DateTime birthday = dtp生日.Value;
            string account = txbaccountnumber.Text;
            string password = txbpassword.Text;

            // 设置数据库连接字符串
            string connectionString = GlobalVar.strDBConnectionString;

            // 使用 SQL 命令插入数据
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // 打开连接

                    // 插入 stuinfo 表
                    string stuInfoQuery = "INSERT INTO stuinfo (stu_name, stu_phone, stu_address, stu_birthday) VALUES (@name, @phone, @address, @birthday); SELECT SCOPE_IDENTITY();";
                    int stuInfoId = 0;

                    using (SqlCommand command = new SqlCommand(stuInfoQuery, connection))
                    {
                        // 添加参数防止 SQL 注入
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@phone", phone);
                        command.Parameters.AddWithValue("@address", address);
                        command.Parameters.AddWithValue("@birthday", birthday);


                        // 执行插入并获取生成的ID
                        stuInfoId = Convert.ToInt32(command.ExecuteScalar());  // ExecuteScalar() 用来获取返回的 SCOPE_IDENTITY
                        // 调试：打印出捕获的stuInfoId
                        Console.WriteLine("新插入的stuinfo ID: " + stuInfoId);
                    }

                    // 检查stuInfoId是否正确
                    if (stuInfoId == 0)
                    {
                        MessageBox.Show("插入学生信息失败，stuInfoId为0！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;  // 防止继续执行插入users的操作
                    }

                    // 插入 users 表
                    string userQuery = "INSERT INTO users(user_account, user_password, user_name, user_status, stu_id, user_identity) VALUES (@account, @password, @user_name, @user_status, @stu_id, @identity)"; // 获取插入的ID

                    using (SqlCommand command = new SqlCommand(userQuery, connection))
                    {
                        // 添加参数防止 SQL 注入
                        command.Parameters.AddWithValue("@account", account);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@user_name", name);  // 用户名设置为stuinfo的name
                        command.Parameters.AddWithValue("@user_status", false);  // 默认status为false
                        command.Parameters.AddWithValue("@stu_id", stuInfoId);  // 将stuinfo的id作为外键
                        command.Parameters.AddWithValue("@identity", "學生");  // 将identity设置为'學生'

                        command.ExecuteNonQuery(); // 执行插入操作
                    }
                    MessageBox.Show("资料已成功保存！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存资料时发生错误: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // 如果你想清空输入框（可选），可以再次调用清空函数
            清空資料();
        }

        private void btn儲存修改_Click(object sender, EventArgs e)
        {
            int intID = 0; // Id一定要存在
            Int32.TryParse(txb_id.Text, out intID);

            if ((intID) > 0 && (txb_name.Text != "") && (txb_phone.Text != ""))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();

                // 修改SQL語句：使用stuinfo.stu_name, stuinfo.stu_phone, stuinfo.stu_address, stuinfo.stu_birthday以及users.user_name, users.user_account, users.user_password
                string strSQL = @"UPDATE stuinfo
                                  SET 
                                      stu_name = @NewName, 
                                      stu_phone = @NewPhone, 
                                      stu_address = @NewAddress, 
                                      stu_birthday = @NewBirthday
                                  WHERE id = @SearchId;

                                  UPDATE users
                                  SET 
                                      user_name = @NewUserName, 
                                      user_account = @NewUserAccount, 
                                      user_password = @NewUserPassword
                                  WHERE stu_id = @SearchId;";

                SqlCommand cmd = new SqlCommand(strSQL, con); // 資料修改不需要資料庫讀取器
                cmd.Parameters.AddWithValue("@SearchId", intID);
                cmd.Parameters.AddWithValue("@NewName", txb_name.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txb_phone.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txb_address.Text);
                cmd.Parameters.AddWithValue("@NewBirthday", txb_birthday.Text);

                // 假設使用者資料來自其他欄位
                cmd.Parameters.AddWithValue("@NewUserName", txb_name.Text); // 假設有txt使用者名稱欄位
                cmd.Parameters.AddWithValue("@NewUserAccount", txbaccountnumber.Text);  // 假設有txt帳號欄位
                cmd.Parameters.AddWithValue("@NewUserPassword", txbpassword.Text); // 假設有txt密碼欄位

                int rows = cmd.ExecuteNonQuery(); // 回傳受影響的筆數
                con.Close();
                MessageBox.Show($"資料修改成功，{rows}列資料受影響.");
            }
            else
            {
                MessageBox.Show("欄位資料不齊全");
            }
        }

        private void btn刪除資料_Click(object sender, EventArgs e)
        {
            // 解析輸入的 ID，並確保它是有效的
            int intID = 0;
            if (Int32.TryParse(txb_id.Text, out intID) && intID > 0)
            {
                // 創建資料庫連接
                using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString))
                {
                    try
                    {
                        con.Open(); // 打開資料庫連接
                        // 開始一個資料庫事務，保證兩個刪除操作的一致性
                        using (SqlTransaction transaction = con.BeginTransaction())
                        {
                            try
                            {   // 1. 刪除 users 表格的資料                                
                                string deleteUsersSQL = @"DELETE FROM users
                                                          WHERE user_account = 
                                                          (SELECT user_account FROM users WHERE stu_id = @StudentId);";

                                using (SqlCommand cmd = new SqlCommand(deleteUsersSQL, con, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@StudentId", intID);  // 使用學生的 ID 來刪除對應的 users 資料
                                    cmd.ExecuteNonQuery();
                                }

                                // 2. 刪除 stuinfo 表格的資料
                                string deleteStuInfoSQL = @"DELETE FROM stuinfoWHERE id = @StudentId;";

                                using (SqlCommand cmd = new SqlCommand(deleteStuInfoSQL, con, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@StudentId", intID);  // 使用學生的 ID 來刪除對應的 stuinfo 資料
                                    cmd.ExecuteNonQuery();
                                }

                                // 如果兩個刪除操作都成功，提交事務
                                transaction.Commit();

                                // 提示刪除成功
                                MessageBox.Show("資料刪除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // 清空欄位
                                清空資料();
                            }
                            catch (Exception ex)
                            {
                                // 如果有任何錯誤，回滾事務
                                transaction.Rollback();
                                MessageBox.Show($"刪除資料時發生錯誤: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // 資料庫連接失敗或其他錯誤
                        MessageBox.Show($"資料庫連接錯誤: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // 如果 ID 不是有效的，顯示錯誤訊息
                MessageBox.Show("請輸入有效的學生 ID！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int GetSelectedStudentId()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // 假設學生 ID 存儲在 DataGridView 的第一列
                int studentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                return studentId;
            }
            return -1;  // 如果沒有選擇學生，返回 -1
        }

        private bool IsUserExistInUsersTable(int studentId)
        {
            string query = @"SELECT COUNT(1) 
                     FROM users u
                     WHERE u.id = (SELECT id FROM stuinfo WHERE id = @studentId)";

            using (SqlConnection connection = new SqlConnection(GlobalVar.strDBConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@studentId", studentId);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;  // 如果有匹配的 user，返回 true
                }
            }
        }
        private void UpdateStudentInfo(int studentId)  // 更新學生資料
        {
            // 檢查學生 ID 是否有效
            if (studentId <= 0)
            {
                MessageBox.Show("請選擇要更新的學生", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // 如果學生 ID 無效，退出方法
            }


            // 檢查該學生是否在 users 表中有對應資料
            if (!IsUserExistInUsersTable(studentId))
            {
                MessageBox.Show("該學生在 users 表中沒有對應的帳號資料，無法更新。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            //LoadStudentData(); // 按下按鈕時重新載入資料
            int studentId = GetSelectedStudentId(); // 假設您有一個方法來獲取所選學生的 ID

            // 更新學生資料
            UpdateStudentInfo(studentId);
            LoadStudentDetails(studentId);
        }
        
    }
}