using DoAnWeb1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnWeb1.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        MyDataDataContext data = new MyDataDataContext();
        public ActionResult Index()
        {
            var all_sanpham = from tt in data.SanPhams select tt;
            return View(all_sanpham);

        }
        public ActionResult Detail(int id)
        {
            var D_sanpham = data.SanPhams.Where(m => m.MaSP == id).First();
            return View(D_sanpham);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection collection, SanPham s)
        {
            var E_tensp = collection["tensp"];
            var E_hinh = collection["hinh"];
            var E_giaban = Convert.ToDecimal(collection["giaban"]);
            var E_ngaycapnhat = Convert.ToDateTime(collection["ngaycapnhat"]);
            var E_soluongton = Convert.ToInt32(collection["soluongton"]);
            if (string.IsNullOrEmpty(E_tensp))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                s.TenSP = E_tensp.ToString();
                s.HinhSP = E_hinh.ToString();
                s.Dongia = E_giaban;
                s.Ngaycapnhat = E_ngaycapnhat;
                s.Soluong = E_soluongton;
                data.SanPhams.InsertOnSubmit(s);
                data.SubmitChanges();
                return RedirectToAction("Index");
            }
            return this.Create();
        }
        public ActionResult Edit(int id)
        {
            var E_category = data.SanPhams.First(m => m.MaSP == id);
            return View(E_category);
        }
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var E_sanpham = data.SanPhams.First(m => m.MaSP == id);
            var E_tensp = collection["tensanpham"];
            var E_hinh = collection["hinh"];
            var E_giaban = Convert.ToDecimal(collection["giaban"]);
            var E_ngaycapnhat = Convert.ToDateTime(collection["ngaycatnhat"]);
            var E_soluongton = Convert.ToInt32(collection["soluongton"]);
            E_sanpham.MaSP = id;
            if (string.IsNullOrEmpty(E_tensp))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                E_sanpham.TenSP = E_tensp;
                E_sanpham.HinhSP = E_hinh;
                E_sanpham.Dongia = E_giaban;
                E_sanpham.Ngaycapnhat = E_ngaycapnhat;
                E_sanpham.Soluong = E_soluongton;
                UpdateModel(E_sanpham);
                data.SubmitChanges();
                return RedirectToAction("Index");
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
            return RedirectToAction("Index");
        }

        public string ProcessUpload(HttpPostedFileBase file)
        {
            if (file == null)
            {
                return "";
            }
            file.SaveAs(Server.MapPath("~/Content/images/" + file.FileName));
            return "/Content/images/" + file.FileName;
        }
    }
}