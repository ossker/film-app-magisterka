using film_app_magisterka.DAL;
using film_app_magisterka.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace film_app_magisterka.Controllers
{
    public class HomeController : Controller
    {
        FilmsContext db;

        public HomeController(FilmsContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var kategorie = db.Categories.ToList();
            return View(kategorie);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult footerSites(string viewName)
        {
            var kategorie = db.Categories.ToList();
            return View(viewName, kategorie);
        }
    }
}