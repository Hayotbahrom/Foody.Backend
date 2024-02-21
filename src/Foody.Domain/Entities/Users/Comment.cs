using Foody.Domain.Commons;
using Foody.Domain.Entities.Products;

namespace Foody.Domain.Entities.Users
{
    public class Comment : Auditable
    {
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
        public string Text { get; set; }
        public byte Rating { get; set; }
    }
}
