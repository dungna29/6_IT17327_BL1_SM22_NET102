using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_0_CLASS_GENERIC
{
    internal class PTPM_GENERIC<A,V>
    {
        private A[] arr;
        private V temp;

        public PTPM_GENERIC()
        {
            
        }

        public PTPM_GENERIC(A[] arr, V temp)
        {
            this.arr = arr;
            this.temp = temp;
        }

        public PTPM_GENERIC(int size)
        {
            arr = new A[size];
        }
    }
}
