using Foody.Domain.Entities.Addresses;
using Foody.Domain.Entities.Carts;
using Foody.Domain.Entities.Payments;
using Foody.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.DTOs.Orders
{
    public class OrderForResultDto
    {
        public long Id { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public Status Status { get; set; }
        public decimal DeliveryFee { get; set; }
        public decimal OrderFee { get; set; }
        public Address Address { get; set; }
        public Payment Payment { get; set; }
    }
}
