using Foody.Domain.Entities.Addresses;
using Foody.Domain.Entities.Payments;
using Foody.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.DTOs.Orders
{
    public class OrderForUpdateDto
    {
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public Status Status { get; set; }
        public decimal DeliveryFee { get; set; }
        public decimal OrderFee { get; set; }
        public long AddressId { get; set; }
        public long PaymentId { get; set; }
    }
}
