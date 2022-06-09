using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_9_LINQ_CACCAULENH
{
    internal class Program
    {
        private static ServiceAll _sv = new ServiceAll();
        private static List<NhanVien> _lstNhanViens;
        private static List<TheLoai> _lstTheLoais;
        private static List<SanPham> _lsSanPhams;
        public Program()
        {
            _lstNhanViens = _sv.GetListNhanViens();
            _lstTheLoais = _sv.GetListTheLoais();
            _lsSanPhams = _sv.GetListSanPhams();
        }
        static void Main(string[] args)
        {
            //Gọi các ví dụ về lý thuyết lên để chạy
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Program program = new Program();//Khi khởi tạo thì các List trên sẽ có giá trị
            LINQ_GroupBy();
        }
        #region 1. Where điều kiện lọc

        static void LINQ_WHERE()
        {
            //1. Lấy danh sách những người có số điện thoai Viettel 098 Vina 091
            var lstSdt1 =
                from a in _lstNhanViens
                where a.Sdt.StartsWith("098") || a.Sdt.StartsWith("091")
                select a;

            var lstSdt2 = _lstNhanViens.Where(c => c.Sdt.StartsWith("098") || c.Sdt.StartsWith("091"));

            foreach (var x in _lstNhanViens.Where(c => c.Sdt.StartsWith("098") || c.Sdt.StartsWith("091")))
            {
                x.InRaManHinh();
            }
        }

        #endregion
        #region 2. Toán tử OfType để lọc các kiểu dữ liệu

        static void LINQ_OfType()
        {
            List<dynamic> lst1 = new List<dynamic>() { 9, "Chín", 8, "Tám" };

            var lst2 =
                from a in lst1.OfType<string>() select a;

            var lst3 =
                from a in lst1.OfType<int>() select a;

            Console.WriteLine("lst1.OfType<string>()");
            foreach (var x in lst2) Console.WriteLine(x);

            Console.WriteLine("lst1.OfType<int>()");
            foreach (var x in lst3) Console.WriteLine(x);

        }

        #endregion
        #region 3. Orderby dùng sắp xếp ngược xuôi và mặc định là ASC theo 1 điều kiện cụ thể

        static void LINQ_Orderby()
        {
            var lst =
                from a in _lstNhanViens
                orderby a.TenNV
                select a;

            var lst2 = _lstNhanViens.OrderBy(c => c.TenNV);
        }

        //ThenBy đi với Orderby giúp mở rộng để sắp xếp thêm nhiều cột hơn cùng lúc và có thể sử dụng nhiều thenby
        static void LINQ_ThenBy()
        {

            var lst2 = _lstNhanViens.OrderBy(c => c.TenNV).ThenBy(c => c.Sdt);
            var lst3 = _lstNhanViens.OrderBy(c => c.TenNV).ThenByDescending(c => c.Sdt);
        }
        #endregion
        #region 4. Group By nhóm các phần giống nhau

        static void LINQ_GroupBy()
        {
            List<string> lstName = new List<string> { "A", "A", "A", "NHAM", "NHAM", "NAM", "NAM" };
            var lst1 =
                from a in lstName
                group a by a
                into g
                select g.Key;
            foreach (var x in lst1)
            {
                Console.WriteLine(x);
            }

            //Tổng Giá nhập trên mỗi thể loại sản phẩm
            var lst2 =
                from a in _lsSanPhams
                group a by new
                {
                    //Nhóm nhiều cột lại
                    a.IdTheLoai
                }
                into g
                select new SanPham()
                {
                    IdTheLoai = g.Key.IdTheLoai,
                    GiaNhap = g.Sum(c => c.GiaNhap)
                };
            foreach (var x in lst2)
            {
                Console.WriteLine(x.IdTheLoai + " " + x.GiaNhap);
            }
            //Bài tập: Viết tính tổng tiền giá bán của tất cả điện thoại có mầu giống nhau và số lượng sản phẩm đang có theo mầu tương ứng
            var lst2Any =
                from a in _lsSanPhams
                group a by new
                {
                    //Nhóm nhiều cột lại
                    a.MauSac
                }
                into g
                select new
                {
                    TenMau = g.Key.MauSac,
                    TongTien = g.Sum(c => c.GiaBan),
                    SoLuong = g.Count(c=>c.MauSac == g.Key.MauSac)
                };
            var lst2AnyLambda = _lsSanPhams.GroupBy(c => new {c.MauSac}).Select(g => new {TenMau = g.Key.MauSac, TongTien = g.Sum(c => c.GiaBan), SoLuong = g.Count(c => c.MauSac == g.Key.MauSac)});
            foreach (var x in lst2AnyLambda)
            {
                Console.WriteLine(x.TenMau + " " + x.TongTien + " " + x.SoLuong);
            }

        }

        #endregion
        #region 5. Join

        static void LINQ_JOIN()
        {
            //Hiển thị  thông tin sản phẩm bao gồm (MÃ, TÊN, MẦU, THỂ LOẠI)
            var lst1 =
                from a in _lsSanPhams //Truy vấn vào 1 bảng
                join b in _lstTheLoais on a.IdTheLoai equals b.Id
                join c in _lstNhanViens on a.IdNhanVien equals c.Id
                where a.TrangThai
                select new //select ra các trường do lập trình viên tự điịnh nghĩa theo bài toán
                {
                    MaSanPham = a.MaSP,
                    TenSanPham = a.TenSP,
                    MauSac = a.MauSac,
                    TheLoai = b.TenTheLoai, //b của bảng thể loại
                    TenNVTao = c.TenNV
                };
            var lst2 = _lsSanPhams.Where(c => c.TrangThai)
                .Join(_lstTheLoais, a => a.IdTheLoai, b => b.Id, (a, b) => new {a, b})
                .Join(_lstNhanViens, c => c.a.IdTheLoai, d => d.Id, (c, d) => new {c, d}).Select(e => new
                {
                    MaSanPham = e.c.a.MaSP,
                    TenSanPham = e.c.a.TenSP,
                    MauSac = e.c.a.MauSac,
                    TheLoai = e.c.b.TenTheLoai, 
                    TenNVTao = e.d.TenNV
                });
            foreach (var x in lst2)
            {
                //Về nhà tự in nốt
            }
        }

        #endregion
        #region temp

        static void LINQ_()
        {

        }

        #endregion
    }
}
