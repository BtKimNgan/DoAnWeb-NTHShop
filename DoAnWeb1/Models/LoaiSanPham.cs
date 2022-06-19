using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnWeb1.Models
{
    public class LoaiSanPham
    {
        MyDataDataContext data = new MyDataDataContext();
        
        public int maloaisp { get; set; }
        public string tenloaisp { get; set; }
        public string hinhsp { get; set; }
        public decimal dongia { get; set; }
        public int soluong { get; set; }
        public DateTime ngaycapnhat { get; set; }
    }
}