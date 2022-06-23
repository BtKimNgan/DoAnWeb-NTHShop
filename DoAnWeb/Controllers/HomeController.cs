using DoAnWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnWeb.Controllers
{
    public class HomeController : Controller
    {
        MyDataDataContext data = new MyDataDataContext();

        public ActionResult Index()
        {
            HomePage homePage = new HomePage();

            homePage.all_category = (from ss in data.LoaiSPs select ss).ToList();

            homePage.all_sanpham = (from ss in data.SanPhams select ss).ToList();

            return View(homePage);
        }
        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}