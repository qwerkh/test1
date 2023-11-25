using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test1.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MyContact()
        {
            return View();
        }
        public ViewResult Detail()
        {
            return View("Details");
        }

        public ContentResult showContent()
        {
            return Content("Hello");
        }
        public int add()
        {
            int a = 4;
            int b = 5;
            int s = a + b;
            return s;
        }
    }
}