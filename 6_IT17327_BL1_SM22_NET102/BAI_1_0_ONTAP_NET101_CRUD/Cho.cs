using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_0_ONTAP_NET101_CRUD
{
    /*
     * Trong C# và JAVA chỉ có đơn kế thừa
     * Lưu ý: Lớp con mà kế thừa lớp abstract thì sẽ bắt buộc ghi đè lại tất cả các phương thức abstract mà lớp cha có.
     */
    internal class Cho:DongVat
    {
        public int Mau { get; set; }//1. Đỏ - 2. Xanh - 3. Trắng

        public Cho()
        {
            
        }
        //Resharper
        //Tạo contructor có tham số
        //1. Chuột phải vào tên Class Con ở trên -> Quick Actions
        //2. Generate Contructor 'ClassCon(Bên trong có tham số của thuộc tính cha)
        //3. Bôi vào các thuộc tính của con -> Quick Actions -> Add Parameter to contructor -> Chọn cái contructor có tham số vừa Generate ra.
        public Cho(int id, string ten, double canNang, int gioiTinh, int Mau) : base(id, ten, canNang, gioiTinh)
        {
            this.Mau = Mau;
            //this: dùng để tham chiếu đến thuộc tính và phương thức của lớp hiện tại
            //base: dùng để tham chiếu đến thuộc tính và phương thức của lớp cha
        }
        //Muốn kế thừa phương thức của lớp cha
        //1. Chuột phải vào tên Class Con ở trên -> Quick Actions
        //2. Generate Overrides sau đó chọn phương thức các bạn muốn kế thừa
        //3. Khi kế thừa lại phương thức của lớp cha thì phương thức đặt tại lớp con có thể code lại nội dung bên trong thì hành động này gọi là ghi đè phương thức.
        public override void method1(int a)
        {
            base.method1(a);
        }

        public override void method2(int a, int b)
        {
            base.method2(a, b);
        }

        public override void InRaManHinh()
        {
            Console.WriteLine($"{Id} {Ten} {CanNang} {(GioiTinh == 1?"Đực":"Cái")} {(Mau == 1?"Đỏ":Mau == 2?"Xanh":"Đen")}");
        }
    }
}
