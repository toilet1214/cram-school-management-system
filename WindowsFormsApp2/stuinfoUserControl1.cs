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
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class stuinfoUserControl1 : UserControl
    {
        public stuinfoUserControl1()
        {
            InitializeComponent();
        }

        public void SetStudentInfo(string stuId, string name, string phone, string address, string birthday, string email)
        {
            // 設置學生資料到控件上
            txb_id.Text = stuId;
            txb_name.Text = name;
            txb_phone.Text = phone;
            txb_address.Text = address;
            txb_birthday.Text = birthday;
            txb_email.Text = email;
        }

        public void stuinfoUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // 從文本框中獲取資料
            string stuId = txb_id.Text.Trim();
            string stuName = txb_name.Text.Trim();
            string stuPhone = txb_phone.Text.Trim();
            string stuAddress = txb_address.Text.Trim();
            string stuBirthday = txb_birthday.Text.Trim(); // 假設是 "yyyy-MM-dd" 格式
            string stuEmail = txb_email.Text.Trim();
            // 檢查輸入資料是否合法
            if (string.IsNullOrEmpty(stuName) || string.IsNullOrEmpty(stuPhone) || string.IsNullOrEmpty(stuAddress) || string.IsNullOrEmpty(stuBirthday) || string.IsNullOrEmpty(stuEmail))
            {
                MessageBox.Show("所有欄位均為必填，請填寫完整資料", "資料錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // 如果有空值，退出
            }

            // 建立資料庫連接
            string connectionString = GlobalVar.strDBConnectionString; 
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open(); // 開啟資料庫連接

                    // SQL UPDATE 語句，更新學生資料
                    string updateSQL = @"UPDATE stuinfo
                                        SET stu_name = @Name,
                                            stu_phone = @Phone, 
                                            stu_address = @Address, 
                                            stu_birthday = @Birthday, 
                                            stu_email = @Email
                                        WHERE id = @id;";

                    SqlCommand cmd = new SqlCommand(updateSQL, con);
                    // 添加參數，避免 SQL 注入                    
                    cmd.Parameters.AddWithValue("@Phone", stuPhone);
                    cmd.Parameters.AddWithValue("@Address", stuAddress);
                    cmd.Parameters.AddWithValue("@Birthday", DateTime.Parse(stuBirthday)); // 將生日轉換為日期類型
                    cmd.Parameters.AddWithValue("@Email", stuEmail);
                    cmd.Parameters.AddWithValue("@Name", stuName); // 假設 stu_name 是唯一的
                    cmd.Parameters.AddWithValue("@Id", stuId);

                    // 執行 UPDATE 語句
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // 檢查更新是否成功
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("學生資料已成功更新！", "更新成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("更新失敗，請檢查學生資料是否存在。", "更新失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // 捕捉異常並顯示錯誤
                    MessageBox.Show($"資料更新時出現錯誤: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void txb_name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txb_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_birthday_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_email_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
    
}
