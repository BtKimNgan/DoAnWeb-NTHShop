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
        public ActionResult Edit(int id)
        {
            var E_sanpham = data.SanPhams.First(m => m.MaSP == id);
            return View(E_sanpham);
        }
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var E_sanpham = data.SanPhams.First(m => m.MaSP == id);
            var E_tensanpham = collection["tensanpham"];
            var E_hinh = collection["hinh"];
            var E_giaban = Convert.ToDecimal(collection["giaban"]);
            var E_ngaycapnhat = Convert.ToDateTime(collection["ngaycatnhat"]);
            var E_soluongton = Convert.ToInt32(collection["soluongton"]);
            E_sanpham.MaSP = id;
            if (string.IsNullOrEmpty(E_tensanpham))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                E_sanpham.TenSP = E_tensanpham;
                E_sanpham.HinhSP = E_hinh;
                E_sanpham.Dongia = E_giaban;
                E_sanpham.Ngaycapnhat = E_ngaycapnhat;
                E_sanpham.Soluong = E_soluongton;
                UpdateModel(E_sanpham);
                data.SubmitChanges();
                return RedirectToAction("ListSanPham");
            }
            return this.Edit(id);
        }
        public ActionResult Delete(int id)
        {
            var D_sanpham = data.SanPhams.First(m => m.MaSP == id);
            return View(D_sanpham);
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var D_sanpham = data.SanPhams.Where(m => m.MaSP == id).First();
            data.SanPhams.DeleteOnSubmit(D_sanpham);
            data.SubmitChanges();
            return RedirectToAction("ListSanPham");
        }
        public string ProcessUpload(HttpPostedFileBase file)
        {
            if (file == null)
            {
                return "";
            }
            file.SaveAs(Server.MapPath("~/assets/img/" + file.FileName));
            return "/assets/img/" + file.FileName;
        }




    }
}