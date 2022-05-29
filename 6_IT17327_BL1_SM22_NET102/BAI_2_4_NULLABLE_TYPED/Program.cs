﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_4_NULLABLE_TYPED
{
    internal class Program
    {
        #region Định nghĩa
        /*
        * 1. Từ khóa null
        *    + null là một giá trị cố định nó biểu thị không có đối tượng nào cả, có nghĩa là biến có giá trị null không có tham chiếu (trỏ) đến đối tượng nào (không có gì).
             + null chỉ có thể gán được cho các biến kiểu tham chiếu (biến có kiểu dữ liệu là các lớp), không thể gán null cho những biến có kiểu dữ liệu dạng tham trị như int, float, bool ...
        */

        /*
         *2. Sử dụng nullable
         *    + Nếu bạn muốn sử dụng các kiểu dữ liệu nguyên tố như int, float, double ... như là một kiểu dữ liệu dạng tham chiếu, có thể gán giá trị null cho nó, có thể sử dụng như đối tượng ... thì khai báo nó có khả năng nullable, khi biến nullable có giá trị thì đọc giá trị bằng truy cập thành viên .Value, cách làm như sau:
         *    + Khi khai báo biến có khả năng nullable thì thêm vào ? sau kiểu dữ liệu      
         */
        #endregion
        static void Main(string[] args)
        {
            #region Phần 1: Null

            ClassA class1, class2;
            class1 = new ClassA();//Khởi tạo tham chiếu bằng 1 đối tượng
            class2 = class1;//Class2 được gán Class1 và cũng tham chiếu đến cùng 1 đối tượng Class1 đang tham chiếu đến
            class2.Method1();

            class1 = null;//Class1 đang không tham chiếu đến đối tượng nào cả
            class1.Method1();

            #endregion
        }

        class ClassA
        {
            public void Method1()
            {

            }
        }
    }
}
