using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Profile
    {
        public int Id { get; set; } // Khóa chính
        public int UserId { get; set; } // Khóa ngoại tham chiếu tới User
        public string FirstName { get; set; } // Tên
        public string LastName { get; set; } // Họ
        public DateTime? DateOfBirth { get; set; } // Ngày sinh (có thể để trống)
        public string Gender { get; set; } // Giới tính
        public string Country { get; set; } // Quốc gia
        public string AvatarPhoto { get; set; } // Đường dẫn tới ảnh đại diện
        public string CoverPhoto { get; set; } // Đường dẫn tới ảnh bìa
        public string Bio { get; set; } // Thông tin cá nhân
    }
}
