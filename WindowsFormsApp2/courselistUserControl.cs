using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class courselistUserControl : UserControl
    {
        public courselistUserControl()
        {
            InitializeComponent();
        }

        #region Properties
        private string _title;
        private string _intro;
        private string _fee;
        private string _start;

        private Image _icon;

        [Category("Courses list")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lbl_coursename.Text = $"{value}"; }
        }

        [Category("Courses list")]
        public string Intro
        {
            get { return _intro; }
            set { _intro = value; lbl_courseintro.Text = $"上課時間: {value}"; }
        }

        [Category("Courses list")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }
        }

        [Category("Courses list")]
        public string Fee
        {
            get { return _fee; }
            set { _fee = value; lbl_fee.Text = $"費　　用: {value}"; }
        }

        [Category("Courses list")]
        public string Start
        {
            get { return _start; }
            set
            {   _start = value;
                DateTime date;

                // 嘗試解析日期格式
                if (DateTime.TryParse(value, out date))
                {
                    lbl_start.Text = $"開課日期: {date.ToString("yyyy-MM-dd")}";
                }
                else
                {
                    lbl_start.Text = "開課日期: 無效日期";
                }
            }
        }

        public string IconPath
        {
            get { return _icon?.ToString(); }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _icon = Image.FromFile(value);  // 這裡將檔案路徑轉換為 Image
                    pictureBox1.Image = _icon;      // 更新 PictureBox 顯示圖片
                }
            }
        }
        #endregion

        private void courselistUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
