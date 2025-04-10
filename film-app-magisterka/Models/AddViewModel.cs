namespace film_app_magisterka.Models
{
    public class AddViewModel
    {
        public Film NewFilm { get; set; }
        public IFormFile Poster { get; set; }
        public List<Category> AllCategories { get; set; }
    }
}
