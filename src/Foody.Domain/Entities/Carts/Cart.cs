using Foody.Domain.Commons;
using Foody.Domain.Entities.Users;

namespace Foody.Domain.Entities.Carts
{
    public class Cart : Auditable
    {
        public decimal TotalPrice { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
    }
}
