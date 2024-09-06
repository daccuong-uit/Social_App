using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Utilities
{
    public static class Extensions
    {
        // Phương thức mở rộng để lấy phần tử ngẫu nhiên từ danh sách
        public static T GetRandomElement<T>(this IList<T> list)
        {
            if (list == null || list.Count == 0)
                throw new ArgumentException("List is empty or null.");

            Random random = new Random();
            return list[random.Next(list.Count)];
        }

        // Phương thức mở rộng để kiểm tra xem chuỗi có phải là số hay không
        public static bool IsNumeric(this string str)
        {
            return double.TryParse(str, out _);
        }

        // Phương thức mở rộng để chuyển đổi một danh sách thành một chuỗi phân cách
        public static string ToDelimitedString<T>(this IEnumerable<T> list, string delimiter)
        {
            return string.Join(delimiter, list);
        }
    }
}
