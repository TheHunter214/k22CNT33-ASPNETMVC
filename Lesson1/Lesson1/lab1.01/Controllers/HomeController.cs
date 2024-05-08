using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab1._01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // su dung ViewBag de dua du lieu ra View 
            ViewBag.message = "Chao mung ban da den Protocol";
            return View();
        }
        public ActionResult About()
        {
            //su dung ViewBag de dua du lieu ra View
            ViewBag.message = "Day la trang chuong trinh Protocol";
            return View();
        }
    }
}