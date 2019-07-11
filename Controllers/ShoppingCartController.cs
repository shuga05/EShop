using EShop.Models;
using EShop.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        EShopContext Store = new EShopContext();
        // GET: ShoppingCart
        public ActionResult Index()
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);


            var viewModel = new ShoppingViewModelCart
            {
                CartItems = cart.GetCartItems(),
                CartTotal = cart.GetTotal()
            };

            ViewData["Name"] = Store.Categories.ToList();
            ViewData["Name"] = Store.Products.ToList();

            return View(viewModel);
        }

        public ActionResult AddToCart(int id)
        {

            var addedItem = Store.Item
                .Single(item => item.ItemId == id);


            var cart = ShoppingCart.GetCart(this.HttpContext);

            cart.AddToCart(addedItem);


            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult RemoveFromCart(int id)
        {

            var cart = ShoppingCart.GetCart(this.HttpContext);


            string itemName = Store.Carts
                .Single(item => item.RecordId == id).Item.Title;


            int itemCount = cart.RemoveFromCart(id);


            var results = new ShoppingRemoveModelCart
            {
                Message = Server.HtmlEncode(itemName) +
                    " has been removed from your shopping cart.",
                CartTotal = cart.GetTotal(),
                CartCount = cart.GetCount(),
                ItemCount = itemCount,
                DeleteId = id
            };
            return Json(results);
        }

        [ChildActionOnly]
        public ActionResult CartSummary()
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);

            ViewData["CartCount"] = cart.GetCount();
            return PartialView("CartSummary");
        }


    }
}