using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoAnWeb1.Models
{
    public class khachhang
    {
        MyDataDataContext data = new MyDataDataContext();
        [Key]
        public string makhachhang { get; set; }
        public string tenkhachhang { get; set; }
        public string diachi { get; set; }
        public int sdt { get; set; }
        public string email { get; set; }
        public string tendangnhap { get; set; }
        public string matkhau { get; set; }
        public DateTime ngaysinh { get; set; }
    }
}