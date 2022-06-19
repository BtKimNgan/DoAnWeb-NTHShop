using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnWeb1.Models
{
    public class DSSanPham
    {
        MyDataDataContext data = new MyDataDataContext();
        public int masanpham { get; set; }
        public string tensanpham { get; set; }

        public string hinh { get; set; }
        public string chitietsp { get; set; }
        public decimal dongian { get; set; }
        public int soluong { get; set; }
    }
}