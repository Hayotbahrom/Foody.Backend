using Foody.Domain.Commons;

namespace Foody.Domain.Entities.Restaurants
{
    public class Restaurant : Auditable
    {
        public string RestaurantName { get; set; }
        public string Description { get; set; }
    }
}
