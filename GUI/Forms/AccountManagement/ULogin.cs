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
    public partial class ULogin : UserControl
    {
        public event EventHandler btnUserClicked;
        public event EventHandler btnPaswordClicked;
        public event EventHandler btnDarkmodeClicked;
        public event EventHandler btnForgotPasswordClicked;
        public ULogin()
        {
            InitializeComponent();
            ResetA();
        }

        void ResetA()
        {
            txtPassword.PasswordChar = '●';
        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lblUsename.BringToFront();
        }

        private void borUserName_Click(object sender, EventArgs e)
        {
            txtUsername.Focus();
            lblUsename.SendToBack();
            txtUsername.BringToFront();
            btnUserClicked?.Invoke(this, EventArgs.Empty);
            borUserName.BorderColor = ColorTranslator.FromHtml("#1877F2");
        }

        private void lblUsename_Click(object sender, EventArgs e)
        {
            txtUsername.Focus();
            lblUsename.SendToBack();
            txtUsername.BringToFront();
            btnUserClicked?.Invoke(this, EventArgs.Empty);
            borUserName.BorderColor = ColorTranslator.FromHtml("#1877F2");
        }

        private void borderCustome2_Click(object sender, EventArgs e)
        {
            txtPassword.Focus();
            lblPassword.SendToBack();
            txtPassword.BringToFront();
            btnPaswordClicked?.Invoke(this, EventArgs.Empty);
            borPassword.BorderColor = ColorTranslator.FromHtml("#1877F2");
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Focus();
            lblPassword.SendToBack();
            txtPassword.BringToFront();
            btnPaswordClicked?.Invoke(this, EventArgs.Empty);
            borPassword.BorderColor = ColorTranslator.FromHtml("#1877F2");
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            // Kiểm tra nếu ô nhập liệu rỗng
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                lblUsename.BringToFront();
            }
            borUserName.BorderColor = ColorPalette.LightColor2;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            // Kiểm tra nếu ô nhập liệu rỗng
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblPassword.BringToFront();
                txtPassword.SendToBack();
                picEye.Visible = false; // Ẩn icon mắt khi không có ký tự
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

        private void picEye_Click(object sender, EventArgs e)
        {
            if(picEye.Tag.ToString() == "1")
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

        private void llblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnForgotPasswordClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
