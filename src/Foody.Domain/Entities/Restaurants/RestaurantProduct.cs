using Foody.Domain.Commons;
using Foody.Domain.Entities.Products;

namespace Foody.Domain.Entities.Restaurants
{
    public class RestaurantProduct : Auditable
    {
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public long RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
