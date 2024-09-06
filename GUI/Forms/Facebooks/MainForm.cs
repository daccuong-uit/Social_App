using GUI.Forms.AccountManagement;
using GUI.UserControls.ControlBar;
using GUI.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ToggleDarkMode()
        {
            AppSettings.IsDarkMode = !AppSettings.IsDarkMode; // Đổi chế độ

            // Cập nhật giao diện
            AppSettings.ApplyTheme(this); 

            AppSettings.SaveSettings(); // Lưu cài đặt
            CallDesignA();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToggleDarkMode();

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
