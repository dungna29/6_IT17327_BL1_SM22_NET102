using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_0_ONTAP_NET101_CRUD
{
    internal class Program
    {
        /*
         * Quản lý Chó
         */
        static void Main(string[] args)
        {
            ChoService cs = new ChoService();
            string input;
            do
            {
                Console.WriteLine("1. Thêm");
                Console.WriteLine("2. Sửa");
                Console.WriteLine("3. Xóa");
                Console.WriteLine("4. Xuất ds");
                Console.WriteLine("5. Tìm kiếm");
                Console.WriteLine("6. Thoát");
                Console.WriteLine("Mời bạn chọn chức năng: ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        cs.ThemCho();
                        break;
                    case "2":
                        cs.Sua();
                        break;
                    case "3":
                        cs.Xoa();
                        break;
                    case "4":
                        cs.InDs();
                        break;
                    case "5":
                        cs.TimKiem();
                        break;
                    default:
                        break;
                }
            } while (input != "6");
        }
    }
}
