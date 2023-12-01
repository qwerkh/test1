using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test1.Controllers
{
    public class DocumentController : Controller
    {
        // GET: Document
        public ActionResult Show()
        {
            return File(Server.MapPath("~/Content/test.txt"),"text/plain");
        }
        public FileResult Download()
        {
            return File(Server.MapPath("~/Content/test.txt"), "text/plain","myfile.txt");
        }

    }
}