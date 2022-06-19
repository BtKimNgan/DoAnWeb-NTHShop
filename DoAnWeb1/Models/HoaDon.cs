using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoAnWeb1.Models
{
    public class HoaDon
    {
        MyDataDataContext data = new MyDataDataContext();
        [Key]
        public string mahoadon { get; set; }
        public DateTime ngaylaphd { get; set; }
        public DateTime ngaygiao { get; set; }
        public decimal thanhtoan { get; set; }
    }
}