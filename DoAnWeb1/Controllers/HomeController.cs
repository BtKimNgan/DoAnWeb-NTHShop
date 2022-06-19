using DoAnWeb1.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnWeb1.Controllers
{
    public class HomeController : Controller
    {
        MyDataDataContext data = new MyDataDataContext();
        public ActionResult Index()
        {
            HomePage homePage = new HomePage();

            homePage.all_Category = (from ss in data.LoaiSPs select ss).ToList();

            homePage.all_sanpham = (from ss in data.SanPhams select ss).ToList();

            return View(homePage);
        }

        //public ActionResult Index(int? page)
        //{

        //    //if (page == null) page = 1;
        //    //var all_sach = (from s in data.SanPhams select s).OrderBy(m => m.MaSP);
        //    //int pageSize = 3;
        //    //int pageNum = page ?? 1;
        //    return View(all_sach.ToPagedList(pageNum, pageSize));
        //}
    }
}