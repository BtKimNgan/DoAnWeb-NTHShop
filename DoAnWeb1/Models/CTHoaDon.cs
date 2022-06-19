using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoAnWeb1.Models
{
    public class CTHoaDon
    {
        MyDataDataContext data = new MyDataDataContext();
        [Key]
        public int mahoadon { get; set; }
        public int soluong { get; set; }
        public decimal dongia { get; set; }
    }
}