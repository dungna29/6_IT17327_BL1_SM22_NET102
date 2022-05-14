using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_0_ONTAP_NET101_CRUD
{
    //Nơi code các chức năng cho đối tượng
    internal class ChoService
    {
        private List<Cho> _lstChos;
        private Cho _cho;
        private string _input;
        public ChoService()
        {
            FakeData();
        }

        private void FakeData()
        {
            _lstChos = new List<Cho>()
            {
                new Cho(1, "Kiki1", 30, 1, 1),
                new Cho(2, "Kiki2", 30, 0, 2),
                new Cho(3, "Kiki3", 30, 1, 3),
            };
        }
        //Code 10 phút code chức năng thêm
        public void ThemCho()
        {

            _input = GetInputValue("số lượng");
            for (int i = 0; i < Convert.ToInt32(_input); i++)
            {
                _cho = new Cho();
                _cho.Id = GetIDCho();
                Console.WriteLine("Mời bạn nhập tên chó: ");
                _cho.Ten = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập giới tính: (1 - Đức | 0 - Cái)");
                _cho.GioiTinh = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập cân nặng: ");
                _cho.CanNang = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Mầu: 1 - Đỏ | 2 - Xanh | 3 - Trắng: ");
                _cho.Mau = Convert.ToInt32(Console.ReadLine());
                _lstChos.Add(_cho);
            }
        }
        //Tìm kiếm, Sửa , Xóa =
        public void TimKiem()
        {
            // Console.WriteLine("Nhập Id chó: ");
            // _input = Console.ReadLine();
            // for (int i = 0; i < _lstChos.Count; i++)
            // {
            //     if (_lstChos[i].Id == Convert.ToInt32(_input))
            //     {
            //         _lstChos[i].InRaManHinh();
            //         return;
            //     }
            // }
            //
            // Console.WriteLine("Không tìm thấy");
            var temp = GetIndexById();
            if (temp == -1)
            {
                Console.WriteLine("Không tìm thấy");
                return;
            } 
            _lstChos[temp].InRaManHinh();
        }
        public void Xoa()
        {
            // Console.WriteLine("Nhập Id chó: ");
            // _input = Console.ReadLine();
            // for (int i = 0; i < _lstChos.Count; i++)
            // {
            //     if (_lstChos[i].Id == Convert.ToInt32(_input))
            //     {
            //         _lstChos.RemoveAt(i);
            //         Console.WriteLine("Xóa thành công");
            //         return;
            //     }
            // }
            //
            // Console.WriteLine("Không tìm thấy");
            var temp = GetIndexById();
            if (temp == -1)
            {
                Console.WriteLine("Không tìm thấy");
                return;
            }
            _lstChos.RemoveAt(temp);
        }
        public void Sua()
        {
            // Console.WriteLine("Nhập Id chó: ");
            // _input = Console.ReadLine();
            // for (int i = 0; i < _lstChos.Count; i++)
            // {
            //     if (_lstChos[i].Id == Convert.ToInt32(_input))
            //     {
            //         Console.WriteLine("Mời bạn nhập tên: ");
            //         _lstChos[i].Ten = Console.ReadLine();
            //         Console.WriteLine("Sửa thành công");
            //         return;
            //     }
            // }
            //
            // Console.WriteLine("Không tìm thấy");
            var temp = GetIndexById();
            if (temp == -1)
            {
                Console.WriteLine("Không tìm thấy");
                return;
            }
            Console.WriteLine("Mời bạn nhập tên: ");
            _lstChos[temp].Ten = Console.ReadLine();
            Console.WriteLine("Sửa thành công");
        }

        public void InDs(){
            foreach (var x in _lstChos)
            {
                x.InRaManHinh();
            }      
        }

        public int GetIDCho()
        {
            if (_lstChos.Count<0)
            {
                return 1;
            }
            return _lstChos.Max(c => c.Id) + 1;
        }

        public int GetIndexById()
        {
            Console.WriteLine("Nhập Id chó: ");
            _input = Console.ReadLine();
            // for (int i = 0; i < _lstChos.Count; i++)
            // {
            //     if (_lstChos[i].Id == Convert.ToInt32(_input))
            //     {
            //         return i;
            //     }
            // }
            //
            // return -1;
            return _lstChos.FindIndex(c => c.Id == Convert.ToInt32(_input));
        }

        public String GetInputValue(string msg)
        {
            Console.WriteLine($"Mời bạn nhập {msg}: ");
            return Console.ReadLine();
        }
    }
}
