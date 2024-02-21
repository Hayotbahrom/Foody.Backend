using Foody.Domain.Commons;

namespace Foody.Domain.Entities.Products
{
    public class Product : Auditable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public byte Rating { get; set; }

    }
}
