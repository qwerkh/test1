using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test1.Models;

namespace test1.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            ViewBag.shopName = "Computer Shop";
            List<ItemList> itemList = new List<ItemList>()
            {
                new ItemList{Id="001",Name="Acer",Price=500,Category="Laptop"},
                new ItemList{Id="002",Name="Mac",Price=1500,Category="Laptop"},
                new ItemList{Id="003",Name="Asus",Price=600,Category="Laptop"},
                new ItemList{Id="004",Name="Dell",Price=580,Category="Laptop"},
            };

            itemList.Add(new ItemList { Id = "005", Name = "MSI", Price = 900, Category = "Laptop" });

            return View(itemList);
        }
    }
}