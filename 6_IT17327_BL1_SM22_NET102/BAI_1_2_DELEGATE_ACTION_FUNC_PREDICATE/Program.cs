using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_2_DELEGATE_ACTION_FUNC_PREDICATE
{
    internal class Program
    {
        #region  Bài Action, Predicate, Func: Delegate - Generic(Sử dụng sẵn tham số Generic để khai báo)
        /*
         Thay vì chúng ta phải khai báo định nghĩa trước delegate thì chúng ta sẽ sử dụng 3 kiểu dưới đây khai báo cho nhanh.
          Action, Predicate, Func (Viết tắt là APF là cho nhanh) trong C#
            + Action: Action<T in1, T in2, …>. Action tương đương 1 delegate với kiểu trả về là void, với in1, in2 là các params nhận vào.
            + Predicate: Predicate<T in>. Predicate tương đương 1 delegate với kiểu trả về là bool, với in là các param nhận vào. Predicate chỉ có thể nhận vào 1 param duy nhất.
            + Func: Func<T in1, T in2, … , T result>. Function tương đương 1 delegate với kiểu trả về do ta khai báo (result), in1, in2 là các params nhận vào. Func bắt buộc phải trả ra giá trị, không thể trả void.
            Bảng so sánh cách khai báo bằng delegate cùng với cách khai báo tương ứng bằng Action, Predicate, Func:
            delegate void VoidDelegate(int input1, bool input2)	- Action<int, bool>	
            
            delegate bool BoolDelegate(int input1)	-  Predicate<int>	|| Func<int, bool>
            delegate int intDelegate(bool input2)	- Func<bool, int>
            
            delegate void HelloWorldDelegate()	- Action
            delegate bool HelloWorldBoolDelegate()	- Predicate -  Func<bool>
        */


        #endregion       
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
        static void ThongTin3(string msg,int b)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ThongTin2: " + msg);
            Console.ResetColor();
        }

        static int phepNhan(int a,int b)
        {
            return a * b;
        }

        static bool CheckVietHoa(string ten)//dung
        {
            //dung == DUNG
            return ten.Equals(ten.ToLower());
        }

        static void Method1()
        {

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            #region Phan 1: Action

            Action action1;//Tương đương delegate void TenDelegate();
            Action<string> action2;//Tương đương delegate void TenDelegate(string a);
            Action<string,int> action3;//Tương đương delegate void TenDelegate(string a,int b);
            Action<string, string, string, int> action4;//Tương đương delegate void TenDelegate(string a,string b, string c, int d);
            action1 = Method1;
            action2 = ThongTin1;
            action2("Đây là action 2");
            action2?.Invoke("Đây là action 2022");

            #endregion

            #region  Phần 2: Predicate - Chỉ làm việc với các phương thức có kiểu bool
            Predicate<string> predicate1;//Tương đương với 1 delegate bool tendelegate(string a);
            predicate1 = CheckVietHoa;
            predicate1("Dung");
            #endregion

            #region Phần 3: Func
            //Tham số cuối cùng chính là kiểu dữ liệu trả về
            Func<int, int, int> func1;//Tương đương với 1 delegate int tenDelegate(int a, int b);
            func1 = phepNhan;
            func1(5,5);
            Console.WriteLine("Phép nhân của 5 x 5 = "+ func1.Invoke(5,5));
            Func<int, int, string, double> func;

            /*
             * Bài tập ví dụ:
             * Viết 4 phương thức để gán được cho các delegate dưới đây
             * Func<double,double,string,int> funcbt1;
             * Predicate<string,string,bool> predbt2;
             * Action<string,int,double> actionbt3;
             * Func<int,string,string> funcbt4;
             */
            #endregion
            Action<string, int, double> actionbt3 = method1;
        }

        static void method1(string a,int b,double c)
        {

        }
    }
}
