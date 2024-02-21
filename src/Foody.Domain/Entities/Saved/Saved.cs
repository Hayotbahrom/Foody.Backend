using Foody.Domain.Commons;
using Foody.Domain.Entities.Products;
using Foody.Domain.Entities.Users;

namespace Foody.Domain.Entities.Saved
{
    public class Saved : Auditable
    {
        public long UserId { get; set; }
        public User User { get; set; }
    }
}
