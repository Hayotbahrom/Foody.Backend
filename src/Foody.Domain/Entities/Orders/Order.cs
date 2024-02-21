using Foody.Domain.Commons;
using Foody.Domain.Entities.Addresses;
using Foody.Domain.Entities.Carts;
using Foody.Domain.Entities.Payments;
using Foody.Domain.Enums;

namespace Foody.Domain.Entities.Orders
{
    public class Order : Auditable
    {
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public Status Status { get; set; }
        public decimal DeliveryFee { get; set; }
        public decimal OrderFee { get; set; }

        public long AddressId { get; set; }
        public Address Address { get; set; }

        public long PaymentId { get; set; }
        public Payment Payment { get; set; }
    }
}
