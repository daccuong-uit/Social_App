using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Utilities
{
    public static class Helpers
    {
        // Phương thức để định dạng ngày
        public static string FormatDate(DateTime date)
        {
            return date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
        }

        // Phương thức để kiểm tra email hợp lệ
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                MessageBox.Show("Email or number không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool ValidateUsername(string username)
        {
            // Kiểm tra điều kiện tên
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Tên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (username.Length < 3 || username.Length > 20)
            {
                MessageBox.Show("Tên phải có từ 3 đến 20 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Nếu tên hợp lệ
            return true;
        }

        public static bool ValidatePassword(string password)
        {
            // Kiểm tra điều kiện mật khẩu
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Mật khẩu không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (password.Length < 8)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!password.Any(char.IsDigit))
            {
                MessageBox.Show("Mật khẩu phải có ít nhất một số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Nếu mật khẩu hợp lệ
            return true;
        }

        // Phương thức để tạo chuỗi ngẫu nhiên
        public static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            char[] stringChars = new char[length];

            for (int i = 0; i < length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new string(stringChars);
        }
    }
}
