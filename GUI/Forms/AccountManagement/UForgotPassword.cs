using GUI.Resources.Styles;
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
        public event EventHandler btnBackToLoginClicked;
        private bool isNext = true;
        public UForgotPassword()
        {
            InitializeComponent();
            ResetA();
        }
        #region --> Design
        private void ResetA()
        {
            if (AppSettings.IsDarkMode)
            {
                cbtnDarkmode.Checked = true;
            }
            else
            {
                cbtnDarkmode.Checked = false;
            }
            txtPassword.PasswordChar = '●';
        }


        private void borderCustome1_Click(object sender, EventArgs e)
        {
            txtUser.Focus();
            lblUser.SendToBack();
            txtUser.BringToFront();
            borderCustome1.BorderColor = ColorTranslator.FromHtml("#1877F2");
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            txtUser.Focus();
            lblUser.SendToBack();
            txtUser.BringToFront();
            borderCustome1.BorderColor = ColorTranslator.FromHtml("#1877F2");
        }

        private void borPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Focus();
            lblPassword.SendToBack();
            txtPassword.BringToFront();
            borPassword.BorderColor = ColorTranslator.FromHtml("#1877F2");
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Focus();
            lblPassword.SendToBack();
            txtPassword.BringToFront();
            borPassword.BorderColor = ColorTranslator.FromHtml("#1877F2");
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            // Kiểm tra nếu ô nhập liệu rỗng
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                lblUser.BringToFront();
                txtUser.SendToBack();
                isNext = false;
            }
            borderCustome1.BorderColor = ColorPalette.LightColor2;
        }

        private void picEye_Click(object sender, EventArgs e)
        {
            if (picEye.Tag.ToString() == "1")
            {
                txtPassword.PasswordChar = '●';
                picEye.Image = Properties.Resources.eye_open_24_black;
                picEye.Tag = "0";
            }
            else
            {
                txtPassword.PasswordChar = '\0';
                picEye.Image = Properties.Resources.eye_24_black;
                picEye.Tag = "1";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            // Kiểm tra nếu ô nhập liệu rỗng
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblPassword.BringToFront();
                txtPassword.SendToBack();
                picEye.Visible = false; // Ẩn icon mắt khi không có ký tự
                isNext = false;
            }
            else
            {
                picEye.Visible = true; // Hiện icon mắt khi có ký tự
            }
            borPassword.BorderColor = ColorPalette.LightColor2;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra khi có thay đổi trong ô mật khẩu
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                picEye.Visible = false; // Ẩn icon mắt khi không có ký tự
            }
            else
            {
                picEye.Visible = true; // Hiện icon mắt khi có ký tự
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            lblUsename.BringToFront();
        }
        //

        // Enter email
        private void borUserName_Click(object sender, EventArgs e)
        {
            txtUsername.Focus();
            lblUsename.SendToBack();
            txtUsername.BringToFront();
            borUserName.BorderColor = ColorTranslator.FromHtml("#1877F2");
        }

        private void lblUsename_Click(object sender, EventArgs e)
        {
            txtUsername.Focus();
            lblUsename.SendToBack();
            txtUsername.BringToFront();
            borUserName.BorderColor = ColorTranslator.FromHtml("#1877F2");
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            // Kiểm tra nếu ô nhập liệu rỗng
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                lblUsename.BringToFront();
                txtUsername.SendToBack();
                isNext = false;
            }
            borUserName.BorderColor = ColorPalette.LightColor2;
        }

        // Back to login form
        private void customButton1_Click(object sender, EventArgs e)
        {
            BackToLogin();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isNext)
            {
                pnlEnterEmail.Visible = false;
                pnlOTPCode.Visible = true;
            }
        }

        // OTP panel
        private void lblOTPEnter_Click(object sender, EventArgs e)
        {
            txtEnterOTP.Focus();
            lblOTPEnter.SendToBack();
            txtEnterOTP.BringToFront();
            borOTP.BorderColor = ColorTranslator.FromHtml("#1877F2");
        }
        private void borOTP_Click(object sender, EventArgs e)
        {
            txtEnterOTP.Focus();
            lblOTPEnter.SendToBack();
            txtEnterOTP.BringToFront();
            borOTP.BorderColor = ColorTranslator.FromHtml("#1877F2");
        }
        private void txtEnterOTP_Leave(object sender, EventArgs e)
        {
            // Kiểm tra nếu ô nhập liệu rỗng
            if (string.IsNullOrWhiteSpace(txtEnterOTP.Text))
            {
                lblOTPEnter.BringToFront();
                txtEnterOTP.SendToBack();
                isNext = false;
            }
            borOTP.BorderColor = ColorPalette.LightColor2;
        }

        private void btnCancelOTP_Click(object sender, EventArgs e)
        {
            pnlEnterEmail.Visible = true;
            pnlOTPCode.Visible = false;
        }

        private void btnNExtOtp_Click(object sender, EventArgs e)
        {
            if (isNext)
            {
                pnlResetPass.Visible = true;
                pnlOTPCode.Visible = false;
            }
        }

        // Resset pass panel
        private void lnlNewpass_Click(object sender, EventArgs e)
        {
            txtNewpass.Focus();
            lnlNewpass.SendToBack();
            txtNewpass.BringToFront();
            borderCustome2.BorderColor = ColorTranslator.FromHtml("#1877F2");
        }

        private void borderCustome2_Click(object sender, EventArgs e)
        {
            txtNewpass.Focus();
            lnlNewpass.SendToBack();
            txtNewpass.BringToFront();
            borderCustome2.BorderColor = ColorTranslator.FromHtml("#1877F2");
        }

        private void lblNewpassAgain_Click(object sender, EventArgs e)
        {
            txtConNewpass.Focus();
            lblNewpassAgain.SendToBack();
            txtConNewpass.BringToFront();
            borderCustome5.BorderColor = ColorTranslator.FromHtml("#1877F2");
        }

        private void borderCustome5_Click(object sender, EventArgs e)
        {
            txtConNewpass.Focus();
            lblNewpassAgain.SendToBack();
            txtConNewpass.BringToFront();
            borderCustome5.BorderColor = ColorTranslator.FromHtml("#1877F2");
        }

        private void txtNewpass_Leave(object sender, EventArgs e)
        {
            // Kiểm tra nếu ô nhập liệu rỗng
            if (Helpers.ValidatePassword(txtNewpass.Text))
            {
                borderCustome2.BorderColor = ColorPalette.LightColor2;
            }
            else
            {
                borderCustome2.BorderColor = Color.Red;
                txtNewpass.SendToBack();
                lnlNewpass.BringToFront();
                isNext = false;
            }
        }

        private void txtConNewpass_Leave(object sender, EventArgs e)
        {
            // Kiểm tra nếu ô nhập liệu rỗng
            if (txtConNewpass.Text != txtNewpass.Text)
            {
                txtConNewpass.SendToBack();
                lblNewpassAgain.BringToFront();
                borderCustome5.BorderColor = Color.Red;
                isNext = false;
            }
            else
            {
                borderCustome5.BorderColor = ColorTranslator.FromHtml("#1877F2");
            }
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            BackToLogin();
        }
        // apply change pass and route to login form
        private void customButton3_Click(object sender, EventArgs e)
        {
            if (isNext)
            {
                BackToLogin();
            }
        }
        private void BackToLogin()
        {
            btnBackToLoginClicked?.Invoke(this, EventArgs.Empty);
        }
        #endregion

        #region --> Appsettings
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


        #endregion

        // Login action
        private void customButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
