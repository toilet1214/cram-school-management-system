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
    public partial class coursesForm : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        List<string> list課程名稱 = new List<string>(); //value
        List<int> list課程價格 = new List<int>();       //value
        List<string> list課程介紹 = new List<string>();  //value
        List<int> listId = new List<int>();             //key

        public coursesForm()
        {
            InitializeComponent();
        }

        private void listView_course_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void coursesForm_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();
            讀取課程資料庫();

            Console.WriteLine("Form Load!!");
        }

        void 讀取課程資料庫()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select top 200 * from courses;";
            SqlCommand sqlCommand = new SqlCommand(strSQL, con);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            int count = 0;
            while (reader.Read())
            {
                listId.Add((int)reader["id"]);
                list課程名稱.Add((string)reader["course_name"]);
                list課程價格.Add((int)reader["course_fee"]);
                list課程介紹.Add((string)reader["course_intro"]);


                /*string image_name = (string)reader["pimage"];
                string 完整圖檔路徑 = GlobalVar.image_dir + @"\" + image_name;
                Console.WriteLine(完整圖檔路徑);
                System.IO.FileStream fs = System.IO.File.OpenRead(完整圖檔路徑); //命名空間system.IO 可以把完整圖案路徑存在Filestrem
                Image img商品圖檔 = Image.FromStream(fs);  //存成圖檔格式  //如果當掉有時是圖檔相容性問題
                image商品圖檔.Images.Add(img商品圖檔);//加入圖檔
                fs.Close();*/

                count++;
            }

            Console.WriteLine($"共有{count}筆資料");
            reader.Close();
            con.Close();
        }
    }
}
