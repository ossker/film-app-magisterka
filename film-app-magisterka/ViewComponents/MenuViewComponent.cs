using film_app_magisterka.DAL;
using Microsoft.AspNetCore.Mvc;

namespace film_app_magisterka.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        FilmsContext db;

        public MenuViewComponent(FilmsContext db)
        {
            this.db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var kategorie = db.Categories.ToList();
            return await Task.FromResult(View("_Menu", kategorie));
        }
    }
}
