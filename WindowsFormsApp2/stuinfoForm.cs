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
    public partial class stuinfoForm : Form
    {
        public stuinfoForm()
        {
            InitializeComponent();
        }

        public void stuinfoForm1_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString; // 設置全局變數
        }

        // 公共方法来设置学生信息
        public void SetStudentInfo(string name, string phone, string address, string birthday, string email)
        {
            txb_name.Text = name;
            txb_phone.Text = phone;
            txb_address.Text = address;
            txb_birthday.Text = birthday;
            txb_email.Text = email;
        }

        public void btn_save_Click(object sender, EventArgs e)
        {

        }

        public void btn_cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
