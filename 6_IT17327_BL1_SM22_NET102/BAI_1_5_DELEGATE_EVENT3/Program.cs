using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_5_DELEGATE_EVENT3
{
    internal class Program
    { 
    /*
    * Ngoài ra trong C# có sẵn chuẩn tạo ra sẵn sự kiện Delegate
    */
        
        class ChucNang
        {
            public event EventHandler suKienNhapSo;//Tương đương delegate void ten(object sender, EventArgs e)

            public void MoiNhapSo()
            {
                Console.WriteLine("Mời nhập số a: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời nhập số b: ");
                int b = Convert.ToInt32(Console.ReadLine());
                suKienNhapSo.Invoke(this,new ChucNang1(a,b));
            }
        }

        class ChucNang1:EventArgs
        {
            public int a { get; set; }
            public int b { get; set; }

            public ChucNang1(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
        }
        class TinhToan
        {
            public void ThucThiTinhTong(ChucNang cn)
            {
                cn.suKienNhapSo += TinhTong; ;
            }

            private void TinhTong(object sender, EventArgs e)
            {
                ChucNang1 cn1 = (ChucNang1) e;
                Console.WriteLine($"{cn1.a} + {cn1.b} = {cn1.a + cn1.b}");
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
