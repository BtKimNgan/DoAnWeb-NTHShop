using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoAnWeb.Models
{
    public class Giohang
    {
        MyDataDataContext data = new MyDataDataContext();
        public int masanpham { get; set; }

        [Display(Name = "Tên Sản Phẩm ")]
        public string tensanpham { get; set; }

        [Display(Name = "Ảnh Bìa")]
        public string hinhsp { get; set; }

        [Display(Name = "Giá Bán ")]
        public Double dongia { get; set; }

        [Display(Name = "Số Lượng ")]
        public int iSoLuong { get; set; }

        [Display(Name = "Thành Tiền ")]
        public double dThanhTien
        {
            get { return iSoLuong * dongia; }
        }

        public Giohang(int id)
        {
            masanpham = id;
            SanPham sanpham = data.SanPhams.Single(n => n.MaSP == masanpham);
            tensanpham = sanpham.TenSP;
            hinhsp = sanpham.HinhSP;
            dongia = double.Parse(sanpham.Dongia.ToString());
            iSoLuong = 1;
        }

    }
}