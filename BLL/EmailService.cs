using System;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmailService
    {
        private string GetOTP()
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            int length = 6;
            StringBuilder otpBuilder = new StringBuilder();

            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                int index = random.Next(0, characters.Length);
                otpBuilder.Append(characters[index]);
            }

            string otp = otpBuilder.ToString();
            return otp;
        }
        public string SendEmail(string Email)
        {
            MailMessage mail = new MailMessage();
            mail.From = new System.Net.Mail.MailAddress("nguyendaccuong1103@gmail.com");
            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(mail.From.Address, "yjui sqed qiaa vdzs");
            smtp.Host = "smtp.gmail.com";

            //recipient
            string OTP = GetOTP();
            mail.To.Add(new MailAddress(Email));
            mail.IsBodyHtml = true;
            mail.Subject = "Quên mật khẩu";
            mail.Body = "Đây là mã xác minh tài khoản của bạn: " + OTP;

            //for (int i = 0; i < attachmentFilename.Length; i++)
            //    mail.Attachments.Add(new Attachment(attachmentFilename[i]));

            smtp.Send(mail);
            return OTP;
        }
    }
}