using DoAnWeb.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnWeb.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        MyDataDataContext data = new MyDataDataContext();
        
        public ActionResult ListSanPham(int? page)
        {
            if (page == null) page = 1;
            var all_sanpham = (from s in data.SanPhams select s).OrderBy(m => m.MaSP);
            int pageSize = 6;
            int pageNum = page ?? 1;
            return View(all_sanpham.ToPagedList(pageNum, pageSize));
        }
        public ActionResult Detail(int id)
        {
            var all_sanpham= data.SanPhams.Where(m => m.MaSP == id).First();
            return View(all_sanpham);
        }
        
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection collection, SanPham s)
        {
            var E_tensanpham = collection["tenSanPham"];
            var E_hinhsp = collection["hinhsp"];
            var E_dongia = Convert.ToDecimal(collection["dongia"]);
            var E_ngaycapnhat = Convert.ToDateTime(collection["ngaycapnhat"]);
            var E_soluong = Convert.ToInt32(collection["soluong"]);
            if (string.IsNullOrEmpty(E_tensanpham))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                s.TenSP = E_tensanpham.ToString();
                s.HinhSP = E_hinhsp.ToString();
                s.Dongia = E_dongia;
                s.Ngaycapnhat = E_ngaycapnhat;
                s.Soluong = E_soluong;
                data.SanPhams.InsertOnSubmit(s);
                data.SubmitChanges();
                return RedirectToAction("ListSanPham");
            }
            return this.Create();
        }
        

        


    }
}