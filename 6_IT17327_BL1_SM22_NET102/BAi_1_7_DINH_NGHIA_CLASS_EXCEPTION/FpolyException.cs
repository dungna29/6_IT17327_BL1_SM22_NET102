using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAi_1_7_DINH_NGHIA_CLASS_EXCEPTION
{
    internal class FpolyException:Exception
    {
        public FpolyException(string message) : base(message)
        {
        }
    }
}
