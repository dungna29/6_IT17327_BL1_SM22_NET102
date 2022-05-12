using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_0_ONTAP_NET101_CRUD
{
    //Lớp cha
    /*
     * Lớp abstract thì nó phải có phương thức abstract
     */
    internal abstract class DongVat
    {
        //Phần 1: Triển khai các Property cần có của đối tượng
        //prop + tab
        public int Id { get; set; }
        public string Ten { get; set; }
        public double CanNang { get; set; }
        public int GioiTinh { get; set; }

        //Phần 2: Contructor - Khi mới học dùng đủ 2 Contructor
        public DongVat()
        {

        }
        //Resharper => ctorp
        //Alt + Enter => Gen...Contructor
        public DongVat(int id, string ten, double canNang, int gioiTinh)
        {
            Id = id;
            Ten = ten;
            CanNang = canNang;
            GioiTinh = gioiTinh;
        }
        //Phần 3: Phương thức của đối tượng.
        public virtual void method1(int a)
        {
        }
        public virtual void method2(int a, int b)
        {
        }
        private void method3(int a, int b)
        {
        }
        /*
         * 1. Overloading(nạp chồng phương thức): Các phương thức được trùng tên nhưng phải khác tham số. Khi sử dụng thì số lượng tham số và kiểu dữ liệu truyền vào sẽ quyết định gọi vào phương thức nào.
         * 2. Overriding (Ghi đè phương thức): Nhớ đến kế thừa - Phương thức lớp con ghi đè lại phương thức của lớp cha. Phương thức của lớp con phải giống tuyệt đối phương thức lớp cha.
         */

        //Phương thức abstract: Không có body code
        public abstract void InRaManHinh();
    }
}
