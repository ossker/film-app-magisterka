using System.ComponentModel.DataAnnotations;

namespace film_app_magisterka.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        [StringLength(600, ErrorMessage = "Przekroczono limit znaków")]
        public string Desc { get; set; }

        public ICollection<Film> Films { get; set; }
    }
}
