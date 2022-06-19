using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoAnWeb1.Models
{
    public class TheLoai
    {
        MyDataDataContext data = new MyDataDataContext();
        [Key]
        public int maloaisp { get; set; }
        public string tenloaisp { get; set; }
    }
}