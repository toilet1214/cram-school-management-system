using FontAwesome.Sharp;
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
    public partial class signupUserControl : UserControl
    {
        public signupUserControl()
        {
            InitializeComponent();
        }

        string placeholder = "---   請輸入 例: 1900-12-31";

        private void signupUserControl_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            //scsb.MultipleActiveResultSets = true; // 啟用多個活動結果集  //除錯:回傳SQL status時已開啟過相關的command

            GlobalVar.strDBConnectionString = scsb.ConnectionString; // 設置全局變數

            txb_birthday.Text = placeholder;
            txb_birthday.ForeColor = Color.Gray;  // 設置為灰色顯示提示文本
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            string userName = txb_name.Text.Trim();
            string userPhone = txb_phone.Text.Trim();
            string userAddress = txb_address.Text.Trim(); 
            string userBirthday = txb_birthday.Text.Trim(); 
            string userEmail = txb_email.Text.Trim(); 
            string userAccount = txbaccountnumber.Text.Trim();
            string userPassword = txbpassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(userAccount) || string.IsNullOrWhiteSpace(userPassword) ||
    string.IsNullOrWhiteSpace(userAddress) || string.IsNullOrWhiteSpace(userBirthday) || string.IsNullOrWhiteSpace(userEmail) ||
    string.IsNullOrWhiteSpace(userPhone))  
            {
                MessageBox.Show("請確保所有欄位都已填寫", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 驗證電子郵件格式
            try
            {
                var addr = new System.Net.Mail.MailAddress(userEmail);
                if (addr.Address != userEmail)
                {
                    throw new FormatException();
                }
            }
            catch
            {
                MessageBox.Show("電子郵件格式無效", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 驗證生日格式 (假設為 yyyy-MM-dd 格式)
            DateTime birthDate;
            if (!DateTime.TryParseExact(userBirthday, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out birthDate))
            {
                MessageBox.Show("請輸入有效的生日日期 (格式: yyyy-MM-dd)", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 檢查帳號是否已經存在
            if (CheckIfAccountExists(userAccount))
            {
                MessageBox.Show("此帳號已被註冊過\n請重新註冊", "註冊錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // 直接設置用戶身份為學生
            string userIdentity = "學生";
            

            //構建 SQL 插入語句
            string strSQL = "INSERT INTO users (user_name, user_account, user_password, user_identity, user_status) " +
                    "VALUES (@userName, @userAccount, @userPassword, @userIdentity, @userStatus); " +
                    "SELECT SCOPE_IDENTITY();";

            string stuInfoQuery = "INSERT INTO stuinfo (stu_name, stu_phone, stu_address, stu_birthday, stu_email) " +
                          "VALUES (@stuName, @stuPhone, @stuAddress, @stuBirthday, @stuEmail); " +
                          "SELECT SCOPE_IDENTITY();";

            using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString))
            {
                con.Open();

                // 插入 users 表並取得新插入用戶的 ID
                SqlCommand com = new SqlCommand(strSQL, con);
                com.Parameters.AddWithValue("@userName", userName);
                com.Parameters.AddWithValue("@userAccount", userAccount);
                com.Parameters.AddWithValue("@userPassword", userPassword);
                com.Parameters.AddWithValue("@userIdentity", userIdentity); // 直接使用 "學生"
                com.Parameters.AddWithValue("@userStatus", 0); // 設置狀態為 false

                int userId = Convert.ToInt32(com.ExecuteScalar()); // 執行 SQL 並獲取用戶 ID

                // 插入 stuinfo 表並取得學生 ID
                SqlCommand stuCmd = new SqlCommand(stuInfoQuery, con);
                stuCmd.Parameters.AddWithValue("@stuName", userName);  // 假設學生姓名與用戶名稱相同
                stuCmd.Parameters.AddWithValue("@stuPhone", userPhone);
                stuCmd.Parameters.AddWithValue("@stuAddress", userAddress);
                stuCmd.Parameters.AddWithValue("@stuBirthday", userBirthday);
                stuCmd.Parameters.AddWithValue("@stuEmail", userEmail);

                int stuId = Convert.ToInt32(stuCmd.ExecuteScalar()); // 執行 SQL 並獲取學生 ID

                // 更新 users 表中的 stu_id 欄位，將其設置為剛才插入的 stuinfo 表中的 id
                string updateUserSQL = "UPDATE users SET stu_id = @stuId WHERE id = @userId";
                SqlCommand updateCmd = new SqlCommand(updateUserSQL, con);
                updateCmd.Parameters.AddWithValue("@stuId", stuId);
                updateCmd.Parameters.AddWithValue("@userId", userId);

                updateCmd.ExecuteNonQuery(); // 執行更新操作
                
            }
                        

            MessageBox.Show("註冊成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txb_name.Text = string.Empty;
            txb_phone.Text = string.Empty;
            txb_address.Text = string.Empty;
            txb_birthday.Text = string.Empty;
            txb_email.Text = string.Empty;
            txbaccountnumber.Text = string.Empty;
            txbpassword.Text = string.Empty;
        }

        // 檢查帳號是否已經存在
        private bool CheckIfAccountExists(string userAccount)
        {
            string query = "SELECT COUNT(*) FROM users WHERE user_account = @userAccount";

            using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString))
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@userAccount", userAccount);

                con.Open();
                int count = (int)command.ExecuteScalar(); // 獲取匹配的數量
                return count > 0; // 如果數量大於0，表示帳號已存在
            }
        }

        // 清空所有文本框的函數
        private void ClearInputFields()
        {
            txb_name.Clear();
            txb_phone.Clear();
            txb_address.Clear();
            txb_birthday.Clear();
            txb_email.Clear();
            txbaccountnumber.Clear();
            txbpassword.Clear();
            rdbStudent.Checked = true; // 強制選擇學生身份
        }

        private void txb_birthday_Enter(object sender, EventArgs e)
        {
            if (txb_birthday.Text == placeholder)
            {
                txb_birthday.Text = "";
                txb_birthday.ForeColor = Color.Black;  // 使用者開始輸入時改為黑色
            }
        }


        private void txbaccountnumber_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
