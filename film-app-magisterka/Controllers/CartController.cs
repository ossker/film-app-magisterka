using film_app_magisterka.DAL;
using film_app_magisterka.Models;
using Microsoft.AspNetCore.Mvc;

namespace film_app_magisterka.Controllers
{
    public class CartController : Controller
    {
        FilmsContext db;

        public CartController(FilmsContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var cart = CartManager.GetItems(HttpContext.Session);
            ViewBag.Total = CartManager.GetCartValue(HttpContext.Session);
            return View(cart);
        }

        public IActionResult AddToCart(int filmId)
        {
            CartManager.AddToCart(HttpContext.Session, filmId, db);
            return RedirectToAction("Index", "Cart");
        }

        public IActionResult RemoveFromCart(int id)
        {
            var model = new RemoveViewModel()
            {
                itemId = id,
                itemQuantity = CartManager.RemoveFromCart(HttpContext.Session, id),
                cartValue = CartManager.GetCartValue(HttpContext.Session)
            };
            return Json(model);
        }
    }
}
