using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_2_PARTIAL_CLASS_METHOD
{
    internal class ClassNested
    {
        /*
     * Trong C# nó cho phép bạn khai báo một lớp (class), giao diện (interface), cấu trúc (struct) trong thân một lớp khác - chúng được gọi là kiểu lồng nhau (Nested Type)
     */
        public class ClassD
        {
            public int Att1 { get; set; }

            public ClassD()
            {
                
            }

            public void Method1()
            {

            }
        }
        public class ClassE
        {

        }
    }
}
