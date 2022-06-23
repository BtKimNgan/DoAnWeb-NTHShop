using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnWeb.Models
{
    public class HomePage
    {

        public List<SanPham> all_sanpham { get; set; }
        public List<LoaiSP> all_category { get; set; }
    }
}