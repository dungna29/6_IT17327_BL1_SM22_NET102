using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_3_DELEGATE_EVENT
{
    internal class Program
    {
        /*
       * ❑Sự kiện (Event) là các hành động, ví dụ như nhấn phím, click, di chuyển chuột...
         ❑Trong C#, Event là một đối tượng đặc biệt của  Delegate, nó là nơi chứa các phương thức, các phương thức này sẽ được thực thi khi sự kiện xảy ra
         ❑Đặc điểm của event:
             ❖Được khai báo trong các lớp hoặc interface
             ❖Được khai báo là abstract hoặc sealed, virtual
             ❖Được thực thi thông qua delegate
         ❑Tạo và sử dụng event
             ❖Đinh nghĩa delegate cho event
             ❖Tạo event thông qua delegate
             ❖Đăng ký để lắng nghe và xử lý event
             ❖Kích hoạt event
       */
        //Bước 1: Tạo 1 Delegate
        delegate void UpdateName(string name);
        //Bước 2: Tạo class 1 đối tượng
        class Student
        {
            public event UpdateName nameChanged;
            private string name;

            public string Name
            {
                get => name;
                set
                {
                    name = value;
                    //Sự kiện kiểm tra khi tên bị thay đổi
                    if (nameChanged != null)
                    {
                        nameChanged(name);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Student st = new Student();
            st.nameChanged += St_nameChanged;//+= tab sẽ có hình tia chớp chính là 1 sự kiện và nó zen hộ ra 1 phương thức.
            st.Name = "C#2";//Khi gán giá trị mới cho tên thì gọi sự kiện ra
            Console.WriteLine("Tên mới: " + st.Name);
            st.Name = "C#3";
            Console.WriteLine("Tên mới: " + st.Name);
        }

        private static void St_nameChanged(string name)
        {
            Console.WriteLine("Thông báo tên có giá trị new: " + name);
        }
    }
}
