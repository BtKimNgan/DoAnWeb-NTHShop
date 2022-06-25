using DoAnWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnWeb.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        MyDataDataContext data = new MyDataDataContext();
        public ActionResult ListCategory()
        {
            var all_loaisp = (from ss in data.LoaiSPs select ss).ToList();
            return View(all_loaisp);
        }
        public ActionResult Detail(int id)
        {
            var all_loaisp = data.LoaiSPs.Where(m => m.MaloaiSP == id).First();
            return View(all_loaisp);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection collection, LoaiSP tl)
        {
            var ten = collection["tenloai"];
            if (string.IsNullOrEmpty(ten))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                tl.TenloaiSP = ten;
                data.LoaiSPs.InsertOnSubmit(tl);
                data.SubmitChanges();
                return RedirectToAction("Index");
            }
            return this.Create();
        }
        public ActionResult Edit(int id)
        {
            var E_category = data.LoaiSPs.First(m => m.MaloaiSP == id);
            return View(E_category);
        }
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var E_loaisp = data.LoaiSPs.First(m => m.MaloaiSP == id);
            var E_maloailt = Convert.ToInt32(collection["MaLoaiLT"]);
            var E_tenslaptop = collection["TenLapTop"];
            var E_hinh = collection["Hinh"];
            var E_giaban = Convert.ToDecimal(collection["GiaBan"]);
            var E_ngaycapnhat = Convert.ToDateTime(collection["NgayCapNhap"]);
            var E_soluongton = Convert.ToInt32(collection["SoLuongTon"]);
            var E_machip = Convert.ToInt32(collection["MaChip"]);
            E_loaisp.MaloaiSP = id;
            if (string.IsNullOrEmpty(E_tenslaptop))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                E_loaisp.MaloaiSP = E_maloailt;
                E_loaisp.TenloaiSP= E_tenslaptop;
                E_loaisp.Hinh = E_hinh;
                E_loaisp.Dongia = E_giaban;
                E_loaisp.Ngaycapnhat = E_ngaycapnhat;
                E_loaisp.Soluong = E_soluongton;
                

                UpdateModel(E_loaisp);
                data.SubmitChanges();
                return RedirectToAction("ListCategory");
            }
            return this.Edit(id);
        }


        //lôi delete/edit /create
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    var theloai = data.LoaiSPs.First(m => m.MaloaiSP == id);
        //    var E_tenloai = collection["tenloai"];
        //    theloai.MaloaiSP = id;
        //    if (string.IsNullOrEmpty(E_tenloai))
        //    {
        //        ViewData["Error"] = "Don't empty!";
        //    }
        //    else
        //    {
        //        theloai.TenloaiSP = E_tenloai;
        //        UpdateModel(theloai);
        //        data.SubmitChanges();
        //        return RedirectToAction("ListCategory");
        //    }
        //    return this.Edit(id);
        //}
        public ActionResult Delete(int id)
        {
            var D_loaisp = data.LoaiSPs.First(m => m.MaloaiSP == id);
            return View(D_loaisp);
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var D_loaisp = data.LoaiSPs.Where(m => m.MaloaiSP == id).First();
            data.LoaiSPs.DeleteOnSubmit(D_loaisp);
            data.SubmitChanges();
            return RedirectToAction("ListCategory");
        }

    }
}