using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{    
    public partial class dayUserControl : UserControl
    {
        string _day;
        string date;
        string weekday;
        
        
        public dayUserControl(string day)
        {
            InitializeComponent();
            _day = day;
            label1.Text = day;
            checkBox1.Hide();
            date = btn_儲存新增._month + "/" +_day + "/" + btn_儲存新增._year;
        }

        private void dayUserControl_Load(object sender, EventArgs e)
        {
            sundays();
        }

        private void sundays()
        {
            try 
            {
                DateTime day = DateTime.Parse(date);
                weekday = day.ToString("ddd");
                if (weekday == "Sun")
                {
                    label1.ForeColor = Color.FromArgb(255, 204, 102);
                }
                else
                {
                    label1.ForeColor = Color.FromArgb(174, 146, 105);
                }
            }
            catch (Exception ex)
            {            
            }
        
        }

        private static dayUserControl lastClickedPanel; // 紀錄上次被點擊的 panel
        private void panel1_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(date, "M/d/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
            {
                // 直接傳入 DateTime 型別的 parsedDate
                DateClicked?.Invoke(parsedDate);

                if (lastClickedPanel != null && lastClickedPanel != this)
                {
                    lastClickedPanel.checkBox1.Checked = false;
                    lastClickedPanel.BackColor = Color.White;
                }

                checkBox1.Checked = !checkBox1.Checked;
                this.BackColor = checkBox1.Checked ? Color.FromArgb(255, 204, 102) : Color.White;

                lastClickedPanel = this;
            }
            else
            {
                //MessageBox.Show("無法辨識日期格式，請確認格式為 'MM/dd/yyyy'。");
            }



            /*
            if (lastClickedPanel != null && lastClickedPanel != this)
            {
                lastClickedPanel.checkBox1.Checked = false;
                lastClickedPanel.BackColor = Color.White;
            }
            checkBox1.Checked = !checkBox1.Checked;
            this.BackColor = checkBox1.Checked ? Color.FromArgb(255, 204, 102) : Color.White;

            
            lastClickedPanel = this;
            MessageBox.Show($"日期值: {date}");
            DateTime parsedDate;
            if (DateTime.TryParseExact(date, "M/d/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
            {
                DateClicked?.Invoke(parsedDate);
            }
            else
            {
                MessageBox.Show("日期格式錯誤，請確認日期格式為 'yyyy-MM-dd'。");
            }*/

        }


        public event Action<DateTime> DateClicked;
        private void dayUserControl_Click(object sender, EventArgs e)
        {
            DateClicked?.Invoke(Convert.ToDateTime(date));
        }

        public void SetAppointmentCount(int count)
        {
            if (count > 0)
            {
                lbl_預約數量.Text = $"有{count}筆";
                lbl_預約數量.ForeColor = Color.Red; // 設為紅色或其他醒目顏色
            }
            else
            {
                lbl_預約數量.Text = ""; // 若不顯示文字，可以留空
                lbl_預約數量.ForeColor = Color.Gray; // 或設為淡色，如Gray或Transparent
            }
        }


        //不同Uc 不同尺寸
        public void SetControlSize(Size newSize)
        {
            this.Size = newSize;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        //..
        /*設置不同usercontrol時的大小
        dayUserControl dayControl = new dayUserControl();
        dayControl.Width = 100; // 設定為適合的寬度
        dayControl.Height = 100; // 設定為適合的高度
        flowLayoutPanel1.Controls.Add(dayControl);


        dayUserControl dayControl = new dayUserControl();
        dayControl.Width = 80; // 設定為另一個適合的寬度
        dayControl.Height = 80; // 設定為另一個適合的高度
        flowLayoutPanel1.Controls.Add(dayControl);
        */
        
    }
}
