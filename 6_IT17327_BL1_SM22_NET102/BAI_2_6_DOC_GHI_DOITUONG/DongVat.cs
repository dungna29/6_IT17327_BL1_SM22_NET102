﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_6_DOC_GHI_DOITUONG
{
    [Serializable]
    internal abstract class DongVat
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public double CanNang { get; set; }
        public int GioiTinh { get; set; }
        
        public DongVat()
        {

        }
        
        public DongVat(int id, string ten, double canNang, int gioiTinh)
        {
            Id = id;
            Ten = ten;
            CanNang = canNang;
            GioiTinh = gioiTinh;
        }
     
        public abstract void InRaManHinh();
    }
}
