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
    public partial class loginForm : Form
    {
        
        public loginForm()
        {
            InitializeComponent();
                        
        }
        public void loginForm_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString; // 設置全局變數
        }

        private void rdbStudent_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbTeacher_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txbaccountnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbpassword_TextChanged(object sender, EventArgs e)
        {
            

        }


        //public HomeForm _homeForm; // 保存HomeForm的參考

        //// 新建構函式，接受一個HomeForm參數
        //public loginForm(HomeForm homeForm)
        //{
        //    _homeForm = homeForm;  // 確保初始化 _homeForm

        //}
        public void btnlogin_Click(object sender, EventArgs e)
        {
            string connectionString = @"."; // 替換為你的資料庫連接字串
            string username = txbaccountnumber.Text.Trim();
            string password = txbpassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                // 帳號或密碼未填寫，顯示提示
                MessageBox.Show("請登入帳號或密碼", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbaccountnumber.Clear();
                txbpassword.Clear();
                return; // 中止執行
            }

            // 檢查帳號和密碼是否正確
            if (username != " " && password != "")  //SQL後改成 if (userCount > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();                         //打開資料庫連接
                string strSQL = "select * from users where user_account=@Searchaccount and user_password=@Searpassword;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Searchaccount", username);
                cmd.Parameters.AddWithValue("@Searpassword", password);
                SqlDataReader reader = cmd.ExecuteReader();


                // 檢查是否有登入成功的用戶
                if (reader.Read())
                {
                    // 確認身份是否符合選擇
                    string userIdentity = reader["user_identity"].ToString(); // 獲取用戶身份

                    if (rdbStudent.Checked && userIdentity == "學生" ||
                        rdbTeacher.Checked && userIdentity == "老師")
                    {
                        // 登入成功
                        GlobalVar.is登入成功 = true;
                        GlobalVar.使用者名稱 = reader["user_name"].ToString(); // 用戶名稱 ////username來源自sql輸入確保一致
                        GlobalVar.使用者ID = reader["id"].ToString(); // 假設 id 是你資料表中的主鍵
                        GlobalVar.使用者權限 = userIdentity; // 根據身份設置權限
                        

                        //第二種避免多個開個command (在這裡關閉 DataReader  
                        reader.Close();

                        // 更新 user_status 為 true (1)
                        string updateSQL = "UPDATE users SET user_status = 1 WHERE user_account = @Searchaccount;";
                        SqlCommand updateCmd = new SqlCommand(updateSQL, con);
                        updateCmd.Parameters.AddWithValue("@Searchaccount", username);
                        updateCmd.ExecuteNonQuery(); // 執行更新命令
                        

                        //MessageBox.Show("登入成功");

                        /*// 如果是學生身份，獲取學生信息並顯示在 stuinfoForm
                        if (userIdentity == "學生")
                        {
                            // 查詢學生資料 (stu_info)
                            string stuInfoQuery = "SELECT stu_name, stu_phone, stu_address, stu_birthday, stu_email FROM stuinfo WHERE stu_name = @stuName;";
                            SqlCommand stuInfoCmd = new SqlCommand(stuInfoQuery, con);
                            stuInfoCmd.Parameters.AddWithValue("@stuName", GlobalVar.使用者名稱);
                            SqlDataReader stuReader = stuInfoCmd.ExecuteReader();

                            if (stuReader.Read())
                            {
                                // 获取学生信息
                                string studentName = stuReader["stu_name"].ToString();
                                string studentPhone = stuReader["stu_phone"].ToString();
                                string studentAddress = stuReader["stu_address"].ToString();
                                string studentBirthday = Convert.ToDateTime(stuReader["stu_birthday"]).ToString("yyyy-MM-dd");
                                string studentEmail = stuReader["stu_email"].ToString();

                                // 创建 stuinfoForm 并将学生信息传递给它
                                stuinfoForm infoForm = new stuinfoForm();
                                infoForm.SetStudentInfo(studentName, studentPhone, studentAddress, studentBirthday, studentEmail);
                                //infoForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("學生資料未找到", "資料錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            // 關閉學生資料的 DataReader
                            stuReader.Close();
                        }*/


                        // 創建 HomeForm 並傳遞用戶名稱
                        HomeForm homeForm = new HomeForm();
                        homeForm.SetUserName(GlobalVar.使用者名稱); // 更新 HomeForm 中的 iconButton_login 的文本
                        homeForm.Show();

                        this.Hide();
                        
                    }
                    else
                    {
                        // 如果用戶身份不匹配，顯示錯誤提示
                        MessageBox.Show("帳號和身份不符，請檢查您的選擇。", "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txbaccountnumber.Clear(); // 清除帳號
                        txbpassword.Clear(); // 清除密碼

                    }
                }
                else
                {
                    // 帳號密碼錯誤，顯示提示
                    MessageBox.Show("帳號或密碼輸入錯誤", "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbaccountnumber.Clear();
                    txbpassword.Clear();
                }

                // 確保關閉資料庫連接
                if (reader != null) reader.Close();
                if (con != null) con.Close();

            }

            else
            {
                // 帳號密碼錯誤，顯示提示
                MessageBox.Show("帳號或密碼輸入錯誤", "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbaccountnumber.Clear(); // 清除帳號
                txbpassword.Clear(); // 清除密碼
            }
        }

        private void linkLabelsignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }





        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
