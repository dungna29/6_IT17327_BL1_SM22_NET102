using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_0_CLASS_GENERIC
{
    internal class FPOLY_GENERIC<T>// T chỉ là kiểu dữ liệu
    {
        private T temp;

        public FPOLY_GENERIC()
        {
            
        }

        public FPOLY_GENERIC(T temp)
        {
            this.temp = temp;
        }

        public T Temp
        {
            get => temp;
            set => temp = value;
        }

        public T GetValue()
        {
            Console.WriteLine(temp);
            return temp;
        }
    }
}
