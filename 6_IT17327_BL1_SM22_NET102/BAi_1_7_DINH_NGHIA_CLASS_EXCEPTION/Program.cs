using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAi_1_7_DINH_NGHIA_CLASS_EXCEPTION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            try
            {
                DangKyDiClub("BK", 17);
            }
            catch (FpolyException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (AgeException e)
            {
                Console.WriteLine(e.Message);
                e.ChiTietLoi();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void DangKyDiClub(string truong, int tuoi)
        {
           
            if (truong != "FPOLY")
            {
                FpolyException exception = new FpolyException("Bạn không thể tham gia vì không phải sinh viên FPOLY");
                throw exception;
            }

            if (tuoi < 18)
            {
                throw new AgeException("Thông báo: AgeException", 18);
            }

            Console.WriteLine("Chúc mừng tối nay bạn sẽ đi CLUB");
        }

      
    }
}
