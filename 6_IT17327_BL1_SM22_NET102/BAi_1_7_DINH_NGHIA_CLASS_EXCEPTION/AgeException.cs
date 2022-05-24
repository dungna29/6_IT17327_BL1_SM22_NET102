using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAi_1_7_DINH_NGHIA_CLASS_EXCEPTION
{
    internal class AgeException:Exception
    {
        public int Age { get; set; }

        public AgeException(string message, int age) : base(message)
        {
            Age = age;
        }

        public void ChiTietLoi()
        {
            Console.WriteLine($"Tuổi của bạn là {Age} chưa đủ tuổi vào CLUB.");
        }
    }
}
