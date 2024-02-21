using Foody.Domain.Commons;

namespace Foody.Domain.Entities.Products
{
    public class Category : Auditable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
    }
}
