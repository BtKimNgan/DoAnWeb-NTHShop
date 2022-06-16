using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoAnWeb1.Models
{
    public class GioHang
    {
        MyDataDataContext data = new MyDataDataContext();
        public int masanphan { get; set; }
        [Display(Name = "Tên sách")]
        public string tensanpham { get; set; }
        [Display(Name = "Ảnh bìa")]
        public string hinh { get; set; }

        [Display(Name = "Giá bán")]
        public double giaban { get; set; }

        [Display(Name = "Số lượng")]
        public int iSoluong { get; set; }

        [Display(Name = "Thành tiền")]
        public double dThanhtien
        {
            get { return iSoluong * giaban; }
        }
        public GioHang(int id)
        {
            masanphan= id;
            SanPham sanpham = data.SanPhams.Single(n => n.MaSP == masanphan);
            tensanpham = sanpham.TenSP;
            hinh = sanpham.HinhSP;
            giaban = double.Parse(sanpham.Dongia.ToString());
            iSoluong = 1;
        }
    }
}