using film_app_magisterka.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace film_app_magisterka.ViewComponents
{
    public class SideMenuViewComponent : ViewComponent
    {
        FilmsContext db;

        public SideMenuViewComponent(FilmsContext db)
        {
            this.db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync(string categoryName)
        {
            var category = db.Categories.Include("Films").Where(c => c.Name.ToUpper() == categoryName.ToUpper()).FirstOrDefault();
            var films = category.Films.OrderBy(f=>f.Title).ToList();
            return await Task.FromResult(View("_SideMenu", films));
        }
    }
}
