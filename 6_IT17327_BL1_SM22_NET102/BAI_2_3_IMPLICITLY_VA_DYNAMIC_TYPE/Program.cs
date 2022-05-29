using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_3_IMPLICITLY_VA_DYNAMIC_TYPE
{
    internal class Program
    {  /*
       * Phần 1: Implicitly,Dynamic
       *          1.1 Implicitly (KIỀU NGẦM ĐỊNH):
       *             ❑Khai báo biến kiểu ngầm định (khai báo không tường minh) là biến được khai báo mà không cần phải chỉ ra kiểu dữ liệu
                     ❑Kiểu dữ liệu của biến sẽ được xác định bởi trình biên dịch dựa vào biểu thức được gán khi khai báo biến
                     ❑Sử dụng từ khóa “var” khi khai báo và cần khởi tạo giá trị
                  1.2 Công thức:
                      var varialble_name = value;
                  1.3 Hạn chế:
                     + Không thể sử dụng từ khóa var bên ngoài phạm vi của một method
                     + Không thể khởi tạo giá trị là null.
                     + Biến phải được khởi tạo giá trị khi nó được khai báo 
                     + Nếu biến được gán giá trị, thì kiểu dữ liệu phải giống        nhau
                     + Giá trị khởi tạo phải là một biểu thức. Giá trị khởi tạo     không được là một đối tượng hay tập hợp các giá trị. Nhưng nó có thể sử dụng toán tử new bởi một đối tượng hoặc tập hợp các giá trị.
                  2.1 Dynamic
                      Kiểu động - ngầm định - khai báo với từ khóa dynamic, thì kiểu thực sự của biến đó được xác định bằng đối tượng gán vào ở thời điểm chạy (khác với kiểu ngầm định var kiểu xác định ngay        thời điểm biên dịch)
       */
        static void Main(string[] args)
        {
            #region  Phần 1: Impliciyly - Kiểu dữ liệu sẽ được định nghĩa ngay khi gán giá trị
            //1. Khai báo
            var temp1 = true;//Impliciyly
            var temp2 = 1;//Impliciyly
            var temp3 = 3.69;//Impliciyly
            var temp4 = "string";//Impliciyly

            int temp5 = 9;//Expliciyly
            //...Ngoài ra nó thể là rất nhiều kiểu dữ liệu khác

            //2. Mặt hạn chế:
            // - không thể khởi tạo giá trị ban đầu là null
            //var temp6 = null;
            
            // - Phải khởi tạo giá trị ngay khi khai báo
            //var temp6;

            // - Nếu biến được gán giá trị, thì kiểu dữ liệu phải giống nhau
            var temp6 = "Giang";
            //temp6 = 1; Lỗi

            // - Giá trị khởi tạo phải là 1 biểu thức. Giá trị khởi tạo không được là 1 đối tượng hay tập giá trị. Nó có thể sử đụng toán tử new bởi 1 đối tượng hoặc tập giá trị khác
            //var temp7 = {5, 8, 9};
            var temp7 = new int[] {5, 8, 9};
            var temp8 = new List<int>() {5, 8, 9};

            // - var không thể khai báo làm biến toàn cục và var không thể sử dụng làm tham số truyền vào của phương thức

            #endregion

            #region Phần 2: Dynamic - Kiểu dữ liệu sẽ được định nghĩa khi biên dịch chương trình
            //1. Khai báo các kiểu dữ liệu giống var
            dynamic x1;
            x1 = 1;
            x1 = "Giang";

            //Khai báo nặc danh
            var SinhVien = new
            {
                Msv = "PH123",
                Ten = "Giang",
                NganhHoc = "C#"
            };
            //Gọi phương thức sử dụng tham ố là dynamic
            Method2(SinhVien,SinhVien.NganhHoc);
            #endregion
        }

        private dynamic temp;

        static void Method2(dynamic temp1,dynamic temp2)
        {
            Console.WriteLine(temp1.Ten + " " + temp2);
        }

        //private var temp = 5;
        // static method1(var temp)
        // {
        //
        // }
    }
}
