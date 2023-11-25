using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //Same Name
        public ActionResult Index()
        {
            ViewBag.name = "Show you Home Page";
            return View();
        }
        //Different Name
        public ActionResult ShowInfo()
        {
            return View("Show");
        }
        //In Share Folder
        public ActionResult Detail()
        {
            return View("Details");
        }
        //Different Controller
        public ActionResult ShowMoreDetail()
        {
            return View("~/Views/About/MyProfile.cshtml");
        }

    }
}