using GUI.UserControls.ControlBar;
using GUI.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class MessengerForm : BaseForm
    {
        public MessengerForm()
        {
            InitializeComponent();
            AppSettings.LoadSettings(); // Tải cài đặt
            AppSettings.ApplyTheme(this); // Áp dụng giao diện
        }

        private void ToggleDarkMode()
        {
            AppSettings.IsDarkMode = !AppSettings.IsDarkMode; // Đổi chế độ
            AppSettings.ApplyTheme(this); // Cập nhật giao diện
            AppSettings.SaveSettings(); // Lưu cài đặt
        }
    }
}
