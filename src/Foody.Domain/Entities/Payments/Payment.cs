using Foody.Domain.Commons;
using Foody.Domain.Enums;

namespace Foody.Domain.Entities.Payments
{
    public class Payment : Auditable
    {
        public PaymentType PaymentType { get; set; }
        public decimal Amount { get; set; }
    }
}
