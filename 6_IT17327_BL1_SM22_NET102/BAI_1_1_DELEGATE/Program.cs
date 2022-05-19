using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_1_DELEGATE
{
    internal class Program
    {
        #region Định nghĩa Delegate
        /*
       * Định nghĩa:
           * ❑Delegate là một biến chứa tham chiếu đến phương thức cần thực thi.
             ❑Một delegate có thể trỏ tới một hoặc nhiều phương thức
             ❑Delegate có thể gọi bất kỳ phương thức nào nó trỏ tới tại thời điểm thực thi
             ❑
       * + Có thể khai báo trong namespace hoặc khai báo trong class
       * + Khi khai báo giống như khai báo một phương thức
       * + Công thức:
       *      <phạm vi truy cập> delegate <kiểu phương thức> <tên>(<Tham số>); 
       */


        #endregion
        //Khai báo 1 delegate
        public delegate void ThongBao(string noiDung);

        static void ThongTin1(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ThongTin1: " + msg);
            Console.ResetColor();
        } 
        static void ThongTin2(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ThongTin2: " + msg);
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");

            #region Phần 1: Khởi tạo Delegate với null

            Console.WriteLine("===Phần 1: Khởi tạo Delegate null===");
            ThongBao thongBao = null;//khai báo và gán giá trị cho delgate = null
            thongBao = ThongTin1;//Gán phương thức cho delegate và delegate sẽ trỏ đến phương thức đó.
            thongBao?.Invoke("Chào các bạn học delegate C#2");//? Dùng để kiểm tra xem delegate có null hay không và nếu không thì sẽ thực thi delegate đó.

            #endregion

            #region Phần 2: Khởi tạo delegate
            Console.WriteLine("===Phần 2: Khởi tạo Delegate===");
            ThongBao thongBao2 = new ThongBao(ThongTin2);
            thongBao2("Đây là thông báo 2");

            #endregion

            #region Phần 3: Multicast Delegates
            Console.WriteLine("===Phần 3: Multicast Delegate===");
            ThongBao thongBao3 = new ThongBao(ThongTin1);
            ThongBao thongBao4 = new ThongBao(ThongTin2);
            ThongBao multicastDelegate = thongBao3 + thongBao4;
            //multicastDelegate += thongBao3;
            multicastDelegate -= thongBao3;
            multicastDelegate("Multicast Delegate");

            #endregion

            #region Phần 4: Delegate Callback
            Console.WriteLine("===Phần 4: Delegate Callback===");
            DelegateCallBack delegateCall = new DelegateCallBack(ThongTin3);
            CallBack(delegateCall);

            #endregion
        }

        #region Phần 4: Delegate Callback

        public delegate void DelegateCallBack(int value);

        static void ThongTin3(int a)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("ThongTin3 : " + a);
            Console.ResetColor();
        }

        static void CallBack(DelegateCallBack delegateCallBack)
        {
            Console.WriteLine("Mời bạn nhập số nguyên: ");
            int temp = Convert.ToInt32(Console.ReadLine());
            delegateCallBack(temp);
        }

        #endregion
    }
}
