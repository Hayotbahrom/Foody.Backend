using Foody.Domain.Commons;
using Foody.Domain.Entities.Products;

namespace Foody.Domain.Entities.Saved
{
    public class SavedProduct : Auditable
    {
        public long SavedId { get; set; }
        public Saved Saved { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
    }
}
