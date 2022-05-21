using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_4_DELEGATE_EVENT2
{
    internal class Program
    {
        public delegate void SuKienNhapSo(int a, int b);

        class ChucNang
        {
            public event SuKienNhapSo suKienNhapSo;

            public void MoiNhapSo()
            {
                Console.WriteLine("Mời nhập số a: ");
                int a = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine("Mời nhập số b: ");
                int b = Convert.ToInt32(Console.ReadLine());
                suKienNhapSo.Invoke(a, b);
            }
        }

        class TinhToan
        {
            public void ThucThiTinhTong(ChucNang cn)
            {
                cn.suKienNhapSo += TinhTong;
            }

            private void TinhTong(int a, int b)
            {
                Console.WriteLine($"{a} + {b} = {a+b}");
            }
        }
        static void Main(string[] args)
        {
            //Phát đi sự kiện
            ChucNang cn = new ChucNang();

            //Nhận sự kiện phát đi
            TinhToan tn = new TinhToan();
            tn.ThucThiTinhTong(cn);

            //Thực thi
            cn.MoiNhapSo();
        }
    }
}
