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
        private UserService _userService;
        public LoginForm()
        {
            InitializeComponent();
            DesignA();

            _userService = new UserService();
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

            uLogin.btnDarkmodeClicked += ULogin_btnDarkmodeClicked;
            uLogin.btnForgotPasswordClicked += ULogin_btnForgotPasswordClicked;
            uLogin.btnRegisterClicked += ULogin_btnbtnRegisterClicked;
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
        private void ULogin_btnBackToLoginClicked(object sender, EventArgs e)
        {
            DesignA();
        }
        private void URegister_btnGoToMainFormClicked(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
        private void ULogin_btnForgotPasswordClicked(object sender, EventArgs e)
        {
            AppSettings.ApplyTheme(this);
            pnlThemeScroll.Controls.Clear();
            UForgotPassword uForgotPassword = new UForgotPassword();
            pnlThemeScroll.Controls.Add(uForgotPassword);
            uForgotPassword.Location = new System.Drawing.Point(0, 0);

            uForgotPassword.btnDarkmodeClicked += ULogin_btnDarkmodeClicked;
            uForgotPassword.btnBackToLoginClicked += ULogin_btnBackToLoginClicked;
        }
        private void ULogin_btnbtnRegisterClicked(object sender, EventArgs e)
        {
            AppSettings.ApplyTheme(this);
            pnlThemeScroll.Controls.Clear();
            URegister uRegister = new URegister(_userService);
            pnlThemeScroll.Controls.Add(uRegister);
            uRegister.Location = new System.Drawing.Point(0, 0);

            uRegister.btnGoToMainFormClicked += URegister_btnGoToMainFormClicked;
            uRegister.btnDarkmodeClicked += ULogin_btnDarkmodeClicked;
        }
    }
}
