using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_0_CLASS_GENERIC
{
    internal class PTPM_GENERIC<A>
    {
        private A[] arr;
        

        public PTPM_GENERIC()
        {
            
        }

        public PTPM_GENERIC(A[] arr)
        {
            this.arr = arr;
            
        }

        public A[] Arr
        {
            get => arr;
            set => arr = value;
        }

        public PTPM_GENERIC(int size)
        {
            arr = new A[size];
        }
        //Phương thức thêm phần tử vào mảng Generic
        public void AddArray(int index, A value)
        {
            if (index < 0 || index >= arr.Length)
            {
                throw new IndexOutOfRangeException();
            }
            arr[index] = value;
        }
        //Phương thức lấy giá tị theo Index
        public A GetValueByIndex(int index)
        {
            if (index < 0 || index >= arr.Length)
            {
                throw new IndexOutOfRangeException();
            }

            return arr[index];
        }
    }
}
