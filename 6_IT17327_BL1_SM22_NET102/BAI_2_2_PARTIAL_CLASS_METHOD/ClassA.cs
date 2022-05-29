using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_2_PARTIAL_CLASS_METHOD
{
    // Sử dụng từ khóa partial đứng trước class
    /*
     * partial class là kỹ thuật giúp giải quyết vấn đề chia một class thành 2 hoặc nhiều file tương tự như kiểu chia thành các phần nhỏ để quản trị.
     */
    internal partial class ClassA
    {
        public int Att1 { get; set; }
        public int Att2 { get; set; }

        public ClassA()
        {
            
        }

        public void Method1()
        {
            Console.WriteLine("Method1");
        }

        //partial method
        /*
        * Phương thức partial khai báo, không có body code
        * Bạn có thể dùng từ khóa partial trong khai báo các phương thức, tuy nhiên mục đích chỉ để chia làm 2 nơi, Một nơi làm khai báo và một nơi triển khai.
        */
        partial void Method2(string a, int b);
    }
}
