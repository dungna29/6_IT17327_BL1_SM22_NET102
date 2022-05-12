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
                Console.WriteLine("Mời bạn nhập id: ");
                _cho.Id = Convert.ToInt32(Console.ReadLine());
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

        public String GetInputValue(string msg)
        {
            Console.WriteLine($"Mời bạn nhập {msg}: ");
            return Console.ReadLine();
        }
    }
}
