using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_2_PARTIAL_CLASS_METHOD
{
    internal partial class ClassA//Class A đang nằm thêm cả trên file Class B
    {
        public int Att3 { get; set; }
        public int Att4 { get; set; }
        public void Method3()
        {
            Console.WriteLine("Method3");
        }
        partial void Method2(string a, int b)
        {
            Console.WriteLine("Method2");
        }
    }
}
