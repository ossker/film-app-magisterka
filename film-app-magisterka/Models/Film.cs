using System.ComponentModel.DataAnnotations;

namespace film_app_magisterka.Models
{
    public class Film
    {
        public int FilmId { get; set; }

        [Required]
        public string Title { get; set; }
        public string Director { get; set; }

        [StringLength(600, ErrorMessage = "Przekroczono limit znaków")]
        public string Description { get; set; }
        public string Poster { get; set; }
        public decimal? Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
