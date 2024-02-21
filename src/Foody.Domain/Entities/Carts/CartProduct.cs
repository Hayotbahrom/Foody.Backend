using Foody.Domain.Commons;
using Foody.Domain.Entities.Products;

namespace Foody.Domain.Entities.Carts
{
    public class CartProduct : Auditable
    {
        public long Quantity { get; set; }
        public decimal Price { get; set; }

        public long CartId { get; set; }
        public Cart Cart { get; set; }

        public long ProductId { get; set; }
        public Product Product { get; set; }
    }
}
