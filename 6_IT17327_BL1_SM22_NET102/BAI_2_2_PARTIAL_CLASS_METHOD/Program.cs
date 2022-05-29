using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_2_PARTIAL_CLASS_METHOD
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            /*
             * Phần 1:  Sử dụng Partial Class
             * Khi sử dụng đối tượng ClassA hoàn toàn bình thường như các class đã được học chỉ khác nó được tách thành 2 file.
             */
            ClassA classA = new ClassA();
            classA.Att1 = 1;
            classA.Att3 = 2;
            classA.Method1();
            classA.Method3();

            /*
           * Phần 2: Sử dụng Class lồng nhau Nested
           ** Lớp Nested được khai báo, định nghĩa trong lớp Container, nếu phạm vị lớp public, thì bên ngoài sử dụng lớp con này bằng cách chỉ rõ Container.Nested
           */
            ClassNested.ClassD classD = new ClassNested.ClassD();
            classD.Att1 = 1;
            classD.Method1();
            
        }
    }
}
