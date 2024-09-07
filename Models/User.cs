using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        public int Id { get; set; } // Khóa chính
        public string EmailAddress { get; set; } // Địa chỉ email
        public string PhoneNumber { get; set; } // Số điện thoại
        public string FirstName { get; set; } // Tên
        public string LastName { get; set; } // Họ
        public string Password { get; set; } // Mật khẩu
        public DateTime CreatedDatetime { get; set; } // Thời gian tạo
        public DateTime UpdatedDatetime { get; set; } // Thời gian cập nhật
    }
}
