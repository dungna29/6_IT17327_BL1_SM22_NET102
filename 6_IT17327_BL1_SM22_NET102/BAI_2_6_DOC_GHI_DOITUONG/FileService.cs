using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_6_DOC_GHI_DOITUONG
{
    internal class FileService
    {
        private static FileStream _fs;
        private static BinaryFormatter _bf;
        public FileService()
        {
            
        }
        //Ghi đối tượng
        //Ghi data vào file thì phải biết file nằm ở đâu và dữ liệu muốn ghi vào file là dữ liệu gì
        public static void SaveFile(string path,List<Cho> lstData)
        {
            //Serialization trong C# là kỹ thuật chuyển đổi object về dạng(text, mảng byte phục vụ lưu trữ)
            _fs = new FileStream(path, FileMode.Create);
            _bf = new BinaryFormatter();//khởi tạo
            _bf.Serialize(_fs,lstData);//Serialize Tuần tự hóa hoặc tuần tự hóa là quá trình dịch cấu trúc dữ liệu hoặc trạng thái đối tượng sang định dạng có thể được lưu trữ hoặc truyền và tái tạo lại sau này.
            _fs.Close();
        }
        //Đọc file trả về 1 tập giá trị
        public static List<Cho> ReadFile(string path)
        {
            //Deserialize là một phương thức đọc các byte từ luồng và chuyển đổi lại về object
            _fs = new FileStream(path, FileMode.Open);
            _bf = new BinaryFormatter();//khởi tạo
            var dataReader = _bf.Deserialize(_fs);//Đọc đối tượng lên
            _fs.Close();
            return (List<Cho>)dataReader;
        }
    }
}
