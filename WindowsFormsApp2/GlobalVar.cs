using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class GlobalVar
    {
        public static string strDBConnectionString = "";
        public static bool is登入成功 = false;
        public static string 使用者ID = " ";    // 新增這個變數來儲存用戶的 ID
        public static string 使用者名稱 = " ";  // 可以保留這個變數作為顯示名稱
        public static string 使用者帳號 = " ";
        public static string 使用者密碼 = " ";
        public static string 使用者權限 = " ";

        public static string 選擇課程名ID = " ";
        public static string 選擇課程名稱 = " ";

        public static string image_dir = @"D:\職訓\廖薈慈-程式課程\個人專題\圖檔";  //設定代號連接網路磁碟機 //@不分辨特殊符號

        //public static string image_dir = @"C:\Users\iSpan\Desktop\廖薈慈-程式課程\個人專題\圖檔";

        public static HomeForm currentHomeForm = null;
    }
}
