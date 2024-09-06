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

namespace GUI.Forms.AccountManagement
{
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
            DesignA();

        }

        private void ToggleDarkMode()
        {
            AppSettings.IsDarkMode = !AppSettings.IsDarkMode; // Đổi chế độ

            // Cập nhật giao diện
            AppSettings.ApplyTheme(this);

            AppSettings.SaveSettings(); // Lưu cài đặt
            CallDesignA();
        }

        private void DesignA()
        {
            AppSettings.ApplyTheme(this);
            pnlThemeScroll.Controls.Clear();
            ULogin uLogin = new ULogin();
            pnlThemeScroll.Controls.Add(uLogin);
            uLogin.Location = new System.Drawing.Point(0, 0);

            uLogin.btnUserClicked += ULogin_btnUserClicked;
            uLogin.btnPaswordClicked += ULogin_btnPasswordClicked;
            uLogin.btnDarkmodeClicked += ULogin_btnDarkmodeClicked;
            uLogin.btnForgotPasswordClicked += ULogin_btnForgotPasswordClicked;
        }

        private void ULogin_btnUserClicked(object sender, EventArgs e)
        {
            
        }
        private void ULogin_btnPasswordClicked(object sender, EventArgs e)
        {

        }
        private void ULogin_btnDarkmodeClicked(object sender, EventArgs e)
        {
            ToggleDarkMode();
        }
        private void ULogin_btnForgotPasswordClicked(object sender, EventArgs e)
        {
            AppSettings.ApplyTheme(this);
            pnlThemeScroll.Controls.Clear();
            UForgotPassword uForgotPassword = new UForgotPassword();
            pnlThemeScroll.Controls.Add(uForgotPassword);
            uForgotPassword.Location = new System.Drawing.Point(0, 0);

            uForgotPassword.btnDarkmodeClicked += ULogin_btnDarkmodeClicked;
        }
    }
}
