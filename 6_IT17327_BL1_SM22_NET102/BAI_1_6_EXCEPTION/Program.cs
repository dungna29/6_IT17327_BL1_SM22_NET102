﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_6_EXCEPTION
{
    internal class Program
    {
        #region EXCEPTION - Xử lý ngoại lệ: try + tab
        /*
       * ❑ Exception là các vấn đề phát sinh trong quá trình thực hiện chương trình như: không đọc được tập tin, kiểu dữ liệu sai…
         ❑ Các exception được sinh ra bởi .NET framework CLR hoặc lập trình viên
         ❑ Xử lý ngoại lệ trong C# được xây dựng chủ yếu trên bốn từ khoá try, catch, finally và throw
                             try
                             {                              
                                  //Các câu lệnh
                             }
                             catch (Exception a)
                             {
                                   //Phần code để xử lý lỗi hoặc đơn giản chỉ là show ra lỗi
                             }
                             finally
                             {
                                  //Một khối finally được sử dụng để thực thi một tập hợp lệnh đã cho, dù có hay không một exception đươc ném hoặc không được ném.
                             }
          Một số Exception class thường gặp:
              - Exception [Lớp cơ bản của mọi ngoại lệ.]          
              - SystemException [Lớp cơ bản của mọi ngoại lệ phát ra tại thời điểm chạy của chương trình.]           
              - IndexOutOfRangeException [Được ném ra tại thời điểm chạy khi truy cập vào một phần tử của mảng với chỉ số không đúng.]           
              - NullReferenceException [Ném ra tại thời điểm chạy khi một đối tượng null được tham chiếu.]
              - AccessViolationException [Ném ra tại thời điểm chạy khi tham chiếu vào vùng bộ nhớ không hợp lệ.]
              - InvalidOperationException [Ném ra bởi phương thức khi ở trạng thái không hợp lệ.]           
              - ArgumentException [Lớp cơ bản cho các ngoại lệ liên quan tới đối số (Argument).]
              - ArgumentNullException [Lớp này là con của ArgumentException, nó được ném ra bởi phương thức mà không cho phép thông số null truyền vào.]
              - ArgumentOutOfRangeException [Lớp này là con của ArgumentException, nó được ném ra bởi phương thức khi một đối số không thuộc phạm vi cho phép truyền vào nó.]
              - ExternalException [Lớp cơ bản cho các ngoại lệ xẩy ra hoặc đến từ môi trường bên ngoài.]
              - COMException [Lớp này mở rộng từ ExternalException, ngoại lệ đóng gói thông tin COM.]
              - SEHException [Lớp này mở rộng từ ExternalException, nó tóm lược các ngoại lệ từ Win32.]
       */


        #endregion
        static void Main(string[] args)
        {
        }
    }
}
