using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_6_DOC_GHI_DOITUONG
{
    [Serializable]
    internal class Cho : DongVat
    {
        public int Mau { get; set; }//1. Đỏ - 2. Xanh - 3. Trắng

        public Cho()
        {

        }

        public Cho(int id, string ten, double canNang, int gioiTinh, int Mau) : base(id, ten, canNang, gioiTinh)
        {
            this.Mau = Mau;

        }

        public override void InRaManHinh()
        {
            Console.WriteLine($"{Id} {Ten} {CanNang} {(GioiTinh == 1 ? "Đực" : "Cái")} {(Mau == 1 ? "Đỏ" : Mau == 2 ? "Xanh" : "Đen")}");
        }
    }
}
