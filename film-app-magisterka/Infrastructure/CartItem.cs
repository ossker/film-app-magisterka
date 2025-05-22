using film_app_magisterka.Models;

namespace film_app_magisterka.Infrastructure
{
    public class CartItem
    {
        public Film Film { get; set; }
        public int Quantity { get; set; }
        public decimal? Value { get; set; }
    }
}
