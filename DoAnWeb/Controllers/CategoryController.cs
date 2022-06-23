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
            var theloai = data.LoaiSPs.First(m => m.MaloaiSP == id);
            var E_tenloai = collection["tenloai"];
            theloai.MaloaiSP = id;
            if (string.IsNullOrEmpty(E_tenloai))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                theloai.TenloaiSP = E_tenloai;
                UpdateModel(theloai);
                data.SubmitChanges();
                return RedirectToAction("Index");
            }
            return this.Edit(id);
        }
        public ActionResult Delete(int id)
        {
            var D_theloai = data.LoaiSPs.First(m => m.MaloaiSP == id);
            return View(D_theloai);
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var D_theloai = data.LoaiSPs.Where(m => m.MaloaiSP == id).First();
            data.LoaiSPs.DeleteOnSubmit(D_theloai);
            data.SubmitChanges();
            return RedirectToAction("Index");
        }
    }
}