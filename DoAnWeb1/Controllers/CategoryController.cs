using DoAnWeb1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnWeb1.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        MyDataDataContext data = new MyDataDataContext();
        public ActionResult Index()
        {
            var all_Category = (from ss in data.LoaiSPs select ss).ToList();
            return View(all_Category);
        }

       

    }
}