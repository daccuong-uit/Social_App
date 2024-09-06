using GUI.Resources.Styles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Utilities
{
    public static class AppSettings
    {
        public static bool IsDarkMode { get; set; } = false; // Mặc định là chế độ sáng

        public static void ApplyTheme(Form form)
        {
            if (IsDarkMode)
            {
                // Thiết lập giao diện cho chế độ tối
                form.BackColor = ColorPalette.DarkColor1;
                form.ForeColor = ColorPalette.LightColor1;
            }
            else
            {
                // Thiết lập giao diện cho chế độ sáng
                form.BackColor = ColorPalette.LightColor1;
                form.ForeColor = ColorPalette.DarkColor1;
            }
        }

        public static void LoadSettings()
        {
            IsDarkMode = Properties.Settings.Default.IsDarkMode;
        }

        public static void SaveSettings()
        {
            Properties.Settings.Default.IsDarkMode = IsDarkMode;
            Properties.Settings.Default.Save();
        }

        // Tải cài đặt khi khởi động ứng dụng
        //AppSettings.IsDarkMode = Properties.Settings.Default.IsDarkMode;

        //// Lưu cài đặt khi thay đổi
        //Properties.Settings.Default.IsDarkMode = AppSettings.IsDarkMode;
        //Properties.Settings.Default.Save();

        //private void ApplyTheme()
        //{
        //    if (AppSettings.IsDarkMode)
        //    {
        //        // Thiết lập giao diện cho chế độ tối
        //    }
        //    else
        //    {
        //        // Thiết lập giao diện cho chế độ sáng
        //    }
        //}

        //private void ToggleDarkMode()
        //{
        //    AppSettings.IsDarkMode = !AppSettings.IsDarkMode; // Đổi chế độ
        //    ApplyTheme(); // Cập nhật giao diện
        //}
    }


}
