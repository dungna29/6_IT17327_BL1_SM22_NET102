using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_6_DOC_GHI_DOITUONG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            ChoService cs = new ChoService();
            string input;
            do
            {
                Console.WriteLine("1. Thêm");
                Console.WriteLine("2. Sửa");
                Console.WriteLine("3. Xóa");
                Console.WriteLine("4. Xuất ds");
                Console.WriteLine("5. Tìm kiếm");
                Console.WriteLine("6. Save File");
                Console.WriteLine("7. Read File");
                Console.WriteLine("8. Thoát");
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
                    case "6":
                       cs.LuuFile();
                        break; 
                    case "7":
                        cs.DocFile();
                        break;
                    default:
                        break;
                }
            } while (input != "8");

            /*
             * 1. TÌm kiếm gần đúng theo tên
             * 2. TÌm kiếm cân nặng theo khoảng
             * 3. Sắp xếp theo cân nặng.
             */
        }
    }
}
