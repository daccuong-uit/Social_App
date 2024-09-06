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

namespace GUI.Forms.AccountManagement
{
    public partial class UForgotPassword : UserControl
    {
        public event EventHandler btnDarkmodeClicked;
        public UForgotPassword()
        {
            InitializeComponent();
        }

        private void cbtnDarkmode_CheckedChanged(object sender, EventArgs e)
        {
            // Kiểm tra trạng thái chế độ tối
            if (cbtnDarkmode.Checked) // Nếu CheckBox được chọn
            {
                AppSettings.IsDarkMode = false; // Tắt chế độ tối
            }
            else
            {
                AppSettings.IsDarkMode = true; // Bật chế độ tối
            }

            // Gọi sự kiện nút
            btnDarkmodeClicked?.Invoke(this, EventArgs.Empty);

            // Lưu cài đặt
            AppSettings.SaveSettings(); // Lưu cài đặt
        }
    }
}
