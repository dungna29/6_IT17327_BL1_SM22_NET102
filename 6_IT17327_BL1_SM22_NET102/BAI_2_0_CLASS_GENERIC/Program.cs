using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_0_CLASS_GENERIC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            /*
             * Ví dụ 1: Sử dụng 1 lớp Generic
             */
            FPOLY_GENERIC<double> classG = new FPOLY_GENERIC<double>();
            classG.Temp = 5.9;
            Console.WriteLine(classG.GetValue());
            /*
            * Ví dụ 2: Triển khai 1 đối tượng có 1 thuộc tính là mảng chưa xác kiểu dữ liệu
            * 1. Khai báo 1 mảng
            * 2. Nhập giá trị
            * 3. In tất cả phần tử trong mảng
            */
            Console.WriteLine("Mời bạn nhập số lượng phần tử: ");
            int size = Convert.ToInt32(Console.ReadLine());
            PTPM_GENERIC<string> pg = new PTPM_GENERIC<string>(size);//Khởi tạo kích thước mảngsd
            for (int i = 0; i < pg.Arr.Length; i++)
            {
                Console.Write($"Mời bạn nhập PT thứ {i}:");
                pg.AddArray(i,Console.ReadLine());
            }

            Console.WriteLine("Xuất các phần tử trong mảng");
            for (int i = 0; i < pg.Arr.Length; i++)
            {
                Console.Write(pg.Arr[i] + " ");
            }
        }
    }
}
