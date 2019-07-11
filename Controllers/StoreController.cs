using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EShop.Models;

namespace EShop.Controllers
{
    public class StoreController : Controller
    {
        EShopContext eShops = new EShopContext();
        // GET: Store
        public ActionResult Index()
        {
            var categories = eShops.Categories.ToList();
            return View(categories);
        }

        public ActionResult Browse(string category) {
            var categoryModel = eShops.Categories.Include("Items").Single(c => c.Name == category);
            return View(categoryModel);
        }

        public ActionResult Details(int id) {

            var Item = new Item { Title = "Item" + id };
            return View(Item);
        }


    }
}