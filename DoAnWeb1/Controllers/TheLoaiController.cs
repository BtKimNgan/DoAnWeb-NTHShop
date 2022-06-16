using DoAnWeb1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnWeb1.Controllers
{
    public class TheLoaiController : Controller
    {
        // GET: TheLoai
        MyDataDataContext data = new MyDataDataContext();
        public ActionResult Index()
        {
            var all_loaisp = from tt in data.LoaiSPs select tt;
            return View(all_loaisp);
        }
        public ActionResult Detail(int id)
        {
            var D_loaisp = data.LoaiSPs.Where(m => m.MaloaiSP == id).First();
            return View(D_loaisp);

        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection conllection, LoaiSP tl)
        {
            var ten = conllection["tenloai"];
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
            var loaiSP = data.LoaiSPs.First(m => m.MaloaiSP == id);
            var E_tenloai = collection["tenloai"];
            loaiSP.MaloaiSP = id;
            if (string.IsNullOrEmpty(E_tenloai))
            {
                ViewData["Error"] = "Don't emptly";
            }
            else
            {
                loaiSP.TenloaiSP = E_tenloai;
                UpdateModel(loaiSP);
                data.SubmitChanges();
                return RedirectToAction("Index");
            }
            return this.Edit(id);
        }
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
            return RedirectToAction("Index");
        }
    }
}